using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestGalaxy.Models
{
    public class Trabajador : DbContext
    {
        public Trabajador(DbContextOptions<Trabajador> options):base(options)
        {
        }
        public DbSet<Trabajador> TRabajadores { get; set; }
    }
}
