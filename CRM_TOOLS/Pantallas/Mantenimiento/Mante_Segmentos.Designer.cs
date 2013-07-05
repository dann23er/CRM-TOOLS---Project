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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Segmentos));
            this.btNew = new Telerik.WinControls.UI.RadButton();
            this.radGridView10 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView10.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Image = global::CRM_TOOLS.Properties.Resources.Add;
            this.btNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNew.Location = new System.Drawing.Point(326, 12);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(42, 42);
            this.btNew.TabIndex = 3;
            // 
            // radGridView10
            // 
            this.radGridView10.BackColor = System.Drawing.Color.White;
            this.radGridView10.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView10.Location = new System.Drawing.Point(381, 12);
            // 
            // radGridView10
            // 
            this.radGridView10.MasterTemplate.AllowColumnChooser = false;
            this.radGridView10.MasterTemplate.AllowColumnReorder = false;
            this.radGridView10.MasterTemplate.AllowColumnResize = false;
            this.radGridView10.MasterTemplate.AllowDragToGroup = false;
            this.radGridView10.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "clCod";
            gridViewTextBoxColumn1.Width = 106;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Descripcion";
            gridViewTextBoxColumn2.Name = "clDes";
            gridViewTextBoxColumn2.Width = 139;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "ID";
            gridViewComboBoxColumn1.Name = "clId";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 57;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
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
            this.radGridView10.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.radGridView10.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column1";
            this.radGridView10.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView10.Name = "radGridView10";
            this.radGridView10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView10.ShowGroupPanel = false;
            this.radGridView10.Size = new System.Drawing.Size(755, 772);
            this.radGridView10.TabIndex = 2;
            this.radGridView10.Text = "radGridView10";
            this.radGridView10.ThemeName = "TelerikMetroBlue";
            // 
            // Mante_Segmentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.radGridView10);
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
            ((System.ComponentModel.ISupportInitialize)(this.radGridView10.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btNew;
        private Telerik.WinControls.UI.RadGridView radGridView10;
    }
}
