using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOlayaDigital.Models
{
    public class CategoryResponse
    {
        public string Msg { get; set; }
        public IEnumerable<Category> Data { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
