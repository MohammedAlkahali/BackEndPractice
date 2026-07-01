using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceManagmentSystem.Models
{
    public class User
    {
        public int      userId           { get; set; }           // System generated
        public string   username         { get; set; }           // User input
        public string   email            { get; set; }           // User input
        public string   passwordHash     { get; set; }           // User input
        public string   fullName         { get; set; }           // User input
        public string   phoneNumber      { get; set; }           // User input
        public string   address          { get; set; }           // User input
        public DateTime registrationDate { get; set; }           // User input
        public bool     isActive         { get; set; }           // Default value
    }
}
