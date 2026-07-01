using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    [Index(nameof(email), IsUnique = true)]
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int instructorId {  get; set; }      // System Generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }        // User input

        [Required]
        [MaxLength(150)]
        public string email { get; set; }           // User input


        [MaxLength(20)]
        public string? officeNumber { get; set; }    // User input

        [Required]
        public DateTime hireDate { get; set; }      // User input

        [Required, Range(0, double.MaxValue)]
        public decimal salary { get; set; }         // User input

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; }   // User input


        [ForeignKey("Department")]
        public int departmentId { get; set; } // Foreign key property
        public Department Department { get; set; } // Navigation property

        public List<Course> courses { get; set; } // Navigation property
    }
}
