using System;
namespace UnidadTrabajo.Models
{
    public class CXC_CLIENTES : mmc
    {
        public string  CliCod { get; set; }
        public string  CliRazSoc { get; set; }
        //public string ?CliTel1 { get; set; }
        public string CliNit { get; set; }
        public string CliDirFac { get; set; }
        public DateTime CliFecAlt { get; set; }
        public string CliUsuAlt { get; set; }
        public string CliEst { get; set; }
        public string CliNom { get; set; }
        //public DateTime ?CliShFchNac { get; set; }
        //public string ?CliShSex { get; set; }
    }
}