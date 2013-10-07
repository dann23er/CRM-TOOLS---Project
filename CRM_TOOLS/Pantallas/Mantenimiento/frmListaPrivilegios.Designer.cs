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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPrivilegios));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btEliminar = new Telerik.WinControls.UI.RadButton();
            this.btEditar = new Telerik.WinControls.UI.RadButton();
            this.btAgregar = new Telerik.WinControls.UI.RadButton();
            this.gv1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(470, 65);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(103, 30);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.ThemeName = "TelerikMetroBlue";
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(348, 65);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(103, 30);
            this.btEditar.TabIndex = 10;
            this.btEditar.Text = "Editar";
            this.btEditar.ThemeName = "TelerikMetroBlue";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(227, 65);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(103, 30);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.ThemeName = "TelerikMetroBlue";
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // gv1
            // 
            this.gv1.BackColor = System.Drawing.Color.White;
            this.gv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gv1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gv1.Location = new System.Drawing.Point(227, 125);
            // 
            // gv1
            // 
            this.gv1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gv1.MasterTemplate.AllowAddNewRow = false;
            this.gv1.MasterTemplate.AllowColumnChooser = false;
            this.gv1.MasterTemplate.AllowColumnReorder = false;
            this.gv1.MasterTemplate.AllowColumnResize = false;
            this.gv1.MasterTemplate.AllowDragToGroup = false;
            this.gv1.MasterTemplate.AllowRowResize = false;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "clCheck";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Id";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.Name = "Id";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 80;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Llave";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Privilegio";
            gridViewTextBoxColumn5.Name = "Llave";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 187;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Description";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Descripcion";
            gridViewTextBoxColumn6.Name = "Description";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 463;
            this.gv1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gv1.MasterTemplate.EnableFiltering = true;
            this.gv1.MasterTemplate.EnableGrouping = false;
            sortDescriptor2.PropertyName = "Id";
            this.gv1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.gv1.Name = "gv1";
            this.gv1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gv1.Size = new System.Drawing.Size(840, 667);
            this.gv1.TabIndex = 14;
            this.gv1.Text = "radGridView1";
            this.gv1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(227, 101);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(108, 16);
            this.radLabel2.TabIndex = 15;
            this.radLabel2.Text = "Seleccione una Fila ";
            // 
            // frmListaPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1420, 823);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.gv1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.radLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPrivilegio;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btEliminar;
        private Telerik.WinControls.UI.RadButton btEditar;
        private Telerik.WinControls.UI.RadButton btAgregar;
        private Telerik.WinControls.UI.RadGridView gv1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
