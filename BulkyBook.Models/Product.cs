using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id  { get; set; }

        [Required]
        public string Title { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        [Required]
        public string ISBN { get; set; } = String.Empty;

        [Required]
        public string Author { get; set; } = String.Empty;

        [Required]
        [DisplayName("List Price")]
        [Range(1,1000)]
        public double ListPrice { get; set; }

        [Required]
        [DisplayName("Price for 1-50")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [DisplayName("Price for 50+")]
        [Range(1, 1000)]
        public double Price50 { get; set; }

        [Required]
        [DisplayName("Price for 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ValidateNever]
        [DisplayName("Product Image")]
        public string? ImageUrl { get; set; }

    }
}
