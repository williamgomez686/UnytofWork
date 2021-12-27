using System;

namespace services
{
    public class services
    {
        public string cadena = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=190.113.91.179)(PORT=55847)) (CONNECT_DATA=(SERVICE_NAME=MMC))); User Id=ADMINISTRADOR;Password=1nfabc123;";
        public static services _instancia = null;

        private services()
        {

        }

        public static services Intancia {
            get {
                if (_instancia == null){
                    _instancia = new services();
                }
                return _instancia;
            }
        }
    }
    
}


