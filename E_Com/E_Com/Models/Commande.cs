using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Com.Models
{
    public class Commande
    {
        public int commandeID { get; set; }
        public DateTime dateCommande { get; set; }
        public string address { get; set; }
        public int quantite { get; set; }
        
        public int articleID { get; set; }
        public Article article { get; set; }
    }
}