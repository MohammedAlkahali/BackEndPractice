using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    [Index(nameof(categoryName), IsUnique = true)]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]// Data annotation
        public int    categoryId    { get; set; }   // System generated  

        [Required, MaxLength(100)]                                          // Data annotation
        public string categoryName  { get; set; }   // User input

        [MaxLength(500)]                                                    // Data annotation
        public string? description   { get; set; }   // User input

        [MaxLength(300)]                                                    // Data annotation
        public string? imageUrl      { get; set; }   // User input
    }
}
