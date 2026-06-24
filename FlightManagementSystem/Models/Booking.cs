using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementSystem.Models
{
    public class Booking
    {
        public int bookingId { get; set; }      // Unique ID for each booking
        public int passengerId { get; set; }    // ID of the passenger who made the booking
        public int flightId { get; set; }       // ID of the flight being booked
        public string seatNumber { get; set; }  // Seat label assigned at booking
        public string bookingDate { get; set; } // Date the booking was made
        public decimal totalPrice { get; set; } // Price paid - taken from flight's ticketPrice at booking time
        public string status { get; set; }      // Booking status: Confirmed | Cancelled
    }
}

