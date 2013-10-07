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

namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmNuevoAgrupar : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();

        string lao;
        string str;
        string n1; 
        string n2; 
        string n3; 
        string n4; 
        string n5;
 
        public frmNuevoAgrupar()
        {
            InitializeComponent();
            gridAgrupar.EnableFiltering = true;
            gridAgrupar.ShowFilteringRow = false;
            gridAgrupar.ShowHeaderCellButtons = true;
        }
        void guardarAgrupar(string lao,string str,string n1,string n2,string n3,string n4,string n5)
        {
            GRUPOS_PRODUCTOS g = new GRUPOS_PRODUCTOS();
            g.LAO_GROUP = lao;
            g.ESTRATEGIC_GROUP = str;
            g.NIVEL1 = n1;
            g.NIVEL2 = n2;
            g.NIVEL3 = n3;
            g.NIVEL4 = n4;
            g.NIVEL5 = n5;
            Entity.GRUPOS_PRODUCTOS.AddObject(g);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridAgrupar.RowCount; i++)
            {


                lao = (string)gridAgrupar.Rows[i].Cells[0].Value;
                str = (string)gridAgrupar.Rows[i].Cells[1].Value;
                n1 = (string)gridAgrupar.Rows[i].Cells[2].Value;
                n2 = (string)gridAgrupar.Rows[i].Cells[3].Value;
                n3 = (string)gridAgrupar.Rows[i].Cells[4].Value;
                n4 = (string)gridAgrupar.Rows[i].Cells[5].Value;
                n5 = (string)gridAgrupar.Rows[i].Cells[6].Value;

                guardarAgrupar(lao, str, n1, n2, n3, n4, n5);
              
            }
            MessageBox.Show("Se Ha Guardado Exitasamente!!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
