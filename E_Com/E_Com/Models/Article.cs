using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class Article
    {
        public int articleID { get; set; }
        public string articleName { get; set; }
        public string image { get; set; }
        public int stock { get; set; }
        public decimal prix { get; set; }
        public int categorieID { get; set; }
        public Categorie categorie { get; set; }
        public ICollection<Commande> commandes { get; set; }
    }
}
