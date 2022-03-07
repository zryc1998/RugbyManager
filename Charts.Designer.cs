
namespace Charts
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.ageTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ageGroup = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.heightAndWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ageTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageGroup)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightAndWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // ageTab
            // 
            this.ageTab.Controls.Add(this.tabPage1);
            this.ageTab.Controls.Add(this.tabPage2);
            this.ageTab.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTab.Location = new System.Drawing.Point(3, 3);
            this.ageTab.Name = "ageTab";
            this.ageTab.SelectedIndex = 0;
            this.ageTab.Size = new System.Drawing.Size(877, 517);
            this.ageTab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ageGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Age Histogram      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ageGroup
            // 
            chartArea1.AxisX.Title = "Age Group";
            chartArea1.AxisX2.Title = "Age Group";
            chartArea1.AxisY.Title = "Number Of Players";
            chartArea1.Name = "ChartArea1";
            this.ageGroup.ChartAreas.Add(chartArea1);
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.ageGroup.Legends.Add(legend1);
            this.ageGroup.Location = new System.Drawing.Point(3, 3);
            this.ageGroup.Name = "ageGroup";
            this.ageGroup.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Number Of Players";
            this.ageGroup.Series.Add(series1);
            this.ageGroup.Size = new System.Drawing.Size(863, 484);
            this.ageGroup.TabIndex = 2;
            this.ageGroup.Text = "chart2";
            title1.Name = "Age Group Histogram";
            this.ageGroup.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.heightAndWeight);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Height & Weight Distribution Chart      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // heightAndWeight
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90)));
            chartArea2.AxisX.LabelStyle.Angle = 90;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.Title = "Players";
            chartArea2.AxisX2.Title = "Age Group";
            chartArea2.AxisY.Title = "Height (cm) / Weight (kg)";
            chartArea2.AxisY2.Title = "Weight (kg)";
            chartArea2.Name = "ChartArea1";
            this.heightAndWeight.ChartAreas.Add(chartArea2);
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.heightAndWeight.Legends.Add(legend2);
            this.heightAndWeight.Location = new System.Drawing.Point(3, 3);
            this.heightAndWeight.Name = "heightAndWeight";
            this.heightAndWeight.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Height";
            series2.YValuesPerPoint = 2;
            series3.BorderWidth = 10;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Weight";
            series3.YValuesPerPoint = 2;
            this.heightAndWeight.Series.Add(series2);
            this.heightAndWeight.Series.Add(series3);
            this.heightAndWeight.Size = new System.Drawing.Size(863, 484);
            this.heightAndWeight.TabIndex = 3;
            this.heightAndWeight.Text = "chart2";
            title2.Name = "Age Group Histogram";
            this.heightAndWeight.Titles.Add(title2);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.ageTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Charts";
            this.Text = "Charts Of Players\' Age Groups, Height And Weight";
            this.ageTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ageGroup)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heightAndWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ageTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ageGroup;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart heightAndWeight;
    }
}