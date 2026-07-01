using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    [Index(nameof(courseCode), IsUnique = true)]
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int courseId { get; set; }           // System generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; }      // User input

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; }     // User input

        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; }        // User input 

        [ForeignKey("Department")]
        [Required]
        public int departmentId { get; set; }       // foreign key

        [ForeignKey("Instructor")]
        public int? instructorId { get; set; }       // foreign key

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } // User input 

        public Department Department { get; set; } // Navigation property 


        public Instructor Instructor { get; set; } // Navigation property 
    }
}
