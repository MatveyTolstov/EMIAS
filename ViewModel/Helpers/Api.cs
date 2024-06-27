using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EMIAS.ViewModel.Helpers
{
    internal class Api
    {
        private static string Url = "https://localhost:7280/api/";

        //метод для обновления данных передаем id и данные

        public static string Put(string json, int id, string additional)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage message = client.PutAsync(Url + additional + id, content).Result;
                return message.Content.ReadAsStringAsync().Result;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //метод для получение данных 

        public static string Get(string additional)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage message = client.GetAsync(Url+ additional).Result;
                return message.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //метод для обновления данных передаем id 

        public static string GetByID(int id, string additional)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage message = client.GetAsync(Url + additional + id).Result;
                return message.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        //метод для создания данных передаем данные

        public static string Post(string json, string additional)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage message = client.PostAsync(Url+additional, content).Result;
                return message.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //метод для удаления данных

        public static string Delete(int id, string additional)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage message = client.DeleteAsync(Url + additional + id).Result;
                return message.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
