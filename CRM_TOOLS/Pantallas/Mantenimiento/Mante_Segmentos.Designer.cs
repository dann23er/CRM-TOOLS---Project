namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Segmentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Segmentos));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.btNew = new Telerik.WinControls.UI.RadButton();
            this.gridSegmento = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSegmento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSegmento.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.Location = new System.Drawing.Point(381, 30);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(95, 42);
            this.btNew.TabIndex = 3;
            this.btNew.Text = "  Nuevo";
            this.btNew.ThemeName = "TelerikMetroBlue";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // gridSegmento
            // 
            this.gridSegmento.BackColor = System.Drawing.Color.White;
            this.gridSegmento.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridSegmento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridSegmento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridSegmento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridSegmento.Location = new System.Drawing.Point(381, 78);
            // 
            // gridSegmento
            // 
            this.gridSegmento.MasterTemplate.AllowColumnChooser = false;
            this.gridSegmento.MasterTemplate.AllowColumnReorder = false;
            this.gridSegmento.MasterTemplate.AllowColumnResize = false;
            this.gridSegmento.MasterTemplate.AllowDragToGroup = false;
            this.gridSegmento.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "idES";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "clCod";
            gridViewTextBoxColumn1.Width = 106;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nomES";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Descripcion";
            gridViewTextBoxColumn2.Name = "clDes";
            gridViewTextBoxColumn2.Width = 139;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "idS";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "ID";
            gridViewComboBoxColumn1.Name = "clId";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 57;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "nomS";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Segmento";
            gridViewTextBoxColumn3.Name = "clSeg";
            gridViewTextBoxColumn3.Width = 182;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Creacion";
            gridViewTextBoxColumn4.Name = "clCreacion";
            gridViewTextBoxColumn4.Width = 132;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Actualizacion";
            gridViewTextBoxColumn5.Name = "clActual";
            gridViewTextBoxColumn5.Width = 116;
            this.gridSegmento.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gridSegmento.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column1";
            this.gridSegmento.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridSegmento.Name = "gridSegmento";
            this.gridSegmento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridSegmento.ShowGroupPanel = false;
            this.gridSegmento.Size = new System.Drawing.Size(755, 706);
            this.gridSegmento.TabIndex = 2;
            this.gridSegmento.ThemeName = "TelerikMetroBlue";
            // 
            // radButton1
            // 
            this.radButton1.Image = ((System.Drawing.Image)(resources.GetObject("radButton1.Image")));
            this.radButton1.Location = new System.Drawing.Point(482, 30);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(95, 42);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "  Salir";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Mante_Segmentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.gridSegmento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Segmentos";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos Segmentos";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSegmento.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSegmento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btNew;
        private Telerik.WinControls.UI.RadGridView gridSegmento;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
