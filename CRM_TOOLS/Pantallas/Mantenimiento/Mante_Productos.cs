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
    public partial class Mante_Productos : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public Mante_Productos()
        {
            InitializeComponent();
            cargarGridProductos();
        }

        void cargarGridProductos()
        {
            var query = from p in Entity.PRODUCTOS
                        select new
                        {
                            id=p.CODIGO_CORTO,
                            nombre=p.DESCRIPCION,
                            lao=p.LAO_GROUP,
                            str=p.STRATEGIC_GROUP,
                            n1=p.NIVEL1,
                            n2=p.NIVEL2,
                            n3=p.NIVEL3,
                            n4=p.NIVEL4,
                            n5=p.NIVEL5,
                           
                        };
            gridProducto.EnableFiltering = true;
            gridProducto.ShowFilteringRow = false;
            gridProducto.ShowHeaderCellButtons = true;
            gridProducto.DataSource = query;
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            file.ShowDialog();

        }
    }
}
