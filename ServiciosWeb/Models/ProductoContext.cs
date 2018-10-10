using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiciosWeb.Models
{
    public class ProductoContext : DbContext
    {
      public ProductoContext() : base("ProductosConnection")
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

    }

}