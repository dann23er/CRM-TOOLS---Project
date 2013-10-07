namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class UpdateSegmento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSegmento));
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.cbSegSC = new Telerik.WinControls.UI.RadDropDownList();
            this.cbSegKC = new Telerik.WinControls.UI.RadDropDownList();
            this.btGenerar = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.radLabel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(92, 19);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Segmento SC";
            // 
            // radLabel2
            // 
            this.radLabel2.Controls.Add(this.radDropDownList2);
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 84);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(92, 19);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Segmento KC";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.DropDownAnimationEnabled = true;
            this.radDropDownList2.Location = new System.Drawing.Point(3, 24);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.ShowImageInEditorArea = true;
            this.radDropDownList2.Size = new System.Drawing.Size(188, 20);
            this.radDropDownList2.TabIndex = 6;
            this.radDropDownList2.Text = "radDropDownList2";
            // 
            // cbSegSC
            // 
            this.cbSegSC.DropDownAnimationEnabled = true;
            this.cbSegSC.Location = new System.Drawing.Point(12, 40);
            this.cbSegSC.Name = "cbSegSC";
            this.cbSegSC.ShowImageInEditorArea = true;
            this.cbSegSC.Size = new System.Drawing.Size(191, 20);
            this.cbSegSC.TabIndex = 5;
            // 
            // cbSegKC
            // 
            this.cbSegKC.DropDownAnimationEnabled = true;
            this.cbSegKC.Location = new System.Drawing.Point(12, 109);
            this.cbSegKC.Name = "cbSegKC";
            this.cbSegKC.ShowImageInEditorArea = true;
            this.cbSegKC.Size = new System.Drawing.Size(191, 20);
            this.cbSegKC.TabIndex = 6;
            // 
            // btGenerar
            // 
            this.btGenerar.Image = global::CRM_TOOLS.Properties.Resources.loop4;
            this.btGenerar.Location = new System.Drawing.Point(143, 153);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(99, 38);
            this.btGenerar.TabIndex = 0;
            this.btGenerar.Text = "    Generar";
            this.btGenerar.ThemeName = "TelerikMetroBlue";
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_TOOLS.Properties.Resources.fondo4;
            this.pictureBox1.Location = new System.Drawing.Point(81, -143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 351);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateSegmento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 203);
            this.Controls.Add(this.cbSegKC);
            this.Controls.Add(this.cbSegSC);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSegmento";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Actualizar Segmento";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.radLabel2.ResumeLayout(false);
            this.radLabel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButton btGenerar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadDropDownList cbSegSC;
        private Telerik.WinControls.UI.RadDropDownList cbSegKC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
