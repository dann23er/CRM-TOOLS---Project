namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    partial class frmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.btCancel = new Telerik.WinControls.UI.RadButton();
            this.btGuardar = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescrip = new Telerik.WinControls.UI.RadTextBox();
            this.txtLlave = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.btEnviarAsignados = new Telerik.WinControls.UI.RadButton();
            this.btEnviarAsignadosTodos = new Telerik.WinControls.UI.RadButton();
            this.btEnviarDisponibles = new Telerik.WinControls.UI.RadButton();
            this.btEnviarDisponiblesTodos = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.listPrivilegiosDisponibles = new Telerik.WinControls.UI.RadListControl();
            this.listPrivilegiosAsignados = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLlave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarAsignadosTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarDisponiblesTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPrivilegiosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPrivilegiosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(975, 593);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(130, 24);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancelar";
            this.btCancel.ThemeName = "TelerikMetroBlue";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(821, 593);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(130, 24);
            this.btGuardar.TabIndex = 12;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.ThemeName = "TelerikMetroBlue";
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel3.Location = new System.Drawing.Point(395, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(164, 32);
            this.radLabel3.TabIndex = 11;
            this.radLabel3.Text = "Nuevos Roles";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(26, 218);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(98, 22);
            this.radLabel2.TabIndex = 10;
            this.radLabel2.Text = "Descripcion ";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(26, 145);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(113, 22);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "Nombre Roles";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(26, 246);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            // 
            // 
            // 
            this.txtDescrip.RootElement.StretchVertically = true;
            this.txtDescrip.Size = new System.Drawing.Size(468, 230);
            this.txtDescrip.TabIndex = 8;
            this.txtDescrip.TabStop = false;
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(26, 173);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(301, 20);
            this.txtLlave.TabIndex = 7;
            this.txtLlave.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(573, 145);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(173, 22);
            this.radLabel4.TabIndex = 10;
            this.radLabel4.Text = "Privilegios Disponibles";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(897, 145);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(165, 22);
            this.radLabel5.TabIndex = 10;
            this.radLabel5.Text = "Privilegios Asignados";
            // 
            // btEnviarAsignados
            // 
            this.btEnviarAsignados.Location = new System.Drawing.Point(807, 238);
            this.btEnviarAsignados.Name = "btEnviarAsignados";
            this.btEnviarAsignados.Size = new System.Drawing.Size(58, 24);
            this.btEnviarAsignados.TabIndex = 13;
            this.btEnviarAsignados.Text = ">";
            this.btEnviarAsignados.ThemeName = "TelerikMetroBlue";
            this.btEnviarAsignados.Click += new System.EventHandler(this.btEnviarAsignados_Click);
            // 
            // btEnviarAsignadosTodos
            // 
            this.btEnviarAsignadosTodos.Location = new System.Drawing.Point(807, 268);
            this.btEnviarAsignadosTodos.Name = "btEnviarAsignadosTodos";
            this.btEnviarAsignadosTodos.Size = new System.Drawing.Size(58, 24);
            this.btEnviarAsignadosTodos.TabIndex = 14;
            this.btEnviarAsignadosTodos.Text = ">>";
            this.btEnviarAsignadosTodos.ThemeName = "TelerikMetroBlue";
            this.btEnviarAsignadosTodos.Click += new System.EventHandler(this.btEnviarAsignadosTodos_Click);
            // 
            // btEnviarDisponibles
            // 
            this.btEnviarDisponibles.Location = new System.Drawing.Point(807, 328);
            this.btEnviarDisponibles.Name = "btEnviarDisponibles";
            this.btEnviarDisponibles.Size = new System.Drawing.Size(58, 24);
            this.btEnviarDisponibles.TabIndex = 14;
            this.btEnviarDisponibles.Text = "<";
            this.btEnviarDisponibles.ThemeName = "TelerikMetroBlue";
            this.btEnviarDisponibles.Click += new System.EventHandler(this.btEnviarDisponibles_Click);
            // 
            // btEnviarDisponiblesTodos
            // 
            this.btEnviarDisponiblesTodos.Location = new System.Drawing.Point(807, 298);
            this.btEnviarDisponiblesTodos.Name = "btEnviarDisponiblesTodos";
            this.btEnviarDisponiblesTodos.Size = new System.Drawing.Size(58, 24);
            this.btEnviarDisponiblesTodos.TabIndex = 14;
            this.btEnviarDisponiblesTodos.Text = "<<";
            this.btEnviarDisponiblesTodos.ThemeName = "TelerikMetroBlue";
            this.btEnviarDisponiblesTodos.Click += new System.EventHandler(this.btEnviarDisponiblesTodos_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(26, 78);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(24, 22);
            this.radLabel6.TabIndex = 17;
            this.radLabel6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(26, 106);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 20);
            this.txtID.TabIndex = 16;
            this.txtID.TabStop = false;
            // 
            // listPrivilegiosDisponibles
            // 
            this.listPrivilegiosDisponibles.CaseSensitiveSort = true;
            this.listPrivilegiosDisponibles.ItemHeight = 18;
            this.listPrivilegiosDisponibles.Location = new System.Drawing.Point(573, 173);
            this.listPrivilegiosDisponibles.Name = "listPrivilegiosDisponibles";
            this.listPrivilegiosDisponibles.Size = new System.Drawing.Size(205, 303);
            this.listPrivilegiosDisponibles.TabIndex = 18;
            this.listPrivilegiosDisponibles.Text = "radListControl1";
            // 
            // listPrivilegiosAsignados
            // 
            this.listPrivilegiosAsignados.CaseSensitiveSort = true;
            this.listPrivilegiosAsignados.ItemHeight = 18;
            this.listPrivilegiosAsignados.Location = new System.Drawing.Point(897, 173);
            this.listPrivilegiosAsignados.Name = "listPrivilegiosAsignados";
            this.listPrivilegiosAsignados.Size = new System.Drawing.Size(196, 303);
            this.listPrivilegiosAsignados.TabIndex = 19;
            this.listPrivilegiosAsignados.Text = "radListControl1";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 681);
            this.Controls.Add(this.listPrivilegiosAsignados);
            this.Controls.Add(this.listPrivilegiosDisponibles);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btEnviarDisponiblesTodos);
            this.Controls.Add(this.btEnviarDisponibles);
            this.Controls.Add(this.btEnviarAsignadosTodos);
            this.Controls.Add(this.btEnviarAsignados);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtLlave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoles";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLlave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarAsignadosTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnviarDisponiblesTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPrivilegiosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPrivilegiosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btCancel;
        private Telerik.WinControls.UI.RadButton btGuardar;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtDescrip;
        private Telerik.WinControls.UI.RadTextBox txtLlave;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btEnviarAsignados;
        private Telerik.WinControls.UI.RadButton btEnviarAsignadosTodos;
        private Telerik.WinControls.UI.RadButton btEnviarDisponibles;
        private Telerik.WinControls.UI.RadButton btEnviarDisponiblesTodos;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadListControl listPrivilegiosDisponibles;
        private Telerik.WinControls.UI.RadListControl listPrivilegiosAsignados;
    }
}
