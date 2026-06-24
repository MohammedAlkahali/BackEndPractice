using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Aircraft
    {
        public int aircraftId { get; set; }      // Unique ID for each aircraft
        public string models { get; set; }        // Aircraft model name (e.g. Boeing 737, Airbus A320)
        public int totalSeats { get; set; }      // Total number of passenger seats on this aircraft
        public bool isOperational { get; set; }  // True if airworthy; false if grounded for maintenance
    }
}
