using System.Drawing;

namespace lab6_intensywnosc_histogram
{
    public class Histogram
    {

        public double[] redValues { get; set; } = new double[256];
        public double[] greenValues { get; set; } = new double[256];
        public double[] blueValues { get; set; } = new double[256];
        private int imageSize { get; set; } = 0;


        public Histogram(Image img, bool shouldNormalize = true) {

            if (img != null)
            {

                Bitmap image = new Bitmap(img);

                double[] redValues = new double[256];
                double[] greenValues = new double[256];
                double[] blueValues = new double[256];

                int image_size = image.Width * image.Height;

                this.imageSize = image_size;

                // count values for RGB
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {

                        Color pixel = image.GetPixel(x, y);

                        byte red = pixel.R;
                        byte green = pixel.G;
                        byte blue = pixel.B;

                        redValues[red] += 1;
                        greenValues[green] += 1;
                        blueValues[blue] += 1;

                    }
                }

                if (!shouldNormalize)
                {
                    this.redValues = redValues;
                    this.greenValues = greenValues;
                    this.blueValues = blueValues;
                }
                else
                {
                    for (int i = 0; i < 255; i++)
                    {
                        this.redValues[i] = (double)redValues[i] / (double)image_size;
                        this.greenValues[i] = (double)greenValues[i] / (double)image_size;
                        this.blueValues[i] = (double)blueValues[i] / (double)image_size;
                    }
                }

            }

        }

        public void drawOnChart(System.Windows.Forms.DataVisualization.Charting.Chart chart) {

            // reset previous chart state
            chart.Series["Red"].Points.Clear();
            chart.Series["Green"].Points.Clear();
            chart.Series["Blue"].Points.Clear();

            for (int i = 0; i < 255; i++)
            {
                double i_red = this.redValues[i];
                double i_green = this.greenValues[i];
                double i_blue = this.blueValues[i];

                chart.Series["Red"].Points.AddXY(i, i_red);
                chart.Series["Green"].Points.AddXY(i, i_green);
                chart.Series["Blue"].Points.AddXY(i, i_blue);

            }
        }

        public double[] expectedValueForRGB()
        {
            double[] expected_values = new double[3];

            for (int i = 0; i < 255; i++) {

                expected_values[0] += i * this.redValues[i];
                expected_values[1] += i * this.greenValues[i];
                expected_values[2] += i * this.blueValues[i];

            }

            return expected_values;
        }

        public double[] variationForRGB() {

            double[] variations = new double[3];

            double[] exp_values = this.expectedValueForRGB();

            for (int i = 0; i < 255; i++)
            {

                variations[0] += System.Math.Pow(i - exp_values[0], 2) * this.redValues[i];
                variations[1] += System.Math.Pow(i - exp_values[1], 2) * this.greenValues[i];
                variations[2] += System.Math.Pow(i - exp_values[2], 2) * this.blueValues[i];

            }

            return variations;
        
        }

    }
}
