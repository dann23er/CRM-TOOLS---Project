namespace CRM_TOOLS.Pantallas
{
    partial class Mante_Paises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mante_Paises));
            this.radGridView9 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView9.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView9
            // 
            this.radGridView9.BackColor = System.Drawing.Color.White;
            this.radGridView9.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView9.Location = new System.Drawing.Point(202, 12);
            // 
            // radGridView9
            // 
            this.radGridView9.MasterTemplate.AllowColumnChooser = false;
            this.radGridView9.MasterTemplate.AllowColumnReorder = false;
            this.radGridView9.MasterTemplate.AllowColumnResize = false;
            this.radGridView9.MasterTemplate.AllowDragToGroup = false;
            this.radGridView9.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Codigo";
            gridViewTextBoxColumn1.Name = "clCod";
            gridViewTextBoxColumn1.Width = 180;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Descripcion Pais";
            gridViewTextBoxColumn2.Name = "clDes";
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.Width = 218;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Modena Pais";
            gridViewTextBoxColumn3.Name = "clMoneda";
            gridViewTextBoxColumn3.Width = 123;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Region";
            gridViewTextBoxColumn4.Name = "clRegion";
            gridViewTextBoxColumn4.Width = 148;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "SubRegion";
            gridViewTextBoxColumn5.Name = "clSubReg";
            gridViewTextBoxColumn5.Width = 152;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Creacion";
            gridViewTextBoxColumn6.Name = "clCreacion";
            gridViewTextBoxColumn6.Width = 115;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Actualizacion";
            gridViewTextBoxColumn7.Name = "clActual";
            gridViewTextBoxColumn7.Width = 97;
            this.radGridView9.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView9.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "clDes";
            this.radGridView9.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView9.Name = "radGridView9";
            this.radGridView9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView9.ShowGroupPanel = false;
            this.radGridView9.Size = new System.Drawing.Size(1058, 772);
            this.radGridView9.TabIndex = 1;
            this.radGridView9.Text = "radGridView9";
            this.radGridView9.ThemeName = "TelerikMetroBlue";
            // 
            // Mante_Paises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 796);
            this.Controls.Add(this.radGridView9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mante_Paises";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Paises";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radGridView9.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView9;
    }
}
