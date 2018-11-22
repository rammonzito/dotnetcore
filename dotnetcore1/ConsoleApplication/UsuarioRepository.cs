using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    public class UsuarioRepository
    {
            //HttpClient pra ser meu postador (postman?)
            HttpClient cliente = new HttpClient();

            
            //no meu construtor...::
            public UsuarioRepository(){
                //qual a minha api
                cliente.BaseAddress = new Uri("http://localhost:5000/");

                //tipo de dado
                cliente.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );
            }
            
            //Uma tarefa que vai ir no meu postman (httpclient) e vai fazer uma ação.
            //neste caso estou usando o GetAsync que trabalha de forma semelhante ao GET do postman
            public async Task<List<Usuario>> GetUsuariosAsync(){
                try
                {
                    HttpResponseMessage response = await cliente.GetAsync("api/usuarios");
                    if (response.IsSuccessStatusCode){
                        var dados = await response.Content.ReadAsStringAsync();
                        // vou deserializar o resultado Json
                        return  JsonConvert.DeserializeObject<List<Usuario>>(dados);
                    }
                }
                catch (System.Exception ex)
                {
                    
                    throw ex;
                }
               
                //Listar a listinha de user..
                return new List<Usuario>();
            }

            public async Task<Usuario> GetUsuarioByIdAsync(int id){
                try
                {
                    HttpResponseMessage response = await cliente.GetAsync(string.Format("api/usuarios/{0}", id));
                    if (response.IsSuccessStatusCode)
                    {
                        var dados = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<Usuario>(dados);
                    }
                }
                catch (System.Exception ex)
                {
                    
                    throw ex;
                }
                return new Usuario();
            }

            public async void AddUsuario(Usuario usuario){
                var serializedUsuario = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
                var result = await cliente.PostAsync("api/usuarios", content);
            }
    }
}