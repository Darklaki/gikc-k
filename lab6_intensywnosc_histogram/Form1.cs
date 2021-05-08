using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_intensywnosc_histogram
{
    public partial class Form1 : Form
    {

        public Histogram zdjeciePrzedHistogram = null;
        public Histogram zdjeciePoHistogram = null;

        public Form1()
        {
            InitializeComponent();
        }

        private bool isInByteRange(int val) {
            return val <= 255 && val >= 0;
        }

        private int normalizeIntToByte(int x)
        {
            if (this.isInByteRange(x)) {
                return x;
            }
            else
            {
                if (x > 255) {
                    return 255;
                }
                else
                {
                    return 0;
                }
            }
        }
        

        private void wybierzZdjeciePrzed(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                this.zdjeciePrzed.LoadAsync(open.FileName);
                this.zdjeciePrzed.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }
        private void zmianaZdjeciaPrzed(object sender, AsyncCompletedEventArgs e) {

            this.zdjeciePrzedHistogram = new Histogram(this.zdjeciePrzed.Image);
            this.zdjeciePrzedHistogram.drawOnChart(this.chart1);

        }

        private int quickSortPartition(int[] arr, int leftIndex, int rightIndex) {

            int pivot = arr[rightIndex];
            int pointer = leftIndex;

            for (int i = leftIndex; i <= rightIndex - 1; i++)
            {
                if (arr[i] < pivot)
                {
                    int el = arr[i];
                    arr[i] = arr[pointer];
                    arr[pointer] = el;
                    pointer += 1;
                }

            }

            int finalPointerVal = arr[pointer];
            arr[pointer] = arr[rightIndex];
            arr[rightIndex] = finalPointerVal;

            return pointer;
        }

        private void quickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if ( leftIndex < rightIndex ) {

                int pivot = this.quickSortPartition(arr, leftIndex, rightIndex);

                this.quickSort(arr, leftIndex, pivot - 1);
                this.quickSort(arr, pivot + 1, rightIndex);

            }
        }

        /**
         *
         * Metoda bierze zdjęcie, przechodzi po jego wszystkich pikselach. Każdy z pikseli jest modyfikowany przez przekazaną funkcję @callback. 
         * @callback musi zwrocic piksel w formacie byte[red, green, blue]
         * Następnie zwracane jest zmodyfikowane zdjęcie 
         * 
         */
        private Bitmap modyfikujZdjecie( Image zdjecieWejsciowe,  Func<Bitmap, int, int, byte[]> callback ) {

            Bitmap zdjeciePrzed = new Bitmap(zdjecieWejsciowe);
            Bitmap zdjeciePo = new Bitmap(zdjecieWejsciowe);

            for (int x = 0; x < zdjeciePrzed.Width; x++)
            {
                for (int y = 0; y < zdjeciePrzed.Height; y++)
                {

                    byte[] modified_pixels = callback(zdjeciePrzed, x, y);
                    byte red = modified_pixels[0];
                    byte green = modified_pixels[1];
                    byte blue = modified_pixels[2];

                    if (red > 255) red = 255;
                    if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;


                    Color newPixel = Color.FromArgb(red, green, blue);
                    zdjeciePo.SetPixel(x, y, newPixel);

                }
            }

            return zdjeciePo;

        }

        /*
         *
         * Delegat do metod wstrzykujących maski.
         * Wstrzykiwanie, czyli modyfikacja maski odbywa się przez modyfikację parametrów przez odwołanie.
         */
        private delegate void  MaskLoader(ref int mask_size, ref int[,] mask_weights);

        /**
         *
         * Zwraca metodę, która stosuje maskę dla piksela w przekazanym zdjęciu. 
         * Rodzaj maski jest wstrzykiwany przez parametr @maskCallback
         * @maskCallback ustala rozmiar maski oraz wagi maski
         */
        private Func<Bitmap, int, int, byte[]>  maskaFiltrujacaFactory( MaskLoader maskCallback ) {
            return (Bitmap img, int x, int y) =>
            {
                // intialize with dummy values
                int mask_size_n = 0;
                int[,] filter_weights = new int[1, 1];

                // assign mask
                maskCallback(ref mask_size_n, ref filter_weights);

                int k = (mask_size_n - 1) / 2;

                Color pixel = img.GetPixel(x, y);

                int red = 0;
                int green = 0;
                int blue = 0;
                int weights_sum = 0;

                for (int i = -k; i <= k; i++)
                {
                    for (int j = -k; j <= k; j++)
                    {
                        int this_x = x + i;
                        int this_y = y + j;

                        if (this_x >= 0 && this_x < img.Width && this_y >= 0 && this_y < img.Height)
                        {
                            Color this_pixel = img.GetPixel(this_x, this_y);

                            int weight = filter_weights[i + k, j + k];
                            weights_sum += weight;

                            red += weight * this_pixel.R;
                            green += weight * this_pixel.G;
                            blue += weight * this_pixel.B;
                        }

                    }
                }

                if (weights_sum != 0)
                {
                    red = red / weights_sum;
                    green = green / weights_sum;
                    blue = blue / weights_sum;
                }


                byte[] rgb_result = new byte[3] { Convert.ToByte(this.normalizeIntToByte(red)), Convert.ToByte(this.normalizeIntToByte(green)), Convert.ToByte(this.normalizeIntToByte(blue)) };

                return rgb_result;
            };
        }

        private void sharpenMasks(ref int mask_size_n, ref int[,] filter_weights)
       {
            if (this.robertsHorizontal.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, -1, 0 }
                };
            }
            if (this.robertsVertical.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 0, 0, 0 },
                    { 0, 1, -1 },
                    { 0, 0, 0 }
                };
            }
            if (this.prewittHorizontal.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 0, -1 },
                    { 1, 0, -1 },
                    { 1, 0, -1 }
                };
            }
            if (this.prewittVertical.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                    { -1, -1, -1 }
                };
            }
            if (this.sobelHorizontal.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 0, -1 },
                    { 2, 0, -2 },
                    { 1, 0, -1 }
                };
            }
            if (this.sobelVertical.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 2, 1 },
                    { 0, 0, 0 },
                    { -1, -2, -1 }
                };
            }
            if (this.laplaceSharpen.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { -2, 1, -2 },
                    { 1, 4, 1 },
                    { -2, 1, -2 }
                };
            }
       }

        private void embossingMasks(ref int mask_size_n, ref int[,] filter_weights)
        {

            if (this.eastEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { -1, 0, 1 },
                    { -1, 1, 1 },
                    { -1, 0, 1 }
                };
            }
            if (this.southEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { -1, -1, -1 },
                    { 0, 1, 0 },
                    { 1, 1, 1 }
                };
            }
            if (this.westEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 0, -1 },
                    { 1, 1, -1 },
                    { 1, 0, -1 }
                };
            }
            if (this.northEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 1, 1 },
                    { 0, 1, 0 },
                    { -1, -1, -1 }
                };
            }
        }

        /*private byte[] maskaFiltrujaca(Bitmap img, int x, int y) {

            // intialize with dummy values
            int mask_size_n = 0;
            int[,] filter_weights = new int[1, 1];

            // sharpen
            if (this.robertsHorizontal.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, -1, 0 }
                };
            }
            if ( this.robertsVertical.Checked )
            {
                mask_size_n = 3;
                filter_weights = new int[,] { 
                    { 0, 0, 0 }, 
                    { 0, 1, -1 }, 
                    { 0, 0, 0 } 
                };
            }
            if (this.prewittHorizontal.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 0, -1 },
                    { 1, 0, -1 },
                    { 1, 0, -1 }
                };
            }
            if (this.prewittVertical.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                    { -1, -1, -1 }
                };
            }
            if (this.sobelHorizontal.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 0, -1 },
                    { 2, 0, -2 },
                    { 1, 0, -1 }
                };
            }
            if (this.sobelVertical.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 2, 1 },
                    { 0, 0, 0 },
                    { -1, -2, -1 }
                };
            }
            if (this.laplaceSharpen.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { -2, 1, -2 },
                    { 1, 4, 1 },
                    { -2, 1, -2 }
                };
            }

            // embossing
            if (this.eastEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { -1, 0, 1 },
                    { -1, 1, 1 },
                    { -1, 0, 1 }
                };
            }
            if (this.southEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { -1, -1, -1 },
                    { 0, 1, 0 },
                    { 1, 1, 1 }
                };
            }
            if (this.westEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 0, -1 },
                    { 1, 1, -1 },
                    { 1, 0, -1 }
                };
            }
            if (this.northEmbossing.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] {
                    { 1, 1, 1 },
                    { 0, 1, 0 },
                    { -1, -1, -1 }
                };
            }

            int k = (mask_size_n - 1) / 2;

            Color pixel = img.GetPixel(x, y);

            int red = 0;
            int green = 0;
            int blue = 0;
            int weights_sum = 0;

            for (int i = -k; i <= k; i++)
            {
                for (int j = -k; j <= k; j++)
                {
                    int this_x = x + i;
                    int this_y = y + j;

                    if ( this_x >= 0 && this_x < img.Width && this_y >= 0 && this_y < img.Height) {
                        Color this_pixel = img.GetPixel(this_x, this_y);

                        int weight = filter_weights[i + k, j + k];
                        weights_sum += weight;

                        red += weight * this_pixel.R;
                        green += weight * this_pixel.G;
                        blue += weight * this_pixel.B;
                    }

                }
            }

            if (weights_sum != 0) {
                red = red / weights_sum;
                green = green / weights_sum;
                blue = blue / weights_sum;
            }


            byte[] rgb_result = new byte[3] { Convert.ToByte(this.normalizeIntToByte(red)), Convert.ToByte(this.normalizeIntToByte(green)), Convert.ToByte(this.normalizeIntToByte(blue)) };

            return rgb_result;

        }*/

        private byte[] filtryStatyczne(Bitmap img, int x, int y)
        {

            // intialize with dummy values
            int mask_size_n = Decimal.ToInt32(this.staticMaskSize.Value);
            int[,] mask_red_values = new int[mask_size_n, mask_size_n];
            int[,] mask_green_values = new int[mask_size_n, mask_size_n];
            int[,] mask_blue_values = new int[mask_size_n, mask_size_n];

            int k = (mask_size_n - 1) / 2;

            Color pixel = img.GetPixel(x, y);

            int red = 0;
            int green = 0;
            int blue = 0;

            for (int i = -k; i <= k; i++)
            {
                for (int j = -k; j <= k; j++)
                {
                    int this_x = x + i;
                    int this_y = y + j;

                    if (this_x >= 0 && this_x < img.Width && this_y >= 0 && this_y < img.Height)
                    {
                        Color this_pixel = img.GetPixel(this_x, this_y);

                        // colect values for this image chunk of size identical to mask 
                        mask_red_values[i + k, j + k] = this_pixel.R;
                        mask_green_values[i + k, j + k] = this_pixel.G;
                        mask_blue_values[i + k, j + k] = this_pixel.B;
                    }

                }
            }

            // apply filters
            if( this.minStatic.Checked)
            {
                int min_red = 0, min_green = 0, min_blue = 0;
                for (int i = 0; i < mask_size_n; i++){
                    for (int j = 0; j < mask_size_n; j++) {
                        if (min_red > mask_red_values[i, j] || (i == 0 && j == 0) ) min_red = mask_red_values[i, j];
                        if (min_green > mask_green_values[i, j] || (i == 0 && j == 0)) min_green = mask_green_values[i, j];
                        if (min_blue > mask_blue_values[i, j] || (i == 0 && j == 0)) min_blue = mask_blue_values[i, j];
                    }
                }
                red = min_red;
                green = min_green;
                blue = min_blue;
            }
            if (this.maxStatic.Checked)
            {
                int max_red = 0, max_green = 0, max_blue = 0;
                for (int i = 0; i < mask_size_n; i++){
                    for (int j = 0; j < mask_size_n; j++){
                        if (max_red < mask_red_values[i, j] || (i == 0 && j == 0)) max_red = mask_red_values[i, j];
                        if (max_green < mask_green_values[i, j] || (i == 0 && j == 0)) max_green = mask_green_values[i, j];
                        if (max_blue < mask_blue_values[i, j] || (i == 0 && j == 0)) max_blue = mask_blue_values[i, j];
                    }
                }
                red = max_red;
                green = max_green;
                blue = max_blue;
            }
            if (this.medianStatic.Checked)
            {
                int vector_len = (int)Math.Pow(mask_size_n, 2);
                int[] red_vector = new int[vector_len];
                int[] blue_vector = new int[vector_len];
                int[] green_vector = new int[vector_len];

                int vector_i = 0;

                for (int i = 0; i < mask_size_n; i++)
                {
                    for (int j = 0; j < mask_size_n; j++)
                    {
                        red_vector[vector_i] = mask_red_values[i, j];
                        green_vector[vector_i] = mask_green_values[i, j];
                        blue_vector[vector_i] = mask_blue_values[i, j];

                        vector_i++;
                    }
                }

                this.quickSort(red_vector, 0, vector_len - 1);
                this.quickSort(blue_vector, 0, vector_len - 1);
                this.quickSort(green_vector, 0, vector_len - 1);

                if ( vector_len % 2 == 0) {
                    int mid_index = vector_len / 2;
                    red = (red_vector[mid_index] + red_vector[mid_index + 1]) / 2;
                    green = (green_vector[mid_index] + green_vector[mid_index + 1]) / 2;
                    blue = (blue_vector[mid_index] + blue_vector[mid_index + 1]) / 2;
                }
                else
                {
                    decimal mid_index = Math.Floor((decimal)(vector_len / 2));
                    red = red_vector[Decimal.ToInt32(mid_index)];
                    green = green_vector[Decimal.ToInt32(mid_index)];
                    blue = blue_vector[Decimal.ToInt32(mid_index)];
                }
            }

            byte[] rgb_result = new byte[3] { Convert.ToByte(this.normalizeIntToByte(red)), Convert.ToByte(this.normalizeIntToByte(green)), Convert.ToByte(this.normalizeIntToByte(blue)) };

            return rgb_result;

        }

        private void filtrStatycznyAction(object sender, EventArgs e)
        {


            if (this.zdjeciePrzed.Image != null)
            {

                Bitmap zdjeciePoModyfikacji = this.modyfikujZdjecie(this.zdjeciePrzed.Image, this.filtryStatyczne);

                for (int i = 0; i < this.staticLevel.Value - 1; i++)
                {
                    zdjeciePoModyfikacji = this.modyfikujZdjecie(zdjeciePoModyfikacji, this.filtryStatyczne);
                }

                this.zdjeciePo.Image = zdjeciePoModyfikacji;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.zdjeciePoHistogram = new Histogram(this.zdjeciePo.Image);
                this.zdjeciePoHistogram.drawOnChart(this.chart2);

            }


        }

        private void filtrWyostrzajacyObrazAction(object sender, EventArgs e)
        {


            if (this.zdjeciePrzed.Image != null)
            {
                Func<Bitmap, int, int, byte[]> maskaFiltrujaca = this.maskaFiltrujacaFactory(this.sharpenMasks);
                Bitmap zdjeciePoModyfikacji = this.modyfikujZdjecie(this.zdjeciePrzed.Image, maskaFiltrujaca);

                for (int i = 0; i < this.sharpenLevel.Value - 1; i++)
                {
                    zdjeciePoModyfikacji = this.modyfikujZdjecie(zdjeciePoModyfikacji, maskaFiltrujaca);
                }

                this.zdjeciePo.Image = zdjeciePoModyfikacji;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.zdjeciePoHistogram = new Histogram(this.zdjeciePo.Image);
                this.zdjeciePoHistogram.drawOnChart(this.chart2);

            }


        }

        private void filtrUwypuklajaceAction(object sender, EventArgs e)
        {


            if (this.zdjeciePrzed.Image != null)
            {

                Func<Bitmap, int, int, byte[]> maskaFiltrujaca = this.maskaFiltrujacaFactory(this.embossingMasks);
                Bitmap zdjeciePoModyfikacji = this.modyfikujZdjecie(this.zdjeciePrzed.Image, maskaFiltrujaca);

                for (int i = 0; i < this.embossingLevel.Value - 1; i++)
                {
                    zdjeciePoModyfikacji = this.modyfikujZdjecie(zdjeciePoModyfikacji, maskaFiltrujaca);
                }

                this.zdjeciePo.Image = zdjeciePoModyfikacji;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.zdjeciePoHistogram = new Histogram(this.zdjeciePo.Image);
                this.zdjeciePoHistogram.drawOnChart(this.chart2);

            }


        }

    }
}
