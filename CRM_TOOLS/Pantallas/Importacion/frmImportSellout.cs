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
using System.Windows.Forms;

using System.Threading;


namespace CRM_TOOLS.Pantallas
{
    public partial class frmImportSellout : Telerik.WinControls.UI.RadForm
    {
        private bool isProcessRunning = false;
        CRMToolEntities Entity = new CRMToolEntities();
        private WinWait_cs _wait;

         #region Variable
        int cont = 0, contCli = 0, contDis = 0, contPs = 0, contPro = 0, secuencia2;
       int secuencia;
        string codDist,codigo,pais;
        string codclic;
        string codcli;
        string nomcli;
        string coddist;
        string nomdist;
        string codv;
        string NomV;
        string Descp;
        string codP;
        string codS;
        int anio;
        int mes;
        int sec;
        string dia;
        string fecha;
        double bultos;
        decimal vtas;
        decimal moneda;
        bool verCN=false;
        bool verPN=false;
        bool verDN=false;
        bool verPaN=false;
        string paises;
        bool ver=false;
        string Expre;
        //string msgNuevos="Clientes Nuevos: " + 0;
        //string msgModificar="Clientes Modificados: " + 0;
        //int contN = 0;
        //int contM = 0;
        //bool verN=false;
        int tick=0;
        #endregion

        public frmImportSellout()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Meses y Distribuidores a Importar \n";

                for (int i = 0; i < gridSellout.RowCount; i++)
                {

                    secuencia = Convert.ToInt32(gridSellout.Rows[i].Cells[1].Value);
                    codDist = Convert.ToString(gridSellout.Rows[i].Cells[7].Value);
                    var query = from qr in Entity.SELLOUT
                                where qr.CODIGO_DISTRIBUIDOR == codDist && qr.SECUENCIA_MES == secuencia
                                group qr by qr.CODIGO_DISTRIBUIDOR into g 
                                select g;
                        foreach(var rw in query){
                        msg = secuencia + " - " + rw.Key + "\n";
                        listDist.Items.Add(msg);
                                        }
                   
                    }
                }
      
            catch
            {
            }
            btProcesar.Enabled = true;
        }

        private void btProcesar_Click(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i < gridSellout.RowCount; i++)
                {


                    secuencia2 = Convert.ToInt32(gridSellout.Rows[i].Cells[1].Value);
                    codigo = Convert.ToString(gridSellout.Rows[i].Cells[6].Value);
                    pais = Convert.ToString(gridSellout.Rows[i].Cells[5].Value);

                    var query = (from sell in Entity.SELLOUT
                                 where sell.SECUENCIA_MES == secuencia2 && sell.CODIGO_DISTRIBUIDOR == codigo && sell.ID_COUNTRY == pais
                                 select sell).FirstOrDefault();


                    // Entity.DeleteObject(query);
                 
                    Entity.SELLOUT.Attach(query);
                    Entity.SELLOUT.DeleteObject(query);
                    if (Entity != null)
                    Entity.SaveChanges();

                }
            }catch
            {
            }
            MessageBox.Show("Registro Anteriores Eliminados!!!");
            btTransferir.Enabled = true;
        }

        private void gridSellout_KeyDown(object sender, KeyEventArgs e)
        {
          
           // WinWait_cs wait = new WinWait_cs();
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

                        }


                        IsFirstPass = false;
                    }
                    else
                    {

                        //Esperar();
                        DataRow newRow = table_Local.NewRow();
                        newRow.ItemArray = cells;
                        table_Local.Rows.Add(newRow);
                                 
                        gridSellout.DataSource = table_Local;
                        txtCantReg.Text = Convert.ToString(table_Local.Rows.Count);
                        btVerificar.Enabled = true;
                    
                    }
                }
                //this.gridCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(dgData_KeyDown);
            }
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            try
            {
               for (int i = 0; i < gridSellout.RowCount; i++)
                {

                    codclic = (string)gridSellout.Rows[i].Cells[10].Value;
                    codcli = (string)gridSellout.Rows[i].Cells[8].Value;
                    nomcli = (string)gridSellout.Rows[i].Cells[9].Value;
                    coddist = (string)gridSellout.Rows[i].Cells[6].Value;
                    nomdist = (string)gridSellout.Rows[i].Cells[7].Value;
                    codv = (string)gridSellout.Rows[i].Cells[11].Value;
                    NomV = (string)gridSellout.Rows[i].Cells[12].Value;

                    Descp = (string)gridSellout.Rows[i].Cells[15].Value;
                    codS = (string)gridSellout.Rows[i].Cells[14].Value;
                    codP = (string)gridSellout.Rows[i].Cells[13].Value;
                    paises = (string)gridSellout.Rows[i].Cells[5].Value;

                    anio = Convert.ToInt32(gridSellout.Rows[i].Cells[0].Value);
                    mes = Convert.ToInt32(gridSellout.Rows[i].Cells[2].Value);
                    sec = Convert.ToInt32(gridSellout.Rows[i].Cells[1].Value);
                    dia = (string)gridSellout.Rows[i].Cells[3].Value;
                    fecha = Convert.ToString(gridSellout.Rows[i].Cells[4].Value);

                    bultos = Convert.ToDouble(gridSellout.Rows[i].Cells[16].Value);
                    vtas = Convert.ToDecimal(gridSellout.Rows[i].Cells[17].Value);
                    moneda = Convert.ToDecimal(gridSellout.Rows[i].Cells[18].Value);

                    GuardarProductosEquivalente(codS, codS, Descp, coddist,paises);
                    GuardarProductos(codS, codS, Descp);
                    GuardarClientes(codclic, codcli, nomcli, coddist, nomdist, codv, NomV, paises);
                    GuardarDistribuidor(coddist, nomdist, paises);
                    GuardarPais(paises);

                    GuardarSellout(anio, sec, mes, paises, coddist, nomdist, codcli, nomcli, codclic, codv, NomV, codP, codS, Descp, bultos, vtas, moneda);

                 
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
             MessageBox.Show("Transferencia de Sellout Exitosa!!!", "SELLOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
             ListResumen.Visible = true;
             listFecha.Visible = true;
      
             ListResumen.Items.Add(ContadorReg(contPs, "Pais"));
             ListResumen.Items.Add(ContadorReg(contCli, "Cliente"));
             ListResumen.Items.Add(ContadorReg(contPro, "Productos"));
             ListResumen.Items.Add(ContadorReg(contDis, "Distribuidor"));
             ListResumen.Items.Add(ContadorReg(cont, "Sellout"));

             listFecha.Items.Add(GetFecha(paises));

        }

   

        #region CLASS SAVE
         public void GuardarClientes(string codclic, string codcli, string nomcli, string coddist, string nomdist, string codv, string NomV,string pais)
        {
           
            CLIENTES cl = new CLIENTES();



            var query = (from cli in Entity.CLIENTES
                         where cli.CODIGO_CLIENTE_COMPUESTO == codclic && cli.CODIGO_CLIENTE == codcli
                         select cli);



            foreach (var row in query)
            {

                if (row.CODIGO_CLIENTE_COMPUESTO == codclic && row.CODIGO_CLIENTE == codcli)
                {
                    row.CODIGO_VENDEDOR = codv;
                    row.CODIGO_DISTRIBUIDOR = coddist;
                    row.NOMBRE_VENDEDOR = NomV;
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

                cl.CODIGO_CLIENTE_COMPUESTO = codclic;
                cl.CODIGO_CLIENTE = codcli;
                cl.CODIGO_VENDEDOR = codv;
                cl.CODIGO_DISTRIBUIDOR = coddist;
                cl.NOMBRE_VENDEDOR = NomV;
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
                        //row.CODIGO_MATERIAL = codPro;
                        //row.CODIGO_CORTO = codSap;
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

         public void GuardarProductosEquivalente(string codPro, string codSap, string Desc,string codDist,string ps)
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

         public void GuardarDistribuidor(string codD, string nomD, string codPais)
        {
           
            DISTRIBUIDORES dis = new DISTRIBUIDORES();

            try
            {

                var query = (from d in Entity.DISTRIBUIDORES
                             where d.CODIGO_DISTRIBUIDOR == codD
                             select d);

                foreach (var row in query)
                {

                    if (row.CODIGO_DISTRIBUIDOR == codD)
                    {
                        row.CODIGO_DISTRIBUIDOR = codD;
                        row.NOMBRE_DISTRIBUIDOR = nomD;
                        row.PAIS = codPais;

                        ver = true;


                        break;
                    }


                }

                if (ver == false)
                {
                    dis.CODIGO_DISTRIBUIDOR = codD;
                    dis.NOMBRE_DISTRIBUIDOR = nomD;
                    dis.PAIS = codPais;


                    contDis++;
                    Entity.DISTRIBUIDORES.AddObject(dis);
                    verDN = true;

                }


                ver = false;
                if (verDN == true)
                {
                    btDistribuidor.Visible = true;
                }
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

         public void GuardarSellout(int anio, int sec, int mes, string pais, string coddist, string nomdist, string codcli, string nomcli, string codclic ,string codv, string nomv, string codP, string codS, string nomP, double bulto,decimal vta,decimal moneda)
        {
           
            SELLOUT sell = new SELLOUT();
      
             
            try
            {
                sell.CODIGO_CLIENTE_COMPUESTO = codclic;
                sell.CODIGO_CLIENTE = codcli;
                sell.CODIGO_VENDEDOR = codv;
                sell.CODIGO_DISTRIBUIDOR = coddist;
                sell.NOMBRE_VENDEDOR = NomV;
                sell.NOMBRE_CLIENTE = nomcli;
                sell.MES = mes;
                sell.ANIO = anio;
                sell.SECUENCIA_MES = sec;
                sell.BULTOS = (float)(bulto);
                sell.VENTA_DOLARES = Convert.ToDecimal(vta);
                sell.VENTA_MONEDA_LOCAL = Convert.ToDecimal(moneda);
                sell.CODIGO_PRODUCTO_DISTRIBUIDOR = codP;
                sell.CODIGO_PRODUCTOS_SAP = codS.Remove(0, 10);
                sell.ID_COUNTRY = pais;
                sell.FECHA = Convert.ToDateTime(fecha);

                cont++;
               
                Entity.AddToSELLOUT(sell);
              
                txtReg.Text = Convert.ToString(cont);
              
            }
            catch
            {
            }
            Entity.SaveChanges();
       

         

        }
         #endregion

     void Esperar()
         {
             if (isProcessRunning)
             {
                MessageBox.Show("El Proceso esta ejecucion.");
                 return;
             }

    
             WinWait_cs progressDialog = new WinWait_cs();

   
             Thread backgroundThread = new Thread(
                 new ThreadStart(() =>
                 {
                     isProcessRunning = true;

                     progressDialog.SetIndeterminate(true);

                     Thread.Sleep(10);

                     //MessageBox.Show("Thread completed!");

                     if (progressDialog.InvokeRequired)
                         progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));

                     isProcessRunning = false;
                 }
             ));

             backgroundThread.Start();

             progressDialog.ShowDialog();
         }

        string ContadorReg(int x,string name)
         {

             if (name == "Cliente")
             {
                 Expre = "Clientes Nuevos: " + x;
             }
             else if(name == "Sellout")
             {
                 Expre="Registro Sellout Nuevos: "+ x;
             }
             else if (name == "Productos")
             {
                 Expre = "Productos Nuevos: " + x;
             }
             else if (name == "Distribuidor")
             {
                 Expre = "Distribuidores Nuevos: " + x;
             }
             else if (name == "Pais")
             {
                 Expre = "Paises Nuevos: " + x;
             }

             return Expre;
         }

        void Wait()
         {
             if (_wait != null && !_wait.IsDisposed)
             {
                 return;
             }

             _wait = new WinWait_cs();
             _wait.Text="Cargando Data.  Porfavor Espere..."; 
             _wait.TopMost = true;
             _wait.StartPosition = FormStartPosition.CenterScreen;
             _wait.Show();
             _wait.Refresh();
                        
             System.Threading.Thread.Sleep(50);
            
         }

        string GetFecha(string codps)
         {
             string temp;
             var query = (from x in Entity.SELLOUT
                         where x.ID_COUNTRY == codps
                         group x by x.FECHA into g
                         select new {
                           id=g.Max(t=> t.FECHA)
                           }).FirstOrDefault();
             temp = query.id.ToString();
             return temp.Remove(9,12);
         }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Mante_Clientes cli = new Mante_Clientes();
            cli.Show();
        }

        private void btProducto_Click(object sender, EventArgs e)
        {
            Mante_Productos pro = new Mante_Productos();
            pro.Show();
        }

        private void btDistribuidor_Click(object sender, EventArgs e)
        {
            Mante_Distribuidor dis = new Mante_Distribuidor();
            dis.Show();
        }

        private void btPais_Click(object sender, EventArgs e)
        {
            Mante_Paises ps = new Mante_Paises();
            ps.Show();
        }

        private void gridSellout_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //WinWait_cs wait = new WinWait_cs();
            //gridSellout.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
         
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
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

                        }


                        IsFirstPass = false;
                    }
                    else
                    {


                        DataRow newRow = table_Local.NewRow();
                        newRow.ItemArray = cells;
                        table_Local.Rows.Add(newRow);
                        // dgData.DataSource = table_Local;

                        Wait();
                        gridSellout.DataSource = table_Local;
                        txtCantReg.Text = Convert.ToString(table_Local.Rows.Count);
                        btVerificar.Enabled = true;

                    }
                }

            }
        }

    }

  
       
    }
