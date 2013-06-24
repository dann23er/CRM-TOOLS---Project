namespace CRM_TOOLS.Pantallas
{
    partial class RadRibbonForm1
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.toolTabStrip6 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.radTreeView2 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.AutoSize = true;
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.AccessibleDescription = "Exit";
            this.radRibbonBar1.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.radRibbonBar1.ExitButton.ButtonElement.Class = "RadMenuButtonElement";
            this.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.AccessibleDescription = "Options";
            this.radRibbonBar1.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.radRibbonBar1.OptionsButton.ButtonElement.Class = "RadMenuButtonElement";
            this.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.OptionsButton.Text = "Options";
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(1270, 144);
            this.radRibbonBar1.StartButtonImage = null;
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "RadRibbonForm1";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 580);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1270, 24);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDock1);
            this.panel1.Controls.Add(this.toolWindow1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 436);
            this.panel1.TabIndex = 2;
            // 
            // radDock1
            // 
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radDock1.Size = new System.Drawing.Size(1270, 436);
            this.radDock1.SplitterWidth = 4;
            this.radDock1.TabIndex = 4;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            this.radDock1.ThemeName = "TelerikMetroBlue";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Location = new System.Drawing.Point(5, 5);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(1260, 426);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(949, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-72, 0);
            this.documentContainer1.SplitterWidth = 4;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            this.documentContainer1.ThemeName = "TelerikMetroBlue";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Caption = null;
            this.toolWindow1.Controls.Add(this.radTreeView1);
            this.toolWindow1.Location = new System.Drawing.Point(1, -44);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow1.Size = new System.Drawing.Size(233, 554);
            this.toolWindow1.Text = "Configuracion";
            // 
            // radTreeView1
            // 
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(233, 554);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // toolTabStrip6
            // 
            this.toolTabStrip6.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip6.Name = "toolTabStrip6";
            // 
            // 
            // 
            this.toolTabStrip6.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip6.Size = new System.Drawing.Size(307, 426);
            this.toolTabStrip6.SizeInfo.AbsoluteSize = new System.Drawing.Size(307, 200);
            this.toolTabStrip6.SizeInfo.SplitterCorrection = new System.Drawing.Size(107, 0);
            this.toolTabStrip6.TabIndex = 1;
            this.toolTabStrip6.TabStop = false;
            this.toolTabStrip6.ThemeName = "TelerikMetroBlue";
            // 
            // radTreeView2
            // 
            this.radTreeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView2.Location = new System.Drawing.Point(0, 0);
            this.radTreeView2.Name = "radTreeView2";
            this.radTreeView2.Size = new System.Drawing.Size(233, 394);
            this.radTreeView2.SpacingBetweenNodes = -1;
            this.radTreeView2.TabIndex = 0;
            this.radTreeView2.Text = "radTreeView2";
            // 
            // RadRibbonForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.MainMenuStrip = null;
            this.Name = "RadRibbonForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadRibbonForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip6;
        private Telerik.WinControls.UI.RadTreeView radTreeView2;
    }
}
