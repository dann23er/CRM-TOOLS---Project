using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using DataAccess;


namespace CRM_TOOLS.Clases
{

    class Class_User
    {
        #region set/gets

        Dictionary<String, bool> permisos = new Dictionary<string, bool>();


        string usuarioID;

        public string UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
        string usuarioNombre;

        public string UsuarioNombre
        {
            get { return usuarioNombre; }
            set { usuarioNombre = value; }
        }
        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        #endregion
        CRMToolEntities Entity = new CRMToolEntities();
        bool ver;
        public bool Login(string user, string pass)
        {

            var query = from User in Entity.USERS
                        where User.USER_NAME == user && User.PASSWORD == pass
                        select User;

            if (query.Count() != 0)
            {
                USERS u = new USERS();

                UsuarioID = u.USER_ID;
                Usuario = u.USER_NAME;
                UsuarioNombre = u.NAME + " " + u.LAST_NAME; ;
                CargarPrivilegios();
                return true;
            }
            else
            {

                return false;
            }



        }

        public static string EncriptarClave(string originalPassword)
        {

            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);
            return BitConverter.ToString(encodedBytes);
        }


        void CargarPrivilegios()
        {

            var query = from privi in Entity.PRIVILEGIOSXUSER
                        where privi.USER_ID == UsuarioID
                        select privi;



            try
            {


                foreach (var row in query)
                {
                    if (!permisos.ContainsKey(row.PRIVILEGIO_LLAVE.ToString()))
                        permisos.Add(row.PRIVILEGIO_LLAVE.ToString(), true);
                }


            }
            catch
            {

            }
            finally
            {

            }

        }
        public bool ValidarPrivilegio(string privilegioLLave)
        {
            bool t = TienePrivilegio(privilegioLLave);
            if (!t)
            {
                MessageBox.Show("No tiene privilegios para esta operacion!!!");

            }
            return t;
        }

        public bool TienePrivilegio(string privilegioLlave)
        {

            return permisos.ContainsKey(privilegioLlave);


        }

    }

    class getData
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string email { get; set; }
        public string Pais { get; set; }
        public string Rol { get; set; }
        public string Estado { get; set; }
        public bool verEstado { get; set; }
        public DateTime Fecha { get; set; }
    }


  
       
}
