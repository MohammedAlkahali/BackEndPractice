using FlightManagementSystem.Models;

namespace FlightManagementSystem
{
    public class Program
    {

        // System Stoarge (The actual storage in the memory for all the lists)
        public static FlightContext context = new FlightContext
        {
            passengers = new List <Passenger>  (),

            pilots     = new List <Pilot>      (),

            aircrafts  = new List <Aircraft>   (),

            flights    = new List <Flight>     (),

            bookings   = new List <Booking>    ()
        };
        // Now there are 5 empty lists that are exist in the memory under context.




        public static void RegisterPassenger()  // Function to add a new passenger 
        {
            // To register a new passenger 

            Console.WriteLine("=== Register a new passenger ===");
            Console.WriteLine();

            Console.Write("Enter the passenger name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the passenger email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter the passenger passport number: ");
            string passportNum = Console.ReadLine();

            Console.Write("Enter the passenger nationality: ");
            string nationality = Console.ReadLine();

            int passengerId = context.passengers.Count + 1; // To generate a new ID for the passenger

            context.passengers.Add( // To add the new passenger in the list
                new Passenger
                {
                    passengerId          = passengerId,
                    passengerName        = name,
                    passengerEmail       = email,
                    passengerPhone       = phone,
                    passportNumber       = passportNum,
                    nationality = nationality
                }
                );
            Console.WriteLine();
            Console.WriteLine("The passenger registered successfully");
            Console.WriteLine($"The passenger ID: {passengerId}");
        }  




        public static void AddAircraft() // Function to add an aircraft 
        {
            Console.WriteLine("=== Add an Aircraft ===");
            Console.WriteLine();

            Console.Write("Enter the Aircraft model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the total seat in the aircraft: ");
            int totalSeat = int.Parse( Console.ReadLine() );


            int aircraftId = context.aircrafts.Count + 1; // To generate a new ID for the aircraft

            context.aircrafts.Add(
                new Aircraft
                {
                    aircraftId    = aircraftId,
                    model         = model,
                    totalSeats    = totalSeat,
                    isOperational = true
                }
                );
            Console.WriteLine();
            Console.WriteLine("The aircraft added successfully");
            Console.WriteLine($"The aircraft ID: {aircraftId}");
        }




        public static void RegisterPilot() // Function to add a new pilot 
        {
            Console.WriteLine("=== Register A Pilot ===");
            Console.WriteLine();

            Console.Write("Enter the pilot name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the pilot phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter the pilot license number: ");
            string licenseNum = Console.ReadLine();

            Console.Write("Enter the total flight hours: ");
            int totalFlightHrs = int.Parse( Console.ReadLine() );

            int pilotId = context.pilots.Count + 1;

            context.pilots.Add(
                new Pilot
                {
                    pilotId       = pilotId,
                    pilotName     = name,
                    pilotPhone    = phone,
                    licenseNumber = licenseNum,
                    flightHours   = totalFlightHrs,
                    isAvailable   = true
                }
            );

            Console.WriteLine("The pilot registered successfully");
            Console.WriteLine($"The pilot ID is: {pilotId}");
        }




        public static void ViewFlights() // Function to display all the flights 
        {
            Console.WriteLine("=== All the flights  ===");
            Console.WriteLine();

            if(context.flights.Count == 0) 
            {
                Console.WriteLine("There are no flights available");
                return;
            }

            foreach( Flight f in context.flights )
            {
                Console.WriteLine($"Flight Code:     {f.flightCode}");
                Console.WriteLine($"Origin:          {f.origin}");
                Console.WriteLine($"Destination:     {f.destination}");
                Console.WriteLine($"Depature Date:   {f.departureDate}");
                Console.WriteLine($"Depature Time:   {f.departureTime}");
                Console.WriteLine($"Available Seats: {f.availableSeats}");
                Console.WriteLine($"Ticket Price:    {f.ticketPrice}");
                Console.WriteLine($"Current Status:  {f.status}");
            }


        }
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)

            {           // Display the main menu to choose

                Console.WriteLine("=============================================\r\nWELCOME TO FLIGHT MANAGEMENT SYSTEM\r\n=============================================");
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
                    case 1:
                        RegisterPassenger();
                        break;



                    case 2:
                        AddAircraft();
                        break;



                    case 3:
                        RegisterPilot();
                        break;



                    case 4:
                        ViewFlights();
                        break;



                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using our System. Goodbye!");
                        break;



                    default:
                        Console.WriteLine("Invalid option. Please select a valid number.");
                        break;



                } // Switch

                Console.WriteLine();
                Console.WriteLine(" => press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            } // While
        } // Main 
    } // Class program
} // Namespace

