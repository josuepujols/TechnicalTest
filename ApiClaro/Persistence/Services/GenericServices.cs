using Persistence.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Persistence.Models;
using System.Net.Http;

namespace Persistence.Services
{
    public class GenericServices<T> : IServices<T> where T : class
    {
        //Generic service to interact with any entity 
        private readonly HttpClient http;
        private readonly string url = "https://fakerestapi.azurewebsites.net/api/v1/Books";

        public GenericServices()
        {
            http = new HttpClient();
        }


        public async Task<bool> AddAsync(T Entity)
        {
            var json = JsonConvert.SerializeObject(Entity);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var ServerResponse = await http.PostAsync(url, data);

            //catch the response form the server 
            var result = ServerResponse.Content.ReadAsStringAsync();

            if (result.IsCompletedSuccessfully)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var response = await http.DeleteAsync(url + "/" + Id);
            var result = response.Content.ReadAsStringAsync();

            if (result.IsCompletedSuccessfully)
            {
                return true;
            }

            return false;
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            var response = await http.GetStringAsync(url + "/" + Id);
            var data = JsonConvert.DeserializeObject<T>(response);

            return data;
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            //Get all from the services 
            var response = await http.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<List<T>>(response);

            return data;
        }

        public async Task<bool> UpdateAsync(int Id, T Entity)
        {
            var json = JsonConvert.SerializeObject(Entity);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var ServerResponse = await http.PutAsync(url + "/" + Id, data);

            //catch the response form the server 
            var result = ServerResponse.Content.ReadAsStringAsync();

            if (result.IsCompletedSuccessfully)
            {
                return true;
            }

            return false;
        }
    }
}
