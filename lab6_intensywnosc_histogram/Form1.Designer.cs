
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.wybierzZdjecie = new System.Windows.Forms.OpenFileDialog();
            this.zdjeciePrzed = new System.Windows.Forms.PictureBox();
            this.zdjeciePo = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.robertsHorizontal = new System.Windows.Forms.RadioButton();
            this.robertsVertical = new System.Windows.Forms.RadioButton();
            this.prewittHorizontal = new System.Windows.Forms.RadioButton();
            this.prewittVertical = new System.Windows.Forms.RadioButton();
            this.sobelHorizontal = new System.Windows.Forms.RadioButton();
            this.sobelVertical = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.sharpenLevel = new System.Windows.Forms.NumericUpDown();
            this.applySharpenFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laplaceSharpen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.medianStatic = new System.Windows.Forms.RadioButton();
            this.maxStatic = new System.Windows.Forms.RadioButton();
            this.minStatic = new System.Windows.Forms.RadioButton();
            this.applyStaticFilter = new System.Windows.Forms.Button();
            this.staticLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.staticMaskSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.applyEmbossingFilter = new System.Windows.Forms.Button();
            this.embossingLevel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.northEmbossing = new System.Windows.Forms.RadioButton();
            this.westEmbossing = new System.Windows.Forms.RadioButton();
            this.eastEmbossing = new System.Windows.Forms.RadioButton();
            this.southEmbossing = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePrzed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticMaskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embossingLevel)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            chartArea1.Name = "ChartArea1Red";
            chartArea2.Name = "ChartArea1Green";
            chartArea3.Name = "ChartArea1Blue";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(215, 300);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1Red";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1Green";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1Blue";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(310, 253);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Histogram początkowego zdjęcia ";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1Red";
            chartArea5.Name = "ChartArea1Green";
            chartArea6.Name = "ChartArea1Blue";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.ChartAreas.Add(chartArea5);
            this.chart2.ChartAreas.Add(chartArea6);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(553, 300);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1Red";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Red";
            series5.ChartArea = "ChartArea1Green";
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "Green";
            series6.ChartArea = "ChartArea1Blue";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Blue";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(310, 253);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Histogram po transformacji";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // robertsHorizontal
            // 
            this.robertsHorizontal.AutoSize = true;
            this.robertsHorizontal.Checked = true;
            this.robertsHorizontal.Location = new System.Drawing.Point(8, 19);
            this.robertsHorizontal.Name = "robertsHorizontal";
            this.robertsHorizontal.Size = new System.Drawing.Size(153, 17);
            this.robertsHorizontal.TabIndex = 17;
            this.robertsHorizontal.TabStop = true;
            this.robertsHorizontal.Text = "Operator poziomy Robertsa";
            this.robertsHorizontal.UseVisualStyleBackColor = true;
            // 
            // robertsVertical
            // 
            this.robertsVertical.AutoSize = true;
            this.robertsVertical.Location = new System.Drawing.Point(8, 42);
            this.robertsVertical.Name = "robertsVertical";
            this.robertsVertical.Size = new System.Drawing.Size(154, 17);
            this.robertsVertical.TabIndex = 18;
            this.robertsVertical.Text = "Operator pionowy Robertsa";
            this.robertsVertical.UseVisualStyleBackColor = true;
            // 
            // prewittHorizontal
            // 
            this.prewittHorizontal.AutoSize = true;
            this.prewittHorizontal.Location = new System.Drawing.Point(9, 65);
            this.prewittHorizontal.Name = "prewittHorizontal";
            this.prewittHorizontal.Size = new System.Drawing.Size(148, 17);
            this.prewittHorizontal.TabIndex = 19;
            this.prewittHorizontal.Text = "Operator poziomy Prewitta";
            this.prewittHorizontal.UseVisualStyleBackColor = true;
            // 
            // prewittVertical
            // 
            this.prewittVertical.AutoSize = true;
            this.prewittVertical.Location = new System.Drawing.Point(9, 88);
            this.prewittVertical.Name = "prewittVertical";
            this.prewittVertical.Size = new System.Drawing.Size(149, 17);
            this.prewittVertical.TabIndex = 20;
            this.prewittVertical.Text = "Operator pionowy Prewitta";
            this.prewittVertical.UseVisualStyleBackColor = true;
            // 
            // sobelHorizontal
            // 
            this.sobelHorizontal.AutoSize = true;
            this.sobelHorizontal.Location = new System.Drawing.Point(9, 111);
            this.sobelHorizontal.Name = "sobelHorizontal";
            this.sobelHorizontal.Size = new System.Drawing.Size(143, 17);
            this.sobelHorizontal.TabIndex = 21;
            this.sobelHorizontal.Text = "Operator poziomy Sobela";
            this.sobelHorizontal.UseVisualStyleBackColor = true;
            // 
            // sobelVertical
            // 
            this.sobelVertical.AutoSize = true;
            this.sobelVertical.Location = new System.Drawing.Point(9, 134);
            this.sobelVertical.Name = "sobelVertical";
            this.sobelVertical.Size = new System.Drawing.Size(144, 17);
            this.sobelVertical.TabIndex = 22;
            this.sobelVertical.Text = "Operator pionowy Sobela";
            this.sobelVertical.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Stopień = ";
            // 
            // sharpenLevel
            // 
            this.sharpenLevel.Location = new System.Drawing.Point(68, 206);
            this.sharpenLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sharpenLevel.Name = "sharpenLevel";
            this.sharpenLevel.Size = new System.Drawing.Size(43, 20);
            this.sharpenLevel.TabIndex = 24;
            this.sharpenLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // applySharpenFilter
            // 
            this.applySharpenFilter.Location = new System.Drawing.Point(11, 238);
            this.applySharpenFilter.Name = "applySharpenFilter";
            this.applySharpenFilter.Size = new System.Drawing.Size(189, 23);
            this.applySharpenFilter.TabIndex = 25;
            this.applySharpenFilter.Text = "Zastosuj";
            this.applySharpenFilter.UseVisualStyleBackColor = true;
            this.applySharpenFilter.Click += new System.EventHandler(this.filtrWyostrzajacyObrazAction);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laplaceSharpen);
            this.groupBox1.Controls.Add(this.robertsHorizontal);
            this.groupBox1.Controls.Add(this.robertsVertical);
            this.groupBox1.Controls.Add(this.prewittHorizontal);
            this.groupBox1.Controls.Add(this.prewittVertical);
            this.groupBox1.Controls.Add(this.sobelVertical);
            this.groupBox1.Controls.Add(this.sobelHorizontal);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 186);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtry wyostrzające";
            // 
            // laplaceSharpen
            // 
            this.laplaceSharpen.AutoSize = true;
            this.laplaceSharpen.Location = new System.Drawing.Point(8, 157);
            this.laplaceSharpen.Name = "laplaceSharpen";
            this.laplaceSharpen.Size = new System.Drawing.Size(116, 17);
            this.laplaceSharpen.TabIndex = 23;
            this.laplaceSharpen.TabStop = true;
            this.laplaceSharpen.Text = "Operator Laplace’a";
            this.laplaceSharpen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.medianStatic);
            this.groupBox2.Controls.Add(this.maxStatic);
            this.groupBox2.Controls.Add(this.minStatic);
            this.groupBox2.Location = new System.Drawing.Point(11, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 97);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtry statyczne";
            // 
            // medianStatic
            // 
            this.medianStatic.AutoSize = true;
            this.medianStatic.Location = new System.Drawing.Point(9, 69);
            this.medianStatic.Name = "medianStatic";
            this.medianStatic.Size = new System.Drawing.Size(79, 17);
            this.medianStatic.TabIndex = 2;
            this.medianStatic.Text = "Medianowy";
            this.medianStatic.UseVisualStyleBackColor = true;
            // 
            // maxStatic
            // 
            this.maxStatic.AutoSize = true;
            this.maxStatic.Location = new System.Drawing.Point(9, 46);
            this.maxStatic.Name = "maxStatic";
            this.maxStatic.Size = new System.Drawing.Size(45, 17);
            this.maxStatic.TabIndex = 1;
            this.maxStatic.Text = "Max";
            this.maxStatic.UseVisualStyleBackColor = true;
            // 
            // minStatic
            // 
            this.minStatic.AutoSize = true;
            this.minStatic.Checked = true;
            this.minStatic.Location = new System.Drawing.Point(9, 23);
            this.minStatic.Name = "minStatic";
            this.minStatic.Size = new System.Drawing.Size(42, 17);
            this.minStatic.TabIndex = 0;
            this.minStatic.TabStop = true;
            this.minStatic.Text = "Min";
            this.minStatic.UseVisualStyleBackColor = true;
            // 
            // applyStaticFilter
            // 
            this.applyStaticFilter.Location = new System.Drawing.Point(11, 436);
            this.applyStaticFilter.Name = "applyStaticFilter";
            this.applyStaticFilter.Size = new System.Drawing.Size(189, 23);
            this.applyStaticFilter.TabIndex = 30;
            this.applyStaticFilter.Text = "Zastosuj";
            this.applyStaticFilter.UseVisualStyleBackColor = true;
            this.applyStaticFilter.Click += new System.EventHandler(this.filtrStatycznyAction);
            // 
            // staticLevel
            // 
            this.staticLevel.Location = new System.Drawing.Point(94, 381);
            this.staticLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.staticLevel.Name = "staticLevel";
            this.staticLevel.Size = new System.Drawing.Size(43, 20);
            this.staticLevel.TabIndex = 29;
            this.staticLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Stopień = ";
            // 
            // staticMaskSize
            // 
            this.staticMaskSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.staticMaskSize.Location = new System.Drawing.Point(94, 408);
            this.staticMaskSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.staticMaskSize.Name = "staticMaskSize";
            this.staticMaskSize.Size = new System.Drawing.Size(43, 20);
            this.staticMaskSize.TabIndex = 32;
            this.staticMaskSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rozmiar maski";
            // 
            // applyEmbossingFilter
            // 
            this.applyEmbossingFilter.Location = new System.Drawing.Point(11, 632);
            this.applyEmbossingFilter.Name = "applyEmbossingFilter";
            this.applyEmbossingFilter.Size = new System.Drawing.Size(189, 23);
            this.applyEmbossingFilter.TabIndex = 36;
            this.applyEmbossingFilter.Text = "Zastosuj";
            this.applyEmbossingFilter.UseVisualStyleBackColor = true;
            this.applyEmbossingFilter.Click += new System.EventHandler(this.filtrUwypuklajaceAction);
            // 
            // embossingLevel
            // 
            this.embossingLevel.Location = new System.Drawing.Point(94, 602);
            this.embossingLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.embossingLevel.Name = "embossingLevel";
            this.embossingLevel.Size = new System.Drawing.Size(43, 20);
            this.embossingLevel.TabIndex = 35;
            this.embossingLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Stopień = ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.southEmbossing);
            this.groupBox3.Controls.Add(this.northEmbossing);
            this.groupBox3.Controls.Add(this.westEmbossing);
            this.groupBox3.Controls.Add(this.eastEmbossing);
            this.groupBox3.Location = new System.Drawing.Point(11, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 122);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtry uwypuklające";
            // 
            // northEmbossing
            // 
            this.northEmbossing.AutoSize = true;
            this.northEmbossing.Location = new System.Drawing.Point(9, 69);
            this.northEmbossing.Name = "northEmbossing";
            this.northEmbossing.Size = new System.Drawing.Size(60, 17);
            this.northEmbossing.TabIndex = 2;
            this.northEmbossing.Text = "Północ";
            this.northEmbossing.UseVisualStyleBackColor = true;
            // 
            // westEmbossing
            // 
            this.westEmbossing.AutoSize = true;
            this.westEmbossing.Location = new System.Drawing.Point(9, 46);
            this.westEmbossing.Name = "westEmbossing";
            this.westEmbossing.Size = new System.Drawing.Size(62, 17);
            this.westEmbossing.TabIndex = 1;
            this.westEmbossing.Text = "Zachód";
            this.westEmbossing.UseVisualStyleBackColor = true;
            // 
            // eastEmbossing
            // 
            this.eastEmbossing.AutoSize = true;
            this.eastEmbossing.Checked = true;
            this.eastEmbossing.Location = new System.Drawing.Point(9, 23);
            this.eastEmbossing.Name = "eastEmbossing";
            this.eastEmbossing.Size = new System.Drawing.Size(65, 17);
            this.eastEmbossing.TabIndex = 0;
            this.eastEmbossing.TabStop = true;
            this.eastEmbossing.Text = "Wschód";
            this.eastEmbossing.UseVisualStyleBackColor = true;
            // 
            // southEmbossing
            // 
            this.southEmbossing.AutoSize = true;
            this.southEmbossing.Location = new System.Drawing.Point(8, 92);
            this.southEmbossing.Name = "southEmbossing";
            this.southEmbossing.Size = new System.Drawing.Size(68, 17);
            this.southEmbossing.TabIndex = 3;
            this.southEmbossing.Text = "Południe";
            this.southEmbossing.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 672);
            this.Controls.Add(this.applyEmbossingFilter);
            this.Controls.Add(this.embossingLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.staticMaskSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.applyStaticFilter);
            this.Controls.Add(this.staticLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applySharpenFilter);
            this.Controls.Add(this.sharpenLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.zdjeciePo);
            this.Controls.Add(this.zdjeciePrzed);
            this.Name = "Form1";
            this.Text = "Lab8";
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePrzed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticMaskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embossingLevel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton robertsHorizontal;
        private System.Windows.Forms.RadioButton robertsVertical;
        private System.Windows.Forms.RadioButton prewittHorizontal;
        private System.Windows.Forms.RadioButton prewittVertical;
        private System.Windows.Forms.RadioButton sobelHorizontal;
        private System.Windows.Forms.RadioButton sobelVertical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sharpenLevel;
        private System.Windows.Forms.Button applySharpenFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton laplaceSharpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton medianStatic;
        private System.Windows.Forms.RadioButton maxStatic;
        private System.Windows.Forms.RadioButton minStatic;
        private System.Windows.Forms.Button applyStaticFilter;
        private System.Windows.Forms.NumericUpDown staticLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown staticMaskSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyEmbossingFilter;
        private System.Windows.Forms.NumericUpDown embossingLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton southEmbossing;
        private System.Windows.Forms.RadioButton northEmbossing;
        private System.Windows.Forms.RadioButton westEmbossing;
        private System.Windows.Forms.RadioButton eastEmbossing;
    }
}

