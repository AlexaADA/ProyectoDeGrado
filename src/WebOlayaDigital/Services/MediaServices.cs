using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebOlayaDigital.Interfaces;
using WebOlayaDigital.Models;
using WebOlayaDigital.Services.Commons;

namespace WebOlayaDigital.Services
{
    public class MediaServices : IMediaServices
    {
        #region "Field"
        private readonly IConfiguration _configuration;
        private readonly IConfigHttp _configHttp;
        #endregion

        public MediaServices(IConfiguration configuration, IConfigHttp configHttp)
        {
            _configuration = configuration;
            _configHttp = configHttp;
        }

        public async Task<bool> Save(MediaDto info)
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}media";

            string _jsonData = JsonConvert.SerializeObject(info);
            HttpResponseMessage response = await _configHttp.GetConfigHttp().PostAsync(url,
                 new StringContent(_jsonData, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                _ = $"statusCode: {response.StatusCode}, messageException: {response.Content.ReadAsStringAsync().Result}";
                return false;
            }

            return true;
        }
    }
}
