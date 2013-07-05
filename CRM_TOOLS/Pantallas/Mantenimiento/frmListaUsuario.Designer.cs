namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class frmListaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaUsuario));
            this.gridRoles = new Telerik.WinControls.UI.RadGridView();
            this.btAgregar = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRoles
            // 
            this.gridRoles.BackColor = System.Drawing.Color.White;
            this.gridRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridRoles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridRoles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridRoles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridRoles.Location = new System.Drawing.Point(231, 105);
            // 
            // gridRoles
            // 
            this.gridRoles.MasterTemplate.AllowColumnChooser = false;
            this.gridRoles.MasterTemplate.AllowColumnReorder = false;
            this.gridRoles.MasterTemplate.AllowColumnResize = false;
            this.gridRoles.MasterTemplate.AllowDragToGroup = false;
            this.gridRoles.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.Name = "clNombre";
            gridViewTextBoxColumn1.Width = 306;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Descripcion";
            gridViewTextBoxColumn2.Name = "clDescripcion";
            gridViewTextBoxColumn2.Width = 372;
            gridViewHyperlinkColumn1.EnableExpressionEditor = false;
            gridViewHyperlinkColumn1.FieldName = "Editar";
            gridViewHyperlinkColumn1.FormatString = "";
            gridViewHyperlinkColumn1.HeaderText = "Editar";
            gridViewHyperlinkColumn1.Name = "clEditar";
            gridViewHyperlinkColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewHyperlinkColumn1.Width = 129;
            gridViewHyperlinkColumn2.EnableExpressionEditor = false;
            gridViewHyperlinkColumn2.FieldName = "Eliminar";
            gridViewHyperlinkColumn2.FormatString = "";
            gridViewHyperlinkColumn2.HeaderText = "Eliminar";
            gridViewHyperlinkColumn2.Name = "clEliminar";
            gridViewHyperlinkColumn2.Width = 110;
            this.gridRoles.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewHyperlinkColumn1,
            gridViewHyperlinkColumn2});
            this.gridRoles.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "clEditar";
            this.gridRoles.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridRoles.ShowGroupPanel = false;
            this.gridRoles.Size = new System.Drawing.Size(936, 482);
            this.gridRoles.TabIndex = 3;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(1191, 105);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(103, 30);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel1.Location = new System.Drawing.Point(231, 44);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(167, 32);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Lista Usuarios";
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.gridRoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaUsuario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Usuario";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridRoles;
        private Telerik.WinControls.UI.RadButton btAgregar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
