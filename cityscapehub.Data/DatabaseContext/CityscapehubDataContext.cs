using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cityscapehub.Model.DbModels;
using Microsoft.EntityFrameworkCore;

namespace cityscapehub.Data.DatabaseContext
{
    public class CityscapehubDataContext: DbContext
    {
        public CityscapehubDataContext(DbContextOptions<CityscapehubDataContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }

    }
}
