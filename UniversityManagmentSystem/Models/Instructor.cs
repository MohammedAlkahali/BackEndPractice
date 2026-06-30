using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    public class Instructor
    {
        public int instructorId {  get; set; }      // System Generated 
        public string fullName { get; set; }        // User input
        public string email { get; set; }           // User input
        public string officeNumber { get; set; }    // User input
        public DateTime hireDate { get; set; }      // User input
        public decimal salary { get; set; }         // User input
        public string academicTitle { get; set; }   // User input
    }
}
