using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using UnidadTrabajo.Common;
using UnidadTrabajo.Models;

namespace UnidadTrabajo
{
    public class servicos
    {
        public string cadena = parametros.ConnectionString; 
        public static servicos _instancia = null;

        private servicos()
        {

        }

        public static servicos Intancia
         {
            get 
            {
                if (_instancia == null)
                {
                    _instancia = new servicos();
                }
                return _instancia;
            }
        }

public List<FacturaViewModel> Listar()
        {
            List<FacturaViewModel> oFactura = new List<FacturaViewModel>();
            try
            {
                using (OracleConnection db = new OracleConnection(cadena))
            {
                string consulta = @"SELECT ff.FACFECALT, ff.FACANOMDE, ff.CLICOD, ff.FACDIRFAC, ffd.FACCANFAC, ffd.ARTCOD, ffd.FACPREFAC
                                        FROM FAC_FACTURA ff 
	                                        INNER JOIN FAC_FACTURA_DETALLE ffd 
		                                        ON ff.FACNOTX = ffd.FACNOTX 
                                                AND ff.EMPCOD  = ffd.EMPCOD 
                                        WHERE ff.EMPCOD = '00002'
                                        AND ff.TIECOD = '00001'
                                        AND ff.FACNOTX  = 98352";
                db.Open();
                using (OracleCommand cmd = new OracleCommand(consulta, db))
                {
                    cmd.CommandType = CommandType.Text;
                    using (OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {                                
                            oFactura.Add(new FacturaViewModel()
                            { 
                                FacFecAlt = dr.GetDateTime(0),
                                FacANomD = dr.GetString(1),
                                CliCod = dr.GetString(2),
                                facDirFac = dr.GetString(3),
                                FacCanFac = dr.GetInt32(4),
                                ArtCod = dr.GetString(5),
                                FacPreFac = dr.GetInt32(6)
                            });
                        }
                    }
                }
                return oFactura;
            }
            }
            catch(Exception ex)
            { 
                var error = $"Ocurrio un Error: {ex.Message}";
                return oFactura;
            }
        }

    }
}