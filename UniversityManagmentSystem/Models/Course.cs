using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    public class Course
    {
        public int courseId { get; set; }           // System generated
        public string courseCode { get; set; }      // User input
        public string courseTitle { get; set; }     // User input
        public int creditHours { get; set; }        // User input 
        public int departmentId { get; set; }       // From list
        public int instructorId { get; set; }       // From list
        public string semesterOffered { get; set; } // User input 
    }
}
