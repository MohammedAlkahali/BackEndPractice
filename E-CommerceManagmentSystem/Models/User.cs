using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    [Index(nameof(username), IsUnique = true)]
    [Index(nameof(email), IsUnique = true)]
    public class User
    { 
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] [Required] // data annotation
        public int      userId           { get; set; }           // System generated


        [Required, MaxLength(50)]                                              // data annotation
        public string   username         { get; set; }           // User input


        [Required, MaxLength (150)]                                            // data annotation
        public string   email            { get; set; }           // User input


        [Required, MaxLength(256)]                                             // data annotation
        public string   passwordHash     { get; set; }           // User input


        [Required, MaxLength(100)]                                             // data annotation
        public string   fullName         { get; set; }           // User input


        [MaxLength(20)]                                                        // data annotation
        public string?   phoneNumber      { get; set; }           // User input


        [MaxLength(300)]                                                       // data annotation
        public string?   address          { get; set; }          // User input


        [Required]                                                             // data annotation
        public DateTime registrationDate { get; set; }           // User input


        public bool isActive { get; set; } = true;               // Default value


        public List<Review> reviews { get; set; }   // // Navigation property 

        public List<Order> Orders { get; set; }   // // Navigation property 
    }
}
