using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Order
    {
        public int      orderId         { get; set; }   // System generated 
        public int      userId          { get; set; }   // Foreign key
        public DateTime OrderDate       { get; set; }   // User input
        public decimal  totalAmount     { get; set; }   // User input
        public string   status          { get; set; }   // User input
        public string   shippingAddress { get; set; }   // User input
        public string   paymentMethod   { get; set; }   // User input
    }
}
