using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using DataAccess;
using System.Linq;


namespace CRM_TOOLS.Pantallas
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        #region Evento Usuario

        private bool _Authenticar = false;

        public bool Authenticar
        {
            get { return _Authenticar; }
            set { _Authenticar = value; }
        }
        private string _User = "";

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }

        #endregion

        CRMTOOLSEntities Entity = new CRMTOOLSEntities();

        public Login()
        {
          

 
            InitializeComponent();
        }

        

        private void btEntrar_Click(object sender, EventArgs e)
        {
            funLogin();
        }
        private void funLogin()
        {

            if (txtPass.Text.Length > 0 && txtUser.Text.Length > 0)
            {
                if (UserLogin(txtUser.Text, txtPass.Text))
                {
                    Authenticar = true;
                  
                    RadForm1 rf = new RadForm1();
                    rf.Show();
                    this.Visible = false;
                   
                }
                else
                {
                    Authenticar = false;
                    MessageBox.Show("Usuario or Contraseña no reconocida ");

                }
            }
            else // contraseña o usuario si esta vacio
            {
                Authenticar = false;
                MessageBox.Show("Necesita un Usuario y una Contraseña para continuar");
            }

        }

   
       

        private void btCerrarL_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }




         public bool UserLogin(string User, string Pass)
            {
                             
                var query = from user in Entity.USERS
                            where user.USER_NAME==User && user.PASSWORD==Pass
                            select user;

                if (query.Count() != 0)
                {
                    
                    return true;
                }
                else
                {
                  
                    return false;
                }



            }


      
        
        
    }
}
