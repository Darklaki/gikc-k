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
        

        private void wybierzZdjeciePrzed(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                this.zdjeciePrzed.LoadAsync( open.FileName);
                this.zdjeciePrzed.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }
        private void zmianaZdjeciaPrzed(object sender, AsyncCompletedEventArgs e) {

            //this.narysujHistogram(this.zdjeciePrzed.Image, this.chart1);
            this.zdjeciePrzedHistogram = new Histogram(this.zdjeciePrzed.Image);
            this.zdjeciePrzedHistogram.drawOnChart(this.chart1);

        }

        private void trackZmianyA(object sender, EventArgs e)
        {

            this.label1.Text = "A: " + this.trackBarSkalowanieA.Value;

        }

        private void trackZmianyB(object sender, EventArgs e)
        {

            this.label2.Text = "B: " + this.trackBarSkalowanieB.Value;

        }

        private void trackZmianyC(object sender, EventArgs e)
        {

            this.label3.Text = "C: " + this.trackBarSkalowanieC.Value;

        }

        private void trackZmianyD(object sender, EventArgs e)
        {

            this.label4.Text = "D: " + this.trackBarSkalowanieD.Value;

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

        private byte[] obliczSkalowanie( Bitmap img, int x , int y ) {

            Color pixel = img.GetPixel(x, y);

            byte red = pixel.R;
            byte green = pixel.G;
            byte blue = pixel.B;

            int a = this.trackBarSkalowanieA.Value;
            int b = this.trackBarSkalowanieB.Value;
            int c = this.trackBarSkalowanieC.Value;
            int d = this.trackBarSkalowanieD.Value;

            byte[] rgb_result = new byte[3] { red, green, blue };

            if (b - a != 0)
            {
                if (this.isInByteRange((red - a) * ((d - c) / (b - a)) + c))
                {
                    rgb_result[0] = Convert.ToByte((red - a) * ((d - c) / (b - a)) + c);
                }
                if (this.isInByteRange((green - a) * ((d - c) / (b - a)) + c))
                {
                    rgb_result[1] = Convert.ToByte((green - a) * ((d - c) / (b - a)) + c);
                }
                if (this.isInByteRange((blue - a) * ((d - c) / (b - a)) + c))
                {
                    rgb_result[2] = Convert.ToByte((blue - a) * ((d - c) / (b - a)) + c);
                }
            }
            return rgb_result;
        }

        private void obliczSkalowanieAction(object sender, EventArgs e)
        {

            if (this.zdjeciePrzed.Image != null)
            {

                Bitmap zdjeciePoModyfikacji = this.modyfikujZdjecie(this.zdjeciePrzed.Image, this.obliczSkalowanie);

                this.zdjeciePo.Image = zdjeciePoModyfikacji;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.zdjeciePoHistogram = new Histogram(this.zdjeciePo.Image);
                this.zdjeciePoHistogram.drawOnChart(this.chart2);

            }
        }

        private byte[] filtrujObraz(Bitmap img, int x, int y) {

            // intialize with dummy values
            int mask_size_n = 0;
            int[,] filter_weights = new int[1, 1];

            if( this.avgFilter.Checked)
            {
                mask_size_n = 3;
                filter_weights = new int[,] { {1, 1, 1}, { 1, 1, 1 }, { 1, 1, 1 } };
            }
            if ( this.gauss1Filter.Checked ) {
                mask_size_n = 3;
                filter_weights = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 1, 2, 1 } };
            }
            if( this.pyramidFilter.Checked )
            {
                mask_size_n = 5;
                filter_weights = new int[,] { { 1, 2, 3, 2, 1 }, { 2, 4, 6, 4, 2 }, { 3, 6, 9, 6, 3 }, { 2, 4, 6, 4, 2 }, { 1, 2, 3, 2, 1 } };
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

            byte[] rgb_result = new byte[3] { Convert.ToByte(red), Convert.ToByte(green), Convert.ToByte(blue) };

            return rgb_result;

        }

        private void filtrujObrazAction(object sender, EventArgs e)
        {

            
            if (this.zdjeciePrzed.Image != null)
            {

                Bitmap zdjeciePoModyfikacji = this.modyfikujZdjecie(this.zdjeciePrzed.Image, this.filtrujObraz);

                for(int i = 0; i < this.filterTimes.Value - 1; i++)
                {
                    zdjeciePoModyfikacji = this.modyfikujZdjecie(zdjeciePoModyfikacji, this.filtrujObraz);
                }

                this.zdjeciePo.Image = zdjeciePoModyfikacji;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.zdjeciePoHistogram = new Histogram(this.zdjeciePo.Image);
                this.zdjeciePoHistogram.drawOnChart(this.chart2);

            }


        }
    }
}
