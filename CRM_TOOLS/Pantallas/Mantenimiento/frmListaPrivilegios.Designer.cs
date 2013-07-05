namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class frmListaPrivilegios
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
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn2 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPrivilegios));
            this.gridPrivilegio = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btAgregar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivilegio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivilegio.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPrivilegio
            // 
            this.gridPrivilegio.BackColor = System.Drawing.Color.White;
            this.gridPrivilegio.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPrivilegio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridPrivilegio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridPrivilegio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridPrivilegio.Location = new System.Drawing.Point(227, 87);
            // 
            // gridPrivilegio
            // 
            this.gridPrivilegio.MasterTemplate.AllowColumnChooser = false;
            this.gridPrivilegio.MasterTemplate.AllowColumnReorder = false;
            this.gridPrivilegio.MasterTemplate.AllowColumnResize = false;
            this.gridPrivilegio.MasterTemplate.AllowDragToGroup = false;
            this.gridPrivilegio.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Privilegio";
            gridViewTextBoxColumn1.Name = "clPrivilegio";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn1.Width = 306;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Descripcion";
            gridViewTextBoxColumn2.Name = "clDescripcion";
            gridViewTextBoxColumn2.Width = 372;
            gridViewHyperlinkColumn1.EnableExpressionEditor = false;
            gridViewHyperlinkColumn1.FormatString = "";
            gridViewHyperlinkColumn1.HeaderText = "Editar";
            gridViewHyperlinkColumn1.Name = "clEditar";
            gridViewHyperlinkColumn1.Width = 129;
            gridViewHyperlinkColumn2.EnableExpressionEditor = false;
            gridViewHyperlinkColumn2.HeaderText = "Eliminar";
            gridViewHyperlinkColumn2.Name = "clEliminar";
            gridViewHyperlinkColumn2.Width = 110;
            this.gridPrivilegio.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewHyperlinkColumn1,
            gridViewHyperlinkColumn2});
            this.gridPrivilegio.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "clPrivilegio";
            this.gridPrivilegio.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridPrivilegio.Name = "gridPrivilegio";
            this.gridPrivilegio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridPrivilegio.ShowGroupPanel = false;
            this.gridPrivilegio.Size = new System.Drawing.Size(936, 482);
            this.gridPrivilegio.TabIndex = 0;
            this.gridPrivilegio.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel1.Location = new System.Drawing.Point(227, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(183, 32);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Lista Privilegios";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(1181, 87);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(130, 24);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.ThemeName = "TelerikMetroBlue";
            // 
            // frmListaPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 823);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.gridPrivilegio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaPrivilegios";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Privilegios";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivilegio.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivilegio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPrivilegio;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btAgregar;
    }
}
