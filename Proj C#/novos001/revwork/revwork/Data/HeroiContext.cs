using Microsoft.EntityFrameworkCore;
using revwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revwork.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=HeroApp;Data Source=DESKTOP-EFLO2U3\\SQLEXPRESS");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(chaves =>
            {
                chaves.HasKey(o => new { o.BatalhaId, o.HeroiId });
            });
        }
















        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<HeroiBatalha>(entity =>
        //    {
        //        entity.HasKey(e => new {e.BatalhaId, e.HeroiId });
        //    });
        //}
    }
}
