using FlightManagementSystem.Models;

namespace FlightManagementSystem
{
    public class Program
    {

        // System Stoarge (The actual storage in the memory for all the lists)
        public static FlightContext context = new FlightContext
        {
            passengers = new List <Passenger> (),

            pilots     = new List <Pilot>     (),

            aircrafts  = new List <Aircraft>  (),

            flights    = new List <Flight>    (),

            bookings   = new List <Booking>   ()
        };
        // Now there are 5 empty lists that are exist in the memory under context.
         
        static void Main(string[] args)
        {
            
        }
    }
}

