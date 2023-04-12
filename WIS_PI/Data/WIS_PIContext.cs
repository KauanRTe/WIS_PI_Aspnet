using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WIS_PI.Models;

namespace WIS_PI.Data
{
    public class WIS_PIContext : DbContext
    {
        public WIS_PIContext (DbContextOptions<WIS_PIContext> options)
            : base(options)
        {
        }

        public DbSet<WIS_PI.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<WIS_PI.Models.Genero>? Genero { get; set; }
    }
}
