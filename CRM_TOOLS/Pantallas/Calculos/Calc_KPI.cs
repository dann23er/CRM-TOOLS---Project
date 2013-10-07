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

namespace CRM_TOOLS.Pantallas.Calculos
{
    public partial class Calc_KPI : Telerik.WinControls.UI.RadForm
    {
        Class_Funciones calc = new Class_Funciones();
        bool flag, flag1,flag2;

        public Calc_KPI()
        {
            InitializeComponent();
            flag = false;
            flag1 = false;
            flag2 = false;
        }

        private void rdPaisP_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            calc.cargarDesde(cbSecP);
            calc.cargarPais(cbPaisP);
        }

        private void rdDistP_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            cbPaisP.Enabled = true;
            cbSecP.Enabled = true;
            cbDistP.Enabled = true;
            calc.cargarDesde(cbSecP);
            calc.cargarPais(cbPaisP);
        }

        private void cbPaisP_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp;
            if (rdPaisP.IsChecked == true)
            {
                cbDistP.Enabled = false;
            }
            else if (rdDistP.IsChecked == true)
            {
                if (flag)
                {
                    cbDistP.Enabled = true;
                    temp = Convert.ToString(cbPaisP.SelectedValue);
                    calc.cargarDistribuidor(temp, cbDistP, 2);
                }
                flag = true;
            }


        }

        private void btProcesarP_Click(object sender, EventArgs e)
        {
            int tipoP = 1;
            string ps = Convert.ToString(cbPaisP.SelectedValue);
            int sec = Convert.ToInt32(cbSecP.SelectedText);
            string dis = Convert.ToString(cbDistP.SelectedValue);
            calc.Calculo_IndicePenetracion(ps,sec,dis,tipoP);
        }

        private void rdPaisV_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            calc.cargarDesde(cbSecV);
            calc.cargarPais(cbPaisV);
        }

        private void rdDistV_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            cbPaisV.Enabled = true;
            cbSecV.Enabled = true;
            cbDistV.Enabled = true;
            calc.cargarDesde(cbSecV);
            calc.cargarPais(cbPaisV);
        }

        private void cbPaisV_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp;
            if (rdPaisV.IsChecked == true)
            {
                cbDistV.Enabled = false;
            }
            else if (rdDistV.IsChecked == true)
            {
                if (flag1)
                {
                    cbDistV.Enabled = true;
                    temp = Convert.ToString(cbPaisV.SelectedValue);
                    calc.cargarDistribuidor(temp, cbDistV, 2);
                }
                flag1 = true;
            }
        }

        private void btProcesarV_Click(object sender, EventArgs e)
        {
            int tipoV=1;
            string ps = Convert.ToString(cbPaisV.SelectedValue);
            int sec = Convert.ToInt32(cbSecV.SelectedText);
            string dis = Convert.ToString(cbDistV.SelectedValue);
            calc.Calculo_VentasNuevas(ps,sec,dis,tipoV);
        }

        private void rdPaisC_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            calc.cargarDesde(cbSecC);
            calc.cargarPais(cbPaisC);
        }

        private void rdDistC_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            cbPaisC.Enabled = true;
            cbSecC.Enabled = true;
            cbDistC.Enabled = true;
            calc.cargarDesde(cbSecC);
            calc.cargarPais(cbPaisC);
        }

        private void cbPaisC_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp;
            if (rdPaisC.IsChecked == true)
            {
                cbDistC.Enabled = false;
            }
            else if (rdDistC.IsChecked == true)
            {
                if (flag2)
                {
                    cbDistC.Enabled = true;
                    temp = Convert.ToString(cbPaisC.SelectedValue);
                    calc.cargarDistribuidor(temp, cbDistC, 2);
                }
                flag2 = true;
            }

        }

        private void btProcesarC_Click(object sender, EventArgs e)
        {
            int tipoC = 1;
            string ps = Convert.ToString(cbPaisC.SelectedValue);
            int sec = Convert.ToInt32(cbSecC.SelectedText);
            string dis = Convert.ToString(cbDistC.SelectedValue);
            calc.Calculo_Cobertura(ps, sec, dis, tipoC);
        }

        private void btProcesarS_Click(object sender, EventArgs e)
        {
            if (rdPerdido.IsChecked == true)
            {
                rdRecuperado.IsChecked = false;
                rdEmergencia.IsChecked = false;
                rdNuevo.IsChecked = false;
            }
            else if (rdRecuperado.IsChecked == true)
            {
                rdEmergencia.IsChecked = false;
                rdNuevo.IsChecked = false;
                rdPerdido.IsChecked = false;
            }
            else if (rdNuevo.IsChecked == true)
            {
              
                rdEmergencia.IsChecked = false;
                rdRecuperado.IsChecked = false;
                rdPerdido.IsChecked = false;
            }
            else if(rdEmergencia.IsChecked==true)
            {
                rdNuevo.IsChecked = false;
                rdRecuperado.IsChecked = false;
                rdPerdido.IsChecked = false;
            }
        }
    }
}
