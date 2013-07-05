namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Plataformas
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Plataformas));
            this.radGridView4 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView4
            // 
            this.radGridView4.BackColor = System.Drawing.Color.White;
            this.radGridView4.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView4.ForeColor = System.Drawing.Color.Black;
            this.radGridView4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView4.Location = new System.Drawing.Point(473, 12);
            // 
            // radGridView4
            // 
            this.radGridView4.MasterTemplate.AllowColumnChooser = false;
            this.radGridView4.MasterTemplate.AllowColumnReorder = false;
            this.radGridView4.MasterTemplate.AllowColumnResize = false;
            this.radGridView4.MasterTemplate.AllowDragToGroup = false;
            this.radGridView4.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Plataformas";
            gridViewTextBoxColumn1.Name = "clPlataformas";
            gridViewTextBoxColumn1.Width = 195;
            this.radGridView4.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.radGridView4.MasterTemplate.EnableGrouping = false;
            this.radGridView4.Name = "radGridView4";
            this.radGridView4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView4.ShowGroupPanel = false;
            this.radGridView4.Size = new System.Drawing.Size(264, 783);
            this.radGridView4.TabIndex = 1;
            this.radGridView4.Text = "radGridView4";
            this.radGridView4.ThemeName = "TelerikMetroBlue";
            // 
            // Mante_Plataformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 787);
            this.Controls.Add(this.radGridView4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Plataformas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Plataformas";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView4;
    }
}
