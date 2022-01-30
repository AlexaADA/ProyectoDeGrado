using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebOlayaDigital.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string Tittle { get; set; }

        public string Url { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string Category { get; set; }



        [NotMapped]
        [Required]
        public List<SelectListItem> Categories { get; set; }
    }
}
