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
    public class PostService : IPostService
    {
        #region "Field"
        private readonly IConfiguration _configuration;
        private readonly string getPostAPI = "ConfigUrls:url";
        private readonly IConfigHttp _configHttp;
        #endregion

        public PostService(IConfiguration configuration, IConfigHttp configHttp)
        {
            _configuration = configuration;
            _configHttp = configHttp;
        }

        public async Task<PostResponse> TopPost()
        {
            Uri _getPostAPI = new Uri($"{_configuration.GetValue<string>(getPostAPI)}post");
            var _httpClient = new HttpClient();
            var _json = await _httpClient.GetStringAsync(_getPostAPI.ToString());

            return JsonConvert.DeserializeObject<PostResponse>(_json);
        }

        public async Task<DetailResponse> DetailById(int id)
        {
            Uri _getPostAPI = new Uri($"{_configuration.GetValue<string>(getPostAPI)}post/{id}");
            var _httpClient = new HttpClient();
            var _json = await _httpClient.GetStringAsync(_getPostAPI.ToString());

            return JsonConvert.DeserializeObject<DetailResponse>(_json);
        }

        public async Task<Post> AddPost(Post requestPost)
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}post";

            PostDto post = new PostDto();
            post.Description = requestPost.Description;
            post.Tittle = requestPost.Tittle;
            post.Url = Guid.NewGuid().ToString();
            post.Id = requestPost.Id;
            post.IdCategory = Convert.ToInt16(requestPost.Category);
            post.IdUser = 1;


            string _jsonData = JsonConvert.SerializeObject(post);
            HttpResponseMessage response = await _configHttp.GetConfigHttp().PostAsync(url,
                 new StringContent(_jsonData, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"statusCode: {response.StatusCode}, messageException: {response.Content.ReadAsStringAsync().Result}");
            }

            _jsonData = await response.Content.ReadAsStringAsync();
            ResponsePost responsePost = JsonConvert.DeserializeObject<ResponsePost>(_jsonData);
            return responsePost.Data;
        }

        public async Task<bool> AddUpdate(Post requestPost)
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}post?id={requestPost.Id}";

            PostDto post = new PostDto();
            post.Description = requestPost.Description;
            post.Tittle = requestPost.Tittle;
            post.Url = Guid.NewGuid().ToString();
            post.Id = requestPost.Id;
            post.IdCategory = Convert.ToInt16(requestPost.Category);
            post.IdUser = 1;


            string _jsonData = JsonConvert.SerializeObject(post);
            HttpResponseMessage response = await _configHttp.GetConfigHttp().PutAsync(url,
                 new StringContent(_jsonData, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"statusCode: {response.StatusCode}, messageException: {response.Content.ReadAsStringAsync().Result}");
            }

            return true;
        }

    }
}
