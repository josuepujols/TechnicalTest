using Newtonsoft.Json;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.BookService
{
    public class BookServices
    {
        private readonly HttpClient http;
        HttpClientHandler clientHandler;
        private readonly string url = "https://localhost:5001/api/Books";

        public BookServices()
        {
            //this is to bypass ssl certificate 
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            //pass by pass to the constructor 
            http = new HttpClient(clientHandler);
        }

        public async Task<bool> Add(Book book)
        {
            var json = JsonConvert.SerializeObject(book);
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

        public async Task<bool> Delete(int Id)
        {
            var response = await http.DeleteAsync(url + "/" + Id);
            var result = response.Content.ReadAsStringAsync();

            if (result.IsCompletedSuccessfully)
            {
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Book>> GetAll(string BookId)
        {
            int Id = 0;

            try
            {
                if (BookId != "")
                {
                    Id = Convert.ToInt32(BookId);
                }
                
            }
            catch(Exception ex)
            {
                throw;
            }

            var response = await http.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<List<Book>>(response);

            if (Id != 0)
            {
                data = data.FindAll(x => x.Id == Id).Take(5).ToList();
            }

            return data;
        }

        public async Task<Book> GetById(int Id)
        {
            var response = await http.GetStringAsync(url + "/" + Id);
            var data = JsonConvert.DeserializeObject<Book>(response);

            return data;
        }

        public async Task<bool> Update(int Id, Book book)
        {
            var json = JsonConvert.SerializeObject(book);
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
