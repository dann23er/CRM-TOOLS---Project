namespace CRM_TOOLS.Pantallas
{
    partial class Dashboard
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
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries3 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries4 = new Telerik.Charting.ChartSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.radPageView4 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage28 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            this.radPageViewPage29 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radChart2 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView4)).BeginInit();
            this.radPageView4.SuspendLayout();
            this.radPageViewPage28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.radPageViewPage29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView4
            // 
            this.radPageView4.Controls.Add(this.radPageViewPage28);
            this.radPageView4.Controls.Add(this.radPageViewPage29);
            this.radPageView4.Location = new System.Drawing.Point(12, 3);
            this.radPageView4.Name = "radPageView4";
            this.radPageView4.SelectedPage = this.radPageViewPage28;
            this.radPageView4.Size = new System.Drawing.Size(1407, 790);
            this.radPageView4.TabIndex = 1;
            this.radPageView4.Text = "radPageView4";
            // 
            // radPageViewPage28
            // 
            this.radPageViewPage28.Controls.Add(this.radChart1);
            this.radPageViewPage28.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage28.Name = "radPageViewPage28";
            this.radPageViewPage28.Size = new System.Drawing.Size(1386, 742);
            this.radPageViewPage28.Text = "Indicadores";
            // 
            // radChart1
            // 
            this.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Pie;
            this.radChart1.Location = new System.Drawing.Point(120, 3);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.XAxis.MinValue = 1D;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            chartSeries1.Name = "Series 1";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.Pie;
            chartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(254)))), ((int)(((byte)(122)))));
            chartSeries2.Name = "Series 2";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.Pie;
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart1.Size = new System.Drawing.Size(805, 537);
            this.radChart1.TabIndex = 1;
            // 
            // radPageViewPage29
            // 
            this.radPageViewPage29.Controls.Add(this.radChart2);
            this.radPageViewPage29.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage29.Name = "radPageViewPage29";
            this.radPageViewPage29.Size = new System.Drawing.Size(1386, 742);
            this.radPageViewPage29.Text = "Datos Requeridos";
            // 
            // radChart2
            // 
            this.radChart2.ChartTitle.TextBlock.Text = "Datos Requeridos";
            this.radChart2.DefaultType = Telerik.Charting.ChartSeriesType.Line;
            this.radChart2.Location = new System.Drawing.Point(112, 3);
            this.radChart2.Name = "radChart2";
            this.radChart2.PlotArea.XAxis.MinValue = 1D;
            this.radChart2.PlotArea.YAxis.MaxValue = 100D;
            this.radChart2.PlotArea.YAxis.Step = 10D;
            chartSeries3.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            chartSeries3.Name = "Series 1";
            chartSeries3.Type = Telerik.Charting.ChartSeriesType.Line;
            chartSeries4.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(254)))), ((int)(((byte)(122)))));
            chartSeries4.Name = "Series 2";
            chartSeries4.Type = Telerik.Charting.ChartSeriesType.Line;
            this.radChart2.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries3,
            chartSeries4});
            this.radChart2.Size = new System.Drawing.Size(804, 524);
            this.radChart2.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 805);
            this.Controls.Add(this.radPageView4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radPageView4)).EndInit();
            this.radPageView4.ResumeLayout(false);
            this.radPageViewPage28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            this.radPageViewPage29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage28;
        private Telerik.WinControls.UI.RadChart radChart1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage29;
        private Telerik.WinControls.UI.RadChart radChart2;
    }
}
