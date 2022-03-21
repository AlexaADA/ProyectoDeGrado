using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebOlayaDigital.Interfaces;
using WebOlayaDigital.Models;
using WebOlayaDigital.Services.Commons;

namespace WebOlayaDigital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostService _postService;
        private readonly IUploadedFileIIS _uploadedFileIIS;
        private readonly IMediaServices _mediaServices;
        public HomeController(ILogger<HomeController> logger, IPostService postService, IUploadedFileIIS uploadedFileIIS, IMediaServices mediaServices)
        {
            _logger = logger;
            _postService = postService;
            _uploadedFileIIS = uploadedFileIIS;
            _mediaServices = mediaServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            HomeModel model = new HomeModel();
            model.Post = await _postService.TopPost();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            DetailResponse detail = await _postService.DetailById(id);
            ViewBag.Error = string.Empty;

            return View(detail);
        }

        [HttpPost]
        public async Task<IActionResult> Galleries(List<IFormFile> formFile, int idPost)
        {
            int ThreeMegaBytes = 3 * 1024 * 1024;
            List<MediaDto> dataMedia = new List<MediaDto>();

            foreach (var img in formFile)
            {
                if (img == null)
                {
                    ViewBag.Error = "Una o varias imagenes no tiene el formato correcto.";
                    return RedirectToAction("Detail", new { id = idPost });
                }
                else if (string.IsNullOrEmpty(SupportedExtensions(img.ContentType)))
                {
                    ViewBag.Error = "La imagen es obligatoria.";
                    return RedirectToAction("Detail", new { id = idPost });

                }
                else if (img.Length > ThreeMegaBytes)
                {
                    ViewBag.Error = "Una o varias imagens cargada exceden los 300 kb, cargue imagenes más pequeña.";
                    return RedirectToAction("Detail", new { id = idPost });
                }

                dataMedia.Add(UploadImage(img, "publicaciones", idPost.ToString()));
            }

            foreach (var dataImage in dataMedia)
            {
                await _mediaServices.Save(dataImage);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

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
                Cover = false,
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
