using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Review
    {
        public int      reviewId    { get; set; }   // System generated 
        public int      userId      { get; set; }   // Foreign key
        public int      productId   { get; set; }   // Foreign key
        public string   comment     { get; set; }   // User input 
        public DateTime reviewDate  { get; set; }   // User input
    }
}
