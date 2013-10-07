namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Conglomerado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Conglomerado));
            this.btActual = new Telerik.WinControls.UI.RadButton();
            this.gridDatos = new Telerik.WinControls.UI.RadGridView();
            this.txtGrupoCliente = new Telerik.WinControls.UI.RadTextBox();
            this.lbGC = new Telerik.WinControls.UI.RadLabel();
            this.lbGAN = new Telerik.WinControls.UI.RadLabel();
            this.cbGAN = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox9 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbSegmento = new Telerik.WinControls.UI.RadDropDownList();
            this.cbPlataformas = new Telerik.WinControls.UI.RadDropDownList();
            this.rdSeg = new Telerik.WinControls.UI.RadRadioButton();
            this.rdPla = new Telerik.WinControls.UI.RadRadioButton();
            this.rdGC = new Telerik.WinControls.UI.RadRadioButton();
            this.rdGAN = new Telerik.WinControls.UI.RadRadioButton();
            this.rdInactivo = new Telerik.WinControls.UI.RadRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox9)).BeginInit();
            this.radGroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegmento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlataformas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdPla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdInactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btActual
            // 
            this.btActual.Image = global::CRM_TOOLS.Properties.Resources.loop;
            this.btActual.Location = new System.Drawing.Point(926, 250);
            this.btActual.Name = "btActual";
            this.btActual.Size = new System.Drawing.Size(105, 41);
            this.btActual.TabIndex = 14;
            this.btActual.Text = "       Actualizar";
            this.btActual.ThemeName = "TelerikMetroBlue";
            this.btActual.Click += new System.EventHandler(this.btActual_Click);
            // 
            // gridDatos
            // 
            this.gridDatos.BackColor = System.Drawing.Color.White;
            this.gridDatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDatos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridDatos.Location = new System.Drawing.Point(340, 297);
            // 
            // gridDatos
            // 
            this.gridDatos.MasterTemplate.AllowColumnChooser = false;
            this.gridDatos.MasterTemplate.AllowColumnReorder = false;
            this.gridDatos.MasterTemplate.AllowColumnResize = false;
            this.gridDatos.MasterTemplate.AllowDragToGroup = false;
            this.gridDatos.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Codigo Cliente Compuesto";
            gridViewTextBoxColumn3.Name = "clCodClieComp";
            gridViewTextBoxColumn3.Width = 295;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Nombre Cliente";
            gridViewTextBoxColumn4.Name = "clNomClie";
            gridViewTextBoxColumn4.Width = 374;
            this.gridDatos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gridDatos.MasterTemplate.EnableGrouping = false;
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDatos.ShowGroupPanel = false;
            this.gridDatos.Size = new System.Drawing.Size(691, 454);
            this.gridDatos.TabIndex = 13;
            this.gridDatos.ThemeName = "TelerikMetroBlue";
            // 
            // txtGrupoCliente
            // 
            this.txtGrupoCliente.Location = new System.Drawing.Point(442, 261);
            this.txtGrupoCliente.Name = "txtGrupoCliente";
            this.txtGrupoCliente.Size = new System.Drawing.Size(333, 20);
            this.txtGrupoCliente.TabIndex = 12;
            this.txtGrupoCliente.TabStop = false;
            this.txtGrupoCliente.Visible = false;
            // 
            // lbGC
            // 
            this.lbGC.Location = new System.Drawing.Point(354, 261);
            this.lbGC.Name = "lbGC";
            this.lbGC.Size = new System.Drawing.Size(76, 16);
            this.lbGC.TabIndex = 11;
            this.lbGC.Text = "Grupo Cliente";
            this.lbGC.Visible = false;
            // 
            // lbGAN
            // 
            this.lbGAN.Location = new System.Drawing.Point(354, 236);
            this.lbGAN.Name = "lbGAN";
            this.lbGAN.Size = new System.Drawing.Size(119, 16);
            this.lbGAN.TabIndex = 10;
            this.lbGAN.Text = "Global Account Name ";
            this.lbGAN.Visible = false;
            // 
            // cbGAN
            // 
            this.cbGAN.DropDownAnimationEnabled = true;
            this.cbGAN.Location = new System.Drawing.Point(489, 236);
            this.cbGAN.Name = "cbGAN";
            this.cbGAN.ShowImageInEditorArea = true;
            this.cbGAN.Size = new System.Drawing.Size(286, 20);
            this.cbGAN.TabIndex = 9;
            this.cbGAN.Visible = false;
            // 
            // radGroupBox9
            // 
            this.radGroupBox9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox9.Controls.Add(this.cbSegmento);
            this.radGroupBox9.Controls.Add(this.cbPlataformas);
            this.radGroupBox9.Controls.Add(this.rdSeg);
            this.radGroupBox9.Controls.Add(this.rdPla);
            this.radGroupBox9.Controls.Add(this.rdGC);
            this.radGroupBox9.Controls.Add(this.rdGAN);
            this.radGroupBox9.Controls.Add(this.rdInactivo);
            this.radGroupBox9.FooterImageIndex = -1;
            this.radGroupBox9.FooterImageKey = "";
            this.radGroupBox9.HeaderImageIndex = -1;
            this.radGroupBox9.HeaderImageKey = "";
            this.radGroupBox9.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox9.HeaderText = "Opciones";
            this.radGroupBox9.Location = new System.Drawing.Point(340, 2);
            this.radGroupBox9.Name = "radGroupBox9";
            this.radGroupBox9.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox9.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox9.Size = new System.Drawing.Size(431, 221);
            this.radGroupBox9.TabIndex = 8;
            this.radGroupBox9.Text = "Opciones";
            // 
            // cbSegmento
            // 
            this.cbSegmento.DropDownAnimationEnabled = true;
            this.cbSegmento.Location = new System.Drawing.Point(123, 188);
            this.cbSegmento.Name = "cbSegmento";
            this.cbSegmento.ShowImageInEditorArea = true;
            this.cbSegmento.Size = new System.Drawing.Size(206, 20);
            this.cbSegmento.TabIndex = 6;
            this.cbSegmento.Visible = false;
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.DropDownAnimationEnabled = true;
            this.cbPlataformas.Location = new System.Drawing.Point(123, 144);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.ShowImageInEditorArea = true;
            this.cbPlataformas.Size = new System.Drawing.Size(206, 20);
            this.cbPlataformas.TabIndex = 5;
            this.cbPlataformas.Visible = false;
            // 
            // rdSeg
            // 
            this.rdSeg.Location = new System.Drawing.Point(24, 190);
            this.rdSeg.Name = "rdSeg";
            this.rdSeg.Size = new System.Drawing.Size(110, 18);
            this.rdSeg.TabIndex = 4;
            this.rdSeg.Text = "Segmento";
            this.rdSeg.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdSeg_ToggleStateChanged);
            // 
            // rdPla
            // 
            this.rdPla.Location = new System.Drawing.Point(24, 146);
            this.rdPla.Name = "rdPla";
            this.rdPla.Size = new System.Drawing.Size(110, 18);
            this.rdPla.TabIndex = 3;
            this.rdPla.Text = "Plataformas";
            this.rdPla.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdPla_ToggleStateChanged);
            // 
            // rdGC
            // 
            this.rdGC.Location = new System.Drawing.Point(24, 105);
            this.rdGC.Name = "rdGC";
            this.rdGC.Size = new System.Drawing.Size(110, 18);
            this.rdGC.TabIndex = 2;
            this.rdGC.Text = "Grupo Cliente";
            this.rdGC.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdGC_ToggleStateChanged);
            // 
            // rdGAN
            // 
            this.rdGAN.Location = new System.Drawing.Point(24, 69);
            this.rdGAN.Name = "rdGAN";
            this.rdGAN.Size = new System.Drawing.Size(146, 18);
            this.rdGAN.TabIndex = 1;
            this.rdGAN.Text = "Global Account Name";
            this.rdGAN.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdGAN_ToggleStateChanged);
            // 
            // rdInactivo
            // 
            this.rdInactivo.Location = new System.Drawing.Point(24, 31);
            this.rdInactivo.Name = "rdInactivo";
            this.rdInactivo.Size = new System.Drawing.Size(110, 18);
            this.rdInactivo.TabIndex = 0;
            this.rdInactivo.Text = "Inactivo";
            this.rdInactivo.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdInactivo_ToggleStateChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 358);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CRM_TOOLS.Properties.Resources.fondo5;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 307);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 152);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 682);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Mante_Conglomerado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btActual);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.txtGrupoCliente);
            this.Controls.Add(this.lbGC);
            this.Controls.Add(this.lbGAN);
            this.Controls.Add(this.cbGAN);
            this.Controls.Add(this.radGroupBox9);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Conglomerado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantemiento Conglomerado";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox9)).EndInit();
            this.radGroupBox9.ResumeLayout(false);
            this.radGroupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegmento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlataformas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdPla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdInactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btActual;
        private Telerik.WinControls.UI.RadGridView gridDatos;
        private Telerik.WinControls.UI.RadTextBox txtGrupoCliente;
        private Telerik.WinControls.UI.RadLabel lbGC;
        private Telerik.WinControls.UI.RadLabel lbGAN;
        private Telerik.WinControls.UI.RadDropDownList cbGAN;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox9;
        private Telerik.WinControls.UI.RadDropDownList cbSegmento;
        private Telerik.WinControls.UI.RadDropDownList cbPlataformas;
        private Telerik.WinControls.UI.RadRadioButton rdSeg;
        private Telerik.WinControls.UI.RadRadioButton rdPla;
        private Telerik.WinControls.UI.RadRadioButton rdGC;
        private Telerik.WinControls.UI.RadRadioButton rdGAN;
        private Telerik.WinControls.UI.RadRadioButton rdInactivo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
