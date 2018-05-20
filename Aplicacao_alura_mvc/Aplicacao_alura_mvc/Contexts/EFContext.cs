using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Aplicacao_alura_mvc.Models;

namespace Aplicacao_alura_mvc.Contexts
{
    public class EFContext : DbContext
    {
        //base("CONNSTRING") = De onde ele vai pegar a connection string
        public EFContext() : base("CONNSTRING") { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

    }
}