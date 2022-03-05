using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebOlayaDigital.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string Tittle { get; set; }

        public string Url { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }

        //[Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Imagen")]
        public IFormFile File { get; set; }

        public List<SelectListItem> Categories { get; set; }
    }
}
