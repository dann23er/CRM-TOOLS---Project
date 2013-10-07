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
    public partial class Mante_KAM : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public Mante_KAM()
        {
            InitializeComponent();
            cargarGridKAM();
        }

        public void cargarGridKAM()
        {
            var query = from k in Entity.KAM

                        select new
                        {
                            id = k.KAM_ID,
                            nombre = k.KAM_NAME,
                            esta = k.KAM_ACTIVE,
                            pais = k.COUNTRY,
                            gba = k.GBA
                        };

            this.gridKAM.EnableFiltering = true;
            this.gridKAM.ShowFilteringRow = false;
            this.gridKAM.ShowHeaderCellButtons = true;
            gridKAM.DataSource = query;

        }
        private void btNew_Click(object sender, EventArgs e)
        {
            frmNuevoKAM kam = new frmNuevoKAM(this);
            kam.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        
    }
}
