using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuotesApp.Interface;
using QuotesApp.Models;

namespace QuotesApp.Services
{
    public class RestServices : IRestService
    {
        public async Task<List<Equipment>> GetEquipments()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://etestapi.test.eminenttechnology.com/api/Equipment");

            return JsonConvert.DeserializeObject<List<Equipment>>(response);
        }

        public async Task<List<Student>> GetStudents()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://etestapi.test.eminenttechnology.com/api/Student");

            return JsonConvert.DeserializeObject<List<Student>>(response);
        }

        public async Task<bool> PostEquipment(Equipment equipment)
        {
            var httpClient = new HttpClient();
            var postEquipment = JsonConvert.SerializeObject(equipment);
            var content = new StringContent(postEquipment, Encoding.UTF8, "application/json");
        
            var response =  await httpClient.PostAsync("http://etestapi.test.eminenttechnology.com/api/Equipment", content);

            return response.IsSuccessStatusCode;
        }
    }
}
