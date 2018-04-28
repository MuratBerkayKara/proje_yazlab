namespace proje
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafik1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafik2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafik3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafik4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.grafik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik4)).BeginInit();
            this.SuspendLayout();
            // 
            // grafik1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafik1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafik1.Legends.Add(legend1);
            this.grafik1.Location = new System.Drawing.Point(25, 26);
            this.grafik1.Name = "grafik1";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            this.grafik1.Series.Add(series1);
            this.grafik1.Size = new System.Drawing.Size(425, 190);
            this.grafik1.TabIndex = 0;
            this.grafik1.Text = "chart1";
            // 
            // grafik2
            // 
            chartArea2.Name = "ChartArea1";
            this.grafik2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafik2.Legends.Add(legend2);
            this.grafik2.Location = new System.Drawing.Point(456, 26);
            this.grafik2.Name = "grafik2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            this.grafik2.Series.Add(series2);
            this.grafik2.Size = new System.Drawing.Size(425, 190);
            this.grafik2.TabIndex = 1;
            this.grafik2.Text = "chart2";
            // 
            // grafik3
            // 
            chartArea3.Name = "ChartArea1";
            this.grafik3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafik3.Legends.Add(legend3);
            this.grafik3.Location = new System.Drawing.Point(25, 222);
            this.grafik3.Name = "grafik3";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.grafik3.Series.Add(series3);
            this.grafik3.Size = new System.Drawing.Size(425, 190);
            this.grafik3.TabIndex = 2;
            this.grafik3.Text = "chart3";
            // 
            // grafik4
            // 
            chartArea4.Name = "ChartArea1";
            this.grafik4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafik4.Legends.Add(legend4);
            this.grafik4.Location = new System.Drawing.Point(456, 222);
            this.grafik4.Name = "grafik4";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Color = System.Drawing.Color.Gray;
            series4.Legend = "Legend1";
            series4.Name = "Grey";
            this.grafik4.Series.Add(series4);
            this.grafik4.Size = new System.Drawing.Size(425, 190);
            this.grafik4.TabIndex = 3;
            this.grafik4.Text = "chart4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 421);
            this.Controls.Add(this.grafik4);
            this.Controls.Add(this.grafik3);
            this.Controls.Add(this.grafik2);
            this.Controls.Add(this.grafik1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafik1;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafik2;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafik3;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafik4;
    }
}