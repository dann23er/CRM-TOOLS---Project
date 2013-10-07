using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using CRM_TOOLS.Clases;
using DataAccess;
using System.Data;
using Telerik.WinControls.UI;
using System.Linq;


namespace CRM_TOOLS.Pantallas.Calculos
{
    public partial class Calc_Oportunidades : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        Class_Funciones calc = new Class_Funciones();
        DataTable dt = new DataTable();

        bool flag, flag1;
        public Calc_Oportunidades()
        {
            flag = false;
            flag1 = false;
            InitializeComponent();
            dt.Columns.Add("Anio");
            dt.Columns.Add("Mes");
            dt.Columns.Add("Codigo_Cliente_Compuesto");
            dt.Columns.Add("Codigo_Distribuidor");
            dt.Columns.Add("Codigo_Cliente");
            dt.Columns.Add("Nombre_Cliente");
            dt.Columns.Add("SEGMENTO_KC");
            dt.Columns.Add("LAO_GROUP");
            dt.Columns.Add("NIVEL1");
            dt.Columns.Add("NIVEL2");
            dt.Columns.Add("Penetracion");
  
        }

        private void rdPaisPR_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
          
            cbPaisPR.Enabled = true;
            cbSecPR.Enabled = true;
            calc.cargarDesde(cbSecPR);
            calc.cargarPais(cbPaisPR);
        }

        private void rdDistPR_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

            cbDistPR.Enabled = true;
            cbPaisPR.Enabled = true;
            cbSecPR.Enabled = true;
            calc.cargarDesde(cbSecPR);
            calc.cargarPais(cbPaisPR);
        }

        private void cbPaisPR_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp;
            if (rdPaisPR.IsChecked == true)
            {
                cbDistPR.Enabled = false;
            }
            else if (rdDistPR.IsChecked == true)
            {
                if (flag)
                {
                    cbDistPR.Enabled = true;
                    temp=Convert.ToString(cbPaisPR.SelectedValue);
                    calc.cargarDistribuidor(temp, cbDistPR, 2);
                }
                flag = true;
            }
        }

        private void cbPaisPP_SelectedValueChanged(object sender, EventArgs e)
        {
            string temp;
            if (rdPaisPP.IsChecked == true)
            {
                cbDistPP.Enabled = false;
            }
            else if (rdDistPP.IsChecked == true)
            {
                if (flag1)
                {
                    cbDistPP.Enabled = true;
                    temp = Convert.ToString(cbPaisPP.SelectedValue);
                    calc.cargarDistribuidor(temp, cbDistPP, 2);
                }
                flag1 = true;
            }

        }

        private void rdPaisPP_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

  
            cbPaisPP.Enabled = true;
            cbSecPP.Enabled = true;
            calc.cargarDesde(cbSecPP);
            calc.cargarPais(cbPaisPP);

        }

        private void rdDistPP_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

            cbDistPP.Enabled = true;
            cbPaisPP.Enabled = true;
            cbSecPP.Enabled = true;
            calc.cargarDesde(cbSecPP);
            calc.cargarPais(cbPaisPP);
        }

        private void btProcesarOP_Click(object sender, EventArgs e)
        {
            gridRP.Columns.Clear();
            string secs = cbSecPR.SelectedItem.Text;
            string ps = Convert.ToString(cbPaisPR.SelectedValue);
            int sec = Convert.ToInt32(secs);
            string cod = Convert.ToString(cbDistPR.SelectedValue);
            calc.Calculo_Recuperados(ps,sec,cod,cbDistPR.SelectedText,listRecuperado,gridRP);

            gridRP.Visible = true;
        }

        private void btProcesarPP_Click(object sender, EventArgs e)
        {
          
            string ps =Convert.ToString(cbPaisPP.SelectedValue);
            int sec=Convert.ToInt32(cbSecPP.SelectedItem.Text);
            string cod=Convert.ToString(cbDistPP.SelectedValue);
            calc.Calculo_Penetrados(ps, sec, cod, cbDistPR.SelectedText, listResumen, gridPN,dt);
           // calc.Calculo_Penetrados_2(ps, sec, cod, cbDistPR.SelectedText, listResumen, gridPN, dt);
            gridPN.Visible = true;
            
        }

    }
}
