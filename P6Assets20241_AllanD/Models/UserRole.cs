using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace P6Assets20241_AllanD.Models
{
    public class UserRole
    {
        //cuando queremos comunicarnos con el API hay dos formas más usadas
        //1. Con las librerías nativas de .NET
        //2. o usando herramientas de terceros. 
        //en lo personal he encontrado más fácil y eficiente el uso de 
        //restSharp. 

        public RestRequest request { get; set; }
        const string mimeType = "application/json";
        const string contentType = "Content-Type";

        public int UserRoleId { get; set; }

        public string UserRoleDescription { get; set; } = null!;

        //FUNCIONES 
        //cargar todos los roles de usuario

        public async Task<List<UserRole>?> GetAllUserRolesAsync()
        {
            try
            {
                //tenemos que armar la ruta completa de consumo del API 
                //para eso tenemos en WebAPIConnection la ruta base del API
                //y acá la completamos 
                string RouterSufix = string.Format("UserRoles");

                //armamos la ruta completa de consumo del API 
                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;
                //ahora tenemos la ruta completa lista 
                                
                //configuramos el request 
                var client = new RestClient(URL);

                request = new RestRequest(URL, Method.Get);

                //agregamos el método se seguridad, en este caso tenemos apikey 
                request.AddHeader(Services.WebAPIConnection.ApiKeyName,
                                  Services.WebAPIConnection.ApiKeyValue);

                //y ahora ejecutamos la llamada al API
                RestResponse response = await client.ExecuteAsync(request);

                //validamos que todo haya salido bien 
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //si obtuvimos respuesta positiva desde el API 
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;
                throw;
            }

        }






    }
}
