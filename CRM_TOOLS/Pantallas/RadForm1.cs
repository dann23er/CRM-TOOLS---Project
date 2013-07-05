using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using CRM_TOOLS.Pantallas.Calculos;
using CRM_TOOLS.Pantallas.Importacion;
using CRM_TOOLS.Pantallas.Mantenimiento;


namespace CRM_TOOLS.Pantallas
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        #region Variables
        private frmImportSellin SI;
        private frmImportSellout IS;
        private frmImportCliente IC;
        private Calc_ABC cabc;
        private Calc_Oportunidades cop;
        private Calc_KPI ckpi;
        private Mante_Clientes MC;
        private Mante_Plataformas Pl;
        private Mante_Productos P;
        private Mante_ProductoEquivalente PE;
        private Mante_AgruparProducto AP;
        private Mante_Distribuidor D;
        private Mante_KAM K;
        private Mante_Paises Ps;
        private Mante_Segmentos S;
        private Mante_NuevoSegmento NS;
        private Mante_Conglomerado C;
        private Mante_CuentasGlobales CG;
        private frmMKTtool MT;
        private frmListaRoles RL;
        private frmListaPrivilegios PV;
        private frmListaUsuario LU;
        private RegistroUsuario RU;
        #endregion


        public RadForm1()
        {
            InitializeComponent();
          
          
        }


        #region Menu
        private void radMenuIS_Click(object sender, EventArgs e)
        {
            if(IS==null){
            IS = new frmImportSellout();
            IS.MdiParent = this;
            IS.FormClosed += delegate { IS = null; };
            IS.Show();
               
            }
            else
            {

                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuIC_Click(object sender, EventArgs e)
        {
           if(IC==null){
            IC = new frmImportCliente();
            IC.MdiParent = this;
            IC.FormClosed += delegate { IC = null; };
            IC.Show();
               
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
                
            }
        }

        private void radMenuCABC_Click(object sender, EventArgs e)
        {
            if (cabc == null)
            {
                cabc = new Calc_ABC();
                cabc.MdiParent = this;
                cabc.FormClosed += delegate { cabc = null; };
                cabc.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuCOP_Click(object sender, EventArgs e)
        {
            if(cop==null){
            cop = new Calc_Oportunidades();
            cop.MdiParent = this;
            cop.FormClosed += delegate { cop = null; };
            cop.Show();
            }else{
            MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }

        }

        private void radMenuCKPI_Click(object sender, EventArgs e)
        {
            if (ckpi == null)
            {
                ckpi = new Calc_KPI();
                ckpi.MdiParent = this;
                ckpi.FormClosed += delegate { ckpi = null; };
                ckpi.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuCliente_Click(object sender, EventArgs e)
        {
            if (MC == null)
            {
                MC = new Mante_Clientes();
                MC.MdiParent = this;
                MC.FormClosed += delegate { MC = null; };
                MC.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuAC_Click(object sender, EventArgs e)
        {
            if (Pl == null)
            {
                Pl = new Mante_Plataformas();
                Pl.MdiParent = this;
                Pl.FormClosed += delegate { Pl = null; };
                Pl.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuMP_Click(object sender, EventArgs e)
        {
            if (P == null)
            {
                P = new Mante_Productos();
                P.MdiParent = this;
                P.FormClosed += delegate { P = null; };
                P.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuPE_Click(object sender, EventArgs e)
        {
            if (PE == null)
            {
                PE = new Mante_ProductoEquivalente();
                PE.MdiParent = this;
                PE.FormClosed += delegate { PE = null; };
                PE.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuAP_Click(object sender, EventArgs e)
        {
            if (AP == null)
            {
                AP = new Mante_AgruparProducto();
                AP.MdiParent = this;
                AP.FormClosed += delegate { AP = null; };
                AP.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuDist_Click(object sender, EventArgs e)
        {
            if (D == null)
            {
                D = new Mante_Distribuidor();
                D.MdiParent = this;
                D.FormClosed += delegate { D = null; };
                D.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuK_Click(object sender, EventArgs e)
        {
            if (K == null)
            {
                K = new Mante_KAM();
                K.MdiParent = this;
                Pl.FormClosed += delegate { Pl = null; };
                K.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuPais_Click(object sender, EventArgs e)
        {
            if (Ps == null)
            {
                Ps = new Mante_Paises();
                Ps.MdiParent = this;
                Ps.FormClosed += delegate { Ps = null; };
                Ps.Show();
            }
        }

        private void radMenuSeg_Click(object sender, EventArgs e)
        {
            if (S == null)
            {
                S = new Mante_Segmentos();
                S.MdiParent = this;
                S.FormClosed += delegate { S = null; };
                S.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuNS_Click(object sender, EventArgs e)
        {
            if (NS == null)
            {
                NS = new Mante_NuevoSegmento();
                NS.MdiParent = this;
                NS.FormClosed += delegate { NS = null; };
                NS.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuConglo_Click(object sender, EventArgs e)
        {
            if (C == null)
            {
                C = new Mante_Conglomerado();
                C.MdiParent = this;
                C.FormClosed += delegate { C = null; };
                C.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuCG_Click(object sender, EventArgs e)
        {
            if (CG == null)
            {
                CG = new Mante_CuentasGlobales();
                CG.MdiParent = this;
                CG.FormClosed += delegate { CG = null; };
                CG.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuSellin_Click(object sender, EventArgs e)
        {

            if (SI == null)
            {
                SI = new frmImportSellin();
                SI.MdiParent = this;
                SI.FormClosed += delegate { SI = null; };
                SI.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }

        }

        private void radMenuMKT_Click(object sender, EventArgs e)
        {
            if (MT == null)
            {
                MT = new frmMKTtool();
                MT.MdiParent = this;
                MT.FormClosed += delegate { MT = null; };
                MT.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            RadForm1 form = new RadForm1();
            //this.Close();
            this.Hide();
            
            Login lg = new Login();
            lg.Show();
        }


        private void radMenuRol_Click(object sender, EventArgs e)
        {
            if (RL == null)
            {
                RL = new frmListaRoles();
                RL.MdiParent = this;
                RL.FormClosed += delegate { RL = null; };
                RL.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuPrivilegio_Click(object sender, EventArgs e)
        {
            if (PV == null)
            {
                PV = new frmListaPrivilegios();
                PV.MdiParent = this;
                PV.FormClosed += delegate { PV = null; };
                PV.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        private void radMenuUser_Click(object sender, EventArgs e)
        {
            if (LU == null)
            {
                LU = new frmListaUsuario();
                LU.MdiParent = this;
                LU.FormClosed += delegate { LU = null; };
                LU.Show();
            }
            else
            {
                MessageBox.Show("Ya esta Abierta la Ventana!!!");
            }
        }

        #endregion



    }
}
