using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DataAccess;
using CRM_TOOLS;
using System.Linq;
using Telerik.WinControls.UI;
using CRM_TOOLS.Clases;

namespace CRM_TOOLS.Pantallas
{
    public partial class Mante_ProductoEquivalente : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        Class_Funciones calc = new Class_Funciones();
       
        public Mante_ProductoEquivalente()
        {
            InitializeComponent();
            calc.cargarPais(cbPais);
            cargarComboProductosEquivalente();
            cargarCodigoSap();
            cargarTipo();
        }

        public void cargarComboProductosEquivalente()
        {
            var query = from pe in Entity.PRODUCTOS_EQUIVALENTES
                        join p in Entity.PRODUCTOS on pe.CODIGO_PRODUCTO_SAP equals p.CODIGO_CORTO
                        select new
                        {
                            idP = pe.CODIGO_PRODUCTO_DISTRIBUIDOR,
                            nom = pe.DESCRIPCION_PRODUCTO_DISTR,
                            id = p.CODIGO_CORTO,
                            nomsap = p.DESCRIPCION,
                            
                            tipo = from pr in Entity.PLATAFORMAS
                                   select new
                                   {
                                       pr.CODIGO_PLATAFORMA,
                                       pr.NOMBRE_PLATAFORMA
                                   }
                                   
                        };
            gridProductosE.EnableFiltering = true;
            gridProductosE.ShowFilteringRow = false;
            gridProductosE.ShowHeaderCellButtons = true;
            gridProductosE.DataSource = query;
 
        }

        void cargarTipo()
        {
            DataTable dt = new DataTable();
            GridViewComboBoxColumn combo = (GridViewComboBoxColumn)this.gridProductosE.Columns[4];
            DataRow dr = dt.NewRow();
            dt.Columns.Add("Tipo", typeof(string));
            dt.Rows.Add("Cajas");
            dt.Rows.Add("Bultos");
            dt.Rows.Add("Unidades");
           
           // string query[] = {"Bultos","Unidades","Cajas"};
           combo.DataSource = dt;
           combo.DisplayMember = "Tipo";
           combo.ValueMember = "Tipo";
     
          
            
        }
        void cargarCodigoSap()
        {
            GridViewComboBoxColumn combo = (GridViewComboBoxColumn)this.gridProductosE.Columns[2];
            var query = from eq in Entity.PRODUCTOS
                        select new
                        {
                            id = eq.CODIGO_CORTO
                        };
            combo.DataSource = query;
            combo.DisplayMember = "id";
            combo.ValueMember = "id";

        }
     
        public void GridProductosEquivalente(string ps,string dist)
        {
            var query = from pe in Entity.PRODUCTOS_EQUIVALENTES
                        join p in Entity.PRODUCTOS on pe.CODIGO_PRODUCTO_SAP equals p.CODIGO_CORTO
                        where pe.CODIGO_DISTRIBUIDOR==dist && pe.ID_COUNTRY==ps
                        select new
                        {
                            idP = pe.CODIGO_PRODUCTO_DISTRIBUIDOR,
                            nom = pe.DESCRIPCION_PRODUCTO_DISTR,
                            id = p.CODIGO_CORTO,
                            nomsap = p.DESCRIPCION,

                            tipo = from pr in Entity.PLATAFORMAS
                                   select new
                                   {
                                       pr.CODIGO_PLATAFORMA,
                                       pr.NOMBRE_PLATAFORMA
                                   }

                        };
            gridProductosE.EnableFiltering = true;
            gridProductosE.ShowFilteringRow = false;
            gridProductosE.ShowHeaderCellButtons = true;
            gridProductosE.DataSource = query;

        }
       
        private void MasterTemplate_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RadDropDownListEditor editor = this.gridProductosE.ActiveEditor as RadDropDownListEditor;
            if (editor != null)
            {
                //gridProductosE
                ((RadDropDownListEditorElement)((RadDropDownListEditor)this.gridProductosE.ActiveEditor).EditorElement).RightToLeft = true;
            }

          

        }
        
        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            string pais = Convert.ToString(cbPais.SelectedValue);
            calc.cargarDistribuidor(pais,cbDist,2);
            cbDist.Enabled = true;
        }

        private void cbDist_SelectedValueChanged(object sender, EventArgs e)
        {
            string ps = Convert.ToString(cbPais.SelectedValue);
            string dist = Convert.ToString(cbDist.SelectedValue);
            GridProductosEquivalente(ps,dist);
        }

        private void gridProductosE_CellClick(object sender, GridViewCellEventArgs e)
        {

        }

       
    }
}
