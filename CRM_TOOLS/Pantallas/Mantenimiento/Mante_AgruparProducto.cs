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
    public partial class Mante_AgruparProducto : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();

        public Mante_AgruparProducto()
        {
            InitializeComponent();
            cargarGridAgrupar();
        }

        void cargarGridAgrupar()
        {
            var query = from g in Entity.GRUPOS_PRODUCTOS
                        select new
                        {
                            lao=g.LAO_GROUP,
                            str=g.ESTRATEGIC_GROUP,
                            n1 = g.NIVEL1,
                            n2 = g.NIVEL2,
                            n3 = g.NIVEL3,
                            n4 = g.NIVEL4,
                            n5 = g.NIVEL5,
                        };
            gridAgrupar.EnableFiltering = true;
            gridAgrupar.ShowFilteringRow = false;
            gridAgrupar.ShowHeaderCellButtons = true;
            gridAgrupar.DataSource = query;

        }

        private void btNuevoAP_Click(object sender, EventArgs e)
        {
            frmNuevoAgrupar fa = new frmNuevoAgrupar();
            fa.Show();
        }
    }
}
