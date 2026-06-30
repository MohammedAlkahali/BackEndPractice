using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    public class Student
    {
        [Key]
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
    }
}
