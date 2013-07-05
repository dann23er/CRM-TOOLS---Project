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
            this.radGridView6 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox8 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbDist = new Telerik.WinControls.UI.RadDropDownList();
            this.cbPais = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel14 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel15 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView6.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox8)).BeginInit();
            this.radGroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView6
            // 
            this.radGridView6.BackColor = System.Drawing.Color.White;
            this.radGridView6.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView6.Location = new System.Drawing.Point(12, 232);
            // 
            // radGridView6
            // 
            this.radGridView6.MasterTemplate.AllowColumnChooser = false;
            this.radGridView6.MasterTemplate.AllowColumnReorder = false;
            this.radGridView6.MasterTemplate.AllowColumnResize = false;
            this.radGridView6.MasterTemplate.AllowDragToGroup = false;
            this.radGridView6.MasterTemplate.AllowRowResize = false;
            this.radGridView6.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo Producto Distribuidor";
            gridViewTextBoxColumn1.Name = "clCodProdDist";
            gridViewTextBoxColumn1.Width = 222;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre Producto Distribuidor";
            gridViewTextBoxColumn2.Name = "clNomProDist";
            gridViewTextBoxColumn2.Width = 209;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Codigo Producto SAP";
            gridViewComboBoxColumn1.Name = "clCodProSap";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 180;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nombre Prodcuto SAP";
            gridViewTextBoxColumn3.Name = "clNomSap";
            gridViewTextBoxColumn3.Width = 192;
            gridViewComboBoxColumn2.DisplayMember = null;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Tipo Medida";
            gridViewComboBoxColumn2.Name = "clTipoMed";
            gridViewComboBoxColumn2.ValueMember = null;
            gridViewComboBoxColumn2.Width = 114;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Cantidad";
            gridViewTextBoxColumn4.Name = "clCanti";
            gridViewTextBoxColumn4.Width = 112;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "VC";
            gridViewTextBoxColumn5.Name = "clVC";
            gridViewTextBoxColumn5.Width = 59;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Resultado";
            gridViewTextBoxColumn6.Name = "clResultado";
            gridViewTextBoxColumn6.Width = 88;
            this.radGridView6.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.radGridView6.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column3";
            this.radGridView6.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView6.Name = "radGridView6";
            this.radGridView6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView6.ShowGroupPanel = false;
            this.radGridView6.Size = new System.Drawing.Size(1192, 532);
            this.radGridView6.TabIndex = 5;
            this.radGridView6.Text = "radGridView6";
            this.radGridView6.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox8
            // 
            this.radGroupBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
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
            this.radGroupBox8.Location = new System.Drawing.Point(12, 23);
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
            this.cbDist.Location = new System.Drawing.Point(36, 106);
            this.cbDist.Name = "cbDist";
            this.cbDist.ShowImageInEditorArea = true;
            this.cbDist.Size = new System.Drawing.Size(389, 20);
            this.cbDist.TabIndex = 3;
            // 
            // cbPais
            // 
            this.cbPais.DropDownAnimationEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(36, 45);
            this.cbPais.Name = "cbPais";
            this.cbPais.ShowImageInEditorArea = true;
            this.cbPais.Size = new System.Drawing.Size(141, 20);
            this.cbPais.TabIndex = 2;
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
            // Mante_ProductoEquivalente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 787);
            this.Controls.Add(this.radGridView6);
            this.Controls.Add(this.radGroupBox8);
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
            ((System.ComponentModel.ISupportInitialize)(this.radGridView6.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox8)).EndInit();
            this.radGroupBox8.ResumeLayout(false);
            this.radGroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView6;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox8;
        private Telerik.WinControls.UI.RadDropDownList cbDist;
        private Telerik.WinControls.UI.RadDropDownList cbPais;
        private Telerik.WinControls.UI.RadLabel radLabel14;
        private Telerik.WinControls.UI.RadLabel radLabel15;
    }
}
