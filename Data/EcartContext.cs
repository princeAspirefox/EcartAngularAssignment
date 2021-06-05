using EcartAssiggmnet.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Data
{
    public class EcartContext:IdentityDbContext<User>
    {
        private readonly DbContextOptions options;

        public EcartContext(DbContextOptions options): base(options)
        {
            this.options = options;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
