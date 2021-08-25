using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using Api.Models;

namespace Api
{
    public class ApiHandler
    {
        private WeatherModel weather;

        public ApiHandler() { }

        public WeatherModel ApiCall()
        {
            var uri = ApiSettings.Default.Url;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream == null) return null;
                        using (StreamReader streamReader = new StreamReader(stream))
                        {
                            string responseBody = streamReader.ReadToEnd();
                            JObject json = JObject.Parse(responseBody);
                            weather = JsonConvert.DeserializeObject<WeatherModel>(responseBody);
                            return weather;
                        }
                    }
                }
            }
            catch (WebException) { return null; }
        }
    }
}
