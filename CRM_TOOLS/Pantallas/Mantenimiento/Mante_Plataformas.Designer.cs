namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Plataformas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Plataformas));
            this.gridPlataforma = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlataforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlataforma.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPlataforma
            // 
            this.gridPlataforma.BackColor = System.Drawing.Color.White;
            this.gridPlataforma.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPlataforma.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridPlataforma.ForeColor = System.Drawing.Color.Black;
            this.gridPlataforma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridPlataforma.Location = new System.Drawing.Point(473, 12);
            // 
            // gridPlataforma
            // 
            this.gridPlataforma.MasterTemplate.AllowAddNewRow = false;
            this.gridPlataforma.MasterTemplate.AllowColumnChooser = false;
            this.gridPlataforma.MasterTemplate.AllowColumnReorder = false;
            this.gridPlataforma.MasterTemplate.AllowColumnResize = false;
            this.gridPlataforma.MasterTemplate.AllowDragToGroup = false;
            this.gridPlataforma.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "nombre";
            gridViewTextBoxColumn1.HeaderText = "Plataformas";
            gridViewTextBoxColumn1.Name = "clPlataformas";
            gridViewTextBoxColumn1.Width = 195;
            this.gridPlataforma.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridPlataforma.MasterTemplate.EnableGrouping = false;
            this.gridPlataforma.Name = "gridPlataforma";
            this.gridPlataforma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridPlataforma.ShowGroupPanel = false;
            this.gridPlataforma.Size = new System.Drawing.Size(222, 783);
            this.gridPlataforma.TabIndex = 1;
            this.gridPlataforma.ThemeName = "TelerikMetroBlue";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 358);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 152);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_TOOLS.Properties.Resources.fondo3;
            this.pictureBox1.Location = new System.Drawing.Point(624, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 682);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Mante_Plataformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 787);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gridPlataforma);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Plataformas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Plataformas";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridPlataforma.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlataforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPlataforma;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
