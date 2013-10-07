using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DataAccess;
using CRM_TOOLS.Pantallas.Mantenimiento;
using System.Linq;

namespace CRM_TOOLS.Pantallas
{
    public partial class Mante_Segmentos : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public Mante_Segmentos()
        {
            InitializeComponent();
            cargarGridSegmentos();
        }
        public void cargarGridSegmentos()
        {
            var query = from eseg in Entity.EQUIVALENCIAS_SEGMENTOS
                        join seg in Entity.SEGMENTOS on eseg.SEGMENT_ID equals seg.SEGMENT_ID
                        select new
                        {
                         idES=eseg.COD_SEGMENT_IMPORT,
                         nomES=eseg.NAME_SEGMENT_IMPORT,
                         idS=eseg.SEGMENT_ID,
                         nomS=seg.SEGMENT_NAME
                        };
            gridSegmento.DataSource = query;
                       
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            frmNuevoSegmento seg = new frmNuevoSegmento(this);
            seg.Show();
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
