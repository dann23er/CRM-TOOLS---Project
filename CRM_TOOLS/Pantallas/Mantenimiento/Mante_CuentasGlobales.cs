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
    public partial class Mante_CuentasGlobales : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public Mante_CuentasGlobales()
        {
            InitializeComponent();
            cargarListaGAN();
        }
       public void cargarListaGAN()
        {
            var query = from gan in Entity.GLOBAL_ACCOUNTS
                        select new
                        {
                            id = gan.GLOBAL_ACCOUNT_ID,
                            nombre = gan.NOMBRE_GLOBAL_ACCOUNT
                        };
            this.gridGAN.EnableFiltering = true;
            this.gridGAN.ShowFilteringRow = false;
            this.gridGAN.ShowHeaderCellButtons = true;
            gridGAN.DataSource = query;
           

        }

      

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoCuentasGlobales gan = new frmNuevoCuentasGlobales(this);
            gan.Show();

        }

        
    }
}
