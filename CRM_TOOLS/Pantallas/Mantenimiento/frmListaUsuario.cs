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
using CRM_TOOLS.Clases;
namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmListaUsuario : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public frmListaUsuario()
        {
            InitializeComponent();
            GridListaUsuario();
        }

        public void GridListaUsuario()
        {
           
            
            BindingSource bind = new BindingSource();

                      var query = from u in Entity.USERS
                                  join rxu in Entity.ROLES_X_USUARIO on u.USER_ID equals rxu.USER_ID
                                  join r in Entity.ROLES on rxu.ID_ROL equals r.ID_ROL
                                  where rxu.USER_ID !=null  && rxu.ID_ROL == r.ID_ROL 
                                  select new getData { Id = u.USER_ID, Nombre = u.USER_NAME + " " + u.LAST_NAME, Pais = u.ID_COUNTRY, email = u.E_MAIL, Rol = r.NOMBRE_ROL,verEstado=u.STATUS ,Fecha=(DateTime)u.FECHA_CREACION};

                
            
               
                this.gridUsers.EnableFiltering = true;
                this.gridUsers.ShowFilteringRow = false;
                this.gridUsers.ShowHeaderCellButtons = true;
                gridUsers.DataSource = query;

            //}

            gridUsers.Refresh();
        }
       
        string getNombreRol(string id)
        {
            var query = (from rxu in Entity.ROLES_X_USUARIO
                         join u in Entity.USERS on rxu.USER_ID equals u.USER_ID
                         join r in Entity.ROLES on rxu.ID_ROL equals r.ID_ROL
                         where rxu.USER_ID == id && rxu.ID_ROL == r.ID_ROL
                         select r).FirstOrDefault();

            return query.NOMBRE_ROL;
        }
        
        private void btAgregar_Click(object sender, EventArgs e)
        {
            rdInactivar.Visible = false;
            rdEliminar.Visible = false;
            string ID = "";
            RegistroUsuario RU = new RegistroUsuario(this,ID);
            RU.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            rdInactivar.Visible = false;
            rdEliminar.Visible = false;
            string ID;
            for (int i = 0; i < gridUsers.Rows.Count(); i++)
            {
                if (Convert.ToBoolean(gridUsers.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToString(gridUsers.Rows[i].Cells["ID"].Value);
                    RegistroUsuario RU = new RegistroUsuario(this, ID);
                    RU.Show();
                }
            }
        }
        void eliminarRol(string id)
        {
         
            var pxr2 = (from pr in Entity.ROLES_X_USUARIO
                        where pr.USER_ID == id
                        select pr).ToList();

            if (pxr2.Count > 0)
            {
                foreach (var row in pxr2)
                {
                    Entity.DeleteObject(row);
                }
                Entity.SaveChanges();
            }


        }
        void eliminarLOG(string id)
        {

            var pxr2 = (from pr in Entity.LOG_LOGIN
                        where pr.LOGIN_ID == id
                        select pr).ToList();

            if (pxr2.Count > 0)
            {
                foreach (var row in pxr2)
                {
                    Entity.DeleteObject(row);
                }
                Entity.SaveChanges();
            }


        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            rdInactivar.Visible = true;
            rdEliminar.Visible = true;
        
        }
                
        private void rdInactivar_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            string ID = "";
                 for (int i = 0; i < gridUsers.Rows.Count(); i++)
            {
                if (Convert.ToBoolean(gridUsers.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToString(gridUsers.Rows[i].Cells["ID"].Value);

            if (rdInactivar.IsChecked == true)
            {
               
                        var query = (from p in Entity.USERS
                                     where p.USER_ID == ID
                                     select p).FirstOrDefault();
                        query.STATUS = false;                     
                        Entity.SaveChanges();
                        this.GridListaUsuario();
                        MessageBox.Show("El Usuario se ha Dashabilitado!!!");
                 
            }
            }
            }
        }

        private void rdEliminar_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            string ID = "";
            rdInactivar.Visible = true;
            rdEliminar.Visible = true;

            for (int i = 0; i < gridUsers.Rows.Count(); i++)
            {
                if (Convert.ToBoolean(gridUsers.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToString(gridUsers.Rows[i].Cells["ID"].Value);

                    if (rdEliminar.IsChecked == true)
                    {
                        var query = (from p in Entity.USERS
                                     where p.USER_ID == ID
                                     select p).FirstOrDefault();
                        eliminarRol(ID);
                        eliminarLOG(ID);
                        Entity.DeleteObject(query);
                        Entity.SaveChanges();
                        this.GridListaUsuario();
                        MessageBox.Show("El Usuario se ha Eliminado!!!");

                    } 
                }
            }

        }

        

        
    }
}
