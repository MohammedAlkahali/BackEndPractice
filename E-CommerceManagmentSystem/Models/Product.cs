using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required] // data annotation
        public int      productId     { get; set; } // System generated 

        [Required, MaxLength(150)]                                          // data annotation
        public string   productName   { get; set; } // User input 

        [MaxLength(1000)]                                                   // data annotation
        public string?   description   { get; set; } // User input

        [Required, Range(0,double.MaxValue)]                                // data annotation
        public decimal  price         { get; set; } // User input

        [Required, Range(0, double.MaxValue)]                               // data annotation
        public int stockQuantity { get; set; } = 0; // User input

        [MaxLength(300)]                                                    // data annotation
        public string?   imageUrl      { get; set; } // User input 

        [Required, ForeignKey (nameof (Category))]                          // data annotation
        public int      categoryId    { get; set; } // User input 

        [Required]                                                          // data annotation
        public DateTime createdAt     { get; set; } // User input

        public bool isAvailable { get; set; } = true; // Default value
    }
}
