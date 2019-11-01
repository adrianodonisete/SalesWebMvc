using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc22.Models.ViewModels;

namespace SalesWebMvc22.Models
{
    public class SalesWebMvc22Context : DbContext
    {
        public SalesWebMvc22Context (DbContextOptions<SalesWebMvc22Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord>  SalesRecord { get; set; }
    }
}
