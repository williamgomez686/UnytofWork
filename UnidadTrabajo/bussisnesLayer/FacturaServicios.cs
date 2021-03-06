using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using UnidadTrabajo.Common;
using UnidadTrabajo.Models;

namespace UnidadTrabajo.bussisnesLayer
{
    public class FacturaServicios
    {
        public List<Factura> GetAll()
        { 
            var cadena = parametros.ConnectionString;
            var result = new List<Factura>();
            var consulta = @"SELECT PAICOD , EMPCOD , TIECOD , CAJCOD , FACNOTX ,TTRCOD , VENCOD , CLICOD , FACANOMDE , FACANIT , FACDIRFAC , FACDIRENT , FACEST 
                                , FACOBS , FACIVA , FACTASCAM , FACSER , FACNUM , FACTOTFAC , FACTOTDES , FACFECALT , FACUSUALT ,FACHORALT 
                                FROM FAC_FACTURA ff 
                                WHERE empcod = '00002'
                                AND TIECOD = '00001'
                                AND FACNOTX IN (96517, 96379)";
            
            try
            {
                 using(var context = new OracleConnection(cadena))
                 {
                     context.Open();

                     var cmd = new OracleCommand(consulta, context);
                     
                    using(var reader = cmd.ExecuteReader())
                    {
                         while (reader.Read())
                        {
                            var oFactura = new Factura{
                                PaiCod = reader.GetString(0),
                                EmpCod = reader.GetString(1),
                                TieCod = reader.GetString(2),
                                CajCod = reader.GetString(3),
                                FacNotx = reader.GetInt32(4),
                                TtrCod = reader.GetString(5),
                                VenCod = reader.GetString(6),
                                CliCod = reader.GetString(7),   
                                FacANomDe = reader.GetString(8),
                                FacANit = reader.GetString(9),
                                FacDirFac = reader.GetString(10),
                                FacDirRent = reader.GetString(11),
                                FacEst = reader.GetString(12),
                                FacObs = reader.GetString(13),
                                FacIva = reader.GetInt32(14),
                                FacTasCam = reader.GetInt32(15),
                                FacSer = reader.GetString(16),
                                FacNum = reader.GetInt32(17),
                                FacToFac = reader.GetInt32(18),
                                FacToDes = reader.GetInt32(19),
                                FacFecAlt = reader.GetDateTime(20),
                                FacUsuAlt = reader.GetString(21),
                                FacHoraAlt= reader.GetString(22)
                            };
                         result.Add(oFactura);
                        }
                         //obtenemos al cliente
                         foreach(var factura in result)
                         {
                             //Cliente
                            obtieneCliente(factura, context);
                         }
                     }
                 }
                 return result;
            }
            catch (Exception ex)
            {           var error = ex.Message;  
                return result;
            }
        }
        private void obtieneCliente(Factura factura, OracleConnection context)
        {
            var consulta = @"SELECT PAICOD, EMPCOD, CLICOD, CLIRAZSOC, CLINIT, CLIDIRFAC, CLIFECALT, CLIUSUALT, CLIEST, CLINOM
                                FROM CXC_CLIENTES cc 
                                WHERE EMPCOD = '00002'
                                AND CLICOD ='" + factura.CliCod+"'";
            var cmd = new OracleCommand(consulta, context);
            
            cmd.CommandType = System.Data.CommandType.Text;
            //using (OracleDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))        
            try
            {
                    using(var reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    var Cliente = new CXC_CLIENTES
                    {
                            PaiCod = reader.GetString(0),
                            EmpCod = reader.GetString(1),
                            CliCod = reader.GetString(2),
                            CliRazSoc = reader.GetString(3),
                            //CliTel1 = reader.GetString(4),
                            CliNit = reader.GetString(4),
                            CliDirFac = reader.GetString(5),
                            CliFecAlt = reader.GetDateTime(6),
                            CliUsuAlt = reader.GetString(7),
                            CliEst = reader.GetString(8),
                            CliNom = reader.GetString(9)
                            //CliShFchNac = reader.GetDateTime(11),
                            //CliShSex = reader.GetString(12)
                    };
                }       
            }
            catch (System.Exception ex)
            {
                var error = ex.Message;
                throw;
            }
        }
    }
}