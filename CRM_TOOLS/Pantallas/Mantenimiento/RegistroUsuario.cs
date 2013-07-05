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
using System.Security.Cryptography;


namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class RegistroUsuario : Telerik.WinControls.UI.RadForm
    {
        CRMTOOLSEntities Entity = new CRMTOOLSEntities();

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        void GuardarUsuarios()
        {


            USERS user = new USERS();
            
            user.USER_ID=txtId.Text;
            user.USER_NAME=txtNom.Text;
            user.PASSWORD = EncriptarPassword(txtContra.Text);
            
        }



         string EncriptarPassword(string pass)
        {
            
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = md5.ComputeHash(inputBytes);
            pass = BitConverter.ToString(hash).Replace("-", "");
            return pass;
        }

         

    }
}
