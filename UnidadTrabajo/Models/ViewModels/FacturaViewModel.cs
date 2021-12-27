using System;

namespace UnidadTrabajo.Models {
    public class FacturaViewModel{
        public string PaiCod { get; set; }//pais
        public string EmpCod { get; set; }//empresa
        public string CliCod { get; set; }//cliente
        public string TieCod { get; set; }//tienda
        public string CajCod { get; set; }//cajja
        public string FacNotx { get; set; }//Notx
        public DateTime FacFecAlt { get; set; }//fecha alta
        public string FacANomD { get; set; }// a nombre de
        public string facDirFac { get; set; }//direccion
        public float FacCanFac { get; set; }//Monto
        public string ArtCod { get; set; }//codigo articulo
        public float FacPreFac { get; set; }//Precio
    }
}