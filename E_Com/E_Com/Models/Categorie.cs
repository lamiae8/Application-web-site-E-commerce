using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class Categorie
    {
        public int categorieID { get; set; }
        public string categorieName { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
