using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly ICommentService _commentService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminServices _adminServices;

        public HomeController(ILogger<HomeController> logger, IPostService postService, IUploadedFileIIS uploadedFileIIS, IMediaServices mediaServices, ICommentService commentService, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IAdminServices adminServices)
        {
            _logger = logger;
            _postService = postService;
            _uploadedFileIIS = uploadedFileIIS;
            _mediaServices = mediaServices;
            _commentService = commentService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _adminServices = adminServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Post categoriesDropList = await _adminServices.CategoriesDropList();
            List<(string name, string url)> categories = new List<(string name, string url)>();
            categoriesDropList.Categories.ForEach(ctgry => categories.Add((ctgry.Text, ctgry.Value)));
            PostResponse post = await _postService.TopPost();

            HomeModel model = new HomeModel();
            model.Post = post.Data.Take(10).ToList();
            model.Categories = categories;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id, string msg)
        {
            List<string> roles = new List<string>();

            if (!string.IsNullOrEmpty(User.Identity.Name))
            {
                IdentityUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                roles = (List<string>) await _userManager.GetRolesAsync(user);
            }
            else
            {
                roles.Add("UserApp");
            }

            ViewBag.Roles = roles;

            DetailResponse detail = await _postService.DetailById(id);
            ViewBag.Error = msg;

            return View(detail);
        }

        [HttpPost]
        public async Task<IActionResult> Galleries(List<IFormFile> formFile, int idPost)
        {
            int ThreeMegaBytes = 3 * 1024 * 1024;
            List<MediaDto> dataMedia = new List<MediaDto>();

            if (formFile.Count == 0)
            {
                return RedirectToAction("Detail", new { id = idPost, msg = "Seleccione una o más imagenes." });
            }

            foreach (var img in formFile)
            {
                if (img == null)
                {
                    return RedirectToAction("Detail", new { id = idPost, msg = "Una o varias imagenes no tiene el formato correcto." });
                }
                else if (string.IsNullOrEmpty(SupportedExtensions(img.ContentType)))
                {
                    return RedirectToAction("Detail", new { id = idPost, msg = "La imagen es obligatoria." });

                }
                else if (img.Length > ThreeMegaBytes)
                {
                    return RedirectToAction("Detail", new { id = idPost, msg = "Una o varias imagens cargada exceden los 300 kb, cargue imagenes más pequeña." });
                }

                dataMedia.Add(UploadImage(img, "publicaciones", idPost.ToString()));
            }

            foreach (var dataImage in dataMedia)
            {
                await _mediaServices.Save(dataImage);
            }

            return RedirectToAction("Detail", new { id = idPost, msg = string.Empty });
        }

        [HttpPost]
        public async Task<IActionResult> Comment(int idPost, int idUser, string comment)
        {
            if (comment == null)
            {
                ViewBag.Error = "No puede enviar un comentario nulo";
            }
            else if (comment.Length > 500)
            {
                ViewBag.Error = "No puede superar los 500 caracteres";
                return RedirectToAction("Detail", new { id = idPost });
            }

            await _commentService.Save(idPost, idUser, comment);

            ViewBag.Error = "Se agrego correctamente el comentario";
            return RedirectToAction("Detail", new { id = idPost });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Categories(string nameCategory)
        {
            PostResponse post = await _postService.TopPost();
            Post categoriesDropList = await _adminServices.CategoriesDropList();
            List<(string name, string url)> categories = new List<(string name, string url)>();
            categoriesDropList.Categories.ForEach(ctgry =>
            {
                if (ctgry.Value == nameCategory)
                {
                    categories.Add((ctgry.Text, ctgry.Value));
                };
            });

            HomeModel model = new HomeModel();
            model.Post = post.Data.Where(ctg => ctg.IdCategory == int.Parse(nameCategory)).ToList();
            model.Categories = categories;
            return View(model);
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
