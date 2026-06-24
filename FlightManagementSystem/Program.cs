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
            bool exit = false;
            while (exit == false)

            {           // Display the main menu to choose

                Console.WriteLine("=============================================\r\nWELCOME TO SKY WINGS FLIGHT MANAGEMENT SYSTEM\r\n=============================================");
                Console.WriteLine("  Please select from the main menu");
                Console.WriteLine();
                Console.WriteLine("   1)  Register a Passenger");
                Console.WriteLine("   2)  Add an Aircraft");
                Console.WriteLine("   3)  Register a Pilot");
                Console.WriteLine("   4)  View All Flights");
                Console.WriteLine("   5)  Schedule a Flight");
                Console.WriteLine("   6)  Book a Flight");
                Console.WriteLine("   7)  Cancel a Booking");
                Console.WriteLine("   8)  Depart a Flight");
                Console.WriteLine("   9)  Cancel a Flight");
                Console.WriteLine("   10) Passenger Booking History");
                Console.WriteLine("   11) Flight Revenue & Load Factor Report");
                Console.WriteLine("   0)  Exit");
                Console.WriteLine(" =============================================");

                Console.Write("   -> Select: ");
            
                // New 
                int Select;

                try
                {
                    Select = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;   // skip the rest, show the menu again
                }

                //-------------------------------------------------------------
                switch (Select)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using our System. Goodbye!");
                        break;


                    default:
                        Console.WriteLine("Invalid option. Please select a valid number.");
                        break;


                } // Switch

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}

