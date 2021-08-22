using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebOlayaDigital.Interfaces;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Services
{
    public class AdminServices : IAdminServices
    {
        #region "Field"
        private readonly IConfiguration _configuration;
        #endregion

        public AdminServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Post> CategoriesDropList()
        {
            List<SelectListItem> selectListItem = new List<SelectListItem>();
            CategoryResponse categories = await Categories();
            if (categories != null)
            {
                foreach (var item in categories.Data)
                {
                    SelectListItem listItem = new SelectListItem();
                    listItem.Text = item.Name;
                    listItem.Value = item.Id.ToString();
                    selectListItem.Add(listItem);
                }
            }

            Post post = new Post();
            post.Categories = selectListItem;
            return post;
        }

        public async Task<bool> AddPost(Post requestPost)
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}post";

            PostDto post = new PostDto();
            post.Description = requestPost.Description;
            post.Tittle = requestPost.Tittle;
            post.Url = "Esta es una url";
            post.Id = requestPost.Id;
            post.IdCategory =  Convert.ToInt16(requestPost.Category);
            post.IdUser = 1;


            string _jsonData = JsonConvert.SerializeObject(post);
            HttpResponseMessage response = await GetConfigHttp().PostAsync(url,
                 new StringContent(_jsonData, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"statusCode: {response.StatusCode}, messageException: {response.Content.ReadAsStringAsync().Result}");
            }

            return true;
        }

        #region "Private"

        public HttpClient GetConfigHttp()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Content-Transfer-Encoding", "UTF-8");
            //client.DefaultRequestHeaders.Add("x-api-key", aFKey);
            return client;
        }

        private async Task<CategoryResponse> Categories()
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}category";
            var response = await GetConfigHttp().GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"statusCode: {response.StatusCode}, messageException: {await response.Content.ReadAsStringAsync()}");
            }
            string _json = await response.Content.ReadAsStringAsync();
            CategoryResponse categories = JsonConvert.DeserializeObject<CategoryResponse>(_json);

            return categories;
        }
        #endregion

    }
}
