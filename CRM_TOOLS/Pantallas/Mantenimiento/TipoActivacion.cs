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
    public partial class TipoActivacion : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        Mante_Clientes _owner;
        string Codigo;

        public TipoActivacion(Mante_Clientes x,string id)
        {
            _owner = x;
            InitializeComponent();
            Codigo = id;
        
            cargarGAN();
            cargarPlataforma();
        }

        void cargarGAN()
        {
            var query = from gan in Entity.GLOBAL_ACCOUNTS
                        select new
                        {
                            id = gan.GLOBAL_ACCOUNT_ID,
                            nombre = gan.NOMBRE_GLOBAL_ACCOUNT
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

        void guardarDatos()
        {
            var query =(from qr in Entity.CLIENTES
                        where qr.CODIGO_CLIENTE==Codigo
                        select qr).ToList();
                 
          
            foreach (var row in query)
            {

                    if (rdGAN.IsChecked == true)
                    {
                        row.GLOBAL_ACCOUNT_ID = Convert.ToInt32(cbGAN.SelectedValue);
                        row.GLOBAL_ACCOUNT_NAME = Convert.ToString(cbGAN.SelectedItem);

                    }
                    else if (rdGC.IsChecked == true)
                    {
                        row.GRUPO_CLIENTE = txtGP.Text;

                    }
                    else if (rdPla.IsChecked == true)
                    {
                        row.PLATAFORMAS =Convert.ToString(cbPlataformas.SelectedItem);

                    }
                 
                    }
                    Entity.SaveChanges();
                    MessageBox.Show("Datos Actualizado!!!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
            }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            _owner.gridClientes();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            _owner.CargarCheck(null);
            this.Close();
        }

        private void rdGAN_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdGAN.IsChecked == true)
            {
                cbGAN.Enabled = true;
            }
                rdGC.IsChecked =false;
                rdPla.IsChecked = false;
                cbPlataformas.Enabled = false;
                txtGP.Enabled = false;
            }

        private void rdPla_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdPla.IsChecked == true)
            {
                cbPlataformas.Enabled = true;
            }

            rdGC.IsChecked = false;
            rdGAN.IsChecked = false;
            cbGAN.Enabled = false;
            txtGP.Enabled = false;
                
        }

        private void rdGC_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdGC.IsChecked == true)
            {
                txtGP.Enabled = true;
            }
            cbPlataformas.Enabled = false;
            rdGAN.IsChecked = false;
            rdPla.IsChecked = false;
            cbGAN.Enabled = false;
         
                
        }
    }
}
