using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Passenger
    {
        public int passengerId { get; set; }        // Unique ID for every passenger in the system
        public string passengerName { get; set; }   // Full name of the passenger
        public string passengerEmail { get; set; }  // Email address used for booking confirmation
        public int passengerPhone { get; set; }  // Contact phone number
        public int passportNumber { get; set; }  // Passport / national ID number - must be unique per passenger
        public string PassengerNationality { get; set; }     // Country of the passenger's passport
    }
}
