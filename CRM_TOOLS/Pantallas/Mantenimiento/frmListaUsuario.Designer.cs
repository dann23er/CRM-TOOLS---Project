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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaUsuario));
            this.gridUsers = new Telerik.WinControls.UI.RadGridView();
            this.btAgregar = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btEditar = new Telerik.WinControls.UI.RadButton();
            this.btEliminar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rdEliminar = new Telerik.WinControls.UI.RadRadioButton();
            this.rdInactivar = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdInactivar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsers
            // 
            this.gridUsers.AutoScroll = true;
            this.gridUsers.AutoSize = true;
            this.gridUsers.BackColor = System.Drawing.Color.White;
            this.gridUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUsers.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridUsers.Location = new System.Drawing.Point(72, 162);
            // 
            // gridUsers
            // 
            this.gridUsers.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridUsers.MasterTemplate.AllowAddNewRow = false;
            this.gridUsers.MasterTemplate.AllowColumnChooser = false;
            this.gridUsers.MasterTemplate.AllowColumnReorder = false;
            this.gridUsers.MasterTemplate.AllowColumnResize = false;
            this.gridUsers.MasterTemplate.AllowDragToGroup = false;
            this.gridUsers.MasterTemplate.AllowRowResize = false;
            this.gridUsers.MasterTemplate.AutoGenerateColumns = false;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FormatString = "";
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "clCheck";
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "Id";
            gridViewTextBoxColumn22.FormatString = "";
            gridViewTextBoxColumn22.HeaderText = "ID";
            gridViewTextBoxColumn22.Name = "Id";
            gridViewTextBoxColumn22.Width = 99;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "Nombre";
            gridViewTextBoxColumn23.FormatString = "";
            gridViewTextBoxColumn23.HeaderText = "Nombre";
            gridViewTextBoxColumn23.Name = "Nombre";
            gridViewTextBoxColumn23.Width = 328;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "email";
            gridViewTextBoxColumn24.FormatString = "";
            gridViewTextBoxColumn24.HeaderText = "E-MAIL";
            gridViewTextBoxColumn24.Name = "email";
            gridViewTextBoxColumn24.Width = 214;
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.FieldName = "Pais";
            gridViewTextBoxColumn25.FormatString = "";
            gridViewTextBoxColumn25.HeaderText = "Pais";
            gridViewTextBoxColumn25.Name = "Pais";
            gridViewTextBoxColumn25.Width = 75;
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.FieldName = "Rol";
            gridViewTextBoxColumn26.FormatString = "";
            gridViewTextBoxColumn26.HeaderText = "Rol";
            gridViewTextBoxColumn26.Name = "Rol";
            gridViewTextBoxColumn26.Width = 212;
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.FieldName = "Estado";
            gridViewTextBoxColumn27.FormatString = "";
            gridViewTextBoxColumn27.HeaderText = "Estado";
            gridViewTextBoxColumn27.Name = "Estado";
            gridViewTextBoxColumn27.Width = 127;
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.FieldName = "Fecha";
            gridViewTextBoxColumn28.HeaderText = "Fecha Creacion";
            gridViewTextBoxColumn28.Name = "Fecha";
            gridViewTextBoxColumn28.Width = 146;
            this.gridUsers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn4,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28});
            this.gridUsers.MasterTemplate.EnableFiltering = true;
            this.gridUsers.MasterTemplate.EnableGrouping = false;
            sortDescriptor4.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor4.PropertyName = "clID";
            this.gridUsers.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridUsers.RootElement.StretchHorizontally = false;
            this.gridUsers.RootElement.StretchVertically = false;
            this.gridUsers.ShowGroupPanel = false;
            this.gridUsers.Size = new System.Drawing.Size(1266, 56);
            this.gridUsers.TabIndex = 3;
            this.gridUsers.ThemeName = "TelerikMetroBlue";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(226, 102);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(103, 30);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.ThemeName = "TelerikMetroBlue";
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel1.Location = new System.Drawing.Point(226, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(167, 32);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Lista Usuarios";
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(347, 102);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(103, 30);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.ThemeName = "TelerikMetroBlue";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(469, 102);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(125, 30);
            this.btEliminar.TabIndex = 8;
            this.btEliminar.Text = "Eliminar / Inactivar";
            this.btEliminar.ThemeName = "TelerikMetroBlue";
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(72, 138);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(108, 16);
            this.radLabel2.TabIndex = 13;
            this.radLabel2.Text = "Seleccione una Fila ";
            // 
            // rdEliminar
            // 
            this.rdEliminar.Location = new System.Drawing.Point(615, 102);
            this.rdEliminar.Name = "rdEliminar";
            this.rdEliminar.Size = new System.Drawing.Size(110, 30);
            this.rdEliminar.TabIndex = 14;
            this.rdEliminar.Text = "Eliminar Usuario";
            this.rdEliminar.ThemeName = "TelerikMetroBlue";
            this.rdEliminar.Visible = false;
            this.rdEliminar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdEliminar_ToggleStateChanged);
            // 
            // rdInactivar
            // 
            this.rdInactivar.Location = new System.Drawing.Point(731, 102);
            this.rdInactivar.Name = "rdInactivar";
            this.rdInactivar.Size = new System.Drawing.Size(130, 30);
            this.rdInactivar.TabIndex = 15;
            this.rdInactivar.Text = "Deshabilitar Usuario";
            this.rdInactivar.ThemeName = "TelerikMetroBlue";
            this.rdInactivar.Visible = false;
            this.rdInactivar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdInactivar_ToggleStateChanged);
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.rdInactivar);
            this.Controls.Add(this.rdEliminar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.gridUsers);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdInactivar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridUsers;
        private Telerik.WinControls.UI.RadButton btAgregar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btEditar;
        private Telerik.WinControls.UI.RadButton btEliminar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadRadioButton rdEliminar;
        private Telerik.WinControls.UI.RadRadioButton rdInactivar;
    }
}
