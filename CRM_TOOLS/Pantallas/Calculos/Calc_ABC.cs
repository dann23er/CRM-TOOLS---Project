using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using CRM_TOOLS.Clases;

namespace CRM_TOOLS.Pantallas.Calculos
{
    public partial class Calc_ABC : Telerik.WinControls.UI.RadForm
    {
        Class_Funciones calc=new Class_Funciones();
        bool flag,flag2,flag3,flag4,flag5,flag6,flag7,flag8,flag9;
        int tipo = 0;

        public Calc_ABC()
        {
            flag = false;
            flag2 = false;
            flag3 = false;
            flag4 = false;
            flag5 = false;
            flag6 = false;
            flag7 = false;
            flag8 = false;
            flag9 = false;

            InitializeComponent();

            cbPaisDis.SelectedItem = null;
            cbPaisDis.SelectedIndex = 0;
            cbHasta.SelectedItem = null;
            cbHasta.SelectedIndex = 0;
            cbDesde.SelectedItem = null;
            cbDesde.SelectedIndex=0;
            cbDistD.SelectedItem = null;
            cbDistD.SelectedIndex = 0;

            calc.cargarDesde(cbDesdeP);
            calc.cargarPais(cbPaisP);

            calc.cargarDesde(cbDesdeR);
            calc.cargarRegion(cbRegion);

            calc.cargarDesde(cbDesdeSR);
            calc.cargarSubRegion(cbSubReg);

            

         }

        private void btCalcularD_Click(object sender, EventArgs e)
        {            
            int cbH, cbD,tipo=0;
            cbD = Convert.ToInt32(cbDesde.Text);
            cbH = Convert.ToInt32(cbHasta.Text);
            if (rdTodoDist.IsChecked == true)
            {
                rdUnDist.IsChecked = false;
                flag = false;
                tipo=1;

                calc.ABCDistribuidor(cbD, cbH, cbPaisDis.SelectedValue.ToString(), " ", tipo);
              
            }
            else if (rdUnDist.IsChecked == true)
            {
      
                rdTodoDist.IsChecked = false;
                tipo = 2;
                flag = false;
                calc.ABCDistribuidor(cbD, cbH, cbPaisDis.SelectedValue.ToString(), cbDistD.SelectedValue.ToString(), tipo);
            
            }
        }

        private void cbDesde_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                string var = cbDesde.SelectedText;
                calc.cargarHasta(var, cbHasta);

            }
            flag = true;
        }

        private void cbHasta_SelectedValueChanged(object sender, EventArgs e)
        {
             if (flag2)
            {
            calc.getMeses(cbDesde.Text, cbHasta.Text, txtMes);
            }
             flag2 = true;
        }

        private void cbPaisDis_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp="";
            if(rdTodoDist.IsChecked==true)
            {
                tipo=1;
                cbDistD.Enabled = false;
              
            }
            else if(rdUnDist.IsChecked==true)
            {
                tipo=2;
                if (flag3)
                {
                    cbDistD.Enabled = true;
                   
                    temp = Convert.ToString(cbPaisDis.SelectedValue);
                    calc.cargarDistribuidor(temp, cbDistD, tipo);
              
                }
                flag3 = true;
            }

           
        }

        private void rdTodoDist_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
           
                calc.cargarDesde(cbDesde);
                calc.cargarPais(cbPaisDis);
            
        }

        private void rdUnDist_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            calc.cargarDesde(cbDesde);
            calc.cargarPais(cbPaisDis);

        }

        private void cbDesdeP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag4)
            {
                string var = cbDesdeP.SelectedText;
                calc.cargarHasta(var, cbHastaP);

            }
            flag4 = true;
        }

        private void cbHastaP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag5)
            {
                calc.getMeses(cbDesdeP.Text, cbHastaP.Text, txtMesP);
            }
            flag5 = true;
        }

        private void cbDesdeR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag6)
            {
                string var = cbDesdeR.SelectedText;
                calc.cargarHasta(var, cbHastaR);

            }
            flag6 = true;
        }

        private void cbHastaR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag7)
            {
                calc.getMeses(cbDesdeR.Text, cbHastaR.Text, txtMesR);
            }
            flag7 = true;
        }

        private void cbDesdeSR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag8)
            {
                string var = cbDesdeSR.SelectedText;
                calc.cargarHasta(var, cbHastaSR);

            }
            flag8 = true;
        }

        private void cbHastaSR_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag9)
            {
                calc.getMeses(cbDesdeSR.Text, cbHastaSR.Text, txtMesSR);
            }
            flag9 = true;
        }

        private void btCalcularP_Click(object sender, EventArgs e)
        {
            int cbH, cbD;
            cbD = Convert.ToInt32(cbDesde.Text);
            cbH = Convert.ToInt32(cbHasta.Text);
            calc.CalculoABC(cbD,cbH,cbPaisP.SelectedValue.ToString(),1);
        }

        private void btCalcularR_Click(object sender, EventArgs e)
        {
            int cbH, cbD;
            cbD = Convert.ToInt32(cbDesde.Text);
            cbH = Convert.ToInt32(cbHasta.Text);
            calc.CalculoABC(cbD, cbH, cbRegion.SelectedValue.ToString(), 2);
        }

        private void btCalcularSR_Click(object sender, EventArgs e)
        {
            int cbH, cbD;
            cbD = Convert.ToInt32(cbDesde.Text);
            cbH = Convert.ToInt32(cbHasta.Text);
            calc.CalculoABC(cbD, cbH, cbSubReg.SelectedValue.ToString(), 3);
        }
    }
}
