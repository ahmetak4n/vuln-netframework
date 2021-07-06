using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace DI.Services
{
    public class ServerSideRequestForgeryService : IServerSideRequestForgeryService
    {
        public string SyncHttpClient(string path)
        {
            string result = "";

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = client.GetAsync(path).Result;
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        public string SyncWebClient(string path)
        {
            string result = "";

            try
            {
                WebClient client = new WebClient();

                Stream data = client.OpenRead(path);
                StreamReader reader = new StreamReader(data);
                result = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        public string SyncRestClient(string path)
        {
            string result = "";

            try
            {
                RestClient client = new RestClient(path);

                var request = new RestRequest("/");
                var response = client.Get(request);

                result = response.Content;
                
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }
    }
}
