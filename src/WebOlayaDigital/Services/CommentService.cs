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
    public class CommentService : ICommentService
    {
        #region "Field"
        private readonly IConfiguration _configuration;
        private readonly IConfigHttp _configHttp;
        private readonly string enpoind = "ConfigUrls:url";
        #endregion

        public CommentService(IConfiguration configuration, IConfigHttp configHttp)
        {
            _configuration = configuration;
            _configHttp = configHttp;
        }

        public async Task<bool> Save(int idPost, int idUser, string comment)
        {
            string url = $"{_configuration.GetValue<string>(enpoind)}Comment";

            CommentDto commentDto = new CommentDto()
            {
                IdPost = idPost,
                IdUser = idUser,
                Description = comment
            };

            string _jsonData = JsonConvert.SerializeObject(commentDto);
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
