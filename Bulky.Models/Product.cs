using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string ISBN { get; set; } = null!;
        public string Author { get; set; } = null!;
        [Required]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set; }


        [Required]
        [Display(Name = "Price for 50+")]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        public double Price100 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        //public List<ProductImage> ProductImages { get; set; } = new();
    }
}
