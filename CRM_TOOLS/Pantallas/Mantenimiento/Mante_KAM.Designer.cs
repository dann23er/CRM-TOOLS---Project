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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_KAM));
            this.gridKAM = new Telerik.WinControls.UI.RadGridView();
            this.btSalir = new Telerik.WinControls.UI.RadButton();
            this.btNew = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridKAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKAM.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKAM
            // 
            this.gridKAM.BackColor = System.Drawing.Color.White;
            this.gridKAM.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridKAM.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridKAM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridKAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridKAM.Location = new System.Drawing.Point(360, 79);
            // 
            // gridKAM
            // 
            this.gridKAM.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridKAM.MasterTemplate.AllowAddNewRow = false;
            this.gridKAM.MasterTemplate.AllowColumnChooser = false;
            this.gridKAM.MasterTemplate.AllowColumnReorder = false;
            this.gridKAM.MasterTemplate.AllowColumnResize = false;
            this.gridKAM.MasterTemplate.AllowDragToGroup = false;
            this.gridKAM.MasterTemplate.AllowRowResize = false;
            this.gridKAM.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "id";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Codigo KAM";
            gridViewTextBoxColumn3.Name = "clCodKam";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn3.Width = 185;
            gridViewComboBoxColumn3.DisplayMember = null;
            gridViewComboBoxColumn3.EnableExpressionEditor = false;
            gridViewComboBoxColumn3.FieldName = "pais";
            gridViewComboBoxColumn3.FormatString = "";
            gridViewComboBoxColumn3.HeaderText = "Pais";
            gridViewComboBoxColumn3.Name = "clPais";
            gridViewComboBoxColumn3.ValueMember = null;
            gridViewComboBoxColumn3.Width = 111;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "nombre";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Key Accounts Manager";
            gridViewTextBoxColumn4.Name = "clKey";
            gridViewTextBoxColumn4.Width = 224;
            gridViewComboBoxColumn4.DisplayMember = null;
            gridViewComboBoxColumn4.EnableExpressionEditor = false;
            gridViewComboBoxColumn4.FieldName = "gba";
            gridViewComboBoxColumn4.FormatString = "";
            gridViewComboBoxColumn4.HeaderText = "Territorio GBA";
            gridViewComboBoxColumn4.Name = "clTerritorio ";
            gridViewComboBoxColumn4.ValueMember = null;
            gridViewComboBoxColumn4.Width = 142;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "esta";
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "Estado";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "clEstado";
            gridViewCheckBoxColumn2.Width = 62;
            this.gridKAM.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn4,
            gridViewCheckBoxColumn2});
            this.gridKAM.MasterTemplate.EnableFiltering = true;
            this.gridKAM.MasterTemplate.EnableGrouping = false;
            sortDescriptor2.PropertyName = "clCodKam";
            this.gridKAM.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.gridKAM.Name = "gridKAM";
            this.gridKAM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridKAM.ShowGroupPanel = false;
            this.gridKAM.Size = new System.Drawing.Size(750, 687);
            this.gridKAM.TabIndex = 2;
            this.gridKAM.ThemeName = "TelerikMetroBlue";
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(461, 31);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 42);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "  Salir";
            this.btSalir.ThemeName = "TelerikMetroBlue";
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btNew
            // 
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.Location = new System.Drawing.Point(360, 31);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(95, 42);
            this.btNew.TabIndex = 5;
            this.btNew.Text = "  Nuevo";
            this.btNew.ThemeName = "TelerikMetroBlue";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 682);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 358);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox3.Location = new System.Drawing.Point(-7, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 152);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Mante_KAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.gridKAM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridKAM.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridKAM;
        private Telerik.WinControls.UI.RadButton btSalir;
        private Telerik.WinControls.UI.RadButton btNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
