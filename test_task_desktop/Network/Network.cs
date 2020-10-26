using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Classes;
using test_task_desktop.Interfaces;
using test_task_desktop.Models;

namespace test_task_desktop.Networking
{
    class Network 
    {
        const string link = "http://localhost:51218/api/notes";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<Note>> GetAll()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(link);
            IDeserialize des = new JsConvert();
            return des.DeserializeObj<Note>(result);
        }

        public async Task<string> Get(int id)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(link+'/'+id);
            return result;
        }

        public async void Create(StringContent stringcontent)
        {
            HttpClient client = GetClient();
            var result = await client.PostAsync(link, stringcontent);
        }

        public async void Update(int id,StringContent stringcontent)
        {
            HttpClient client = GetClient();
            var result = await client.PutAsync(link+'/'+id, stringcontent);
        }

        public async void Delete(int id)
        {
            HttpClient client = GetClient();
            var result = await client.DeleteAsync(link + '/' + id);
        }
    }
}
