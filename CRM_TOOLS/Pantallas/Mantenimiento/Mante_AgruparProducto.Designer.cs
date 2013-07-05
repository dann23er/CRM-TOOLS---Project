namespace CRM_TOOLS.Pantallas
{
    partial class Mante_AgruparProducto
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_AgruparProducto));
            this.btNuevoAP = new Telerik.WinControls.UI.RadButton();
            this.btActualAP = new Telerik.WinControls.UI.RadButton();
            this.radGridView13 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btNuevoAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActualAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView13.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btNuevoAP
            // 
            this.btNuevoAP.Location = new System.Drawing.Point(96, 21);
            this.btNuevoAP.Name = "btNuevoAP";
            this.btNuevoAP.Size = new System.Drawing.Size(86, 24);
            this.btNuevoAP.TabIndex = 5;
            this.btNuevoAP.Text = "Nuevo";
            // 
            // btActualAP
            // 
            this.btActualAP.Location = new System.Drawing.Point(12, 21);
            this.btActualAP.Name = "btActualAP";
            this.btActualAP.Size = new System.Drawing.Size(78, 24);
            this.btActualAP.TabIndex = 4;
            this.btActualAP.Text = "Refresh";
            // 
            // radGridView13
            // 
            this.radGridView13.BackColor = System.Drawing.Color.White;
            this.radGridView13.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView13.Location = new System.Drawing.Point(170, 54);
            // 
            // radGridView13
            // 
            this.radGridView13.MasterTemplate.AllowColumnChooser = false;
            this.radGridView13.MasterTemplate.AllowColumnReorder = false;
            this.radGridView13.MasterTemplate.AllowColumnResize = false;
            this.radGridView13.MasterTemplate.AllowDragToGroup = false;
            this.radGridView13.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "LAO Group";
            gridViewTextBoxColumn1.Name = "clLAOG";
            gridViewTextBoxColumn1.Width = 169;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Estrategic Group";
            gridViewTextBoxColumn2.Name = "clEstrategic";
            gridViewTextBoxColumn2.Width = 149;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nivel 1";
            gridViewTextBoxColumn3.Name = "clN1";
            gridViewTextBoxColumn3.Width = 175;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Nivel 2";
            gridViewTextBoxColumn4.Name = "clN2";
            gridViewTextBoxColumn4.Width = 148;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Nivel 3";
            gridViewTextBoxColumn5.Name = "clN3";
            gridViewTextBoxColumn5.Width = 148;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Nivel 4";
            gridViewTextBoxColumn6.Name = "clN4";
            gridViewTextBoxColumn6.Width = 132;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Nivel 5";
            gridViewTextBoxColumn7.Name = "clN5";
            gridViewTextBoxColumn7.Width = 115;
            this.radGridView13.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView13.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column1";
            this.radGridView13.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView13.Name = "radGridView13";
            this.radGridView13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView13.ShowGroupPanel = false;
            this.radGridView13.Size = new System.Drawing.Size(1057, 730);
            this.radGridView13.TabIndex = 3;
            this.radGridView13.Text = "radGridView13";
            this.radGridView13.ThemeName = "TelerikMetroBlue";
            // 
            // Mante_AgruparProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.btNuevoAP);
            this.Controls.Add(this.btActualAP);
            this.Controls.Add(this.radGridView13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_AgruparProducto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Agrupacion Producto";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btNuevoAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActualAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView13.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btNuevoAP;
        private Telerik.WinControls.UI.RadButton btActualAP;
        private Telerik.WinControls.UI.RadGridView radGridView13;
    }
}
