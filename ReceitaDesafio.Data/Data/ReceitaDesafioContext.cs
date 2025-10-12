using Microsoft.EntityFrameworkCore;
using ReceitaDesafio.Data.Mappping;
using ReceitaDesafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Data.Data
{
    public class ReceitaDesafioContext : DbContext
    {
        public ReceitaDesafioContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Receita> Receitas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReceitaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
