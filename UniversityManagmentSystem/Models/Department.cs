using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagmentSystem.Models
{
    public class Department
    {

        public int departmentId { get; set; }       // System generated 
        public string departmentName { get; set; }  // User input
        public string building {  get; set; }       // User input
        public decimal budget { get; set; }         // User input
        public int headInstructorId { get; set; }   // From list

    }
}
