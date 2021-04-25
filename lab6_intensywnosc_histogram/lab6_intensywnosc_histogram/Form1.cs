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
        public Form1()
        {
            InitializeComponent();
        }

        private bool isInByteRange(int val) {
            return val <= 255 && val >= 0;
        }

        private void narysujHistogram( Image img, System.Windows.Forms.DataVisualization.Charting.Chart chart ) {
            // reset previous chart state
            chart.Series["Red"].Points.Clear();
            chart.Series["Green"].Points.Clear();
            chart.Series["Blue"].Points.Clear();

            if (img != null)
            {

                Bitmap image = new Bitmap(img);

                int[] redValues = new int[256];
                int[] greenValues = new int[256];
                int[] blueValues = new int[256];

                // count values for RGB
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++) { 

                        Color pixel = image.GetPixel(x, y);

                        byte red = pixel.R;
                        byte green = pixel.G;
                        byte blue = pixel.B;

                        redValues[red] += 1;
                        greenValues[green] += 1;
                        blueValues[blue] += 1;

                    }
                }

                for (int i = 0; i < 255; i++)
                {
                    chart.Series["Red"].Points.AddXY(i, redValues[i]);
                    chart.Series["Green"].Points.AddXY(i, greenValues[i]);
                    chart.Series["Blue"].Points.AddXY(i, blueValues[i]);
                }

            }
        }

        private void obliczWariant1(object sender, EventArgs e)
        {
            if ( this.zdjeciePrzed.Image != null ) {

                int c =  Decimal.ToInt32(this.numericUpDownWariant1C.Value);

                Bitmap zdjeciePrzed =  new Bitmap(this.zdjeciePrzed.Image);
                Bitmap zdjeciePo = new Bitmap(this.zdjeciePrzed.Image);

                for ( int x = 0; x < zdjeciePrzed.Width; x++ ) {
                    for (int y = 0; y < zdjeciePrzed.Height; y++)
                    {
                        Color pixel = zdjeciePrzed.GetPixel(x, y);

                        byte red = pixel.R;
                        byte green = pixel.G;
                        byte blue = pixel.B;

                        if ( c >= 0 ) {

                            if (127 - c != 0) {
                                if (isInByteRange(127 / (127 - c) * (red - c)))
                                {
                                    red = Convert.ToByte(127 / (127 - c) * (red - c));
                                }
                                if (isInByteRange(127 / (127 - c) * (green - c)))
                                {
                                    green = Convert.ToByte(127 / (127 - c) * (green - c));
                                }
                                if (isInByteRange(127 / (127 - c) * (blue - c)))
                                {
                                    blue = Convert.ToByte(127 / (127 - c) * (blue - c));
                                }
                            }
                            
                            

                        }
                        else {

                            if (isInByteRange((127 - c) / 127 * (red - c)))
                            {
                                red = Convert.ToByte((127 - c) / 127 * (red - c));
                            }
                            if (isInByteRange((127 - c) / 127 * (green - c)))
                            {
                                green = Convert.ToByte((127 - c) / 127 * (green - c));
                            }
                            if (isInByteRange((127 - c) / 127 * (blue - c)))
                            {
                                blue = Convert.ToByte((127 - c) / 127 * (blue - c));
                            }

                        }

                        Color newPixel = Color.FromArgb(red, green, blue);
                        zdjeciePo.SetPixel(x, y, newPixel);

                    }
                }

                this.zdjeciePo.Image = zdjeciePo;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.narysujHistogram(this.zdjeciePo.Image, this.chart2);

            }
        }

        private void obliczWariant2(object sender, EventArgs e)
        {
            if (this.zdjeciePrzed.Image != null)
            {
                int c = Decimal.ToInt32(this.numericUpDownWariant2C.Value);

                Bitmap zdjeciePrzed = new Bitmap(this.zdjeciePrzed.Image);
                Bitmap zdjeciePo = new Bitmap(this.zdjeciePrzed.Image);

                for (int x = 0; x < zdjeciePrzed.Width; x++)
                {
                    for (int y = 0; y < zdjeciePrzed.Height; y++)
                    {
                        Color pixel = zdjeciePrzed.GetPixel(x, y);

                        byte red = pixel.R;
                        byte green = pixel.G;
                        byte blue = pixel.B;

                        if (c >= 0)
                        {

                            if (red < 127)
                            {
                                int val = (127 - c) / 127 * red;
                                if (isInByteRange(val))
                                {
                                    red = Convert.ToByte(val);
                                }
                            }
                            else
                            {
                                int val = (127 - c) / 127 * red + 2 * c;
                                if (isInByteRange(val))
                                {
                                    red = Convert.ToByte(val);
                                }
                            }

                            if (green < 127)
                            {
                                int val = (127 - c) / 127 * green;
                                if (isInByteRange(val))
                                {
                                    green = Convert.ToByte(val);
                                }
                            }
                            else
                            {
                                int val = (127 - c) / 127 * green + 2 * c;
                                if (isInByteRange(val))
                                {
                                    green = Convert.ToByte(val);
                                }
                            }

                            if (blue < 127)
                            {
                                int val = (127 - c) / 127 * blue;
                                if (isInByteRange(val))
                                {
                                    blue = Convert.ToByte(val);
                                }
                            }
                            else
                            {
                                int val = (127 - c) / 127 * blue + 2 * c;
                                if (isInByteRange(val))
                                {
                                    blue = Convert.ToByte(val);
                                }
                            }

                        }
                        else
                        {

                            if (c + 127 != 0) {

                                if (red < 127 + c)
                                {
                                    int val = (127 / (127 + c)) * red;
                                    if (this.isInByteRange(val))
                                    {
                                        red = Convert.ToByte(val);
                                    }

                                }else if (red > 127 - c)
                                {
                                    int val = ( 127*red + 255*c ) / (127+c);
                                    if (this.isInByteRange(val))
                                    {
                                        red = Convert.ToByte(val);
                                    }
                                }
                                else
                                {
                                    red = Convert.ToByte(127);
                                }



                                if (green < 127 + c)
                                {
                                    int val = (127 / (127 + c)) * green;
                                    if (this.isInByteRange(val))
                                    {
                                        green = Convert.ToByte(val);
                                    }

                                }
                                else if (green > 127 - c)
                                {
                                    int val = (127 * green + 255 * c) / (127 + c);
                                    if (this.isInByteRange(val))
                                    {
                                        green = Convert.ToByte(val);
                                    }
                                }
                                else
                                {
                                    green = Convert.ToByte(127);
                                }



                                if (blue < 127 + c)
                                {
                                    int val = (127 / (127 + c)) * blue;
                                    if (this.isInByteRange(val))
                                    {
                                        blue = Convert.ToByte(val);
                                    }

                                }
                                else if (blue > 127 - c)
                                {
                                    int val = (127 * blue + 255 * c) / (127 + c);
                                    if (this.isInByteRange(val))
                                    {
                                        blue = Convert.ToByte(val);
                                    }
                                }
                                else
                                {
                                    blue = Convert.ToByte(127);
                                }

                            }

                        }


                        Color newPixel = Color.FromArgb(red, green, blue);
                        zdjeciePo.SetPixel(x, y, newPixel);

                    }
                }

                this.zdjeciePo.Image = zdjeciePo;
                this.zdjeciePo.SizeMode = PictureBoxSizeMode.Zoom;

                this.narysujHistogram(this.zdjeciePo.Image, this.chart2);
            }
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

            this.narysujHistogram(this.zdjeciePrzed.Image, this.chart1);

            /*// reset previous chart state
            this.chart1.Series["Red"].Points.Clear();
            this.chart1.Series["Green"].Points.Clear();
            this.chart1.Series["Blue"].Points.Clear();

            if (this.zdjeciePrzed.Image != null)
            {

                Bitmap zdjeciePrzed = new Bitmap(this.zdjeciePrzed.Image);

                int[] redValues = new int[256];
                int[] greenValues = new int[256];
                int[] blueValues = new int[256];

                // count values for RGB
                for (int x = 0; x < zdjeciePrzed.Width; x++)
                {
                    for (int y = 0; y < zdjeciePrzed.Height; y++)
                    {
                        Color pixel = zdjeciePrzed.GetPixel(x, y);

                        byte red = pixel.R;
                        byte green = pixel.G;
                        byte blue = pixel.B;

                        redValues[red] += 1;
                        greenValues[green] += 1;
                        blueValues[blue] += 1;

                    }
                }

                for(int i = 0; i < 255; i++)
                {
                    this.chart1.Series["Red"].Points.AddXY(i, redValues[i]);
                    this.chart1.Series["Green"].Points.AddXY(i, greenValues[i]);
                    this.chart1.Series["Blue"].Points.AddXY(i, blueValues[i]);
                }

            }*/

        }

    }
}
