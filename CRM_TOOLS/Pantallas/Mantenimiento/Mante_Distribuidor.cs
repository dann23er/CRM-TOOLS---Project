using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DataAccess;
using System.Linq;
using CRM_TOOLS.Pantallas.Mantenimiento;

namespace CRM_TOOLS.Pantallas
{
    public partial class Mante_Distribuidor : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        Mante_KAM x;
        public Mante_Distribuidor()
        {
            InitializeComponent();
            cargarGridDistribuidor();
        }

        public void cargarGridDistribuidor()
        {
            var query = from dist in Entity.DISTRIBUIDORES
                   
                        select new
                        {
                            id = dist.CODIGO_DISTRIBUIDOR,
                            nomDist=dist.NOMBRE_DISTRIBUIDOR,
                            nomCorto=dist.NOMBRE_CORTO,
                            nomKam=dist.KAM_ID,
                            use=dist.UseOnKPI,
                            imp=dist.Import,
                            pais=dist.PAIS,
                            gba=dist.GBA
                        };

            this.gridDistribuidor.EnableFiltering = true;
            this.gridDistribuidor.ShowFilteringRow = false;
            this.gridDistribuidor.ShowHeaderCellButtons = true;
            gridDistribuidor.DataSource = query;
            
        }

        private void btKam_Click(object sender, EventArgs e)
        {
        
            frmNuevoKAM kam = new frmNuevoKAM(x);
            kam.Show();
        }
    }
}
