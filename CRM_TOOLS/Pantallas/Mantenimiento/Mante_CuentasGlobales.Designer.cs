namespace CRM_TOOLS.Pantallas
{
    partial class Mante_CuentasGlobales
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_CuentasGlobales));
            this.radGridView12 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView12.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView12
            // 
            this.radGridView12.BackColor = System.Drawing.Color.White;
            this.radGridView12.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView12.Location = new System.Drawing.Point(509, 3);
            // 
            // radGridView12
            // 
            this.radGridView12.MasterTemplate.AllowColumnChooser = false;
            this.radGridView12.MasterTemplate.AllowColumnReorder = false;
            this.radGridView12.MasterTemplate.AllowColumnResize = false;
            this.radGridView12.MasterTemplate.AllowDragToGroup = false;
            this.radGridView12.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "clCod";
            gridViewTextBoxColumn1.Width = 131;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "clNom";
            gridViewTextBoxColumn2.Width = 205;
            this.radGridView12.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView12.MasterTemplate.EnableGrouping = false;
            this.radGridView12.Name = "radGridView12";
            this.radGridView12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView12.ShowGroupPanel = false;
            this.radGridView12.Size = new System.Drawing.Size(378, 764);
            this.radGridView12.TabIndex = 1;
            this.radGridView12.Text = "radGridView12";
            this.radGridView12.ThemeName = "TelerikMetroBlue";
            // 
            // Mante_CuentasGlobales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.radGridView12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_CuentasGlobales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Cuentas Globales";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radGridView12.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView12;
    }
}
