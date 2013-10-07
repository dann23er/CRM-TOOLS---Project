namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class TipoActivacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoActivacion));
            this.cbGAN = new Telerik.WinControls.UI.RadDropDownList();
            this.cbPlataformas = new Telerik.WinControls.UI.RadDropDownList();
            this.txtGP = new Telerik.WinControls.UI.RadTextBox();
            this.rdGAN = new Telerik.WinControls.UI.RadRadioButton();
            this.rdPla = new Telerik.WinControls.UI.RadRadioButton();
            this.rdGC = new Telerik.WinControls.UI.RadRadioButton();
            this.btSalir = new Telerik.WinControls.UI.RadButton();
            this.btAceptar = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlataformas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdPla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGAN
            // 
            this.cbGAN.DropDownAnimationEnabled = true;
            this.cbGAN.Enabled = false;
            this.cbGAN.Location = new System.Drawing.Point(26, 53);
            this.cbGAN.Name = "cbGAN";
            this.cbGAN.ShowImageInEditorArea = true;
            this.cbGAN.Size = new System.Drawing.Size(384, 20);
            this.cbGAN.TabIndex = 5;
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.DropDownAnimationEnabled = true;
            this.cbPlataformas.Enabled = false;
            this.cbPlataformas.Location = new System.Drawing.Point(26, 109);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.ShowImageInEditorArea = true;
            this.cbPlataformas.Size = new System.Drawing.Size(384, 20);
            this.cbPlataformas.TabIndex = 6;
            // 
            // txtGP
            // 
            this.txtGP.Enabled = false;
            this.txtGP.Location = new System.Drawing.Point(26, 171);
            this.txtGP.Name = "txtGP";
            this.txtGP.Size = new System.Drawing.Size(384, 20);
            this.txtGP.TabIndex = 7;
            this.txtGP.TabStop = false;
            // 
            // rdGAN
            // 
            this.rdGAN.Location = new System.Drawing.Point(26, 29);
            this.rdGAN.Name = "rdGAN";
            this.rdGAN.Size = new System.Drawing.Size(110, 18);
            this.rdGAN.TabIndex = 8;
            this.rdGAN.Text = "Global Account Name";
            this.rdGAN.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdGAN_ToggleStateChanged);
            // 
            // rdPla
            // 
            this.rdPla.Location = new System.Drawing.Point(29, 85);
            this.rdPla.Name = "rdPla";
            this.rdPla.Size = new System.Drawing.Size(110, 18);
            this.rdPla.TabIndex = 9;
            this.rdPla.Text = "Plataformas";
            this.rdPla.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdPla_ToggleStateChanged);
            // 
            // rdGC
            // 
            this.rdGC.Location = new System.Drawing.Point(26, 147);
            this.rdGC.Name = "rdGC";
            this.rdGC.Size = new System.Drawing.Size(110, 18);
            this.rdGC.TabIndex = 9;
            this.rdGC.Text = "Grupo Cliente";
            this.rdGC.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdGC_ToggleStateChanged);
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(305, 237);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(106, 45);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Cerrar";
            this.btSalir.ThemeName = "TelerikMetroBlue";
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btAceptar.Image")));
            this.btAceptar.Location = new System.Drawing.Point(199, 237);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 45);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.ThemeName = "TelerikMetroBlue";
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_TOOLS.Properties.Resources.fondo4;
            this.pictureBox1.Location = new System.Drawing.Point(181, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 383);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TipoActivacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 306);
            this.Controls.Add(this.rdGC);
            this.Controls.Add(this.rdPla);
            this.Controls.Add(this.rdGAN);
            this.Controls.Add(this.txtGP);
            this.Controls.Add(this.cbPlataformas);
            this.Controls.Add(this.cbGAN);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoActivacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Tipo de Activacion";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.cbGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlataformas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdPla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btAceptar;
        private Telerik.WinControls.UI.RadButton btSalir;
        private Telerik.WinControls.UI.RadDropDownList cbGAN;
        private Telerik.WinControls.UI.RadDropDownList cbPlataformas;
        private Telerik.WinControls.UI.RadTextBox txtGP;
        private Telerik.WinControls.UI.RadRadioButton rdGAN;
        private Telerik.WinControls.UI.RadRadioButton rdPla;
        private Telerik.WinControls.UI.RadRadioButton rdGC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
