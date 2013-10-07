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
using Telerik.WinControls.UI;

namespace CRM_TOOLS.Pantallas.Importacion
{
    public partial class frmImportSellin : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();

        #region Variable
        int cont = 0, contCli = 0, contDis = 0, contPs = 0, contPro = 0;
        string concepto;
        string tipo;
        string codcli,codigo;
        string nomcli;
        string coddist;
        string nomdist;
        string codpro;
        string nompro;
        string netsales;
        int salescase;
        int  opencase;
        int anio,mes,mesdel;
        int forescase;
        bool verCN = false;
        bool verPN = false;
        bool verDN = false;
        bool verPaN = false;
        string Expre;
        bool ver = false;
        string pais;
        #endregion
  
        public frmImportSellin()
        {
            InitializeComponent();
        }

        private void dgData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {

                DataTable table_Local = new DataTable();


                string s = Clipboard.GetText();
                string[] lines = s.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);


                bool IsFirstPass = true;

                foreach (string line in lines)
                {

                    string[] cells = line.Split('\t');


                    if (IsFirstPass)
                    {
                        foreach (string value in cells)
                        {
                            table_Local.Columns.Add(value);
                            gridSellin.DataSource = table_Local;
                        }

                        //
                        IsFirstPass = false;
                    }
                    else
                    {
                        DataRow newRow = table_Local.NewRow();
                        newRow.ItemArray = cells;
                        table_Local.Rows.Add(newRow);
                        // dgData.DataSource = table_Local;
                      gridSellin.DataSource = table_Local;
                    }
                }
            }


        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Meses y Distribuidores a Importar \n";
                var query = from qr in Entity.SELLIN
                            group qr by new { qr.CONCEPTO, qr.ANIO, qr.MES } into g
                            select new {
                                g.Key.CONCEPTO,
                                g.Key.ANIO,
                                g.Key.MES
                            };
                foreach (var rw in query)
                {
                    msg = rw.CONCEPTO + " - " + rw.ANIO + " - "+rw.MES + "\n";
                    listDist.Items.Add(msg);
                }
            }

            catch
            {
            }
            btProcesar.Enabled = true;
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridSellin.RowCount; i++)
                {

                    concepto = (string)gridSellin.Rows[i].Cells[0].Value;
                    tipo = (string)gridSellin.Rows[i].Cells[1].Value;
                    anio = Convert.ToInt32(gridSellin.Rows[i].Cells[2].Value);
                    mes = Convert.ToInt32(gridSellin.Rows[i].Cells[3].Value);
                    coddist = (string)gridSellin.Rows[i].Cells[4].Value;
                    nomdist = (string)gridSellin.Rows[i].Cells[5].Value;
                    codcli = (string)gridSellin.Rows[i].Cells[6].Value;
                    nomcli = (string)gridSellin.Rows[i].Cells[7].Value;
                    codpro = (string)gridSellin.Rows[i].Cells[8].Value;
                    nompro = (string)gridSellin.Rows[i].Cells[9].Value;
                    netsales = (string)gridSellin.Rows[i].Cells[10].Value;
                    salescase = Convert.ToInt32(gridSellin.Rows[i].Cells[11].Value);
                    opencase = Convert.ToInt32(gridSellin.Rows[i].Cells[12].Value);
                    forescase = Convert.ToInt32(gridSellin.Rows[i].Cells[13].Value);
                    pais =(string)gridSellin.Rows[i].Cells[14].Value;

                    GuardarProductosEquivalente(codpro,codpro,nompro, coddist, pais);
                    GuardarProductos(codpro, codpro, nompro);
                    GuardarClientes(codcli, nomcli, coddist, nomdist,pais);
                    GuardarPais(pais);
                    GuardarSellin(concepto,anio, mes, pais, codcli, nomcli, codpro, nompro,netsales, salescase, opencase,forescase);


                }

                /* DataTable dt = gridSellout.DataSource as DataTable;
                 // foreach (int i = 0; i < ;i++ )
                  //{
                 MessageBox.Show(dt.Rows.Count.ToString());
                  //}*/


            }
            catch
            {

            }
            MessageBox.Show("Transferencia de Sellin Exitosa!!!", "SELLIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListResumen.Visible = true;
           

            ListResumen.Items.Add(ContadorReg(contPs, "Pais"));
            ListResumen.Items.Add(ContadorReg(contCli, "Cliente"));
            ListResumen.Items.Add(ContadorReg(contPro, "Productos"));
            ListResumen.Items.Add(ContadorReg(cont, "Sellin"));

        

        }

        private void btProcesar_Click(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i < gridSellin.RowCount; i++)
                {


                    mes = Convert.ToInt32(gridSellin.Rows[i].Cells[2].Value);
                    codigo = Convert.ToString(gridSellin.Rows[i].Cells[4].Value);
                    pais = Convert.ToString(gridSellin.Rows[i].Cells[14].Value);

                    var query = (from sell in Entity.SELLIN
                                 where sell.MES == mesdel && sell.CODIGO_CLIENTE == codigo && sell.ID_COUNTRY == pais
                                 select sell).FirstOrDefault();


                    // Entity.DeleteObject(query);

                    Entity.SELLIN.Attach(query);
                    Entity.SELLIN.DeleteObject(query);
                    if (Entity != null)
                        Entity.SaveChanges();

                }
            }
            catch
            {
            }
            MessageBox.Show("Registro Anteriores Eliminados!!!");
            btTransferir.Enabled = true;
        }

        string ContadorReg(int x, string name)
        {

            if (name == "Cliente")
            {
                Expre = "Clientes Nuevos: " + x;
            }
            else if (name == "Sellin")
            {
                Expre = "Registro Sellin Nuevos: " + x;
            }
            else if (name == "Productos")
            {
                Expre = "Productos Nuevos: " + x;
            }
           
            else if (name == "Pais")
            {
                Expre = "Paises Nuevos: " + x;
            }

            return Expre;
        }

        #region CLASS SAVE
        public void GuardarClientes( string codcli, string nomcli, string coddist, string nomdist, string pais)
        {

            CLIENTES cl = new CLIENTES();



            var query = (from cli in Entity.CLIENTES
                         where cli.CODIGO_CLIENTE == codcli
                         select cli);



            foreach (var row in query)
            {

                if (row.CODIGO_CLIENTE == codcli)
                {
             
                    row.CODIGO_DISTRIBUIDOR = coddist;
             
                    row.NOMBRE_CLIENTE = nomcli;
                    row.NOMBRE_DISTRIBUIDOR = nomdist;



                    row.ID_COUNTRY = pais;
                    row.FECHA_ACTUALIZACION = DateTime.Now;
                    ver = true;


                    break;
                }


            }

            if (ver == false)
            {

                cl.CODIGO_CLIENTE_COMPUESTO = pais + "/" + coddist + " /" + codcli;
                cl.CODIGO_CLIENTE = codcli;
             
                cl.CODIGO_DISTRIBUIDOR = coddist;
                cl.NOMBRE_CLIENTE = nomcli;
                cl.NOMBRE_DISTRIBUIDOR = nomdist;

                cl.ID_COUNTRY = pais;
                cl.STATUS_CLIENTE = false;
                cl.AGRUPAR = false;
                cl.FECHA_ACTUALIZACION = DateTime.Now;
                cl.FECHA_CREACION = DateTime.Now;
                contCli++;
                Entity.CLIENTES.AddObject(cl);
                verCN = true;

            }
            if (verCN == true)
            {
                btCliente.Visible = true;
            }

            ver = false;

            Entity.SaveChanges();

        }

        public void GuardarProductos(string codPro, string codSap, string Desc)
        {

            PRODUCTOS pro = new PRODUCTOS();
            try
            {

                var query = (from prod in Entity.PRODUCTOS

                             select prod);

                foreach (var row in query)
                {

                    if (row.CODIGO_MATERIAL == codPro)
                    {
                     
                        row.DESCRIPCION = Desc;
                        row.FACTOR_GSU = 1;

                        ver = true;

                        // break;
                    }


                }

                if (ver == false)
                {
                    pro.CODIGO_MATERIAL = codPro;
                    pro.CODIGO_CORTO = codSap.Remove(0, 10);
                    pro.DESCRIPCION = Desc;
                    pro.NIVEL1 = "";
                    pro.LAO_GROUP = "";
                    pro.STRATEGIC_GROUP = "";
                    contPro++;
                    Entity.PRODUCTOS.AddObject(pro);
                    verPN = true;

                }


                ver = false;
                if (verPN == true)
                {
                    btProducto.Visible = true;
                }
            }
            catch
            {

            }
            Entity.SaveChanges();

        }

        public void GuardarProductosEquivalente(string codPro, string codSap, string Desc, string codDist, string ps)
        {

            PRODUCTOS_EQUIVALENTES pro = new PRODUCTOS_EQUIVALENTES();
            try
            {

                var query = from prod in Entity.PRODUCTOS_EQUIVALENTES
                            select prod;

                foreach (var row in query)
                {

                    if (row.CODIGO_PRODUCTO_DISTRIBUIDOR == codPro)
                    {

                        row.DESCRIPCION_PRODUCTO_DISTR = Desc;
                        row.CANTIDAD = 0;
                        row.TIPO_MEDIDA = "";
                        row.VALOR = 0;
                        row.VC = 0;

                        ver = true;

                        // break;
                    }

                }

                if (ver == false)
                {
                    pro.CODIGO_PRODUCTO_DISTRIBUIDOR = codPro;
                    pro.CODIGO_PRODUCTO_SAP = codSap.Remove(0, 10);
                    pro.DESCRIPCION_PRODUCTO_DISTR = Desc;
                    pro.CODIGO_DISTRIBUIDOR = codDist;
                    pro.ID_COUNTRY = ps;
                    pro.CANTIDAD = 0;
                    pro.TIPO_MEDIDA = "";
                    pro.VALOR = 0;
                    pro.VC = 0;
                    Entity.PRODUCTOS_EQUIVALENTES.AddObject(pro);
                    verPN = true;

                }


                ver = false;

            }
            catch
            {

            }
            Entity.SaveChanges();

        }

        public void GuardarPais(string codP)
        {

            PAISES pais = new PAISES();
            try
            {

                var query = (from p in Entity.PAISES
                             where p.ID_COUNTRY == codP
                             select p);

                foreach (var row in query)
                {

                    if (row.ID_COUNTRY == codP)
                    {
                        row.ID_COUNTRY = codP;


                        ver = true;


                        break;
                    }


                }

                if (ver == false)
                {
                    pais.ID_COUNTRY = codP;

                    contPs++;
                    Entity.PAISES.AddObject(pais);
                    verPaN = true;

                }


                ver = false;
                if (verPaN == true)
                {
                    btPais.Visible = true;
                }

            }
            catch
            {
            }
            Entity.SaveChanges();
        }

        public void GuardarSellin(string concept,int anio, int mes, string pais, string codcli, string nomcli, string codpro, string nompro, string net, int sale, int open, int fores)
        {

            SELLIN sell = new SELLIN();


            try
            {
                sell.CONCEPTO=concept;
                sell.CODIGO_CLIENTE = codcli;
                sell.NOMBRE_CLIENTE_FINAL = nomcli;
                sell.MES = mes;
                sell.ANIO = anio;
                sell.CODIGO_PRODUCTO_SAP = codpro;//codS.Remove(0, 10);
                sell.NOMBRE_PRODUCTO = nompro;
                sell.NETSALES_US = net;
                sell.SALES_CASES_US = sale;
                sell.OPEN_US = open;
                sell.FORECAST_US = fores;
                sell.ID_COUNTRY = pais;

          

                cont++;

                Entity.AddToSELLIN(sell);

        

            }
            catch
            {
            }
            Entity.SaveChanges();




        }
        #endregion
    }
}
