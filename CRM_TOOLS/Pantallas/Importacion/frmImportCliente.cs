using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using CRM_TOOLS.Clases;
using System.Linq;
using DataAccess;


namespace CRM_TOOLS.Pantallas
{
    public partial class frmImportCliente : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        #region Variable
        string codclic;
        string codcli;
        string nomcli;
        string coddist;
        string nomdist;
        string codv;
        string NomV;
        string dir;
        string ciu;
        string tel;
        string cedj;
        string nomcon;
        string nomcom;
        int cods;
        string s;
        string pais;
        bool ver=false;
        string msgNuevos="Clientes Nuevos: " + 0;
        string msgModificar="Clientes Modificados: " + 0;
        int contN = 0;
        int contM = 0;
        bool verN=false;
        int tick=0;
        #endregion

        public frmImportCliente()
        {
            InitializeComponent();
        }
                                  

        private void dgData_KeyDown(object sender, KeyEventArgs e)
{
      if(e.Control && e.KeyCode == Keys.V)
      {
       
        DataTable table_Local = new DataTable();

      
        string s = Clipboard.GetText();
        string[] lines = s.Split(new char[2] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

      
        bool IsFirstPass = true; 
        
        foreach (string line in lines)
        {
       
          string[] cells = line.Split('\t');
          
        
          if (IsFirstPass)
          {
            foreach (string value in cells)
            { 
                table_Local.Columns.Add(value);
                dgData.DataSource = table_Local;
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
            gridCliente.DataSource = table_Local;
          }         
        }
      }

 
}

        private void gridCliente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           // s = (KeyEventArgs)e;
          

          /* if (e.Control && e.KeyCode == Keys.V)
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
                        gridCliente.DataSource = table_Local;
                    }
                }
            */

        }

        private void gridCliente_KeyDown(object sender, KeyEventArgs e)
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

                        }


                        IsFirstPass = false;
                    }
                    else
                    {


                        DataRow newRow = table_Local.NewRow();
                        newRow.ItemArray = cells;
                        table_Local.Rows.Add(newRow);
                        // dgData.DataSource = table_Local;
                        gridCliente.DataSource = table_Local;
                    }
                }
                //this.gridCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(dgData_KeyDown);
            }
        }

        private void gridCliente_KeyUp(object sender, KeyEventArgs e)
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

                        }


                        IsFirstPass = false;
                    }
                    else
                    {


                        DataRow newRow = table_Local.NewRow();
                        newRow.ItemArray = cells;
                        table_Local.Rows.Add(newRow);
                        // dgData.DataSource = table_Local;
                        gridCliente.DataSource = table_Local;
                    }
                }
                //this.gridCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(dgData_KeyDown);
            }
        }

        private void btProcesar_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < gridCliente.RowCount; i++)
            {
          
            
                codclic=(string)gridCliente.Rows[i].Cells[0].Value;
                codcli=(string)gridCliente.Rows[i].Cells[1].Value;
                nomcli=(string)gridCliente.Rows[i].Cells[2].Value;
                coddist=(string)gridCliente.Rows[i].Cells[3].Value;
                nomdist=(string)gridCliente.Rows[i].Cells[4].Value;
                codv=(string)gridCliente.Rows[i].Cells[5].Value;
                NomV=(string)gridCliente.Rows[i].Cells[6].Value;
                dir=(string)gridCliente.Rows[i].Cells[7].Value;
                ciu=(string)gridCliente.Rows[i].Cells[8].Value;
                tel=(string)gridCliente.Rows[i].Cells[9].Value;
                cedj=(string)gridCliente.Rows[i].Cells[10].Value;
                nomcon=(string)gridCliente.Rows[i].Cells[11].Value;
                nomcom=(string)gridCliente.Rows[i].Cells[12].Value;
                cods=Convert.ToInt32(gridCliente.Rows[i].Cells[13].Value);
                s=(string)gridCliente.Rows[i].Cells[14].Value;
                pais = (string)gridCliente.Rows[i].Cells[15].Value;

                GuardarClientes(codclic, codcli, nomcli, coddist, nomdist, codv, NomV, dir, ciu, tel, cedj, nomcon, nomcom, cods, s, pais);
                //MessageBox.Show("Clientes Agregados Exitosamente!!!");
              
            }

               
        }

        public void GuardarClientes(string codclic,string codcli,string nomcli,string coddist,string nomdist,string codv,string NomV,string dir,string ciu,string tel,string cedj,string nomcon, string nomcom,int cods, string s,string pais)
        {
            CLIENTES cl = new CLIENTES();
         
           
 
            var query = (from cli in Entity.CLIENTES
                         where cli.CODIGO_CLIENTE_COMPUESTO==codclic && cli.CODIGO_CLIENTE==codcli
                         select cli);
            
            
        
            foreach (var row in query)
            {

                if (row.CODIGO_CLIENTE_COMPUESTO == codclic && row.CODIGO_CLIENTE==codcli)
                {
                    row.CODIGO_VENDEDOR = codv;
                    row.CODIGO_DISTRIBUIDOR = coddist;
                    row.NOMBRE_VENDEDOR = NomV;
                    row.NOMBRE_CLIENTE = nomcli;
                    row.NOMBRE_DISTRIBUIDOR = nomdist;
                    row.CIUDAD = ciu;
                    row.DIRECCION = dir;
                    row.TELEFONO_CLIENTE = tel;
                    row.CEDULA_JURIDICA = cedj;
                    row.NOMBRE_CONTACTO = nomcon;
                    row.NOMBRE_COMERCIAL = nomcom;
                    row.SEGMENTO_SC_ID = cods;
                    row.ID_COUNTRY = pais;
                    row.FECHA_ACTUALIZACION = DateTime.Now;
                    ver = true;
                    contM++;
                    msgModificar = "Clientes Modificados: " + contM;
                  
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
                cl.CIUDAD = ciu;
                cl.DIRECCION = dir;
                cl.TELEFONO_CLIENTE = tel;
                cl.CEDULA_JURIDICA = cedj;
                cl.NOMBRE_CONTACTO = nomcon;
                cl.NOMBRE_COMERCIAL = nomcom;
                cl.SEGMENTO_SC_ID = cods;
                cl.ID_COUNTRY = pais;
                cl.STATUS_CLIENTE = false;
                cl.AGRUPAR = false;
                cl.FECHA_ACTUALIZACION = DateTime.Now;
                cl.FECHA_CREACION = DateTime.Now;
                Entity.CLIENTES.AddObject(cl);
                
                contN++;
                msgNuevos="Clientes Nuevos: " + contN;
                verN = true;
     
            }
            if (verN == true)
            {
                btClientes.Visible = true;
               
            }
               
                txtResumen.Text = msgNuevos + "\r\n" + msgModificar;
                ver = false;
           
                Entity.SaveChanges();

        }

        
       


    }
}
