using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Product
    {
        public int      productId     { get; set; } // System generated 
        public string   productName   { get; set; } // User input 
        public string   description   { get; set; } // User input
        public decimal  price         { get; set; } // User input
        public int      stockQuantity { get; set; } // User input
        public string   imageUrl      { get; set; } // User input 
        public int      categoryId    { get; set; } // User input 
        public DateTime createdAt     { get; set; } // User input
        public bool     isAvailable   { get; set; } // Default value
    }
}
