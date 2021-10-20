// Context do banco de dados

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaAPIs.Models
{
    // Public class que herda o DbContext
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option)
            : base(option)
        {
        }

        // Consultas e alterações no banco de dados (dentro de Produtos)
        public DbSet<Produto> TodoProducts { get; set; }
    }
}
