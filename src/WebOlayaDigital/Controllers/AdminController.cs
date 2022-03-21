using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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
        private readonly IMediaServices _mediaServices;
        public AdminController(ILogger<AdminController> logger, IPostService postService, IAdminServices adminServices, IUploadedFileIIS uploadedFileIIS, IMediaServices mediaServices)
        {
            _logger = logger;
            _postService = postService;
            _adminServices = adminServices;
            _uploadedFileIIS = uploadedFileIIS;
            _mediaServices = mediaServices;
        }

        [Route("Administrador")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> CreatePOST()
        {
            ViewBag.Error = string.Empty;
            Post post = await _adminServices.CategoriesDropList();
            return View(post);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePOST(Post data)
        {
            var categories = await _adminServices.CategoriesDropList();
            int ThreeMegaBytes = 3 * 1024 * 1024;

            if (data.File == null)
            {
                ViewBag.Error = "La imagen no tiene el formato correcto.";
                data.Categories = categories.Categories;
                return View(data);
            }
            else if (string.IsNullOrEmpty(SupportedExtensions(data.File.ContentType)))
            {
                ViewBag.Error = "La imagen es obligatoria.";
                data.Categories = categories.Categories;
                return View(data);

            }
            else if (data.File.Length > ThreeMegaBytes)
            {
                ViewBag.Error = "La imagen cargada no puede exceder los 300 kb, cargue una imagen más pequeña.";
                data.Categories = categories.Categories;
                return View(data);
            }

            string idPost = await _postService.AddPost(data);
            var inf = UploadImage(data.File, "publicaciones", idPost);
            await _mediaServices.Save(inf);

            //Crear correo pa todos los usuarios registrados.
            //Logica...

            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public ActionResult Mision() => View();

        [HttpGet]
        public ActionResult Vision() => View();


        #region "Internal"
        private MediaDto UploadImage(IFormFile file, string account, string idPost)
        {
            string nameImagen = Guid.NewGuid().ToString();
            string uniqueFileName;

            try
            {
                uniqueFileName = _uploadedFileIIS.UploadedFileImage(file, nameImagen, account);
            }
            catch (Exception)
            {
                throw new Exception("El archivo subido no se reconoce como una imagen.");
            }

            return new MediaDto()
            {
                Cover = true,
                Extension = file.ContentType,
                IdPost = int.Parse(idPost),
                FileName = nameImagen,
                Route = uniqueFileName,
                FileSize = file.Length
            };
        }
        internal string SupportedExtensions(string contentType)
        {
            List<string> supportedExtensions = new List<string>()
            {
                "image/jpeg",
                "image/jpg",
                "image/png"
            };

            return supportedExtensions.Where(supported => supported == contentType).FirstOrDefault();
        }
        #endregion
    }
}
