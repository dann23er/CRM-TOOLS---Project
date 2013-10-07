using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using DataAccess;
using CRM_TOOLS;
using System.Data.SqlClient;
using System.Linq;


namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmListaRoles : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public frmListaRoles()
        {
            InitializeComponent();
            GridListaRol();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            int ID = 0;
            frmRoles Ro = new frmRoles(this,ID);
            Ro.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int ID;
            for (int i = 0; i < gridRoles.Rows.Count(); i++)
            {
                if (Convert.ToBoolean(gridRoles.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToInt32(gridRoles.Rows[i].Cells["ID"].Value);
                    frmRoles Ro = new frmRoles(this,ID);
                    Ro.Show();
                }
            }

        }

        void eliminarRol(int id)
        {
            //int id = Convert.ToInt32(idRol);
            var pxr2 = (from pr in Entity.PRIVILEGIOS_X_ROL
                        where pr.ID_ROL == id
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
            int ID;
            for (int i = 0; i < gridRoles.Rows.Count(); i++)
            {
                if (Convert.ToBoolean(gridRoles.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToInt32(gridRoles.Rows[i].Cells["ID"].Value);
                    var query = (from p in Entity.ROLES
                                 where p.ID_ROL == ID
                                 select p).FirstOrDefault();
                    eliminarRol(ID);
                    Entity.DeleteObject(query);
                    Entity.SaveChanges();
                    this.GridListaRol();
                    MessageBox.Show("El Rol se ha Eliminado!!!");

                }
            }
        }

        private class getData
        {

            public int Id { get; set; }
            public string Llave { get; set; }
            public string Description { get; set; }
        }

        public void GridListaRol()
        {
            BindingSource bind = new BindingSource();
            // var query
            bind.DataSource = from lr in Entity.ROLES
                              where lr.ID_ROL != null
                              select new getData { Id = lr.ID_ROL, Llave = lr.NOMBRE_ROL, Description = lr.DESCRIPCION_ROL };


            if (bind != null)
            {
                // var x = query.ToList();
                this.gridRoles.EnableFiltering = true;
                this.gridRoles.ShowFilteringRow = false;
                this.gridRoles.ShowHeaderCellButtons = true;
                gridRoles.DataSource = bind;

            }

            gridRoles.Refresh();
        }
    }
}
