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


namespace CRM_TOOLS.Pantallas.Mantenimiento
{

    public partial class frmPrivilegios : Telerik.WinControls.UI.RadForm
    {
        
        CRMToolEntities Entity = new CRMToolEntities();
        Class_User u = new Class_User();
        frmListaPrivilegios _owner;
        int ID;
        bool ver=false;
        bool verEditar = false;
      
        

        public frmPrivilegios(frmListaPrivilegios owner,int id)
        {
            ID = id;
            _owner = owner;
            InitializeComponent();
            EditarPrivilegios(ID);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPrivilegiosToActualUsuer()
        {
            if (!u.TienePrivilegio("Insertar Privilegios"))
                btGuardar.Visible = false;
        }
        void GuardarPrivilegiosNuevos()
        {
            try
            {
                PRIVILEGIOS pri = new PRIVILEGIOS();

                var query = from p in Entity.PRIVILEGIOS
                            //where p.PRIVILEGIO_ID == null
                            select p;
        
                        foreach (var row in query)
                        {

                            if (row.PRIVILEGIO_ID == Convert.ToInt32(txtID.Text))
                            {
                                MessageBox.Show("El Codigo ya Existe!!!");
                                ver = true;
                            }
                            else
                           {
                                ver = false;
                            }

                        }
  
                if(ver==false)
                { 
                    pri.PRIVILEGIO_ID = Convert.ToInt32(txtID.Text);
                    pri.PRIVILEGIO_LLAVE = txtLlave.Text;
                    pri.DESCRIPCION = txtDescrip.Text;
                    Entity.AddToPRIVILEGIOS(pri);
                    Entity.SaveChanges();
                    MessageBox.Show("El Privilegio se ha Guardado!!!");

                }
            }
            catch
            {

            }

            
        }

        void GuardarPrivilegiosEditar()
        {
            try
            {
                PRIVILEGIOS pri = new PRIVILEGIOS();

                var query = (from p in Entity.PRIVILEGIOS
                            where p.PRIVILEGIO_ID == ID
                            select p).First();


               
                    //query.PRIVILEGIO_ID = Convert.ToInt32(txtID.Text);
                    query.PRIVILEGIO_LLAVE = txtLlave.Text;
                    query.DESCRIPCION = txtDescrip.Text;
                    //Entity.AddToPRIVILEGIOS(pri);
                    Entity.SaveChanges();
                    MessageBox.Show("El Privilegio se ha Modificado!!!");
                
            }
            catch
            {

            }


        }
        void EditarPrivilegios(int id)
        {
            PRIVILEGIOS pri = new PRIVILEGIOS();

            var query = from p in Entity.PRIVILEGIOS
                        where p.PRIVILEGIO_ID == id
                        select p;
            foreach (var row in query)
            {
                if (row.PRIVILEGIO_ID != 0)
                {
                    txtID.Text = Convert.ToString(row.PRIVILEGIO_ID);
                    txtID.ReadOnly = true;
                    txtLlave.Text = row.PRIVILEGIO_LLAVE.ToString();
                    txtDescrip.Text = row.DESCRIPCION.ToString();
                    verEditar = true;
                }
                else
                {
                    verEditar = false;
                }

            }
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (verEditar == true)
            {
                GuardarPrivilegiosEditar();
            }
            else
            {
                GuardarPrivilegiosNuevos();
            }
          
            _owner.GridListaPrivilegio();
         
         
       
        }

        
    }
}
