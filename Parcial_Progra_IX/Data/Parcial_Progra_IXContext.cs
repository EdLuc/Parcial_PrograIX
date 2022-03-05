using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial_Progra_IX.Models;

namespace Parcial_Progra_IX.Data
{
    public class Parcial_Progra_IXContext : DbContext
    {
        public Parcial_Progra_IXContext (DbContextOptions<Parcial_Progra_IXContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial_Progra_IX.Models.Alumnos> Alumnos { get; set; }
    }
}
