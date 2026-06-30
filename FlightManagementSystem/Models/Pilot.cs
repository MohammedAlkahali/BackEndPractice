using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Pilot
    {
        public int pilotId { get; set; }            // Unique ID for each pilot
        public string pilotName { get; set; }       // Full name of the pilot
        public string pilotPhone { get; set; }      // Contact number
        public string licenseNumber { get; set; }   // Official aviation license number
        public int flightHours { get; set; }        // Total logged flight hours
        public bool isAvailable { get; set; }       // Whether the pilot is currently free to be assigned
    }
}
