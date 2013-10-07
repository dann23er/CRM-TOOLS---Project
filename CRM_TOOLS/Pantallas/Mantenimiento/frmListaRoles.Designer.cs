namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class frmListaRoles
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaRoles));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.gridRoles = new Telerik.WinControls.UI.RadGridView();
            this.btEliminar = new Telerik.WinControls.UI.RadButton();
            this.btEditar = new Telerik.WinControls.UI.RadButton();
            this.btAgregar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel1.Location = new System.Drawing.Point(237, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(133, 32);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Lista Roles";
            // 
            // gridRoles
            // 
            this.gridRoles.BackColor = System.Drawing.Color.White;
            this.gridRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridRoles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridRoles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridRoles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridRoles.Location = new System.Drawing.Point(237, 123);
            // 
            // gridRoles
            // 
            this.gridRoles.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridRoles.MasterTemplate.AllowAddNewRow = false;
            this.gridRoles.MasterTemplate.AllowColumnChooser = false;
            this.gridRoles.MasterTemplate.AllowColumnReorder = false;
            this.gridRoles.MasterTemplate.AllowColumnResize = false;
            this.gridRoles.MasterTemplate.AllowDragToGroup = false;
            this.gridRoles.MasterTemplate.AllowRowResize = false;
            this.gridRoles.MasterTemplate.AutoGenerateColumns = false;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "clcheck";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 84;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Llave";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "Llave";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 313;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Descripcion";
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 388;
            this.gridRoles.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.gridRoles.MasterTemplate.EnableFiltering = true;
            this.gridRoles.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "clId";
            sortDescriptor2.PropertyName = "clNombre";
            this.gridRoles.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2});
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridRoles.ShowGroupPanel = false;
            this.gridRoles.Size = new System.Drawing.Size(854, 626);
            this.gridRoles.TabIndex = 2;
            this.gridRoles.ThemeName = "TelerikMetroBlue";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(480, 63);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(103, 30);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.ThemeName = "TelerikMetroBlue";
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(358, 63);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(103, 30);
            this.btEditar.TabIndex = 10;
            this.btEditar.Text = "Editar";
            this.btEditar.ThemeName = "TelerikMetroBlue";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(237, 63);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(103, 30);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.ThemeName = "TelerikMetroBlue";
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(237, 99);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(104, 18);
            this.radLabel2.TabIndex = 12;
            this.radLabel2.Text = "Seleccione una Fila ";
            // 
            // frmListaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.gridRoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaRoles";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Roles";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView gridRoles;
        private Telerik.WinControls.UI.RadButton btEliminar;
        private Telerik.WinControls.UI.RadButton btEditar;
        private Telerik.WinControls.UI.RadButton btAgregar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
