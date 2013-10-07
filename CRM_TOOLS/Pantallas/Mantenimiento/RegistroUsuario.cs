using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using DataAccess;
using System.Linq;
using CRM_TOOLS;



namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class RegistroUsuario : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        bool estado;
        string estado2;
        string varestado;
        string ID;
        frmListaUsuario _owner;
        bool verEditar = false;
        bool ver = false;

        public RegistroUsuario(frmListaUsuario x,string Id)
        {
            _owner = x;
            ID = Id;
            InitializeComponent();
            CargarPais();
            CargarRol();
            CargarDatos(Id);
        }

        public RegistroUsuario()
        {

        }

        void CargarPais()
        {
            var query = from p in Entity.PAISES
                        select p;
            cbPais.DataSource = query;
            cbPais.ValueMember = "COUNTRY_ID";
            cbPais.DisplayMember = "COUNTRY_NAME";
            cbPais.Refresh();
        }

        void CargarRol()
        {
            var query = from r in Entity.ROLES
                        select r;
            cbRol.DataSource = query;
            cbRol.ValueMember = "ID_ROL";
            cbRol.DisplayMember = "NOMBRE_ROL";
            cbRol.Refresh();

        }

        void CargarDatos(string id)
        {
            var query = from u in Entity.USERS
                        join rxu in Entity.ROLES_X_USUARIO on u.USER_ID equals rxu.USER_ID
                        join r in Entity.ROLES on rxu.ID_ROL equals r.ID_ROL 
                        where rxu.USER_ID ==id && rxu.ID_ROL == r.ID_ROL
                        select new {u.USER_ID,u.USER_NAME,u.STATUS,u.NAME,u.PASSWORD,u.E_MAIL,u.ID_COUNTRY,u.LAST_NAME,r.NOMBRE_ROL}; 
                foreach(var user in query){

              
                cbRol.Text = user.NOMBRE_ROL;
                txtId.Text=user.USER_ID;
                txtId.ReadOnly = true;
                txtNom.Text=user.USER_NAME;
                txtContra.Text=user.PASSWORD;
                cbPais.Text=getPais(user.ID_COUNTRY);
                if (user.STATUS == true)
                {
                    estado2 = "Habilitado";
                }
                else
                {
                    estado2 = "Deshabilitado";
                }
                cbEstado.Text = estado2;
                txtNombre.Text = user.NAME;
                txtApellido.Text = user.LAST_NAME;
                txtEmail.Text=user.E_MAIL;
            }
        }

        string getPais(string id)
        {
            var query = (from i in Entity.PAISES
                        where i.ID_COUNTRY == id
                        select i).FirstOrDefault();
            return query.COUNTRY_NAME; 
        }

        void GuardarRUNuevos()
        {
            try
            {
                USERS user = new USERS();

                var query = from u in Entity.USERS
                            
                            select u;

                foreach (var row in query)
                {

                    if (row.USER_ID == txtId.Text)
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
                    user.USER_ID = txtId.Text;
                    user.USER_NAME = txtNom.Text;
                    user.PASSWORD = Clases.Class_User.EncriptarClave(txtContra.Text);
                    user.ID_COUNTRY = Convert.ToString(cbPais.SelectedValue);
                    if (cbEstado.Text == "Habilitado")
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                    user.STATUS = estado;
                    user.NAME = txtNombre.Text;
                    user.LAST_NAME = txtApellido.Text;
                    user.LOGIN_ID = txtId.Text;
                    user.E_MAIL = txtEmail.Text;
                    user.FECHA_CREACION=DateTime.Now;
                    Entity.USERS.AddObject(user);
                    GuardarROLXUSER();
                    GuardarLog_Login();
                }
                Entity.SaveChanges();
                MessageBox.Show("El Usuario se ha Guardado!!!");
            }
            catch
            {

            }

        }

        void GuardarROLXUSER()
        {
            try
            {
                var rxu = (from ru in Entity.ROLES_X_USUARIO
                            where ru.ROLXUSERID == null
                            select ru).FirstOrDefault();

                if (rxu == null)
                {
                    ROLES_X_USUARIO rxu2 = new ROLES_X_USUARIO();
                    rxu2.ID_ROL = Convert.ToInt32(cbRol.SelectedValue);
                    rxu2.USER_ID = txtId.Text;
                    Entity.ROLES_X_USUARIO.AddObject(rxu2);
                  
                }
                Entity.SaveChanges();
            }
            catch
            {
            }
        }

        void GuardarLog_Login()
        {
            try
            {
                var rxu = (from ru in Entity.LOG_LOGIN
                            where ru.LOG_ID == null
                            select ru).FirstOrDefault();

                if (rxu == null)
                {
                   
                    LOG_LOGIN l = new LOG_LOGIN();
                    l.LOGIN_ID = txtId.Text;
                    l.LOGIN = DateTime.Now;
                    l.LOGOUT = DateTime.Now;
                    l.USER_NAME = txtNom.Text;
                    l.HISTORY = "";
                    Entity.LOG_LOGIN.AddObject(l);
                }
                Entity.SaveChanges();
            }
            catch
            {
            }
        }

        void GuardarRUEditar()
        {
            try
            {
                USERS user = new USERS();

                var query = (from u in Entity.USERS
                             where u.USER_ID == ID
                             select u).First();
               

               // user.USER_ID = txtId.Text;
                user.USER_NAME = txtNom.Text;
                user.PASSWORD = Clases.Class_User.EncriptarClave(txtContra.Text);
                user.ID_COUNTRY = cbPais.Text;
                if (cbEstado.Text == "Habilitado")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                user.STATUS = estado;
                user.NAME = txtNombre.Text;
                user.LAST_NAME = txtApellido.Text;
                user.E_MAIL = txtEmail.Text;
                user.FECHA_CREACION = DateTime.Now;
                GuardarROLXUSER();
                GuardarLog_Login();
                Entity.SaveChanges();
                MessageBox.Show("El Usuario se ha Modificado!!!");

            }
            catch
            {

            }


        }

      
         private void btSalir_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btGuardar_Click(object sender, EventArgs e)
         {
             if (verEditar == true)
             {
                 GuardarRUEditar();
             }
             else
             {
               
                 GuardarRUNuevos();
                // Entity.SaveChanges();
                 
             }
             _owner.GridListaUsuario();
         }

         

    }
}
