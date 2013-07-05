namespace CRM_TOOLS.Pantallas
{
    partial class Mante_KAM
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_KAM));
            this.btNuevo = new Telerik.WinControls.UI.RadButton();
            this.radGridView8 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView8.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btNuevo
            // 
            this.btNuevo.Image = global::CRM_TOOLS.Properties.Resources.Add;
            this.btNuevo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNuevo.Location = new System.Drawing.Point(303, 12);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(46, 50);
            this.btNuevo.TabIndex = 3;
            // 
            // radGridView8
            // 
            this.radGridView8.BackColor = System.Drawing.Color.White;
            this.radGridView8.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView8.Location = new System.Drawing.Point(365, 12);
            // 
            // radGridView8
            // 
            this.radGridView8.MasterTemplate.AllowColumnChooser = false;
            this.radGridView8.MasterTemplate.AllowColumnReorder = false;
            this.radGridView8.MasterTemplate.AllowColumnResize = false;
            this.radGridView8.MasterTemplate.AllowDragToGroup = false;
            this.radGridView8.MasterTemplate.AllowRowResize = false;
            this.radGridView8.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo KAM";
            gridViewTextBoxColumn1.Name = "clCodKam";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 185;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Pais";
            gridViewComboBoxColumn1.Name = "clPais";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 111;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Key Accounts Manager";
            gridViewTextBoxColumn2.Name = "clKey";
            gridViewTextBoxColumn2.Width = 224;
            gridViewComboBoxColumn2.DisplayMember = null;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Territorio GBA";
            gridViewComboBoxColumn2.Name = "clTerritorio ";
            gridViewComboBoxColumn2.ValueMember = null;
            gridViewComboBoxColumn2.Width = 142;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Estado";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "clEstado";
            gridViewCheckBoxColumn1.Width = 62;
            this.radGridView8.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewComboBoxColumn2,
            gridViewCheckBoxColumn1});
            this.radGridView8.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "clCodKam";
            this.radGridView8.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView8.Name = "radGridView8";
            this.radGridView8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView8.ShowGroupPanel = false;
            this.radGridView8.Size = new System.Drawing.Size(750, 772);
            this.radGridView8.TabIndex = 2;
            this.radGridView8.Text = "radGridView8";
            this.radGridView8.ThemeName = "TelerikMetroBlue";
            // 
            // Mante_KAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.radGridView8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_KAM";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento KAM\'s";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView8.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btNuevo;
        private Telerik.WinControls.UI.RadGridView radGridView8;
    }
}
