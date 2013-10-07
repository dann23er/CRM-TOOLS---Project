using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data;
using Telerik.WinControls.UI;
using System.Windows.Forms;


namespace CRM_TOOLS.Clases
{
    class Class_Funciones
    {
        CRMToolEntities Entity = new CRMToolEntities();
        int i;
        decimal total;
        List<string> buffer= new List<string>();
        List<string> buffer2= new List<string>();
        //DataTable dt = new DataTable();
        int cont,contu;
        //DataTable dt2 = new DataTable();

        #region ABC
        public void ABCDistribuidor(int desde,int hasta,string codpais,string coddist,int tipo)
        {
            string abc="";
            double vtacumulada = 0;
            double vtatotal = 0;
            double vta = 0;
            if (tipo == 1)
            {
               var queryTodos = (from todo in Entity.SELLOUT
                                  where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta && todo.ID_COUNTRY == codpais
                                  select new
                                  {
                                      id = todo.CODIGO_DISTRIBUIDOR,
                                      vta = todo.VENTA_DOLARES
                                  }
                                  ).Sum(o => o.vta);
                vtatotal = Convert.ToDouble(queryTodos.Value);
            }
            else if(tipo==2)
            {
               var queryTodos = (from todo in Entity.SELLOUT
                                  where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta 
                                  && todo.ID_COUNTRY == codpais && todo.CODIGO_DISTRIBUIDOR==coddist
                                  select new
                                  {
                                      id = todo.CODIGO_DISTRIBUIDOR,
                                      vta = todo.VENTA_DOLARES
                                  }
                                  ).Sum(o => o.vta);
                if(queryTodos!=null)
               vtatotal = Convert.ToDouble(queryTodos.Value);

            }
            var query = from q in Entity.SELLOUT
                        where q.SECUENCIA_MES >= desde && q.SECUENCIA_MES <= hasta
                         && q.CODIGO_DISTRIBUIDOR == coddist
                        select new
                        {
                            codComp=q.CODIGO_CLIENTE_COMPUESTO
                        };

            foreach (var row in query)
            {
                   var queryVta = (from todo in Entity.SELLOUT
                                where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta
                                && todo.CODIGO_DISTRIBUIDOR == coddist && todo.CODIGO_CLIENTE_COMPUESTO==row.codComp
                                select new
                                {
                                    id = todo.CODIGO_DISTRIBUIDOR,
                                    vta = todo.VENTA_DOLARES,
                                    
                                }).Sum(o => o.vta);

                  
                   vtacumulada = Convert.ToDouble(queryVta.Value);

                   vta = vtacumulada / vtatotal;

                   if (vta < 0.5)
                   {
                       abc = "A";
                   }
                   else if (vta < 0.8)
                   {
                       abc = "B";
                   }
                   else
                   {
                       abc = "C";
                   }

                
                   var queryTabla = from qt in Entity.CLIENTES
                                    where qt.CODIGO_DISTRIBUIDOR == coddist
                                    select qt;

                   foreach (var rw in queryTabla)
                   {
                       rw.TIPO_ABC_DISTRIBUIDOR = abc;
                   }
                
                  
                   }
            Entity.SaveChanges();                

        }

        public void CalculoABC(int desde, int hasta, string valor, int tipo)
        {
            string abc = "";
            double vtacumulada = 0;
            double vtatotal = 0;
            double vta = 0;
            string coddist;
            if (tipo == 1)
            {
                var queryTodos = (from todo in Entity.SELLOUT
                                  where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta && todo.ID_COUNTRY == valor
                                  select new
                                  {
                                      id = todo.CODIGO_DISTRIBUIDOR,
                                      vta = todo.VENTA_DOLARES
                                  }
                                   ).Sum(o => o.vta);

                vtatotal = Convert.ToDouble(queryTodos.Value);

                var query = from q in Entity.SELLOUT
                            where q.SECUENCIA_MES >= desde && q.SECUENCIA_MES <= hasta
                             && q.ID_COUNTRY == valor
                            select new
                            {
                                iddist = q.CODIGO_DISTRIBUIDOR,
                                codComp = q.CODIGO_CLIENTE_COMPUESTO
                            };

                foreach (var row in query)
                {
                    var queryVta = (from todo in Entity.SELLOUT
                                    where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta
                                    && todo.CODIGO_DISTRIBUIDOR == row.iddist && todo.CODIGO_CLIENTE_COMPUESTO == row.codComp
                                    select new
                                    {
                                        id = todo.CODIGO_DISTRIBUIDOR,
                                        vta = todo.VENTA_DOLARES,

                                    }).Sum(o => o.vta);

                    coddist = row.iddist;
                    vtacumulada = Convert.ToDouble(queryVta.Value);
                    vta = vtacumulada / vtatotal;


                    ActualizarDistribuidor(vta, abc, coddist);

                }
            }
            else if (tipo == 2)
            {
                var queryTodos = (from todo in Entity.SELLOUT join ps in Entity.PAISES 
                                  on todo.ID_COUNTRY equals ps.ID_COUNTRY
                                  where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta
                                  && todo.ID_COUNTRY == ps.ID_COUNTRY && ps.REGION==valor
                                  select new
                                  {
                                      id = todo.CODIGO_DISTRIBUIDOR,
                                      vta = todo.VENTA_DOLARES
                                  }
                                   ).Sum(o => o.vta);

                vtatotal = Convert.ToDouble(queryTodos.Value);

                var query = from q in Entity.SELLOUT
                            join ps in Entity.PAISES
                                on q.ID_COUNTRY equals ps.ID_COUNTRY
                            where q.SECUENCIA_MES >= desde && q.SECUENCIA_MES <= hasta
                             && q.ID_COUNTRY == valor
                            select new
                            {
                                iddist = q.CODIGO_DISTRIBUIDOR,
                                codComp = q.CODIGO_CLIENTE_COMPUESTO
                            };

                foreach (var row in query)
                {
                    var queryVta = (from todo in Entity.SELLOUT 
                                    where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta
                                    && todo.CODIGO_DISTRIBUIDOR == row.iddist && todo.CODIGO_CLIENTE_COMPUESTO == row.codComp
                                    select new
                                    {
                                        id = todo.CODIGO_DISTRIBUIDOR,
                                        vta = todo.VENTA_DOLARES,

                                    }).Sum(o => o.vta);

                    coddist = row.iddist;
                    vtacumulada = Convert.ToDouble(queryVta.Value);
                    vta = vtacumulada / vtatotal;


                    ActualizarDistribuidor(vta, abc, coddist);

                }

            }
            else if (tipo == 3)
            {
                var queryTodos = (from todo in Entity.SELLOUT
                                  join ps in Entity.PAISES 
                                  on todo.ID_COUNTRY equals ps.ID_COUNTRY
                                  where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta
                                  && todo.ID_COUNTRY == ps.ID_COUNTRY && ps.SUB_REGION==valor 
                                  select new
                                  {
                                      id = todo.CODIGO_DISTRIBUIDOR,
                                      vta = todo.VENTA_DOLARES
                                  }
                                ).Sum(o => o.vta);

                vtatotal = Convert.ToDouble(queryTodos.Value);

                var query = from q in Entity.SELLOUT  join ps in Entity.PAISES 
                            on q.ID_COUNTRY equals ps.ID_COUNTRY
                            where q.SECUENCIA_MES >= desde && q.SECUENCIA_MES <= hasta
                             &&  ps.SUB_REGION == valor && q.ID_COUNTRY== ps.ID_COUNTRY
                            select new
                            {
                                iddist = q.CODIGO_DISTRIBUIDOR,
                                codComp = q.CODIGO_CLIENTE_COMPUESTO
                            };

                foreach (var row in query)
                {
                    var queryVta = (from todo in Entity.SELLOUT
                                    where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= hasta
                                    && todo.CODIGO_DISTRIBUIDOR == row.iddist && todo.CODIGO_CLIENTE_COMPUESTO == row.codComp
                                    select new
                                    {
                                        id = todo.CODIGO_DISTRIBUIDOR,
                                        vta = todo.VENTA_DOLARES,

                                    }).Sum(o => o.vta);

                    coddist = row.iddist;
                    vtacumulada = Convert.ToDouble(queryVta.Value);
                    vta = vtacumulada / vtatotal;


                    ActualizarDistribuidor(vta, abc, coddist);

                }
            }

          
            Entity.SaveChanges();

        }
     
        void ActualizarDistribuidor(double vta,string abc,string coddist)
        {
            if (vta < 0.5)
            {
                abc = "A";
            }
            else if (vta < 0.8)
            {
                abc = "B";
            }
            else
            {
                abc = "C";
            }


            var queryTabla = from qt in Entity.CLIENTES
                             where qt.CODIGO_DISTRIBUIDOR == coddist
                             select qt;

            foreach (var rw in queryTabla)
            {
                rw.TIPO_ABC_DISTRIBUIDOR = abc;
            }
        }

        public RadDropDownList cargarDesde(RadDropDownList cb){
            cb.SelectedItem = null;
            var query = (from cbs in Entity.SELLOUT
                         group cbs by cbs.SECUENCIA_MES into g
                         orderby g.Key ascending
                        select new
                        {
                           mes=g.Key
                        }).ToList();
         
            cb.DataSource=query;
            cb.DisplayMember = "mes";
       
           

            return cb;
        
            
        }

        public RadDropDownList cargarHasta(string cbdesde, RadDropDownList cbhasta)
        {
            if (cbdesde != "")
            {
                int desde = Convert.ToInt32(cbdesde);
                var query = from cbs in Entity.SELLOUT
                            where cbs.SECUENCIA_MES > desde
                            group cbs by cbs.SECUENCIA_MES into g
                            orderby g.Key ascending
                            select new
                            {
                                mes = g.Key,

                            };


                cbhasta.DataSource = query;
                cbhasta.DisplayMember = "mes";
            }

            return cbhasta;
        }

        public RadTextBox getMeses(string desde,string hasta,RadTextBox text)
        {
            int d=Convert.ToInt32(desde.Remove(0,4));
            int h = Convert.ToInt32(hasta.Remove(0,4));
            int ad = Convert.ToInt32(desde.Remove(4,2));
            int ah = Convert.ToInt32(hasta.Remove(4,2));
            int res =(12-(d))+(h+1);
            int res2 = ((h - d) + 1);
            if ((ah - ad) == 1)
            {
                text.Text = Convert.ToString(res);
            }
            else
            {
                text.Text = Convert.ToString(res2);
            }
            
            

                return text;
        }

        public RadDropDownList cargarPais(RadDropDownList pais)
        {

            pais.SelectedItem = null;
            var query = from ps in Entity.PAISES
                        select new
                        {
                            id = ps.ID_COUNTRY,
                            name = ps.COUNTRY_NAME
                        };

            pais.DataSource = query;
            pais.ValueMember = "id";
            pais.DisplayMember = "name";
          
            return pais;
        }

        public RadDropDownList cargarDistribuidor(string ps,RadDropDownList dist,int tipo)
        {
            if (tipo == 2 && (ps!=""||ps!=null))
            {
                var query = from dis in Entity.DISTRIBUIDORES
                            where dis.PAIS == ps
                            select new
                            {
                                codigo = dis.CODIGO_DISTRIBUIDOR,
                                nam = dis.NOMBRE_DISTRIBUIDOR
                            };

                dist.DataSource = query;
                dist.ValueMember = "codigo";
                dist.DisplayMember = "nam";
            }
            return dist;
        }

        public RadDropDownList cargarRegion(RadDropDownList reg)
        {

            reg.SelectedItem = null;
            var query = from ps in Entity.PAISES
                        select new
                        {
                            
                            name = ps.REGION
                        };

            reg.DataSource = query;
            
            reg.DisplayMember = "name";

            return reg;
        }

        public RadDropDownList cargarSubRegion(RadDropDownList sreg)
        {

            sreg.SelectedItem = null;
            var query = from ps in Entity.PAISES
                        select new
                        {
                            name = ps.SUB_REGION
                        };

            sreg.DataSource = query;
            sreg.DisplayMember = "name";

            return sreg;
        }
        #endregion

        #region OPORTUNIDADES
        public void Calculo_Recuperados(string pais, int secuencia, string codDist, string nomDist,RadListControl resumen,RadGridView grid)
        {
            resumen.Items.Clear();
            int desde = secuencia - 3;
            double venta = 0;
             DataTable dt = new DataTable();
            dt.Columns.Add("Anio");
            
            dt.Columns.Add("Mes");
           // dt.Columns.Add("Secuencia_Mes");
            dt.Columns.Add("Codigo_Cliente_Compuesto");
           // dt.Columns.Add("Codigo_Distribuidor");
           // dt.Columns.Add("Nombre_Vendedor");
           // dt.Columns.Add("Codigo_Cliente");
            dt.Columns.Add("Nombre_Cliente");
           // dt.Columns.Add("Codigo_Producto_Distribuidor");
           // dt.Columns.Add("Codigo_Producto_Sap");
            //dt.Columns.Add("Nombre_Producto_Distribuidor");

            try
            {

                var queryTodos = from todo in Entity.SELLOUT join cli in Entity.CLIENTES
                                 on todo.CODIGO_DISTRIBUIDOR equals cli.CODIGO_DISTRIBUIDOR 
                                 where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES == secuencia
                                 && todo.ID_COUNTRY == pais && todo.CODIGO_DISTRIBUIDOR == codDist && todo.VENTA_DOLARES>0
                                 group todo by new{ 
                                     todo.ANIO,
                                      todo.CODIGO_CLIENTE_COMPUESTO,
                                      todo.MES,
                                      todo.NOMBRE_CLIENTE
                                  } into g 
                                  select new  
                                          {   
                                      anio=g.Key.ANIO,
                                      id =g.Key.CODIGO_CLIENTE_COMPUESTO,
                                      mes=g.Key.MES,
                                      nom=g.Key.NOMBRE_CLIENTE

                                          };

                         foreach(var rw in queryTodos){
                                      
                            var queryVta = (from todo in Entity.SELLOUT
                                            where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= secuencia
                                            && todo.CODIGO_DISTRIBUIDOR == codDist && todo.CODIGO_CLIENTE_COMPUESTO == rw.id && todo.VENTA_DOLARES!=0
                                            group todo by new{ todo.CODIGO_DISTRIBUIDOR,todo.VENTA_DOLARES
                                            } into g
                                            select new
                                            {
                                                id = g.Key.CODIGO_DISTRIBUIDOR,
                                                vta = g.Key.VENTA_DOLARES,

                                            }).Sum(o => o.vta);

                            venta = Convert.ToDouble(queryVta.Value);
                            
                          
                        


                           
                                if (venta != 0)
                                {
                                   
                                    resumen.Items.Add(rw.nom);
                                    //buffer.Add(rw2.nom);
                                    DataRow dr =dt.NewRow();
                                    dr["Anio"] = rw.anio;
                                    dr["Mes"] = rw.mes;
                                    dr["Codigo_Cliente_Compuesto"] = rw.id;
                                    dr["Nombre_Cliente"] = rw.nom;
                                    dt.Rows.Add(dr);
                                 
                                }
                                          
                            

                           
                }
                
              //  for (int i = 0; i < buffer.Count;i++ )
               // {

                        grid.EnableFiltering = true;
                        grid.ShowFilteringRow = false;
                        grid.ShowHeaderCellButtons = true;          
                        grid.DataSource = dt;
                    
                //}
            }
            catch
            {

            }

        }
    
        public void Calculo_Penetrados(string pais, int secuencia, string codDist, string nomDist, RadListControl resumen,RadGridView grid,DataTable dt)
        {
            
             string penetrar2=" ";
             dt.Clear();
         
           // DataTable dt = new DataTable();
         

            var query = (from pr in Entity.PRODUCTOS
                        join sell in Entity.SELLOUT
                        on pr.CODIGO_CORTO equals sell.CODIGO_PRODUCTOS_SAP
                        where pr.NIVEL2 != "AMBIENTALES" && pr.NIVEL2 != "DISP HIGIENICOS" && pr.NIVEL2 != "DISP JABONES"
                        && sell.ID_COUNTRY==pais && sell.CODIGO_DISTRIBUIDOR==codDist && sell.SECUENCIA_MES==secuencia
                        select new
                        {
                            id=sell.CODIGO_CLIENTE_COMPUESTO,
                            cod=sell.CODIGO_CLIENTE,
                            nomc=sell.NOMBRE_CLIENTE,
                            lao=pr.LAO_GROUP,
                            n1=pr.NIVEL1,
                            n2=pr.NIVEL2,
                            mes=sell.MES,
                            anio=sell.ANIO
                            
                        }).ToList();

            foreach (var rw in query)
            {
               /* var query2 = from seg in Entity.SEGMENTOS
                             join cli in Entity.CLIENTES
                             on seg.SEGMENT_ID equals cli.SEGMENTO_KC_ID 
                             where cli.CODIGO_CLIENTE_COMPUESTO==rw.id
                             select new
                             {
                                 seg=seg.SEGMENT_NAME
                                 
                             };*/
                var query2 = from pro in Entity.PRODUCTOS
                             join sell in Entity.SELLOUT
                             on pro.CODIGO_CORTO equals sell.CODIGO_PRODUCTOS_SAP
                             where pro.NIVEL2 != "AMBIENTALES" && pro.NIVEL2 != "DISP HIGIENICOS" && pro.NIVEL2 != "DISP JABONES" && pro.NIVEL2 != null && pro.NIVEL2!=""
                             && sell.ID_COUNTRY == pais && sell.CODIGO_DISTRIBUIDOR == codDist && sell.SECUENCIA_MES == secuencia
                             group pro by pro.NIVEL2 into g
                             select new
                             {
                                 pn=g.Key
                             };

                cont = 0;
                contu = 0;

                foreach(var rw2 in query2){
                                      

                    if (rw2.pn == "JABONES" || rw2.pn == "TOALLAS" || rw2.pn == "PAPEL HIGIENICO")
                    {
                        cont++;
                        if (cont == 3)
                        {
                            Insertar(codDist, rw.id,rw.cod,rw.lao,rw.n1,rw.n2,rw.mes,rw.anio,rw.nomc,"SANITIZANTES",dt);
                        }
                    }

                      if (rw2.pn == "WIPERS" || rw2.pn == "SAFETY")
                        {
                            penetrar2 = rw2.pn;
                            Insertar(codDist, rw.id,rw.cod,rw.lao,rw.n1,rw.n2,rw.mes,rw.anio,rw.nomc, penetrar2,dt);
                        }
                       
                        if (rw2.pn == "SERVILLETAS")
                        {
                            Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, "SERVILLETAS",dt);
                        }

                        if (rw2.pn == "FACIALES")
                        {
                            Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, "FACIALES",dt);
                        }

                        if (rw2.pn == "Manufacturing")
                        {
                            Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, "WIPERS",dt);
                            Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, "SAFETY",dt);

                        } if (rw2.pn == "Food Processing")
                        {
                            Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, "WIPERS",dt);
                            Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, "SAFETY",dt);
                        }
                    }
                

            }
            grid.EnableFiltering = true;
            grid.ShowFilteringRow = false;
            grid.ShowHeaderCellButtons = true;  
            grid.DataSource = dt;
            resumen.Items.Add("LOS CLIENTES YA HAN SIDO PENETRADOS");
                                        
        }
        public void Calculo_Penetrados_2(string pais, int secuencia, string codDist, string nomDist, RadListControl resumen, RadGridView grid, DataTable dt)
        {

            string penetrar2 = " ";

            // DataTable dt = new DataTable();


            var query = (from pr in Entity.PRODUCTOS
                         join sell in Entity.SELLOUT
                         on pr.CODIGO_CORTO equals sell.CODIGO_PRODUCTOS_SAP
                         where pr.NIVEL2 != "AMBIENTALES" && pr.NIVEL2 != "DISP HIGIENICOS" && pr.NIVEL2 != "DISP JABONES"
                         && sell.ID_COUNTRY == pais && sell.CODIGO_DISTRIBUIDOR == codDist && sell.SECUENCIA_MES == secuencia
                         select new
                         {
                             id = sell.CODIGO_CLIENTE_COMPUESTO,
                             cod = sell.CODIGO_CLIENTE,
                             nomc = sell.NOMBRE_CLIENTE,
                             lao = pr.LAO_GROUP,
                             n1 = pr.NIVEL1,
                             n2 = pr.NIVEL2,
                             mes = sell.MES,
                             anio = sell.ANIO

                         }).ToList();

            foreach (var rw in query)
            {
                var query2 = from pro in Entity.PRODUCTOS
                             join sell in Entity.SELLOUT
                             on pro.CODIGO_CORTO equals sell.CODIGO_PRODUCTOS_SAP
                             where pro.NIVEL2 != "AMBIENTALES" && pro.NIVEL2 != "DISP HIGIENICOS" && pro.NIVEL2 != "DISP JABONES" && pro.NIVEL2 != null && pro.NIVEL2 != ""
                             && sell.ID_COUNTRY == pais && sell.CODIGO_DISTRIBUIDOR == codDist && sell.SECUENCIA_MES == secuencia
                             group pro by pro.NIVEL2 into g
                             select new
                             {
                                 pn = g.Key
                             };

                contu = 0;

                foreach (var rw2 in query2)
                {
                    if (rw2.pn == "JABONES" || rw2.pn == "TOALLAS" || rw2.pn == "PAPEL HIGIENICO")
                    {
                        contu++;
                    }

                    if ((contu == 1 && rw2.pn == "JABONES") || (contu == 1 && rw2.pn == "TOALLAS") || (contu == 1 && rw2.pn == "PAPEL HIGIENICO"))
                    {
                        Insertar(codDist, rw.id, rw.cod, rw.lao, rw.n1, rw.n2, rw.mes, rw.anio, rw.nomc, rw2.pn, dt);
                    }

                }
                grid.EnableFiltering = true;
                grid.ShowFilteringRow = false;
                grid.ShowHeaderCellButtons = true;
                grid.DataSource = dt;
                resumen.Items.Add("LOS CLIENTES YA HAN SIDO PENETRADOS");

            }
        }
       
        void Insertar(string codDist,string codCli,string codc,string lao,string n1,string n2,int mes,int anio,string nom,string pn,DataTable dt )
        {

          DataRow dr = dt.NewRow();
         
              dr["Anio"] = anio;
              dr["Mes"] = mes;
              dr["Codigo_Distribuidor"] = codDist;
              dr["Codigo_Cliente_Compuesto"] = codCli;
              dr["Codigo_Cliente"] = codc;
              dr["Nombre_Cliente"] = nom;
              dr["LAO_GROUP"] = lao;
              dr["NIVEL1"] = n1;
              dr["NIVEL2"] = n2;
              dr["Penetracion"] = pn;

              dt.Rows.Add(dr);
          
        }


        #endregion

        #region KPI´S

        public void Calculo_IndicePenetracion(string pais,int secuencia,string codDist,int tipo)
        {
            switch (tipo)
            {
                case 1:
                    var query = (from sell in Entity.SELLOUT
                                join pr in Entity.PRODUCTOS
                                on sell.CODIGO_PRODUCTOS_SAP equals pr.CODIGO_CORTO
                                where sell.SECUENCIA_MES==secuencia && sell.ID_COUNTRY==pais && pr.LAO_GROUP!="NO APLICA"
                                select new
                                { 
                                    ps=sell.ID_COUNTRY,
                                    sec=sell.SECUENCIA_MES,
                                    lao=pr.LAO_GROUP.Count(),
                                    cod=sell.CODIGO_CLIENTE_COMPUESTO
                                }).ToList();


                    break;
                case 2:
                    var query2 = (from sell in Entity.SELLOUT
                                 join pr in Entity.PRODUCTOS
                                 on sell.CODIGO_PRODUCTOS_SAP equals pr.CODIGO_CORTO
                                 where sell.SECUENCIA_MES == secuencia && sell.ID_COUNTRY == pais && pr.LAO_GROUP != "NO APLICA"
                                 select new
                                 {
                                     ps = sell.ID_COUNTRY,
                                     sec = sell.SECUENCIA_MES,
                                     lao = pr.LAO_GROUP.Count(),
                                     cod = sell.CODIGO_CLIENTE_COMPUESTO
                                 }).ToList();
                    break;

               }

        }

        public decimal  Calculo_VentasNuevas(string pais, int secuencia, string codDist, int tipo)
        {
          
            switch (tipo)
            {
                case 1:
                   var query = (from vn in Entity.VENTAS_NUEVAS
                                 where vn.PAIS==pais 
                                select new
                                {
                                    total=vn.TOTAL_VENTAS_NUEVAS
                                }).Sum(x=>x.total);
                   total = query;
                    break;
                case 2:
                   var query2 = (from vn in Entity.VENTAS_NUEVAS
                                 where vn.PAIS == pais && vn.CODIGO_DISTRIBUIDOR==codDist
                                 select new
                                 {
                                     total = vn.TOTAL_VENTAS_NUEVAS
                                 }).Sum(x => x.total);
                   total = query2;

                    break;
            }
            return total;
        
        }

        public void EliminarVentasNuevas()
        {
            var query = from vn in Entity.VENTAS_NUEVAS
                        select vn;
            Entity.DeleteObject(query);
            Entity.SaveChanges();
        }

        public void InsertarClientesNuevos(string pais, int secuencia, string codCli,string codDist, int tipo, decimal vta )
        {
            VENTAS_NUEVAS vn = new VENTAS_NUEVAS();
            vn.CODIGO_DISTRIBUIDOR = codDist;
            vn.CODIGO_CLIENTE_COMPUESTO = codCli;
            vn.PAIS = pais;
            vn.SECUENCIA = secuencia;
            vn.TOTAL_VENTAS_NUEVAS = vta;

            Entity.VENTAS_NUEVAS.AddObject(vn);
            Entity.SaveChanges();

        }

        public void Calculo_Cobertura(string pais, int secuencia, string codDist, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    var query = (from sell in Entity.SELLOUT
                                 join pr in Entity.CLIENTES
                                 on sell.CODIGO_CLIENTE_COMPUESTO equals pr.CODIGO_CLIENTE_COMPUESTO
                                 where sell.SECUENCIA_MES == secuencia && sell.ID_COUNTRY == pais 
                                 select new
                                 {
                                     ps = sell.ID_COUNTRY,
                                     sec = sell.SECUENCIA_MES,
                                     nom = sell.NOMBRE_CLIENTE.Count(),
                                     cod = sell.CODIGO_CLIENTE_COMPUESTO
                                    
                                 }).ToList();


                    break;
                case 2:
                    var query2 = (from sell in Entity.SELLOUT
                                 join pr in Entity.CLIENTES
                                 on sell.CODIGO_CLIENTE_COMPUESTO equals pr.CODIGO_CLIENTE_COMPUESTO
                                 where sell.SECUENCIA_MES == secuencia && sell.ID_COUNTRY == pais 
                                 select new
                                 {
                                     ps = sell.ID_COUNTRY,
                                     sec = sell.SECUENCIA_MES,
                                     nom = sell.NOMBRE_CLIENTE.Count(),
                                     cod = sell.CODIGO_CLIENTE_COMPUESTO
                                 }).ToList();
                    break;

            }
        }

        #endregion

        #region Semaforo

        decimal getPerdido(string pais, int secuencia, string codDist, string nomDist, RadListControl resumen, RadGridView grid)
        {
            int desde = secuencia - 3;
            double venta = 0;
            decimal total=0;
            try
            {

                var queryTodos = (from todo in Entity.SELLOUT
                                  join cli in Entity.CLIENTES
                                  on todo.CODIGO_DISTRIBUIDOR equals cli.CODIGO_DISTRIBUIDOR
                                  where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES == secuencia
                                  && todo.ID_COUNTRY == pais && todo.CODIGO_DISTRIBUIDOR == codDist && todo.VENTA_DOLARES > 0
                                  select new
                                  {

                                      id = todo.CODIGO_CLIENTE_COMPUESTO,
                                      mes = todo.MES,
                                      nom = cli.NOMBRE_CLIENTE

                                  }).ToList();

                foreach (var rw in queryTodos)
                {

                    var queryVta = (from todo in Entity.SELLOUT
                                    where todo.SECUENCIA_MES >= desde && todo.SECUENCIA_MES <= secuencia
                                    && todo.CODIGO_DISTRIBUIDOR == codDist && todo.CODIGO_CLIENTE_COMPUESTO == rw.id && todo.VENTA_DOLARES != 0
                                    select new
                                    {
                                        id = todo.CODIGO_DISTRIBUIDOR,
                                        vta = todo.VENTA_DOLARES,

                                    }).Sum(o => o.vta);

                    venta = Convert.ToDouble(queryVta.Value);


                    var queryNom = (from a in Entity.CLIENTES
                                    where a.CODIGO_CLIENTE_COMPUESTO == rw.id
                                    group a by a.NOMBRE_CLIENTE into g
                                    select new
                                    {
                                        nom = g.Key
                                    }).ToList();

                    foreach (var rw2 in queryNom)
                    {
                        buffer.Add(rw2.nom);
                    }


                }

                for (int i = 0; i < buffer.Count; i++)
                {

                    if (venta != 0)
                    {
                        resumen.Items.Add(buffer[i]);
                        grid.DataSource = buffer;
                    }
                }
            }
            catch
            {

            }
            return total;
        }


        public void Caculo_Perdido(string pais)
        {
            var query = (from p in Entity.SELLOUT
                        where p.ID_COUNTRY == pais
                        group p by p.ID_COUNTRY into g
                        select new
                        {
                            id = g.Key,
                            max=g.Max(t=>t.ANIO)
                            

                        }).ToList();

            foreach (var rw in query)
            {
                var querymes = from m in Entity.SELLOUT
                               where m.ANIO == rw.max && m.ID_COUNTRY == rw.id
                               select new
                               {
                                   mes =m.MES
                               };
            }




        }
        public void Calculo_Recuperacion(string pais)
        {
            var query = (from p in Entity.SELLOUT
                         where p.ID_COUNTRY == pais
                         group p by p.ID_COUNTRY into g
                         select new
                         {
                             id = g.Key,
                             max = g.Max(t => t.ANIO)


                         }).ToList();

            foreach (var rw in query)
            {
                var querymes = from m in Entity.SELLOUT
                               where m.ANIO == rw.max && m.ID_COUNTRY == rw.id
                               select new
                               {
                                   mes = m.MES
                               };
            }
        }
        public void Calculo_Emergencia(string pais)
        {
            var query = (from p in Entity.SELLOUT
                         where p.ID_COUNTRY == pais
                         group p by p.ID_COUNTRY into g
                         select new
                         {
                             id = g.Key,
                             max = g.Max(t => t.ANIO)


                         }).ToList();

            foreach (var rw in query)
            {
                var querymes = from m in Entity.SELLOUT
                               where m.ANIO == rw.max && m.ID_COUNTRY == rw.id
                               select new
                               {
                                   mes = m.MES
                               };
            }
        }
        public void Calculo_Nuevo(string pais)
        {
            var query = (from p in Entity.SELLOUT
                         where p.ID_COUNTRY == pais
                         group p by p.ID_COUNTRY into g
                         select new
                         {
                             id = g.Key,
                             max = g.Max(t => t.ANIO)


                         }).ToList();

            foreach (var rw in query)
            {
                var querymes = from m in Entity.SELLOUT
                               where m.ANIO == rw.max && m.ID_COUNTRY == rw.id
                               select new
                               {
                                   mes = m.MES
                               };
            }
        }


        #endregion

    }



}
