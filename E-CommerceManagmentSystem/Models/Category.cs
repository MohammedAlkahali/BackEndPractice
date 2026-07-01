using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Category
    {
        public int    categoryId    { get; set; }   // System generated  
        public string categoryName  { get; set; }   // User input
        public string description   { get; set; }   // User input
        public string imageUrl      { get; set; }   // User input
    }
}
