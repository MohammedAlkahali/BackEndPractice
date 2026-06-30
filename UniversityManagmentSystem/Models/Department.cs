using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    [Index(nameof(departmentName), IsUnique = true)]
    public class Department
    {
        [Key]
        [Required]
        public int departmentId { get; set; }       // System generated 

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; }  // User input

        [MaxLength(50)]
        public string? building {  get; set; }       // User input

        [Required]
        public decimal budget { get; set; }         // User input


        public int headInstructorId { get; set; }   // foreign key

    }
}
