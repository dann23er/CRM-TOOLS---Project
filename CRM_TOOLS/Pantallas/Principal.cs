using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;
using CRM_TOOLS.Properties;


namespace CRM_TOOLS.Pantallas
{
    public partial class Principal : Telerik.WinControls.UI.RadRibbonForm
    {
        public Principal()
        {
            InitializeComponent();
           
           
            CargarData();
            FunTreeView();
      
        
        }

        #region Fields
        private DataSet dataSet;
        private GridViewRowInfo saveBugsSelectedRow;
        private GridViewRowInfo saveFeaturesSelectedRow;
        #endregion

        private void CargarData()
        {
           
            DataTable project = new DataTable("Project");
           
            dataSet = new DataSet();
            dataSet.Tables.Add(project);
          
                       
            project.Columns.Add("Id", typeof(int));
            project.Columns.Add("ParentId", typeof(int));
            project.Columns.Add("Name", typeof(string));

            project.Rows.Add(0, DBNull.Value, "Sellout");
            project.Rows.Add(1, 0, "Proceso de Importacion");
            project.Rows.Add(2, 1, "Importacion de Sellout");
            project.Rows.Add(3, 1, "Importacion de Clientes");

            project.Rows.Add(4, 0, "Proceso de Calculos");
            project.Rows.Add(5, 4, "Calculos de ABC");
            project.Rows.Add(6, 4, "Calculos de Oportunidades");
            project.Rows.Add(7, 4, "Calculos de KPI'S");

            project.Rows.Add(8, 0, "Mantenimientos de Datos");
            project.Rows.Add(10, 8, "Clientes");
            project.Rows.Add(11, 8, "Master de Productos KC");
            project.Rows.Add(12, 8, "Productos Equivalentes");
            project.Rows.Add(13, 8, "Agrupoacion de Productos");
            project.Rows.Add(14, 8, "Distribuidores");
            project.Rows.Add(15, 8, "KAM'S");
            project.Rows.Add(16, 8, "Pais");
            project.Rows.Add(17, 8, "Segmentos");
            project.Rows.Add(18, 8, "Nuevos Segmentos");
            project.Rows.Add(19, 8, "Conglomerados");
            project.Rows.Add(20, 8, "Cuentas Globales");

            project.Rows.Add(21, DBNull.Value, "Sellin");
            project.Rows.Add(22, 21, "Proceso de Importacion");
            project.Rows.Add(23, 21, "Proceso de Calculos");
            project.Rows.Add(24, 21, "Mantenimientos de Datos");

            project.Rows.Add(25, DBNull.Value, "MKTOOLS");
            project.Rows.Add(26, 25, "Proceso de Importacion");
            project.Rows.Add(27, 25, "Mantenimientos de Datos");

           

            dataSet.WriteXml(@"source.xml");
            dataSet.WriteXmlSchema(@"XMLSchema.xsd");

        }

       

        private void FunTreeView()
        {
            proyectsTV.DataSource = dataSet.Tables["Project"];
            proyectsTV.DisplayMember = "Name";
            proyectsTV.ValueMember = "Id";
            proyectsTV.ParentMember = "ParentId";
            proyectsTV.ChildMember = "Id";
            proyectsTV.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(projectsTreeView_SelectedNodeChanged);
            proyectsTV.SelectedNode = proyectsTV.Nodes[0];
        }

        private void projectsTreeView_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (bugsGrid.FilterDescriptors.Count > 1)
            {
                for (int i = 0; i < bugsGrid.FilterDescriptors.Count; i++)
                {
                    if (bugsGrid.FilterDescriptors[i].PropertyName == "ProjectId")
                    {
                        bugsGrid.FilterDescriptors.RemoveAt(i);
                    }
                    if (gridSellout.FilterDescriptors[i].PropertyName == "ProjectId")
                    {
                        gridSellout.FilterDescriptors.RemoveAt(i);
                    }
                }
            }

            if ((int)e.Node.Value == 0)
            {
                return;
            }
            else
            {
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = "ProjectId";
                filter.Operator = FilterOperator.IsEqualTo;
                filter.Value = e.Node.Value;
                this.bugsGrid.FilterDescriptors.Add(filter);
                this.gridSellout.FilterDescriptors.Add(filter);
            }
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {

        }

     
       
       
      

       

       

       
                      
    }
}
