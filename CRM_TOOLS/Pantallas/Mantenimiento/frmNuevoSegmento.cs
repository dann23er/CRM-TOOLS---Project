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

namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmNuevoSegmento : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity=new CRMToolEntities();
        bool ver=false;
        Mante_Segmentos _owner;
        public frmNuevoSegmento(Mante_Segmentos x)
        {
            _owner = x;
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            GuardarSegmento();
        }

        void GuardarSegmento()
        {
            SEGMENTOS seg = new SEGMENTOS();
            int IdSeg = Convert.ToInt32(txtId.Text);
            var query = from segs in Entity.SEGMENTOS
                        where segs.SEGMENT_ID==IdSeg
                        select segs;
            foreach (var row in query)
            {
               if(row.SEGMENT_ID==IdSeg){
                   MessageBox.Show("El Codigo ya Existe!!!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                   ver=true;
                   break;
               }
               if (ver == false)
               {
                   seg.SEGMENT_ID = IdSeg;
                   seg.SEGMENT_NAME = txtSegEs.Text;
                   seg.SEGMENT_NAME_ING = txtSegIn.Text;
                   Entity.SEGMENTOS.AddObject(seg);

                   MessageBox.Show("El Segmento se ha guardado!!!");
                   
               }
               Entity.SaveChanges();
               _owner.cargarGridSegmentos(); ;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       
      


        

        
    }
}
