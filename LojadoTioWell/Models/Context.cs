using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojadoTioWell.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Produto> produto{ get; set; }
    }
}