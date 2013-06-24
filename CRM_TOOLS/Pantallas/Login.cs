using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;


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
                if (UserAuthenticacion(txtUser.Text, txtPass.Text))
                {
                    Authenticar = true;
                    Principal p = new Principal();
                    p.Show();
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
                MessageBox.Show("Necesita un usuario y una contraseña para continuar");
            }

        }

   
        private bool UserAuthenticacion(string p, string p_2)
        {
            try
            {
                int result = 1;//(int)UsersTableAdapter.GetUserIDByUsernameAndPassword(p, p_2);
                Authenticar = true;
                if (result > 0) return true;
            }
            catch (Exception) 
            {
                Authenticar = false;
                return false;
            }
            Authenticar = false;
            return false;
        }

      

       

      
        
        
    }
}
