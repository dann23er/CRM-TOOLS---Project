namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Productos
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn5 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn6 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Productos));
            this.btAbrir = new Telerik.WinControls.UI.RadButton();
            this.txtDir = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.gridProducto = new Telerik.WinControls.UI.RadGridView();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btAbrir
            // 
            this.btAbrir.Image = global::CRM_TOOLS.Properties.Resources.folder;
            this.btAbrir.Location = new System.Drawing.Point(521, 57);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(92, 39);
            this.btAbrir.TabIndex = 8;
            this.btAbrir.Text = "  Abrir";
            this.btAbrir.ThemeName = "TelerikMetroBlue";
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(12, 67);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(494, 20);
            this.txtDir.TabIndex = 7;
            this.txtDir.TabStop = false;
            // 
            // radLabel13
            // 
            this.radLabel13.Location = new System.Drawing.Point(12, 45);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(84, 16);
            this.radLabel13.TabIndex = 6;
            this.radLabel13.Text = "Direccion Excel";
            // 
            // gridProducto
            // 
            this.gridProducto.BackColor = System.Drawing.Color.White;
            this.gridProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridProducto.Location = new System.Drawing.Point(12, 141);
            // 
            // gridProducto
            // 
            this.gridProducto.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridProducto.MasterTemplate.AllowAddNewRow = false;
            this.gridProducto.MasterTemplate.AllowColumnChooser = false;
            this.gridProducto.MasterTemplate.AllowColumnReorder = false;
            this.gridProducto.MasterTemplate.AllowColumnResize = false;
            this.gridProducto.MasterTemplate.AllowDragToGroup = false;
            this.gridProducto.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo SAP";
            gridViewTextBoxColumn1.Name = "clCodSAP";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 104;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nombre";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre Producto";
            gridViewTextBoxColumn2.Name = "clNombre";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 374;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "lao";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "LAO Group";
            gridViewTextBoxColumn3.Name = "clLAO";
            gridViewTextBoxColumn3.Width = 92;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "str";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Strategic Group";
            gridViewComboBoxColumn1.Name = "clStrategic";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 126;
            gridViewComboBoxColumn2.DisplayMember = null;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FieldName = "n1";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Nivel 1";
            gridViewComboBoxColumn2.Name = "clN1";
            gridViewComboBoxColumn2.ValueMember = null;
            gridViewComboBoxColumn2.Width = 112;
            gridViewComboBoxColumn3.DisplayMember = null;
            gridViewComboBoxColumn3.EnableExpressionEditor = false;
            gridViewComboBoxColumn3.FieldName = "n2";
            gridViewComboBoxColumn3.FormatString = "";
            gridViewComboBoxColumn3.HeaderText = "Nivel 2";
            gridViewComboBoxColumn3.Name = "clN2";
            gridViewComboBoxColumn3.ValueMember = null;
            gridViewComboBoxColumn3.Width = 109;
            gridViewComboBoxColumn4.DisplayMember = null;
            gridViewComboBoxColumn4.EnableExpressionEditor = false;
            gridViewComboBoxColumn4.FieldName = "n3";
            gridViewComboBoxColumn4.FormatString = "";
            gridViewComboBoxColumn4.HeaderText = "Nivel 3";
            gridViewComboBoxColumn4.Name = "clN3";
            gridViewComboBoxColumn4.ValueMember = null;
            gridViewComboBoxColumn4.Width = 110;
            gridViewComboBoxColumn5.DisplayMember = null;
            gridViewComboBoxColumn5.EnableExpressionEditor = false;
            gridViewComboBoxColumn5.FieldName = "n4";
            gridViewComboBoxColumn5.FormatString = "";
            gridViewComboBoxColumn5.HeaderText = "Nivel 4";
            gridViewComboBoxColumn5.Name = "clN4";
            gridViewComboBoxColumn5.ValueMember = null;
            gridViewComboBoxColumn5.Width = 106;
            gridViewComboBoxColumn6.DisplayMember = null;
            gridViewComboBoxColumn6.EnableExpressionEditor = false;
            gridViewComboBoxColumn6.FieldName = "n5";
            gridViewComboBoxColumn6.FormatString = "";
            gridViewComboBoxColumn6.HeaderText = "Nivel 5";
            gridViewComboBoxColumn6.Name = "clN5";
            gridViewComboBoxColumn6.ValueMember = null;
            gridViewComboBoxColumn6.Width = 100;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Creacion ";
            gridViewTextBoxColumn4.Name = "clCreacion ";
            gridViewTextBoxColumn4.Width = 97;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Actualizacion";
            gridViewTextBoxColumn5.Name = "clActual";
            gridViewTextBoxColumn5.Width = 107;
            this.gridProducto.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2,
            gridViewComboBoxColumn3,
            gridViewComboBoxColumn4,
            gridViewComboBoxColumn5,
            gridViewComboBoxColumn6,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gridProducto.MasterTemplate.EnableFiltering = true;
            this.gridProducto.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column1";
            this.gridProducto.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridProducto.Name = "gridProducto";
            this.gridProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridProducto.ShowGroupPanel = false;
            this.gridProducto.Size = new System.Drawing.Size(1342, 643);
            this.gridProducto.TabIndex = 5;
            this.gridProducto.ThemeName = "TelerikMetroBlue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 682);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Mante_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.radLabel13);
            this.Controls.Add(this.gridProducto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Productos";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos Productos";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btAbrir;
        private Telerik.WinControls.UI.RadTextBox txtDir;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Telerik.WinControls.UI.RadGridView gridProducto;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}
