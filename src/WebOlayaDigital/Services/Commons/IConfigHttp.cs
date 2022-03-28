using System.Net.Http;

namespace WebOlayaDigital.Services.Commons
{
    public interface IConfigHttp
    {
        HttpClient GetConfigHttp();
    }

    public class ConfigHttp : IConfigHttp
    {
        public HttpClient GetConfigHttp()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Content-Transfer-Encoding", "UTF-8");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("x-api-key", aFKey);
            return client;
        }
    }
}
