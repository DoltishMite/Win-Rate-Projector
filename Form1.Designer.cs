namespace Win_Rate_Projector
{
    partial class MainWindowForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WinButton = new System.Windows.Forms.Button();
            this.LossButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.Title = "Match Number";
            chartArea4.AxisY.Interval = 10D;
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.Title = "Percentage";
            chartArea4.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.MainChart.Legends.Add(legend4);
            this.MainChart.Location = new System.Drawing.Point(0, -1);
            this.MainChart.Name = "MainChart";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.Name = "Win / Loss Ratio";
            this.MainChart.Series.Add(series4);
            this.MainChart.Size = new System.Drawing.Size(1228, 479);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Win / Loss Ratio Chart";
            this.MainChart.Titles.Add(title4);
            // 
            // WinButton
            // 
            this.WinButton.AutoSize = true;
            this.WinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WinButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WinButton.Location = new System.Drawing.Point(0, 517);
            this.WinButton.Name = "WinButton";
            this.WinButton.Size = new System.Drawing.Size(1228, 41);
            this.WinButton.TabIndex = 2;
            this.WinButton.Text = "Win";
            this.WinButton.UseVisualStyleBackColor = true;
            this.WinButton.Click += new System.EventHandler(this.WinButton_Click);
            // 
            // LossButton
            // 
            this.LossButton.AutoSize = true;
            this.LossButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LossButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LossButton.Location = new System.Drawing.Point(0, 476);
            this.LossButton.Name = "LossButton";
            this.LossButton.Size = new System.Drawing.Size(1228, 41);
            this.LossButton.TabIndex = 3;
            this.LossButton.Text = "Loss";
            this.LossButton.UseVisualStyleBackColor = true;
            this.LossButton.Click += new System.EventHandler(this.LossButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 558);
            this.Controls.Add(this.LossButton);
            this.Controls.Add(this.WinButton);
            this.Controls.Add(this.MainChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindowForm";
            this.Text = "Win Rate Projector";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button WinButton;
        private System.Windows.Forms.Button LossButton;
    }
}

