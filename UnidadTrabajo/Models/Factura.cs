using System;
using System.Collections.Generic;

namespace UnidadTrabajo.Models
{
    public class Factura : mmc
    {

        public string TieCod { get; set; }//Codigo de la Tienda
        public string CajCod { get; set; }//Codigo de Cajero
        public int FacNotx { get; set; }//Notx
        public string TtrCod { get; set; }
        public string VenCod { get; set; }
        public string CliCod { get; set; }//Codigo del cliente o NIT    
        public IEnumerable<Fac_Factura_Detalle> detalle{ get; set;} // datos de prueba
        public string FacANomDe { get; set; }// a nombre de
        public string FacANit { get; set; }//NIT
        public string FacDirFac { get; set; }//Direccion de la factura
        public string FacDirRent { get; set; }
        public string FacEst { get; set; }//estado de la factura
        public string FacObs { get; set; }//observaciones
        public int FacIva { get; set; }// monto de IVA
        public int FacTasCam { get; set; }
        public string FacSer { get; set; }//Serie de la Factura
        public int FacNum { get; set; }//Numero de la factura
        public int FacToFac { get; set; }
        public int FacToDes { get; set; }
        public string FacUsuAlt { get; set; }
        public string FacHoraAlt {get; set;}
        public CXC_CLIENTES CliCodId {get; set;}

       public Factura()
        {
            detalle = new List<Fac_Factura_Detalle>();
        }
        
    }
}
