namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class frmPrivilegios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrivilegios));
            this.txtLlave = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescrip = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btGuardar = new Telerik.WinControls.UI.RadButton();
            this.btCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtLlave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(446, 184);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(301, 20);
            this.txtLlave.TabIndex = 0;
            this.txtLlave.TabStop = false;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(446, 257);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            // 
            // 
            // 
            this.txtDescrip.RootElement.StretchVertically = true;
            this.txtDescrip.Size = new System.Drawing.Size(468, 210);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(446, 156);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(138, 22);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Nombre Privilegio";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(446, 229);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(98, 22);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Descripcion ";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel3.Location = new System.Drawing.Point(533, 65);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(214, 32);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Nuevos Privilegios";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(608, 535);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(130, 24);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.ThemeName = "TelerikMetroBlue";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(762, 535);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(130, 24);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancelar";
            this.btCancel.ThemeName = "TelerikMetroBlue";
            // 
            // frmPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 814);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtLlave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrivilegios";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilegios";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtLlave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtLlave;
        private Telerik.WinControls.UI.RadTextBox txtDescrip;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btGuardar;
        private Telerik.WinControls.UI.RadButton btCancel;

    }
}
