using Microsoft.EntityFrameworkCore;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Infra
{
    public class MercadoTechDbContext : DbContext
    {
        public MercadoTechDbContext() : base() { }

        public virtual DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            optionsBuider.UseSqlServer(@"Server=DESKTOP-8O8S6E4\SQLEXPRESS;Database=MercadoTech;Trusted_Connection=True");
        }
    }
}
