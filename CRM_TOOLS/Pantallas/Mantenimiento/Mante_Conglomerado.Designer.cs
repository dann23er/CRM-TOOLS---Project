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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Conglomerado));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btActualCon = new Telerik.WinControls.UI.RadButton();
            this.radGridView11 = new Telerik.WinControls.UI.RadGridView();
            this.txtGrupoCliente = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel17 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel16 = new Telerik.WinControls.UI.RadLabel();
            this.cbGAN = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox9 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbSegmento = new Telerik.WinControls.UI.RadDropDownList();
            this.cbPlataformas = new Telerik.WinControls.UI.RadDropDownList();
            this.radRadioButton5 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton4 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton3 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btActualCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView11.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox9)).BeginInit();
            this.radGroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegmento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlataformas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(800, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 221);
            this.textBox2.TabIndex = 15;
            // 
            // btActualCon
            // 
            this.btActualCon.Location = new System.Drawing.Point(973, 250);
            this.btActualCon.Name = "btActualCon";
            this.btActualCon.Size = new System.Drawing.Size(58, 26);
            this.btActualCon.TabIndex = 14;
            // 
            // radGridView11
            // 
            this.radGridView11.BackColor = System.Drawing.Color.White;
            this.radGridView11.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView11.Location = new System.Drawing.Point(340, 297);
            // 
            // radGridView11
            // 
            this.radGridView11.MasterTemplate.AllowColumnChooser = false;
            this.radGridView11.MasterTemplate.AllowColumnReorder = false;
            this.radGridView11.MasterTemplate.AllowColumnResize = false;
            this.radGridView11.MasterTemplate.AllowDragToGroup = false;
            this.radGridView11.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo Cliente Compuesto";
            gridViewTextBoxColumn1.Name = "clCodClieComp";
            gridViewTextBoxColumn1.Width = 295;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombre Cliente";
            gridViewTextBoxColumn2.Name = "clNomClie";
            gridViewTextBoxColumn2.Width = 374;
            this.radGridView11.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView11.MasterTemplate.EnableGrouping = false;
            this.radGridView11.Name = "radGridView11";
            this.radGridView11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView11.ShowGroupPanel = false;
            this.radGridView11.Size = new System.Drawing.Size(691, 454);
            this.radGridView11.TabIndex = 13;
            this.radGridView11.Text = "radGridView11";
            this.radGridView11.ThemeName = "TelerikMetroBlue";
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
            // radLabel17
            // 
            this.radLabel17.Location = new System.Drawing.Point(354, 261);
            this.radLabel17.Name = "radLabel17";
            this.radLabel17.Size = new System.Drawing.Size(76, 16);
            this.radLabel17.TabIndex = 11;
            this.radLabel17.Text = "Grupo Cliente";
            this.radLabel17.Visible = false;
            // 
            // radLabel16
            // 
            this.radLabel16.Location = new System.Drawing.Point(354, 236);
            this.radLabel16.Name = "radLabel16";
            this.radLabel16.Size = new System.Drawing.Size(119, 16);
            this.radLabel16.TabIndex = 10;
            this.radLabel16.Text = "Global Account Name ";
            this.radLabel16.Visible = false;
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
            this.radGroupBox9.Controls.Add(this.radRadioButton5);
            this.radGroupBox9.Controls.Add(this.radRadioButton4);
            this.radGroupBox9.Controls.Add(this.radRadioButton3);
            this.radGroupBox9.Controls.Add(this.radRadioButton2);
            this.radGroupBox9.Controls.Add(this.radRadioButton1);
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
            this.cbSegmento.Size = new System.Drawing.Size(152, 20);
            this.cbSegmento.TabIndex = 6;
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.DropDownAnimationEnabled = true;
            this.cbPlataformas.Location = new System.Drawing.Point(123, 144);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.ShowImageInEditorArea = true;
            this.cbPlataformas.Size = new System.Drawing.Size(118, 20);
            this.cbPlataformas.TabIndex = 5;
            // 
            // radRadioButton5
            // 
            this.radRadioButton5.Location = new System.Drawing.Point(24, 190);
            this.radRadioButton5.Name = "radRadioButton5";
            this.radRadioButton5.Size = new System.Drawing.Size(110, 18);
            this.radRadioButton5.TabIndex = 4;
            this.radRadioButton5.Text = "Segmento";
            // 
            // radRadioButton4
            // 
            this.radRadioButton4.Location = new System.Drawing.Point(24, 146);
            this.radRadioButton4.Name = "radRadioButton4";
            this.radRadioButton4.Size = new System.Drawing.Size(110, 18);
            this.radRadioButton4.TabIndex = 3;
            this.radRadioButton4.Text = "Plataformas";
            // 
            // radRadioButton3
            // 
            this.radRadioButton3.Location = new System.Drawing.Point(24, 105);
            this.radRadioButton3.Name = "radRadioButton3";
            this.radRadioButton3.Size = new System.Drawing.Size(110, 18);
            this.radRadioButton3.TabIndex = 2;
            this.radRadioButton3.Text = "Grupo Cliente";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(24, 69);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(146, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.Text = "Global Account Name";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(24, 31);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(110, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.Text = "Inactivo";
            // 
            // Mante_Conglomerado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btActualCon);
            this.Controls.Add(this.radGridView11);
            this.Controls.Add(this.txtGrupoCliente);
            this.Controls.Add(this.radLabel17);
            this.Controls.Add(this.radLabel16);
            this.Controls.Add(this.cbGAN);
            this.Controls.Add(this.radGroupBox9);
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
            ((System.ComponentModel.ISupportInitialize)(this.btActualCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView11.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox9)).EndInit();
            this.radGroupBox9.ResumeLayout(false);
            this.radGroupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSegmento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlataformas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private Telerik.WinControls.UI.RadButton btActualCon;
        private Telerik.WinControls.UI.RadGridView radGridView11;
        private Telerik.WinControls.UI.RadTextBox txtGrupoCliente;
        private Telerik.WinControls.UI.RadLabel radLabel17;
        private Telerik.WinControls.UI.RadLabel radLabel16;
        private Telerik.WinControls.UI.RadDropDownList cbGAN;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox9;
        private Telerik.WinControls.UI.RadDropDownList cbSegmento;
        private Telerik.WinControls.UI.RadDropDownList cbPlataformas;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton5;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton4;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton3;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
    }
}
