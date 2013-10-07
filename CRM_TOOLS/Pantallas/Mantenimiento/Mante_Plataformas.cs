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
using CRM_TOOLS.Pantallas.Mantenimiento;

namespace CRM_TOOLS.Pantallas
{
    public partial class Mante_Plataformas : Telerik.WinControls.UI.RadForm
    {
        CRMToolEntities Entity = new CRMToolEntities();
        public Mante_Plataformas()
        {
            InitializeComponent();
            cargarPlataformas();
        }
        void cargarPlataformas()
        {
            var query = from p in Entity.PLATAFORMAS
                        select new
                        {
                            id=p.CODIGO_PLATAFORMA,
                            nombre=p.NOMBRE_PLATAFORMA
                        };
            this.gridPlataforma.EnableFiltering = true;
            this.gridPlataforma.ShowFilteringRow = false;
            this.gridPlataforma.ShowHeaderCellButtons = true;
            gridPlataforma.DataSource = query;
            
        }
    }
}
