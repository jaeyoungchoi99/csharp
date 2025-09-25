using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.ComponentModel;
using System.IO.Pipes;


namespace jaeyoung
{
    internal class Api
    {
        public static HttpClient client = new HttpClient();

        public async Task<List<UserDto>> GetData()
        {
            var url = "http://localhost:8080/api/users";

            var data = await client.GetFromJsonAsync<List<UserDto>>(url);

            return data;

        }

        public async Task<HttpResponseMessage> Signup(UserDto userdto)
        {
            var url = "http://localhost:8080/api/signup";
            return await client.PostAsJsonAsync(url, userdto);
        }
        
        public async Task<HttpResponseMessage> Modify(UserDto userdto)
        {
            var url = "http://localhost:8080/api/modify";
            return await client.PostAsJsonAsync(url, userdto);
        }

        public async Task<HttpResponseMessage> Delete(string u_id)
        {
            var url = $"http://localhost:8080/api/delete/{u_id}";
            return await client.DeleteAsync(url);
        }

    }
}
