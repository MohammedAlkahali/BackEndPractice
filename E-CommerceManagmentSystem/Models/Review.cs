using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required] // data annotation
        public int      reviewId    { get; set; }   // System generated 

        [ForeignKey("User"), Required]                                // data annotation
        public int      userId      { get; set; }   // Foreign key property

        [ForeignKey("Product")]                                       // data annotation
        public int      productId   { get; set; }   // Foreign key

        [Required, Range(1,5)]                                              // data annotation
        public int rating { get; set; }             // User input 


        [MaxLength(1000)]                                                   // data annotation
        public string?   comment     { get; set; }   // User input 

        [Required]                                                          // data annotation
        public DateTime reviewDate  { get; set; }   // User input


        public User User { get; set; } // Navigation property

        public Product Product { get; set; } // Navigation property 
    }
}
