using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityscapehub.Model.DbModels
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [DefaultValue(typeof(DateTime), "")]
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        [DefaultValue(true)]
        public bool Active { get; set; }
        [DefaultValue(false)]
        public bool BestSellers { get; set; }

    }

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName{ get; set; }
        public string CategoryDescription{ get; set; }
        public string CategoryImage{ get; set; }
    }

    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
