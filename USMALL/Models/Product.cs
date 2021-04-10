using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace USMALL.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a product description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        //SQL data type that will be used to store values for Price property 
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage ="Please specify a category")]
        public string Category { get; set; }
    }
}
