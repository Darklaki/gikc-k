
namespace lab6_intensywnosc_histogram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.wybierzZdjecie = new System.Windows.Forms.OpenFileDialog();
            this.zdjeciePrzed = new System.Windows.Forms.PictureBox();
            this.zdjeciePo = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarSkalowanieA = new System.Windows.Forms.TrackBar();
            this.trackBarSkalowanieB = new System.Windows.Forms.TrackBar();
            this.trackBarSkalowanieC = new System.Windows.Forms.TrackBar();
            this.trackBarSkalowanieD = new System.Windows.Forms.TrackBar();
            this.skalowanieHistogramuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.avgFilter = new System.Windows.Forms.RadioButton();
            this.gauss1Filter = new System.Windows.Forms.RadioButton();
            this.filterTimes = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.pyramidFilter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePrzed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // zdjeciePrzed
            // 
            this.zdjeciePrzed.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zdjeciePrzed.Location = new System.Drawing.Point(215, 27);
            this.zdjeciePrzed.Name = "zdjeciePrzed";
            this.zdjeciePrzed.Size = new System.Drawing.Size(310, 233);
            this.zdjeciePrzed.TabIndex = 10;
            this.zdjeciePrzed.TabStop = false;
            this.zdjeciePrzed.Tag = "";
            this.zdjeciePrzed.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.zmianaZdjeciaPrzed);
            this.zdjeciePrzed.Click += new System.EventHandler(this.wybierzZdjeciePrzed);
            // 
            // zdjeciePo
            // 
            this.zdjeciePo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zdjeciePo.Location = new System.Drawing.Point(553, 27);
            this.zdjeciePo.Name = "zdjeciePo";
            this.zdjeciePo.Size = new System.Drawing.Size(310, 233);
            this.zdjeciePo.TabIndex = 11;
            this.zdjeciePo.TabStop = false;
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1Red";
            chartArea8.Name = "ChartArea1Green";
            chartArea9.Name = "ChartArea1Blue";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.ChartAreas.Add(chartArea9);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(215, 308);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1Red";
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "Red";
            series8.ChartArea = "ChartArea1Green";
            series8.Color = System.Drawing.Color.Green;
            series8.Legend = "Legend1";
            series8.Name = "Green";
            series9.ChartArea = "ChartArea1Blue";
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.Name = "Blue";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(310, 253);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Histogram początkowego zdjęcia ";
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1Red";
            chartArea11.Name = "ChartArea1Green";
            chartArea12.Name = "ChartArea1Blue";
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.ChartAreas.Add(chartArea11);
            this.chart2.ChartAreas.Add(chartArea12);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(553, 308);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series10.ChartArea = "ChartArea1Red";
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "Red";
            series11.ChartArea = "ChartArea1Green";
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.Name = "Green";
            series12.ChartArea = "ChartArea1Blue";
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.Name = "Blue";
            this.chart2.Series.Add(series10);
            this.chart2.Series.Add(series11);
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(310, 253);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Histogram po transformacji";
            // 
            // trackBarSkalowanieA
            // 
            this.trackBarSkalowanieA.Location = new System.Drawing.Point(12, 44);
            this.trackBarSkalowanieA.Maximum = 255;
            this.trackBarSkalowanieA.Name = "trackBarSkalowanieA";
            this.trackBarSkalowanieA.Size = new System.Drawing.Size(181, 45);
            this.trackBarSkalowanieA.TabIndex = 16;
            this.trackBarSkalowanieA.ValueChanged += new System.EventHandler(this.trackZmianyA);
            // 
            // trackBarSkalowanieB
            // 
            this.trackBarSkalowanieB.Location = new System.Drawing.Point(12, 98);
            this.trackBarSkalowanieB.Maximum = 255;
            this.trackBarSkalowanieB.Name = "trackBarSkalowanieB";
            this.trackBarSkalowanieB.Size = new System.Drawing.Size(181, 45);
            this.trackBarSkalowanieB.TabIndex = 17;
            this.trackBarSkalowanieB.ValueChanged += new System.EventHandler(this.trackZmianyB);
            // 
            // trackBarSkalowanieC
            // 
            this.trackBarSkalowanieC.Location = new System.Drawing.Point(12, 146);
            this.trackBarSkalowanieC.Maximum = 255;
            this.trackBarSkalowanieC.Name = "trackBarSkalowanieC";
            this.trackBarSkalowanieC.Size = new System.Drawing.Size(181, 45);
            this.trackBarSkalowanieC.TabIndex = 18;
            this.trackBarSkalowanieC.ValueChanged += new System.EventHandler(this.trackZmianyC);
            // 
            // trackBarSkalowanieD
            // 
            this.trackBarSkalowanieD.Location = new System.Drawing.Point(12, 197);
            this.trackBarSkalowanieD.Maximum = 255;
            this.trackBarSkalowanieD.Name = "trackBarSkalowanieD";
            this.trackBarSkalowanieD.Size = new System.Drawing.Size(181, 45);
            this.trackBarSkalowanieD.TabIndex = 19;
            this.trackBarSkalowanieD.Value = 255;
            this.trackBarSkalowanieD.ValueChanged += new System.EventHandler(this.trackZmianyD);
            // 
            // skalowanieHistogramuButton
            // 
            this.skalowanieHistogramuButton.Location = new System.Drawing.Point(12, 245);
            this.skalowanieHistogramuButton.Name = "skalowanieHistogramuButton";
            this.skalowanieHistogramuButton.Size = new System.Drawing.Size(181, 23);
            this.skalowanieHistogramuButton.TabIndex = 20;
            this.skalowanieHistogramuButton.Text = "Skalowanie Histogramu";
            this.skalowanieHistogramuButton.UseVisualStyleBackColor = true;
            this.skalowanieHistogramuButton.Click += new System.EventHandler(this.obliczSkalowanieAction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Filtry rozmywające";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(12, 406);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(181, 23);
            this.filterButton.TabIndex = 27;
            this.filterButton.Text = "Filtruj";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filtrujObrazAction);
            // 
            // avgFilter
            // 
            this.avgFilter.AutoSize = true;
            this.avgFilter.Checked = true;
            this.avgFilter.Location = new System.Drawing.Point(15, 308);
            this.avgFilter.Name = "avgFilter";
            this.avgFilter.Size = new System.Drawing.Size(103, 17);
            this.avgFilter.TabIndex = 28;
            this.avgFilter.TabStop = true;
            this.avgFilter.Text = "Filtr uśredniający";
            this.avgFilter.UseVisualStyleBackColor = true;
            // 
            // gauss1Filter
            // 
            this.gauss1Filter.AutoSize = true;
            this.gauss1Filter.Location = new System.Drawing.Point(15, 331);
            this.gauss1Filter.Name = "gauss1Filter";
            this.gauss1Filter.Size = new System.Drawing.Size(80, 17);
            this.gauss1Filter.TabIndex = 29;
            this.gauss1Filter.TabStop = true;
            this.gauss1Filter.Text = "Filtr Gaussa";
            this.gauss1Filter.UseVisualStyleBackColor = true;
            // 
            // filterTimes
            // 
            this.filterTimes.Location = new System.Drawing.Point(15, 379);
            this.filterTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filterTimes.Name = "filterTimes";
            this.filterTimes.Size = new System.Drawing.Size(36, 20);
            this.filterTimes.TabIndex = 30;
            this.filterTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "razy";
            // 
            // pyramidFilter
            // 
            this.pyramidFilter.AutoSize = true;
            this.pyramidFilter.Location = new System.Drawing.Point(15, 353);
            this.pyramidFilter.Name = "pyramidFilter";
            this.pyramidFilter.Size = new System.Drawing.Size(96, 17);
            this.pyramidFilter.TabIndex = 32;
            this.pyramidFilter.TabStop = true;
            this.pyramidFilter.Text = "Filtr piramidalny";
            this.pyramidFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 585);
            this.Controls.Add(this.pyramidFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filterTimes);
            this.Controls.Add(this.gauss1Filter);
            this.Controls.Add(this.avgFilter);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skalowanieHistogramuButton);
            this.Controls.Add(this.trackBarSkalowanieD);
            this.Controls.Add(this.trackBarSkalowanieC);
            this.Controls.Add(this.trackBarSkalowanieB);
            this.Controls.Add(this.trackBarSkalowanieA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.zdjeciePo);
            this.Controls.Add(this.zdjeciePrzed);
            this.Name = "Form1";
            this.Text = "Lab7";
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePrzed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkalowanieD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog wybierzZdjecie;
        private System.Windows.Forms.PictureBox zdjeciePrzed;
        private System.Windows.Forms.PictureBox zdjeciePo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarSkalowanieA;
        private System.Windows.Forms.TrackBar trackBarSkalowanieB;
        private System.Windows.Forms.TrackBar trackBarSkalowanieC;
        private System.Windows.Forms.TrackBar trackBarSkalowanieD;
        private System.Windows.Forms.Button skalowanieHistogramuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.RadioButton avgFilter;
        private System.Windows.Forms.RadioButton gauss1Filter;
        private System.Windows.Forms.NumericUpDown filterTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton pyramidFilter;
    }
}

