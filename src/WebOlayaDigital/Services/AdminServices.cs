using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebOlayaDigital.Interfaces;
using WebOlayaDigital.Models;
using WebOlayaDigital.Services.Commons;

namespace WebOlayaDigital.Services
{
    public class AdminServices : IAdminServices
    {
        #region "Field"
        private readonly IConfiguration _configuration;
        private readonly IConfigHttp _configHttp;
        #endregion

        public AdminServices(IConfiguration configuration, IConfigHttp configHttp)
        {
            _configuration = configuration;
            _configHttp = configHttp;
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

        public async Task<UserResponse> CrearUser(UserDto userDto)
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}user";
            UserResponse userResponse = new UserResponse();

            string _jsonData = JsonConvert.SerializeObject(userDto);
            HttpResponseMessage response = await _configHttp.GetConfigHttp().PostAsync(url,
                 new StringContent(_jsonData, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
                return new UserResponse() { Msg = $"statusCode: {response.StatusCode}, messageException: {response.Content.ReadAsStringAsync().Result}" };

            return JsonConvert.DeserializeObject<UserResponse>(await response.Content.ReadAsStringAsync());
        }

        #region "Private"

        private async Task<CategoryResponse> Categories()
        {
            string url = $"{_configuration.GetValue<string>("ConfigUrls:url")}category";
            var response = await _configHttp.GetConfigHttp().GetAsync(url);
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
