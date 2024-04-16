using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Assets20241_AllanD.Services
{
    public static class WebAPIConnection
    {
        //acá definimos la ruta raíz del URL del servicio web (API Rest)
        //a esta raíz, que llamaremos Prefijo, se le debe adjuntar 
        //el resto de la ruta URL, que llamares Sufijo, para cada
        //endpoint que vayamos a usar 

        //además, es importante indicar que normalmente los APIs 
        //trabajan en dos versiones: Pruebas y Producción 

        public static string ProductionURLPrefix = "http://192.168.0.10:45455/api/";

        public static string TestingURLPrefix = "http://192.168.0.10:45455/api/";

        //además de la raíz de URL acá vamos a indicar cuál es la API Key que deberíamos 
        //usar para consumir los endpoints 
        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "AllanDP6Apik123454321abc";

        public static string MimeType = "application/json";
        public static string ContentType = "Content-Type";


    }
}
