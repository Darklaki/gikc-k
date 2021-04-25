
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownWariant1C = new System.Windows.Forms.NumericUpDown();
            this.buttonWariant1 = new System.Windows.Forms.Button();
            this.buttonWariant2 = new System.Windows.Forms.Button();
            this.numericUpDownWariant2C = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wybierzZdjecie = new System.Windows.Forms.OpenFileDialog();
            this.zdjeciePrzed = new System.Windows.Forms.PictureBox();
            this.zdjeciePo = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWariant1C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWariant2C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePrzed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontrast i histogram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wariant 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ΔC";
            // 
            // numericUpDownWariant1C
            // 
            this.numericUpDownWariant1C.Location = new System.Drawing.Point(43, 90);
            this.numericUpDownWariant1C.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownWariant1C.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.numericUpDownWariant1C.Name = "numericUpDownWariant1C";
            this.numericUpDownWariant1C.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownWariant1C.TabIndex = 4;
            // 
            // buttonWariant1
            // 
            this.buttonWariant1.Location = new System.Drawing.Point(114, 88);
            this.buttonWariant1.Name = "buttonWariant1";
            this.buttonWariant1.Size = new System.Drawing.Size(75, 23);
            this.buttonWariant1.TabIndex = 5;
            this.buttonWariant1.Text = "Zastosuj";
            this.buttonWariant1.UseVisualStyleBackColor = true;
            this.buttonWariant1.Click += new System.EventHandler(this.obliczWariant1);
            // 
            // buttonWariant2
            // 
            this.buttonWariant2.Location = new System.Drawing.Point(346, 88);
            this.buttonWariant2.Name = "buttonWariant2";
            this.buttonWariant2.Size = new System.Drawing.Size(74, 23);
            this.buttonWariant2.TabIndex = 9;
            this.buttonWariant2.Text = "Zastosuj";
            this.buttonWariant2.UseVisualStyleBackColor = true;
            this.buttonWariant2.Click += new System.EventHandler(this.obliczWariant2);
            // 
            // numericUpDownWariant2C
            // 
            this.numericUpDownWariant2C.Location = new System.Drawing.Point(275, 90);
            this.numericUpDownWariant2C.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownWariant2C.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.numericUpDownWariant2C.Name = "numericUpDownWariant2C";
            this.numericUpDownWariant2C.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownWariant2C.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(251, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ΔC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(246, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wariant 2";
            // 
            // zdjeciePrzed
            // 
            this.zdjeciePrzed.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zdjeciePrzed.Location = new System.Drawing.Point(17, 139);
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
            this.zdjeciePo.Location = new System.Drawing.Point(355, 139);
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
            this.chart1.Location = new System.Drawing.Point(17, 420);
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
            this.label6.Location = new System.Drawing.Point(14, 397);
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
            this.chart2.Location = new System.Drawing.Point(355, 420);
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
            this.label7.Location = new System.Drawing.Point(352, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Histogram po transformacji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.zdjeciePo);
            this.Controls.Add(this.zdjeciePrzed);
            this.Controls.Add(this.buttonWariant2);
            this.Controls.Add(this.numericUpDownWariant2C);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonWariant1);
            this.Controls.Add(this.numericUpDownWariant1C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab6";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWariant1C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWariant2C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePrzed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWariant1C;
        private System.Windows.Forms.Button buttonWariant1;
        private System.Windows.Forms.Button buttonWariant2;
        private System.Windows.Forms.NumericUpDown numericUpDownWariant2C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog wybierzZdjecie;
        private System.Windows.Forms.PictureBox zdjeciePrzed;
        private System.Windows.Forms.PictureBox zdjeciePo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label7;
    }
}

