namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Distribuidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Distribuidor));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.btKam = new Telerik.WinControls.UI.RadButton();
            this.gridDistribuidor = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btKam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuidor.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btKam
            // 
            this.btKam.Image = ((System.Drawing.Image)(resources.GetObject("btKam.Image")));
            this.btKam.Location = new System.Drawing.Point(21, 12);
            this.btKam.Name = "btKam";
            this.btKam.Size = new System.Drawing.Size(85, 40);
            this.btKam.TabIndex = 4;
            this.btKam.Text = "   KAM";
            this.btKam.ThemeName = "TelerikMetroBlue";
            this.btKam.Click += new System.EventHandler(this.btKam_Click);
            // 
            // gridDistribuidor
            // 
            this.gridDistribuidor.BackColor = System.Drawing.Color.White;
            this.gridDistribuidor.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDistribuidor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridDistribuidor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridDistribuidor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridDistribuidor.Location = new System.Drawing.Point(21, 58);
            // 
            // gridDistribuidor
            // 
            this.gridDistribuidor.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridDistribuidor.MasterTemplate.AllowAddNewRow = false;
            this.gridDistribuidor.MasterTemplate.AllowColumnChooser = false;
            this.gridDistribuidor.MasterTemplate.AllowColumnReorder = false;
            this.gridDistribuidor.MasterTemplate.AllowColumnResize = false;
            this.gridDistribuidor.MasterTemplate.AllowDragToGroup = false;
            this.gridDistribuidor.MasterTemplate.AllowRowResize = false;
            this.gridDistribuidor.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "pais";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Pais";
            gridViewTextBoxColumn1.Name = "clPais";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 54;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nomDist";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre Distribuidor";
            gridViewTextBoxColumn2.Name = "clNomDis";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 322;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "nomCorto";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nombre Corto";
            gridViewTextBoxColumn3.Name = "clNomCor";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 170;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "nomKam";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "KAM";
            gridViewTextBoxColumn4.Name = "clKam";
            gridViewTextBoxColumn4.Width = 208;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "imp";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Import";
            gridViewComboBoxColumn1.Name = "clImport";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 78;
            gridViewComboBoxColumn2.DisplayMember = null;
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FieldName = "use";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "UseOnKPLs";
            gridViewComboBoxColumn2.Name = "clUse";
            gridViewComboBoxColumn2.ValueMember = null;
            gridViewComboBoxColumn2.Width = 116;
            gridViewComboBoxColumn3.DisplayMember = null;
            gridViewComboBoxColumn3.EnableExpressionEditor = false;
            gridViewComboBoxColumn3.FieldName = "id";
            gridViewComboBoxColumn3.FormatString = "";
            gridViewComboBoxColumn3.HeaderText = "Codigo Distribuidor";
            gridViewComboBoxColumn3.Name = "clCodDis";
            gridViewComboBoxColumn3.ReadOnly = true;
            gridViewComboBoxColumn3.ValueMember = null;
            gridViewComboBoxColumn3.Width = 209;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "gba";
            gridViewTextBoxColumn5.HeaderText = "GBA";
            gridViewTextBoxColumn5.Name = "clGBA";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 192;
            this.gridDistribuidor.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2,
            gridViewComboBoxColumn3,
            gridViewTextBoxColumn5});
            this.gridDistribuidor.MasterTemplate.EnableFiltering = true;
            this.gridDistribuidor.MasterTemplate.EnableGrouping = false;
            this.gridDistribuidor.Name = "gridDistribuidor";
            this.gridDistribuidor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDistribuidor.ShowGroupPanel = false;
            this.gridDistribuidor.Size = new System.Drawing.Size(1375, 732);
            this.gridDistribuidor.TabIndex = 3;
            this.gridDistribuidor.ThemeName = "TelerikMetroBlue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1254, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 313);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Mante_Distribuidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.btKam);
            this.Controls.Add(this.gridDistribuidor);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Distribuidor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Distribuidor";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btKam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuidor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btKam;
        private Telerik.WinControls.UI.RadGridView gridDistribuidor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
