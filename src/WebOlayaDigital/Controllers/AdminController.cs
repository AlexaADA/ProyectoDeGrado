using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private readonly IEmailSender _emailSender;
        public AdminController(ILogger<AdminController> logger, IPostService postService, IAdminServices adminServices, IUploadedFileIIS uploadedFileIIS, IMediaServices mediaServices, IEmailSender emailSender)
        {
            _logger = logger;
            _postService = postService;
            _adminServices = adminServices;
            _uploadedFileIIS = uploadedFileIIS;
            _mediaServices = mediaServices;
            _emailSender = emailSender;
        }

        [Route("Administrador")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<ActionResult> CreatePOST()
        {
            ViewBag.Error = string.Empty;
            Post post = await _adminServices.CategoriesDropList();
            return View(post);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
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

            var addPost = await _postService.AddPost(data);
            var inf = UploadImage(data.File, "publicaciones", addPost.Id);
            await _mediaServices.Save(inf);

            var user = await _adminServices.getAllUser();
            if (user != null)
            {
                string hostname = HttpContext.Request.Host.Value;
                var url = $"{hostname}/home/Detail/{addPost.Id}";

                foreach (var item in user.Data)
                {
                    await _emailSender.SendEmailAsync(item.Email, addPost.Tittle,
                                                $"Encuentra el artículo en el siguiente enlace <a href='{url}'>{url}</a>.");
                }
            }


            return RedirectToAction("index", "home");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult CreateCategory() => View();

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<ActionResult> CreateCategory(string nameCategories)
        {
            Post itCategory = await _adminServices.CategoriesDropList();
            string mensaje = string.Empty;

            if (itCategory != null || itCategory.Categories.Where(x => x.Text.ToUpper() == nameCategories.ToUpper()).Count() > 0)
            {
                Category category = new Category()
                {
                    Name = nameCategories,
                    Url = nameCategories.Replace(" ", "-").Trim(),
                };
                var ctg = await _adminServices.CrearCategory(category);
            }
            else
            {
                mensaje = "Ya hay una categoria con ese nombre";
                ViewBag.Error = mensaje;
                return View();
            }

            return RedirectToAction("index", "home");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<ActionResult> UpdatePost(int postId)
        {
            DetailResponse post = await _postService.DetailById(postId);

            if (post == null) return View("Error");

            var categories = await _adminServices.CategoriesDropList();
            Post model = new Post()
            {
                Categories = categories.Categories,
                Category = post.Data.IdCategory.ToString(),
                Description = post.Data.Description,
                Id = postId,
                Tittle = post.Data.Tittle,
                Url = post.Data.Url
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<ActionResult> UpdatePost(Post data)
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

            DetailResponse post = await _postService.DetailById(data.Id);

            MediaDto cover = post.Data.Media.Where(x => x.Cover == true).FirstOrDefault();
            if (cover != null)
            {
                await _mediaServices.Delete(cover.Id);
            }

            data.Enabled = true;
            bool addUpdate = await _postService.AddUpdate(data);
            var inf = UploadImage(data.File, "publicaciones", data.Id);
            await _mediaServices.Save(inf);

            return RedirectToAction("index", "home");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> DisablePost(int postId)
        {
            DetailResponse detailById = await _postService.DetailById(postId);

            Post post = new Post()
            {
                Id = postId,
                Description = detailById.Data.Description,
                Enabled = false,    
                Tittle = detailById.Data.Tittle,
                Url = detailById.Data.Url
            };

            bool addUpdate = await _postService.AddUpdate(post);
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public ActionResult Mision() => View();

        [HttpGet]
        public ActionResult Vision() => View();

        [HttpGet]
        public ActionResult Services() => View();

        [HttpGet]
        public ActionResult Sedes() => View();

        #region "Internal"
        private MediaDto UploadImage(IFormFile file, string account, int idPost)
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
                IdPost = idPost,
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
