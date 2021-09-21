using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace DI.Services
{
    public class ServerSideRequestForgeryService : IServerSideRequestForgeryService
    {
        #region Classic

        public string ClassicWithHttpClient(string path)
        {
            string result = "";

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = client.GetAsync(path).Result;
                result = response.Content.ReadAsStringAsync().Result;
                client.Dispose();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        public string ClassicWithWebClient(string path)
        {
            string result = "";

            try
            {
                WebClient client = new WebClient();

                Stream data = client.OpenRead(path);
                StreamReader reader = new StreamReader(data);
                result = reader.ReadToEnd();
                client.Dispose();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        public string ClassicWithRestClient(string path)
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

        public string ClassicWithWebRequest(string path)
        {
            string result = "";
            WebRequest webRequest = WebRequest.Create(path);

            try
            {
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();

                Stream receiveStream = response.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                StreamReader readStream = new StreamReader(receiveStream, encode);
                result = readStream.ReadToEnd();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return result;
        }

        #endregion

        #region Blind

        public string BlindWithHttpClient(string path)
        {
            string result = "Message was sended";

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = client.GetAsync(path).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                client.Dispose();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                result = "An error occured";
            }

            return result;
        }

        public string BlindWithWebClient(string path)
        {
            string result = "Message was sended";

            try
            {
                WebClient client = new WebClient();
                Stream data = client.OpenRead(path);
                client.Dispose();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                result = "An error occured";
            }

            return result;
        }

        public string BlindWithRestClient(string path)
        {
            string result = "Message was sended";

            try
            {
                RestClient client = new RestClient(path);

                var request = new RestRequest("/");
                var response = client.Get(request);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                result = "An error occured";
            }

            return result;
        }

        public string BlindWithWebRequest(string path)
        {
            string result = "Message was sended";
            WebRequest webRequest = WebRequest.Create(path);

            try
            {
                WebResponse response = webRequest.GetResponse();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                result = "An error occured";
            }

            return result;
        }
        #endregion
    }
}
