using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using CRM_TOOLS;
using System.Data.SqlClient;
using System.Windows.Documents;
using Telerik.WinControls.UI;




namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmRoles : Telerik.WinControls.UI.RadForm
    {
        #region Variables
        CRMToolEntities Entity = new CRMToolEntities();
        frmListaRoles _owner;
        bool verEditar=false;
        bool ver=false;
        int ID;
        #endregion

        public frmRoles(frmListaRoles x,int id)
        {
            _owner = x;
            ID = id;
            InitializeComponent();
            cargarPrivilegiosDisponibles();
            EditarRoles(id);
            compararPrivilegiosAsigConDispo();
        }

       
        void GuardarRolesNuevos()
        {
            try
            {
                ROLES rol = new ROLES();

                var query = from r in Entity.ROLES
                            //where p.PRIVILEGIO_ID == null
                            select r;

                foreach (var row in query)
                {

                    if (row.ID_ROL == Convert.ToInt32(txtID.Text))
                    {
                        MessageBox.Show("El Codigo ya Existe!!!");
                        ver = true;
                    }
                    else
                    {
                        ver = false;
                    }

                }

                if (ver == false)
                {
                    rol.ID_ROL = Convert.ToInt32(txtID.Text);
                    rol.NOMBRE_ROL = txtLlave.Text;
                    rol.DESCRIPCION_ROL = txtDescrip.Text;
                    Entity.AddToROLES(rol);
                    Entity.SaveChanges();
                    MessageBox.Show("El Rol se ha Guardado!!!");

                }
            }
            catch
            {

            }


        }

        void GuardarRolesEditar()
        {
            try
            {
               ROLES rol = new ROLES();

                var query = (from r in Entity.ROLES
                             where r.ID_ROL == ID
                             select r).First();



               
                query.NOMBRE_ROL = txtLlave.Text;
                query.DESCRIPCION_ROL = txtDescrip.Text;
               
                Entity.SaveChanges();
                MessageBox.Show("El Rol se ha Modificado!!!");

            }
            catch
            {

            }


        }

        void EditarRoles(int id)
        {
        
            var query = from r in Entity.ROLES
                        where r.ID_ROL == id
                        select r;
            foreach (var row in query)
            {
                if (row.ID_ROL != 0)
                {
                    txtID.Text = Convert.ToString(row.ID_ROL);
                    txtID.ReadOnly = true;
                    txtLlave.Text = row.NOMBRE_ROL.ToString();
                    txtDescrip.Text = row.DESCRIPCION_ROL.ToString();
                    cargarPrivilegiosAsignados(id);
                    verEditar = true;
                }
                else
                {
                    verEditar = false;
                }

            }
        }

        void cargarPrivilegiosDisponibles()
        {

            var query = (from pri in Entity.PRIVILEGIOS
                        select pri).ToList(); 

    
            listPrivilegiosDisponibles.DataSource = query;
            listPrivilegiosDisponibles.ValueMember = "PRIVILEGIO_ID";
            listPrivilegiosDisponibles.DisplayMember = "PRIVILEGIO_LLAVE";
            
        }

        void cargarPrivilegiosAsignados(int id)
        {

            var query = (from  pxr in Entity.PRIVILEGIOS_X_ROL 
                         join p in Entity.PRIVILEGIOS on pxr.PRIVILEGIO_ID equals p.PRIVILEGIO_ID
                         where p.PRIVILEGIO_ID==pxr.PRIVILEGIO_ID && pxr.ID_ROL==id
                         select p).ToList();


            listPrivilegiosAsignados.DataSource = query;
            listPrivilegiosAsignados.ValueMember = "PRIVILEGIO_ID";
            listPrivilegiosAsignados.DisplayMember = "PRIVILEGIO_LLAVE";

          /*  int idrol=Convert.ToInt32(txtID.Text);
            string llave="";
            var query = (from pr in Entity.PRIVILEGIOS_X_ROL
                        where pr.ID_ROL==id
                        select pr).ToList();
            foreach (var r in query)
            {
                var query2 =(from p in Entity.PRIVILEGIOS
                              where p.PRIVILEGIO_ID == r.PRIVILEGIO_ID
                              select p).ToList();

                listPrivilegiosAsignados.DataSource = query2;
                listPrivilegiosAsignados.ValueMember = "PRIVILEGIO_ID";
                listPrivilegiosAsignados.DisplayMember = "PRIVILEGIO_LLAVE";
            }
            for (int i = 0; i < listPrivilegiosAsignados.Items.Count; i++)
            {
                foreach (RadListDataItem row in listPrivilegiosAsignados.Items)
                {
                    for (int x = 0; x < listPrivilegiosDisponibles.Items.Count; x++)
                    {
                            llave=listPrivilegiosDisponibles.Items[x].Text;
                        if ( llave==row.Text)
                            listPrivilegiosDisponibles.Items.Remove(row);
                    }
                }
            }*/
        }

        
        void compararPrivilegiosAsigConDispo()
        {
            if (listPrivilegiosDisponibles.Items == null || listPrivilegiosAsignados.Items == null)
                return;

            List<RadListDataItem> disp = new List<RadListDataItem>();
            foreach (RadListDataItem itemDisp in listPrivilegiosDisponibles.Items)
            {
                string dato = itemDisp.Text;
                bool existe = false;
                int size = listPrivilegiosAsignados.Items.Count;
                for (int i = 0; i < size; i++)
                {
                    listPrivilegiosAsignados.SelectedIndex = i;
                    string c = listPrivilegiosAsignados.SelectedItem.ToString();
                    if (dato.Equals(c))
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                    disp.Add(itemDisp);
                else
                    listPrivilegiosAsignados.SelectedIndex = -1;
            }
            listPrivilegiosDisponibles.Items.Clear();
            for (int i = 0; i < disp.Count; i++)
            {
                listPrivilegiosDisponibles.Items.Add(disp[i]);
               

            }
        }

        void insertarPrivilegiosXUsuarios()
        {
          
            var pxr2 = (from pr in Entity.PRIVILEGIOS_X_ROL
                        where pr.PRIVILEGIOXROLID==null
                        select pr).FirstOrDefault();


            for (int i = 0; i < listPrivilegiosAsignados.Items.Count;i++ )
            {

                string privNombre = listPrivilegiosAsignados.Items[i].Text;
                int id = Convert.ToInt32(listPrivilegiosAsignados.Items[i].Value);

                var query = (from p in Entity.PRIVILEGIOS
                             where p.PRIVILEGIO_LLAVE == privNombre
                             select p).FirstOrDefault();
                 
                if(pxr2==null){
                    PRIVILEGIOS_X_ROL pxr1 = new PRIVILEGIOS_X_ROL();
                    pxr1.PRIVILEGIO_ID = query.PRIVILEGIO_ID;
                    pxr1.ID_ROL = Convert.ToInt32(txtID.Text);
                    Entity.PRIVILEGIOS_X_ROL.AddObject(pxr1);

                }else{
                    pxr2.PRIVILEGIO_ID = query.PRIVILEGIO_ID;
                    pxr2.ID_ROL = Convert.ToInt32(txtID.Text);
                    }
                  
                
                Entity.SaveChanges();
            }
           
     
        }

        void eliminarPrivilegiosXUsuarios()
        {
            int id=Convert.ToInt32(txtID.Text);
            var pxr2 = (from pr in Entity.PRIVILEGIOS_X_ROL
                        where pr.ID_ROL == id  
                        select pr).ToList();

            if(pxr2.Count>0){
                foreach (var row in pxr2)
                {
                    Entity.DeleteObject(row); 
                }
                Entity.SaveChanges();
            }


        }



        #region BtPasar List

        private void btEnviarAsignados_Click(object sender, EventArgs e)
        {
       
            
            MoverListBox(listPrivilegiosDisponibles,listPrivilegiosAsignados);

        }

        private void btEnviarAsignadosTodos_Click(object sender, EventArgs e)
        {
            MoverAllItems(listPrivilegiosDisponibles, listPrivilegiosAsignados);
        }

        private void btEnviarDisponibles_Click(object sender, EventArgs e)
        {
            MoverListBox( listPrivilegiosAsignados,listPrivilegiosDisponibles);
        }

        private void btEnviarDisponiblesTodos_Click(object sender, EventArgs e)
        {

            MoverAllItems(listPrivilegiosAsignados, listPrivilegiosDisponibles);
        }

        private void MoverAllItems(RadListControl sourceListBox, RadListControl targetListBox) { 
            for (int i = 0; i < sourceListBox.Items.Count; )
            { RadListDataItem item = sourceListBox.Items[i];
                sourceListBox.Items.Remove(item); targetListBox.Items.Add(item);
            }
            }     
     
        private void MoverListBox(RadListControl sourceListBox, RadListControl targetListBox) { 
            if (sourceListBox.Items.Count == 0) { 
                return;
            } if (sourceListBox.SelectedItem == null)
            { return; 
            } RadListDataItem item = sourceListBox.SelectedItem; 
            sourceListBox.Items.Remove(item); 
            targetListBox.Items.Add(item); 
            }

        #endregion

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (verEditar == true)
            {
                GuardarRolesEditar();
                eliminarPrivilegiosXUsuarios();
                insertarPrivilegiosXUsuarios();
            }
            else
            {
                GuardarRolesNuevos();
                insertarPrivilegiosXUsuarios();
            }

           
            //GuardarRoles();
            
            _owner.GridListaRol();
        } 
    }
}
