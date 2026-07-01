using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int enrollmentId { get; set; }               // System generated 

        [ForeignKey(nameof(Student))]
        [Required]
        public int studentId { get; set; }                  // foreign key

        [ForeignKey(nameof(Course))]
        [Required]
        public int courseId { get; set; }                   // foreign key

        [Required]
        public DateTime enrollmentDate { get; set; }        // User input

        [MaxLength(2)]
        public string? finalGrade { get; set; }             // User input

        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress"; // Default value
    }
}
