using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required] // Data annotation 
        public int      orderId         { get; set; }   // System generated

        [ForeignKey(nameof(userId)), Required]                              // Data annotation
        public int      userId          { get; set; }   // Foreign key

        [Required]                                                          // Data annotation
        public DateTime OrderDate       { get; set; }   // User input

        [Required, Range(0, double.MaxValue)]                               // Data annotation
        public decimal  totalAmount     { get; set; }   // User input

        [Required, MaxLength(30)]                                           // Data annotation
        public string status { get; set; } = "Pending";   // User input

        [Required, MaxLength(300)]                                          // Data annotation
        public string   shippingAddress { get; set; }   // User input

        [Required, MaxLength(50)]                                           // Data annotation
        public string   paymentMethod   { get; set; }   // User input
    }
}
