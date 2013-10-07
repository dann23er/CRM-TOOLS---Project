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

namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmNuevoKAM : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        bool ver=false;
        bool estado = false;
        Mante_KAM _owner;
        public frmNuevoKAM(Mante_KAM x)
        {
            _owner = x;
            InitializeComponent();
        }

        void CargarPais()
        {
            var query = from p in Entity.PAISES
                        select p;
            cbPais.DataSource = query;
            cbPais.ValueMember = "COUNTRY_ID";
            cbPais.DisplayMember = "COUNTRY_NAME";
        }
        void CargarEstado()
        {

        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            GuardarKAM();
        }
        void GuardarKAM()
        {
            KAM kam = new KAM();
            string Id = txtId.Text;
            var query = from k in Entity.KAM
                        select k;

            foreach (var row in query)
            {
                if (row.KAM_ID == Id)
                {
                    MessageBox.Show("El Codigo ya Existe!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ver = true;
                    break;
                }
            }
            if (ver == false)
            {
                kam.KAM_ID = Id;
                kam.KAM_NAME = txtNombre.Text;
                kam.KAM_eMAIL = txtemail.Text;
                kam.GBA = txtGBA.Text;
                kam.COUNTRY = cbPais.Text;
                if (cbEstado.Text == "Habilitado")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                kam.KAM_ACTIVE = estado;

                Entity.KAM.AddObject(kam);

                MessageBox.Show("El KAM se ha guardado!!!","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }
            Entity.SaveChanges();
            _owner.cargarGridKAM();
         

        }

        
    }
}
