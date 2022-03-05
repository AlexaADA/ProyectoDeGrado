using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebOlayaDigital.Interfaces;
using WebOlayaDigital.Models;
using WebOlayaDigital.Services.Commons;

namespace WebOlayaDigital.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IPostService _postService;
        private readonly IAdminServices _adminServices;
        private readonly IUploadedFileIIS _uploadedFileIIS;
        public AdminController(ILogger<AdminController> logger, IPostService postService, IAdminServices adminServices, IUploadedFileIIS uploadedFileIIS)
        {
            _logger = logger;
            _postService = postService;
            _adminServices = adminServices;
            _uploadedFileIIS = uploadedFileIIS;
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
            string name = UploadImage(data.File, "publicaciones");
            bool statud = await _adminServices.AddPost(data);

            //Crear correo pa todos los usuarios registrados.
            //Logica...

            return RedirectToAction("index","home");
        }


        public string UploadImage(IFormFile file, string account)
        {
            string nameImagen = string.Empty;
            if (file.Length >= 300000)
                throw new Exception("La imagen cargada no puede exceder los 300 kb, cargue una imagen más pequeña.");

            if (file.ContentType == ".jpg" || file.ContentType == ".png" || file.ContentType == ".jpeg")
                throw new Exception("La imagen no tiene el formato correcto.");

            try
            {
                _uploadedFileIIS.UploadedFileImage(file, Guid.NewGuid().ToString(), account);
            }
            catch (Exception)
            {
                throw new Exception("Uploaded file is not recognized as an image.");
            }
            return nameImagen;
        }
    }
}
