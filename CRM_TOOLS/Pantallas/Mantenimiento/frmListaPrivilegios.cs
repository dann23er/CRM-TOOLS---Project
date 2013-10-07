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
using System.Data.SqlClient;
using CRM_TOOLS.Clases;
using Telerik.WinControls.UI;

namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class frmListaPrivilegios : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
       
        public frmListaPrivilegios()
        {
            InitializeComponent();
            GridListaPrivilegio();
           
        }
     
        private void btAgregar_Click(object sender, EventArgs e)
        {
            int ID=0;
            frmPrivilegios Pr = new frmPrivilegios(this,ID);
            Pr.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int ID;
            for (int i = 0; i < gv1.Rows.Count();i++ )
            {
                if (Convert.ToBoolean(gv1.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToInt32(gv1.Rows[i].Cells["ID"].Value);
                    frmPrivilegios Pr = new frmPrivilegios(this,ID);
                    Pr.Show();
                }
            }
         

         
        }
        private class getData
        {
     
        public int Id { get; set; }
        public string Llave { get; set; }
        public string Description { get; set; }
        }

        public void GridListaPrivilegio()
        {
            BindingSource bind = new BindingSource();
           // var query
                bind.DataSource= from lp in Entity.PRIVILEGIOS
                        where lp.PRIVILEGIO_ID != null
                        select new getData{Id=lp.PRIVILEGIO_ID, Llave=lp.PRIVILEGIO_LLAVE, Description=lp.DESCRIPCION} ;


            if (bind != null)
            {
               // var x = query.ToList();
                this.gv1.EnableFiltering = true;
                this.gv1.ShowFilteringRow = false;
                this.gv1.ShowHeaderCellButtons = true;
                gv1.DataSource = bind;
               
            }

            gv1.Refresh();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int ID;
            for (int i = 0; i < gv1.Rows.Count(); i++)
            {
                if (Convert.ToBoolean(gv1.Rows[i].Cells["clCheck"].Value) == true)
                {
                    ID = Convert.ToInt32(gv1.Rows[i].Cells["ID"].Value);
                    var query = (from p in Entity.PRIVILEGIOS
                                 where p.PRIVILEGIO_ID == ID
                                 select p).FirstOrDefault();
                    Entity.DeleteObject(query);
                    Entity.SaveChanges();
                    this.GridListaPrivilegio();
                    MessageBox.Show("El Privilegio se ha Eliminado!!!");

                }
            }
        }

       
      
       

       
       
    }
}
