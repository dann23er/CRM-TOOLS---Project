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
    public partial class frmNuevoCuentasGlobales : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        bool ver=false;
        Mante_CuentasGlobales _owner;
        public frmNuevoCuentasGlobales(Mante_CuentasGlobales x)
        {
            _owner = x;
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            GuardarGAN();
        }

        void GuardarGAN()
        {
            GLOBAL_ACCOUNTS gans = new GLOBAL_ACCOUNTS();

            int Id = Convert.ToInt32(txtCodigo.Text);
            var query = from gan in Entity.GLOBAL_ACCOUNTS
                        select gan;

            foreach (var row in query)
            {
                if (row.GLOBAL_ACCOUNT_ID == Id)
                {
                    MessageBox.Show("El Codigo ya Existe!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ver = true;
                    break;
                }
            }
                if (ver == false)
                {
                    gans.GLOBAL_ACCOUNT_ID = Id;
                    gans.NOMBRE_GLOBAL_ACCOUNT = txtNombre.Text;
                    
                    Entity.GLOBAL_ACCOUNTS.AddObject(gans);

                    MessageBox.Show("La Cuenta Global se ha guardado!!!");

                }
                Entity.SaveChanges();
                _owner.cargarListaGAN();

            
        }

       

    }
}
