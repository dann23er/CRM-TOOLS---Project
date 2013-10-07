namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class frmNuevoAgrupar
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoAgrupar));
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.gridAgrupar = new Telerik.WinControls.UI.RadGridView();
            this.btSalir = new Telerik.WinControls.UI.RadButton();
            this.btGuardar = new Telerik.WinControls.UI.RadButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgrupar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgrupar.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAgrupar
            // 
            this.gridAgrupar.BackColor = System.Drawing.Color.White;
            this.gridAgrupar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridAgrupar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridAgrupar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridAgrupar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridAgrupar.Location = new System.Drawing.Point(12, 88);
            // 
            // gridAgrupar
            // 
            this.gridAgrupar.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridAgrupar.MasterTemplate.AllowColumnChooser = false;
            this.gridAgrupar.MasterTemplate.AllowColumnReorder = false;
            this.gridAgrupar.MasterTemplate.AllowColumnResize = false;
            this.gridAgrupar.MasterTemplate.AllowDragToGroup = false;
            this.gridAgrupar.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "lao";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "LAO Group";
            gridViewTextBoxColumn1.Name = "clLAOG";
            gridViewTextBoxColumn1.Width = 169;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "str";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Estrategic Group";
            gridViewTextBoxColumn2.Name = "clEstrategic";
            gridViewTextBoxColumn2.Width = 149;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "n1";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nivel 1";
            gridViewTextBoxColumn3.Name = "clN1";
            gridViewTextBoxColumn3.Width = 175;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "n2";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Nivel 2";
            gridViewTextBoxColumn4.Name = "clN2";
            gridViewTextBoxColumn4.Width = 148;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "n3";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Nivel 3";
            gridViewTextBoxColumn5.Name = "clN3";
            gridViewTextBoxColumn5.Width = 148;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "n4";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Nivel 4";
            gridViewTextBoxColumn6.Name = "clN4";
            gridViewTextBoxColumn6.Width = 132;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "n5";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Nivel 5";
            gridViewTextBoxColumn7.Name = "clN5";
            gridViewTextBoxColumn7.Width = 115;
            this.gridAgrupar.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.gridAgrupar.MasterTemplate.EnableFiltering = true;
            this.gridAgrupar.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column1";
            this.gridAgrupar.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridAgrupar.Name = "gridAgrupar";
            this.gridAgrupar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridAgrupar.ShowGroupPanel = false;
            this.gridAgrupar.Size = new System.Drawing.Size(1054, 551);
            this.gridAgrupar.TabIndex = 4;
            this.gridAgrupar.ThemeName = "TelerikMetroBlue";
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(113, 40);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 42);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "  Salir";
            this.btSalir.ThemeName = "TelerikMetroBlue";
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Image = global::CRM_TOOLS.Properties.Resources.save;
            this.btGuardar.Location = new System.Drawing.Point(12, 40);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(95, 42);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "     Guardar";
            this.btGuardar.ThemeName = "TelerikMetroBlue";
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 358);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 152);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // frmNuevoAgrupar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 671);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.gridAgrupar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoAgrupar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Nuevo Agrupar Producto";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.gridAgrupar.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgrupar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGridView gridAgrupar;
        private Telerik.WinControls.UI.RadButton btSalir;
        private Telerik.WinControls.UI.RadButton btGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
