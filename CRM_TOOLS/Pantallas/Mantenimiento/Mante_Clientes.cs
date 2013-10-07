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
using Telerik.WinControls.UI;
using System.IO;
using CRM_TOOLS.Pantallas.Mantenimiento;


namespace CRM_TOOLS.Pantallas
{
    public partial class Mante_Clientes : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
       //TipoActivacion TA;
        DataTable dt = new DataTable(); 
       public Mante_Clientes()
        {
            InitializeComponent();
            gridClientes();
            cargarComboSegmentos();
            SetDt();
         

        }
       private void SetDt()
       {
           var query = (from sc in Entity.EQUIVALENCIAS_SEGMENTOS
                       select new
                       {
                           nombre = sc.NAME_SEGMENT_IMPORT,
                           id = sc.COD_SEGMENT_IMPORT
                       }).ToList();

           dt.Columns.Add("Id", typeof(int));
           dt.Columns.Add("Name", typeof(string));

           foreach (var rw in  query)
           {
               DataRow dr = dt.NewRow();
               dr[0] = rw.id;

               dr[1] = rw.nombre;

               dt.Rows.Add(dr);

           }

       }

       public void CargarCheck(TipoActivacion TA)
        {
            bool check = false;
            string id;
            for (int i = 0; i < gridCliente.RowCount; i++)
            {
                //Convert.ToBoolean() == true
                check = Convert.ToBoolean(gridCliente.Rows[i].Cells[0].Value);
                id = (string)gridCliente.Rows[i].Cells[1].Value;
                if (check == true)
                {
                    if (TA == null)
                    {
                        TA = new TipoActivacion(this, id);
                        TA.Show();
                    }

                   }
                }
            }

       void cargarComboSegmentos()
        {
            GridViewComboBoxColumn comboColumnSC = (GridViewComboBoxColumn)this.gridCliente.Columns[6];
            var query = from sc in Entity.EQUIVALENCIAS_SEGMENTOS
                        select new
                        {
                            nombre = sc.NAME_SEGMENT_IMPORT,
                            id = sc.COD_SEGMENT_IMPORT
                        };

            comboColumnSC.DataSource = query;
            comboColumnSC.DisplayMember = "nombre";
            comboColumnSC.ValueMember = "id";


            GridViewComboBoxColumn comboColumnKC = (GridViewComboBoxColumn)this.gridCliente.Columns[5];
            var query2 = from sc in Entity.SEGMENTOS
                        select new
                        {
                            nombre = sc.SEGMENT_NAME_ING,
                            id = sc.SEGMENT_ID
                        };

            comboColumnKC.DataSource = query2;
            comboColumnKC.DisplayMember = "nombre";
            comboColumnKC.ValueMember = "id";
                   
      }
    
       public void gridClientes()
        {


            var query = from cli in Entity.CLIENTES
                        where cli.CODIGO_CLIENTE != null && cli.CODIGO_CLIENTE_COMPUESTO != null && cli.AGRUPAR != null && cli.STATUS_CLIENTE != null

                        select new
                        {
                            CodCli = cli.CODIGO_CLIENTE,
                            NomCli = cli.NOMBRE_CLIENTE,
                            CodDist = cli.CODIGO_DISTRIBUIDOR,
                            NomDist = cli.NOMBRE_DISTRIBUIDOR,
                            SegSC = cli.SEGMENTO_SC_ID,
                            SegKC = cli.SEGMENTO_KC_ID,
                            ABCDist = cli.TIPO_ABC_DISTRIBUIDOR,
                            ABCPais = cli.TIPO_ABC_PAIS,
                            GrupoCli = cli.GRUPO_CLIENTE,
                            Plataformas = cli.PLATAFORMAS,
                            GAN=cli.GLOBAL_ACCOUNT_NAME,
                            Inac = (bool)cli.STATUS_CLIENTE.Value,
                            Paises = cli.ID_COUNTRY,
                            Ciudad = cli.CIUDAD,
                            FechaC = cli.FECHA_CREACION,
                           // Agrupar = (bool)cli.AGRUPAR.Value
                        };


            this.gridCliente.EnableFiltering = true;
            this.gridCliente.ShowFilteringRow = false;
            this.gridCliente.ShowHeaderCellButtons = true;
            gridCliente.DataSource = query;
            gridCliente.Refresh();
        }

       private void btEditar_Click(object sender, EventArgs e)
        {
            CargarCheck(null);
          
        }

       private void btSelect_Click(object sender, EventArgs e)
        {
            var query = (from sel in Entity.CLIENTES
                         where sel.AGRUPAR == false
                         select sel).ToList();
            foreach (var row in query)
            {
                row.AGRUPAR = true;

            }
            Entity.SaveChanges();
            gridClientes();

        }

       private void btDeselect_Click(object sender, EventArgs e)
        {
            var query = (from sel in Entity.CLIENTES
                         where sel.AGRUPAR == true
                         select sel).ToList();
            foreach (var row in query)
            {
                row.AGRUPAR = false;


            }
            Entity.SaveChanges();
            gridClientes();
        }
                               
       private void btSegmentos_Click(object sender, EventArgs e)
        {
            UpdateSegmento us = new UpdateSegmento(this);
            us.Show();
        }

    

        private void MasterTemplate_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (e.EditorType == typeof(RadDropDownListEditor))
            {
               // DropDownEditorWithDefaultValue editor = new DropDownEditorWithDefaultValue();
                //e.Editor = editor;
            }

        }

        bool flag;
        private void gridCliente_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (gridCliente.CurrentColumn is GridViewComboBoxColumn)
            {
                if (gridCliente.CurrentColumn.Name.ToString() == "SegSC")
                {
                    if (!flag)
                    {

                        flag = true;
                        RadDropDownListEditor cmb = new RadDropDownListEditor();
                        ((RadDropDownListEditorElement)((RadDropDownListEditor)gridCliente.ActiveEditor).EditorElement)
                         .ListElement.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
                    }

                }

            }

        }
        private void gridCliente_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (gridCliente.CurrentColumn.Name.ToString() == "SegSC")
            {
                RadDropDownListEditor cmb = gridCliente.ActiveEditor as RadDropDownListEditor;
                if (cmb != null)
                {
                    ((RadDropDownListEditorElement)(cmb).EditorElement).DisplayMember = "Name";



                    ((RadDropDownListEditorElement)(cmb).EditorElement).ValueMember = "Id";



                    ((RadDropDownListEditorElement)(cmb).EditorElement).DataSource = dt;



                    ((RadDropDownListEditorElement)(cmb).EditorElement).SelectedIndex = -1;



                    ((RadDropDownListEditorElement)(cmb).EditorElement).ShowPopup();



                }

            }

        }

      

      

       
      
       

     
    }
    }

