using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dwFinal.Models;

namespace dwFinal.Data
{
    public class dwFinalContext : DbContext
    {
        public dwFinalContext (DbContextOptions<dwFinalContext> options)
            : base(options)
        {
        }

        public DbSet<dwFinal.Models.cursos> cursos { get; set; }

        public DbSet<dwFinal.Models.catedraticos> catedraticos { get; set; }

        public DbSet<dwFinal.Models.reportes> reportes { get; set; }
    }
}
