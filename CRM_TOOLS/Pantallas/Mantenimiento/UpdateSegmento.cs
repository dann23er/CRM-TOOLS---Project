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
using CRM_TOOLS.Clases;
using Telerik.WinControls.UI;
using System.IO;
using CRM_TOOLS.Pantallas.Mantenimiento;

namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class UpdateSegmento : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        Mante_Clientes _owner;
        public UpdateSegmento(Mante_Clientes x)
        {
            InitializeComponent();
            _owner = x;
            cargarSegSC();
            cargarSegKC();
        }

        void cargarSegSC()
        {
            var query = from qr in Entity.EQUIVALENCIAS_SEGMENTOS
                        select new
                        {
                            id=qr.COD_SEGMENT_IMPORT,
                            nombre=qr.NAME_SEGMENT_IMPORT
                        };
            cbSegSC.DataSource = query;
            cbSegSC.DisplayMember = "nombre";
            cbSegSC.ValueMember = "id";
        }

        void cargarSegKC()
        {
            var query = from qr in Entity.SEGMENTOS
                        select new
                        {
                            nombre = qr.SEGMENT_NAME_ING,
                            id = qr.SEGMENT_ID
                        };
            cbSegKC.DataSource = query;
            cbSegKC.DisplayMember = "nombre";
            cbSegKC.ValueMember = "id";
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            CLIENTES cli = new CLIENTES();
            int id=Convert.ToInt32(cbSegSC.SelectedValue);

            var query =( from qr in Entity.CLIENTES
                        where qr.SEGMENTO_SC_ID == id
                        select qr).ToList();

            foreach(var rw in query)
            {
                rw.SEGMENTO_KC_ID = Convert.ToInt32(cbSegKC.SelectedValue);
            }
            Entity.SaveChanges();
            MessageBox.Show("Segmento KC Insertado con Exito!!!");
            _owner.gridClientes();
        }
    }
}
