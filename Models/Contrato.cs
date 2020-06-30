using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestGalaxy.Models
{
    public class Contrato : DbContext
    {
        public Contrato(DbContextOptions<Contrato> options):base(options)
        {
        }
        public DbSet<Contrato> Contratos { get; set; }
    }
}
