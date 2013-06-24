namespace CRM_TOOLS.Pantallas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUser = new Telerik.WinControls.UI.RadTextBox();
            this.txtPass = new Telerik.WinControls.UI.RadTextBox();
            this.btEntrar = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Turquoise;
            this.txtUser.Location = new System.Drawing.Point(50, 69);
            this.txtUser.Name = "txtUser";
            // 
            // 
            // 
            this.txtUser.RootElement.Class = "";
            this.txtUser.Size = new System.Drawing.Size(227, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(50, 141);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(227, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.TabStop = false;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(192, 210);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(70, 24);
            this.btEntrar.TabIndex = 2;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.ThemeName = "TelerikMetroBlue";
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radLabel1.Location = new System.Drawing.Point(50, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 23);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Usuario";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radLabel2.Location = new System.Drawing.Point(50, 112);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(94, 23);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 276);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtUser;
        private Telerik.WinControls.UI.RadTextBox txtPass;
        private Telerik.WinControls.UI.RadButton btEntrar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}
