using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    public class Enrollment
    {
        public int enrollmentId { get; set; }        // System generated 
        public int studentId { get; set; }           // foreign key
        public int courseId { get; set; }            // foreign key
        public DateTime enrollmentDate { get; set; } // User input
        public string finalGrade { get; set; }       // User input
        public string status { get; set; }           // Default value
    }
}
