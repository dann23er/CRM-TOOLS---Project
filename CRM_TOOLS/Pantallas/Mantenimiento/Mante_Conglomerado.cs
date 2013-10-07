using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using DataAccess;
using CRM_TOOLS.Pantallas.Mantenimiento;

namespace CRM_TOOLS.Pantallas
{
    public partial class Mante_Conglomerado : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();

        string id, nombre;
        public Mante_Conglomerado()
        {
            InitializeComponent();
        }
        void cargarGAN()
        {
            var query = from gan in Entity.GLOBAL_ACCOUNTS
                        select new
                        {
                           id= gan.GLOBAL_ACCOUNT_ID,
                            nombre=gan.NOMBRE_GLOBAL_ACCOUNT
                        };
            cbGAN.DataSource = query;
            cbGAN.ValueMember = "id";
            cbGAN.DisplayMember = "nombre";
            
        }

        void cargarPlataforma()
        {
            var query = from p in Entity.PLATAFORMAS
                        select new
                        {
                            id = p.CODIGO_PLATAFORMA,
                            nombre = p.NOMBRE_PLATAFORMA
                        };
            cbPlataformas.DataSource = query;
            cbPlataformas.ValueMember = "id";
            cbPlataformas.DisplayMember = "nombre";

        }

        void cargarSegmento()
        {
            var query = from s in Entity.SEGMENTOS
                        select new
                        {
                            id = s.SEGMENT_ID,
                            nombre = s.SEGMENT_NAME_ING
                        };
            cbSegmento.DataSource = query;
            cbSegmento.ValueMember = "id";
            cbSegmento.DisplayMember = "nombre";

        }

        private void rdInactivo_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
         
            lbGC.Visible = false;
            lbGAN.Visible = false;
   
            rdGAN.IsChecked = false;
            rdGC.IsChecked = false;
            rdPla.IsChecked = false;
            rdSeg.IsChecked = false;

            txtGrupoCliente.Visible = false;
            cbGAN.Visible = false;
            cbSegmento.Visible = false;
            cbPlataformas.Visible = false;
        }

        private void rdGAN_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
           if(rdGAN.IsChecked==true){
               lbGAN.Visible = true;
               cbGAN.Visible = true;
               cargarGAN();
           }
            lbGC.Visible = false;
            rdInactivo.IsChecked = false;
            rdGC.IsChecked = false;
            rdPla.IsChecked = false;
            rdSeg.IsChecked = false;
            txtGrupoCliente.Visible = false;
            cbSegmento.Visible = false;
            cbPlataformas.Visible = false;
        }

        private void rdGC_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdGC.IsChecked == true)
            {
                txtGrupoCliente.Visible = true;
                lbGC.Visible = true;
            }
            lbGAN.Visible = false;
            rdInactivo.IsChecked = false;
            rdGAN.IsChecked = false;
            rdPla.IsChecked = false;
            rdSeg.IsChecked = false;
            cbGAN.Visible = false;
            cbSegmento.Visible = false;
            cbPlataformas.Visible = false;
        }

        private void rdPla_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            lbGC.Visible = false;
            lbGAN.Visible = false;
            rdInactivo.IsChecked = false;
            rdGC.IsChecked = false;
            rdGAN.IsChecked = false;
            rdSeg.IsChecked = false;
            txtGrupoCliente.Visible = false;
            cbGAN.Visible = false;
            cbSegmento.Visible = false;
            if (rdPla.IsChecked == true)
            {
                cargarPlataforma();
                cbPlataformas.Visible = true;
            }
        }

        private void rdSeg_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            lbGC.Visible = false;
            lbGAN.Visible = false;
            rdInactivo.IsChecked = false;
            rdGC.IsChecked = false;
            rdGAN.IsChecked = false;
            rdPla.IsChecked = false;
            txtGrupoCliente.Visible = false;
            cbGAN.Visible = false;
            cbPlataformas.Visible = false;
            if (rdSeg.IsChecked == true)
            {
                cargarSegmento();
                cbSegmento.Visible = true;
            }
        }
                
        void guardarDatos(string id,string nom)
        {
            var query = from c in Entity.CLIENTES
                        where c.CODIGO_CLIENTE_COMPUESTO == id && c.NOMBRE_CLIENTE == nom
                        select c;
            foreach (var row in query)
            {
                if(row.NOMBRE_CLIENTE==nom && row.CODIGO_CLIENTE_COMPUESTO==id){
                    CLIENTES cli = new CLIENTES();
                    if (rdInactivo.IsChecked == true)
                    {
                        row.STATUS_CLIENTE = true;
                        
                    }
                    else if (rdGAN.IsChecked == true)
                    {
                        row.GLOBAL_ACCOUNT_ID =Convert.ToInt32(cbGAN.SelectedValue);
                        row.GLOBAL_ACCOUNT_NAME = Convert.ToString(cbGAN.SelectedItem);
                        
                    }
                    else if(rdGC.IsChecked==true)
                    {
                        row.GRUPO_CLIENTE = txtGrupoCliente.Text;
                        
                    }
                    else if (rdPla.IsChecked==true)
                    {
                        row.PLATAFORMAS = cbPlataformas.SelectedItem.Text;
                        
                    }
                    else if (rdSeg.IsChecked == true)
                    {
                        row.SEGMENTO_KC_ID = Convert.ToInt32(cbSegmento.SelectedValue);
                        
                    }

                }
                
            }
            Entity.SaveChanges();
            MessageBox.Show("Datos Actualizado!!!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btActual_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridDatos.RowCount;i++ )
            {
                id=(string)gridDatos.Rows[i].Cells[0].Value;
                nombre=(string)gridDatos.Rows[i].Cells[1].Value;
                guardarDatos(id,nombre);
            }

        }

    }
}
