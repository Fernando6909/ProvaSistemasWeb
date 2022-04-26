using ProvaCliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaCliente.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBProva") { }

        public DbSet<ClienteModel> Cliente { get; set; }
    }
}