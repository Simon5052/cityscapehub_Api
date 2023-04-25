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
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductImage> ProductImages{ get; set; }

    }
}
