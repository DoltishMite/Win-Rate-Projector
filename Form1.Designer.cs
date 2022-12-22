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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WinButton = new System.Windows.Forms.Button();
            this.LossButton = new System.Windows.Forms.Button();
            this.WinLossRatioLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.StatTrackTitleLabel = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.WinsCounterLabel = new System.Windows.Forms.Label();
            this.DrawsCounterLabel = new System.Windows.Forms.Label();
            this.LossesCounterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.Title = "Match Number";
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Percentage";
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(3, 3);
            this.MainChart.Name = "MainChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Win / Loss Ratio";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(874, 502);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            title1.Name = "Title1";
            title1.Text = "Win Rate Percentage Chart";
            this.MainChart.Titles.Add(title1);
            // 
            // WinButton
            // 
            this.WinButton.AutoSize = true;
            this.WinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WinButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WinButton.Location = new System.Drawing.Point(0, 0);
            this.WinButton.Name = "WinButton";
            this.WinButton.Size = new System.Drawing.Size(170, 41);
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
            this.LossButton.Location = new System.Drawing.Point(0, 211);
            this.LossButton.Name = "LossButton";
            this.LossButton.Size = new System.Drawing.Size(170, 41);
            this.LossButton.TabIndex = 3;
            this.LossButton.Text = "Loss";
            this.LossButton.UseVisualStyleBackColor = true;
            this.LossButton.Click += new System.EventHandler(this.LossButton_Click);
            // 
            // WinLossRatioLabel
            // 
            this.WinLossRatioLabel.AutoSize = true;
            this.WinLossRatioLabel.Location = new System.Drawing.Point(8, 34);
            this.WinLossRatioLabel.Name = "WinLossRatioLabel";
            this.WinLossRatioLabel.Size = new System.Drawing.Size(119, 13);
            this.WinLossRatioLabel.TabIndex = 4;
            this.WinLossRatioLabel.Text = "Win / Loss Ration: N/A";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainChart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 511);
            this.splitContainer1.SplitterDistance = 880;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.LossesCounterLabel);
            this.splitContainer2.Panel1.Controls.Add(this.DrawsCounterLabel);
            this.splitContainer2.Panel1.Controls.Add(this.WinsCounterLabel);
            this.splitContainer2.Panel1.Controls.Add(this.StatTrackTitleLabel);
            this.splitContainer2.Panel1.Controls.Add(this.WinLossRatioLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DrawButton);
            this.splitContainer2.Panel2.Controls.Add(this.LossButton);
            this.splitContainer2.Panel2.Controls.Add(this.WinButton);
            this.splitContainer2.Size = new System.Drawing.Size(170, 511);
            this.splitContainer2.SplitterDistance = 255;
            this.splitContainer2.TabIndex = 6;
            // 
            // StatTrackTitleLabel
            // 
            this.StatTrackTitleLabel.AutoSize = true;
            this.StatTrackTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StatTrackTitleLabel.Location = new System.Drawing.Point(6, 9);
            this.StatTrackTitleLabel.Name = "StatTrackTitleLabel";
            this.StatTrackTitleLabel.Size = new System.Drawing.Size(119, 25);
            this.StatTrackTitleLabel.TabIndex = 5;
            this.StatTrackTitleLabel.Text = "Stat Tracker";
            // 
            // DrawButton
            // 
            this.DrawButton.AutoSize = true;
            this.DrawButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DrawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DrawButton.Location = new System.Drawing.Point(0, 41);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(170, 170);
            this.DrawButton.TabIndex = 4;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // WinsCounterLabel
            // 
            this.WinsCounterLabel.AutoSize = true;
            this.WinsCounterLabel.Location = new System.Drawing.Point(8, 47);
            this.WinsCounterLabel.Name = "WinsCounterLabel";
            this.WinsCounterLabel.Size = new System.Drawing.Size(60, 13);
            this.WinsCounterLabel.TabIndex = 6;
            this.WinsCounterLabel.Text = "Wins : N/A";
            // 
            // DrawsCounterLabel
            // 
            this.DrawsCounterLabel.AutoSize = true;
            this.DrawsCounterLabel.Location = new System.Drawing.Point(8, 60);
            this.DrawsCounterLabel.Name = "DrawsCounterLabel";
            this.DrawsCounterLabel.Size = new System.Drawing.Size(66, 13);
            this.DrawsCounterLabel.TabIndex = 7;
            this.DrawsCounterLabel.Text = "Draws : N/A";
            // 
            // LossesCounterLabel
            // 
            this.LossesCounterLabel.AutoSize = true;
            this.LossesCounterLabel.Location = new System.Drawing.Point(8, 73);
            this.LossesCounterLabel.Name = "LossesCounterLabel";
            this.LossesCounterLabel.Size = new System.Drawing.Size(69, 13);
            this.LossesCounterLabel.TabIndex = 8;
            this.LossesCounterLabel.Text = "Losses : N/A";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 511);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(871, 297);
            this.Name = "MainWindowForm";
            this.Text = "Win Rate Projector";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button WinButton;
        private System.Windows.Forms.Button LossButton;
        private System.Windows.Forms.Label WinLossRatioLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Label StatTrackTitleLabel;
        private System.Windows.Forms.Label LossesCounterLabel;
        private System.Windows.Forms.Label DrawsCounterLabel;
        private System.Windows.Forms.Label WinsCounterLabel;
    }
}

