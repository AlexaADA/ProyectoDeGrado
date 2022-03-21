using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
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
        private readonly string enpoind = "ConfigUrls:url";
        #endregion

        public MediaServices(IConfiguration configuration, IConfigHttp configHttp)
        {
            _configuration = configuration;
            _configHttp = configHttp;
        }

        public async Task<bool> Save(MediaDto info)
        {
            string url = $"{_configuration.GetValue<string>(enpoind)}media";

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

        public async Task<DetailResponse> DetailById(int id)
        {
            Uri _getPostAPI = new Uri($"{_configuration.GetValue<string>(enpoind)}media/{id}");
            var _httpClient = new HttpClient();
            var _json = await _httpClient.GetStringAsync(_getPostAPI.ToString());

            return JsonConvert.DeserializeObject<DetailResponse>(_json);
        }

    }
}
