namespace CRM_TOOLS.Pantallas
{
    partial class Mante_ProductoEquivalente
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_ProductoEquivalente));
            this.gridProductosE = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox8 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbDist = new Telerik.WinControls.UI.RadDropDownList();
            this.cbPais = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel14 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel15 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosE.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox8)).BeginInit();
            this.radGroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductosE
            // 
            this.gridProductosE.BackColor = System.Drawing.Color.White;
            this.gridProductosE.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductosE.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridProductosE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridProductosE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridProductosE.Location = new System.Drawing.Point(12, 232);
            // 
            // gridProductosE
            // 
            this.gridProductosE.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridProductosE.MasterTemplate.AllowAddNewRow = false;
            this.gridProductosE.MasterTemplate.AllowColumnChooser = false;
            this.gridProductosE.MasterTemplate.AllowColumnReorder = false;
            this.gridProductosE.MasterTemplate.AllowColumnResize = false;
            this.gridProductosE.MasterTemplate.AllowDragToGroup = false;
            this.gridProductosE.MasterTemplate.AllowRowResize = false;
            this.gridProductosE.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "idP";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo Producto Distribuidor";
            gridViewTextBoxColumn1.Name = "clCodProdDist";
            gridViewTextBoxColumn1.Width = 197;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nom";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre Producto Distribuidor";
            gridViewTextBoxColumn2.Name = "clNomProDist";
            gridViewTextBoxColumn2.Width = 203;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "id";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Codigo Producto SAP";
            gridViewComboBoxColumn1.Name = "clCodProSap";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 147;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "nomsap";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nombre Prodcuto SAP";
            gridViewTextBoxColumn3.Name = "clNomSap";
            gridViewTextBoxColumn3.Width = 153;
            gridViewComboBoxColumn2.DisplayMember = null;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FieldName = "tipo";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Tipo Medida";
            gridViewComboBoxColumn2.Name = "clTipoMed";
            gridViewComboBoxColumn2.ValueMember = null;
            gridViewComboBoxColumn2.Width = 89;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "cant";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Cantidad";
            gridViewTextBoxColumn4.Name = "clCanti";
            gridViewTextBoxColumn4.Width = 83;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "vc";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "VC";
            gridViewTextBoxColumn5.Name = "clVC";
            gridViewTextBoxColumn5.Width = 83;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "valor";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Resultado";
            gridViewTextBoxColumn6.Name = "clResultado";
            gridViewTextBoxColumn6.Width = 83;
            this.gridProductosE.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gridProductosE.MasterTemplate.EnableFiltering = true;
            this.gridProductosE.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column3";
            this.gridProductosE.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridProductosE.Name = "gridProductosE";
            this.gridProductosE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridProductosE.ShowGroupPanel = false;
            this.gridProductosE.Size = new System.Drawing.Size(1192, 532);
            this.gridProductosE.TabIndex = 5;
            this.gridProductosE.ThemeName = "TelerikMetroBlue";
            this.gridProductosE.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellEditorInitialized);
            this.gridProductosE.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridProductosE_CellClick);
            // 
            // radGroupBox8
            // 
            this.radGroupBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox8.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox8.Controls.Add(this.cbDist);
            this.radGroupBox8.Controls.Add(this.cbPais);
            this.radGroupBox8.Controls.Add(this.radLabel14);
            this.radGroupBox8.Controls.Add(this.radLabel15);
            this.radGroupBox8.FooterImageIndex = -1;
            this.radGroupBox8.FooterImageKey = "";
            this.radGroupBox8.HeaderImageIndex = -1;
            this.radGroupBox8.HeaderImageKey = "";
            this.radGroupBox8.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox8.HeaderText = "";
            this.radGroupBox8.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox8.Name = "radGroupBox8";
            this.radGroupBox8.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox8.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox8.Size = new System.Drawing.Size(566, 167);
            this.radGroupBox8.TabIndex = 4;
            this.radGroupBox8.ThemeName = "TelerikMetroBlue";
            // 
            // cbDist
            // 
            this.cbDist.DropDownAnimationEnabled = true;
            this.cbDist.Enabled = false;
            this.cbDist.Location = new System.Drawing.Point(36, 106);
            this.cbDist.Name = "cbDist";
            this.cbDist.ShowImageInEditorArea = true;
            this.cbDist.Size = new System.Drawing.Size(389, 20);
            this.cbDist.TabIndex = 3;
            this.cbDist.SelectedValueChanged += new System.EventHandler(this.cbDist_SelectedValueChanged);
            // 
            // cbPais
            // 
            this.cbPais.DropDownAnimationEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(36, 45);
            this.cbPais.Name = "cbPais";
            this.cbPais.ShowImageInEditorArea = true;
            this.cbPais.Size = new System.Drawing.Size(141, 20);
            this.cbPais.TabIndex = 2;
            this.cbPais.SelectedValueChanged += new System.EventHandler(this.cbPais_SelectedValueChanged);
            // 
            // radLabel14
            // 
            this.radLabel14.Location = new System.Drawing.Point(36, 21);
            this.radLabel14.Name = "radLabel14";
            this.radLabel14.Size = new System.Drawing.Size(28, 16);
            this.radLabel14.TabIndex = 0;
            this.radLabel14.Text = "Pais";
            // 
            // radLabel15
            // 
            this.radLabel15.Location = new System.Drawing.Point(36, 82);
            this.radLabel15.Name = "radLabel15";
            this.radLabel15.Size = new System.Drawing.Size(64, 16);
            this.radLabel15.TabIndex = 1;
            this.radLabel15.Text = "Distribuidor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 682);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox2.Location = new System.Drawing.Point(-12, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 358);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox3.Location = new System.Drawing.Point(-12, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 152);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Mante_ProductoEquivalente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 787);
            this.Controls.Add(this.radGroupBox8);
            this.Controls.Add(this.gridProductosE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_ProductoEquivalente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Producto Equivalente";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosE.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox8)).EndInit();
            this.radGroupBox8.ResumeLayout(false);
            this.radGroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridProductosE;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox8;
        private Telerik.WinControls.UI.RadDropDownList cbDist;
        private Telerik.WinControls.UI.RadDropDownList cbPais;
        private Telerik.WinControls.UI.RadLabel radLabel14;
        private Telerik.WinControls.UI.RadLabel radLabel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
