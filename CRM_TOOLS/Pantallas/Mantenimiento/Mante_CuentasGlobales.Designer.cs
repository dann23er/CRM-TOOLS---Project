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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_CuentasGlobales));
            this.gridGAN = new Telerik.WinControls.UI.RadGridView();
            this.btSalir = new Telerik.WinControls.UI.RadButton();
            this.btNuevo = new Telerik.WinControls.UI.RadButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGAN.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGAN
            // 
            this.gridGAN.BackColor = System.Drawing.Color.White;
            this.gridGAN.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridGAN.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGAN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridGAN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridGAN.Location = new System.Drawing.Point(387, 86);
            // 
            // gridGAN
            // 
            this.gridGAN.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridGAN.MasterTemplate.AllowAddNewRow = false;
            this.gridGAN.MasterTemplate.AllowColumnChooser = false;
            this.gridGAN.MasterTemplate.AllowColumnReorder = false;
            this.gridGAN.MasterTemplate.AllowColumnResize = false;
            this.gridGAN.MasterTemplate.AllowDragToGroup = false;
            this.gridGAN.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "clCod";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 131;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nombre";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "clNom";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.Width = 250;
            this.gridGAN.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridGAN.MasterTemplate.EnableFiltering = true;
            this.gridGAN.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "clNom";
            this.gridGAN.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridGAN.Name = "gridGAN";
            this.gridGAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridGAN.ShowGroupPanel = false;
            this.gridGAN.Size = new System.Drawing.Size(426, 698);
            this.gridGAN.TabIndex = 1;
            this.gridGAN.ThemeName = "TelerikMetroBlue";
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(484, 36);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(91, 44);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.ThemeName = "TelerikMetroBlue";
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btNuevo.Image")));
            this.btNuevo.Location = new System.Drawing.Point(387, 36);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(91, 44);
            this.btNuevo.TabIndex = 4;
            this.btNuevo.Text = "   Nuevo";
            this.btNuevo.ThemeName = "TelerikMetroBlue";
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 358);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 152);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(629, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(798, 682);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // Mante_CuentasGlobales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.gridGAN);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_CuentasGlobales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento Cuentas Globales";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridGAN.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridGAN;
        private Telerik.WinControls.UI.RadButton btSalir;
        private Telerik.WinControls.UI.RadButton btNuevo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
