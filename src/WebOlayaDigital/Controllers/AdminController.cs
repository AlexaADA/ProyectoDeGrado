using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOlayaDigital.Interfaces;
using WebOlayaDigital.Models;

namespace WebOlayaDigital.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IPostService _postService;
        private readonly IAdminServices _adminServices;
        public AdminController(ILogger<AdminController> logger, IPostService postService, IAdminServices adminServices)
        {
            _logger = logger;
            _postService = postService;
            _adminServices = adminServices;
        }

        [Route("Administrador")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> CreatePOST()
        {
            Post post = await _adminServices.CategoriesDropList();

            return View(post);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePOST(Post data)
        {
            bool statud = await _adminServices.AddPost(data);
            return View();
        }


        public ActionResult Test()
        {
            return View();
        }
    }
}
