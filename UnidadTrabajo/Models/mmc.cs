using System;
using System.Collections.Generic;

namespace UnidadTrabajo.Models
{
    public class mmc
    {
        public string PaiCod { get; set; }//pais
        public string EmpCod { get; set; }//Empresa
        public DateTime FechAlt { get; set; }//Fecha de Alta
        public DateTime FechMod { get; set; }//Fecha de Modificacion
        public string UsuAlt { get; set; }// Usuario que dio de Alta
        public string UsuMod { get; set; }// Usuario que modifico

    }
}
