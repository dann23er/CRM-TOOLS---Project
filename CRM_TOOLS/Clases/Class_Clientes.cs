using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;

namespace CRM_TOOLS.Clases
{
        
    class Class_Clientes
    {
        CRMToolEntities Entity = new CRMToolEntities();
        bool ver = false;
        int cont=0;

        public void GuardarClientes(string codclic, string codcli, string nomcli, string coddist, string nomdist, string codv, string NomV, string dir, string ciu, string tel, string cedj, string nomcon, string nomcom, int cods, string s, string pais)
        {
           
            CLIENTES cl = new CLIENTES();



            var query = (from cli in Entity.CLIENTES
                         where cli.CODIGO_CLIENTE_COMPUESTO == codclic && cli.CODIGO_CLIENTE == codcli
                         select cli);



            foreach (var row in query)
            {

                if (row.CODIGO_CLIENTE_COMPUESTO == codclic && row.CODIGO_CLIENTE == codcli)
                {
                    row.CODIGO_VENDEDOR = codv;
                    row.CODIGO_DISTRIBUIDOR = coddist;
                    row.NOMBRE_VENDEDOR = NomV;
                    row.NOMBRE_CLIENTE = nomcli;
                    row.NOMBRE_DISTRIBUIDOR = nomdist;
                    row.CIUDAD = ciu;
                    row.DIRECCION = dir;
                    row.TELEFONO_CLIENTE = tel;
                    row.CEDULA_JURIDICA = cedj;
                    row.NOMBRE_CONTACTO = nomcon;
                    row.NOMBRE_COMERCIAL = nomcom;
                    row.SEGMENTO_SC_ID = cods;
                    row.ID_COUNTRY = pais;
                    row.FECHA_ACTUALIZACION = DateTime.Now;
                    ver = true;
                   

                    break;
                }


            }

            if (ver == false)
            {

                cl.CODIGO_CLIENTE_COMPUESTO = codclic;
                cl.CODIGO_CLIENTE = codcli;
                cl.CODIGO_VENDEDOR = codv;
                cl.CODIGO_DISTRIBUIDOR = coddist;
                cl.NOMBRE_VENDEDOR = NomV;
                cl.NOMBRE_CLIENTE = nomcli;
                cl.NOMBRE_DISTRIBUIDOR = nomdist;
                cl.CIUDAD = ciu;
                cl.DIRECCION = dir;
                cl.TELEFONO_CLIENTE = tel;
                cl.CEDULA_JURIDICA = cedj;
                cl.NOMBRE_CONTACTO = nomcon;
                cl.NOMBRE_COMERCIAL = nomcom;
                cl.SEGMENTO_SC_ID = cods;
                cl.ID_COUNTRY = pais;
                cl.STATUS_CLIENTE = false;
                cl.AGRUPAR = false;
                cl.FECHA_ACTUALIZACION = DateTime.Now;
                cl.FECHA_CREACION = DateTime.Now;
                cont++; 
                Entity.CLIENTES.AddObject(cl);

            }
          
     
            ver = false;

            Entity.SaveChanges();

        }
     

    }
    class getDataCliente
    {

        public string CodCli { get; set; }
        public string CodDist { get; set; }
        public string NomCli { get; set; }
        public string NomDist { get; set; }
        public string Paises { get; set; }
        public int SegKC { get; set; }
        public string SegSC { get; set; }
        public string ABCDist { get; set; }
        public string ABCPais { get; set; }
        public string GrupoCli { get; set; }
        public string Plataformas { get; set; }
        public int GAN { get; set; }
        public string GAN_Name { get; set; }
        public bool Inac { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaC { get; set; }
        public DateTime FechaA { get; set; }
        public bool Agrupar { get; set; }
    }

    

}
