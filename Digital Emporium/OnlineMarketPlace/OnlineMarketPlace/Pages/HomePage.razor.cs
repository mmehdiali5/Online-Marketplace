/*using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OnlineMarketPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Pages
{
    public partial class HomePage
    {
        private JArray result;
        List<Product> list = new List<Product> {
            new Product {Id=1, Name="Denisen Jacket", Price=500,ImgPath="images/nike.jpg"},
            new Product {Id=1, Name="Denisen Jacket", Price=500,ImgPath="images/rolex.png"},
            new Product {Id=1, Name="Denisen Jacket", Price=500,ImgPath="images/tennis.jpg"},
    };
        protected override void OnInitialized()
        {
            Console.WriteLine("In On Initialized");
            GetResponse("category");
            base.OnInitialized();
        }
        async void GetResponse(string table)
        {
            String jsonDataAsString;
            Console.Write("In GetResponse(table)");
            HttpClient http = new HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri("http://localhost:49856/odata/" + table)
            };
            var response = await http.SendAsync(requestMessage);
            jsonDataAsString = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(jsonDataAsString);
            result = (JArray)data["value"];
        }
        async Task<String> GetResponse(string table, string id)
        {
            String result;
            Console.Write("In GetResponse(table,id)");
            HttpClient http = new HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri("http://localhost:49856/odata/" + table + "?$filter=id eq" + id)
            };
            var response = await http.SendAsync(requestMessage);
            result = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(result);
            result = (String)data["value"];
            return result;
        }
        public List<Category> GetAllCategories()
        {
            List<Category> list;
            GetResponse("category");
            list = ConvertJsonArrayToList<Category>(result);
            return list;
        }
        public List<T> ConvertJsonArrayToList<T>(JArray jsonArray)
        {
            List<T> list = jsonArray.ToObject<List<T>>();
            return list;
        }
    }
}
*/