using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using E_Com.Models;

namespace E_Com.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<E_Com.Models.Categorie> Categorie { get; set; }
        public DbSet<E_Com.Models.Article> Article { get; set; }
        public DbSet<E_Com.Models.Commande> Commande { get; set; }
    }
}
