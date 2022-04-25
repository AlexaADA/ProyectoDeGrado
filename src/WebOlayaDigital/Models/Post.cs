using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebOlayaDigital.Models
{
    public class ResponsePost
    {
        public string Msg { get; set; }
        public Post Data { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Tittle { get; set; }

        public string Url { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }

        public bool Enabled { get; set; }

        //[Required(ErrorMessage = "El campo es requerido")]
        [NotMapped]
        [Display(Name = "Imagen")]
        public IFormFile File { get; set; }

        [NotMapped]
        public List<SelectListItem> Categories { get; set; }
    }
}
