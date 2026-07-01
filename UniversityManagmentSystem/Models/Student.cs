using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Linq;

namespace UniversityManagmentSystem.Models
{
    [Index(nameof(email), IsUnique = true)]
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int studentId {  get; set; }         // System Generated 

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }        // User Input

        [Required]
        [MaxLength(150)]
        public string email { get; set; }           // User Input

        [MaxLength(20)]
        public string? phoneNumber { get; set; }     // User Input

        [Required]
        public DateTime dateOfBirth { get; set; }   // User Input

        [Required]
        [Range(2000, 2030)]
        public int enrollmentYear { get; set; }     // User Input 


        [Range(0.0, 4.0)]
        public decimal gpa { get; set; } = 0.0m;    // User Input


        public List <Course> courses { get; set; } // Navigation property


        public List<Enrollment> Enrollment { get; set; } // Navigation property

    }
}
