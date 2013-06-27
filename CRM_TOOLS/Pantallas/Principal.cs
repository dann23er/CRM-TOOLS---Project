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
            project.Rows.Add(7, 4, "Calculos de KPIs");

            project.Rows.Add(8, 0, "Mantenimientos de Datos");
            project.Rows.Add(10, 8, "Clientes");
            project.Rows.Add(11, 8, "Agrupacion de Clientes");
            project.Rows.Add(12, 8, "Master de Productos KC");
            project.Rows.Add(13, 8, "Productos Equivalentes");
            project.Rows.Add(14, 8, "Agrupoacion de Productos");
            project.Rows.Add(15, 8, "Distribuidores");
            project.Rows.Add(16, 8, "KAMs");
            project.Rows.Add(17, 8, "Pais");
            project.Rows.Add(18, 8, "Segmentos");
            project.Rows.Add(19, 8, "Nuevos Segmentos");
            project.Rows.Add(20, 8, "Conglomerados");
            project.Rows.Add(21, 8, "Cuentas Globales");

            project.Rows.Add(22, DBNull.Value, "Sellin");
            project.Rows.Add(23, 22, "Proceso de Importacion");
            project.Rows.Add(24, 22, "Proceso de Calculos");
            project.Rows.Add(25, 22, "Mantenimientos de Datos");

            project.Rows.Add(26, DBNull.Value, "MKTOOLS");
            project.Rows.Add(27, 25, "Proceso de Importacion");
            project.Rows.Add(28, 25, "Mantenimientos de Datos");

           

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
           
          
                
                    if (proyectsTV.SelectedNode.Text== "Importacion de Sellout")
                    {
                        tabImportSellout.Enabled = true;
                        tabImportCliente.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabImportSellout.Show();
                        
                    } if (proyectsTV.SelectedNode.Text == "Importacion de Clientes")
                    {
                        tabImportCliente.Enabled = true;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabImportCliente.Show();
                        

                    } if (proyectsTV.SelectedNode.Text == "Calculos de ABC")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = true;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabCalculoABC.Show();

                    } if (proyectsTV.SelectedNode.Text == "Calculos de Oportunidades")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = true;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabCalculoOP.Show();

                    } if (proyectsTV.SelectedNode.Text == "Calculos de KPIs")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = true;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabCalculoKPI.Show();

                    } if (proyectsTV.SelectedNode.Text == "Clientes")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = true;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabClientes.Show();

                    }
                    if (proyectsTV.SelectedNode.Text == "Agrupacion de Clientes")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = true;
                       // tabAgruparC.Show();
                    } if (proyectsTV.SelectedNode.Text == "Master de Productos KC")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = true;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabMasterP.Show();

                    } if (proyectsTV.SelectedNode.Text == "Productos Equivalentes")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = true;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabProductosE.Show();

                    } if (proyectsTV.SelectedNode.Text == "Agrupacion de Productos")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = true;
                        tabAgruparC.Enabled = false;
                        //tabAgruparP.Show();

                    } if (proyectsTV.SelectedNode.Text == "Distribuidores")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = true;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabDistribuidor.Show();

                    }
                    if (proyectsTV.SelectedNode.Text == "KAMs")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = true;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabKAM.Show();

                    } if (proyectsTV.SelectedNode.Text == "Pais")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = true;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabPais.Show();

                    } if (proyectsTV.SelectedNode.Text == "Segmentos")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = true;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabSegmento.Show();

                    } if (proyectsTV.SelectedNode.Text == "Nuevos Segmentos")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = true;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabNuevosSegmentos.Show();

                    }
                    if (proyectsTV.SelectedNode.Text == "Conglomerados")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = false;
                        tabConglomerados.Enabled = true;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                        //tabConglomerados.Show();

                    }
                    if (proyectsTV.SelectedNode.Text == "Cuentas Globales")
                    {
                        tabImportCliente.Enabled = false;
                        tabImportSellout.Enabled = false;
                        tabKAM.Enabled = false;
                        tabMasterP.Enabled = false;
                        tabNuevosSegmentos.Enabled = false;
                        tabPais.Enabled = false;
                        tabProductosE.Enabled = false;
                        tabSegmento.Enabled = false;
                        tabDistribuidor.Enabled = false;
                        tabCuentasGlobales.Enabled = true;
                        tabConglomerados.Enabled = false;
                        tabClientes.Enabled = false;
                        tabCalculoOP.Enabled = false;
                        tabCalculoKPI.Enabled = false;
                        tabCalculoABC.Enabled = false;
                        tabAgruparP.Enabled = false;
                        tabAgruparC.Enabled = false;
                       // tabCuentasGlobales.Show();

                    }
               
            

        }

        

       
                      
    }
}
