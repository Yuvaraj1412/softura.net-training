using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProdEF.Models
{
    public class ProdDBContext : DbContext
    {
        public ProdDBContext()
        {

        }
        public ProdDBContext(DbContextOptions<ProdDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SAMSUNG;Initial Catalog=Task;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
