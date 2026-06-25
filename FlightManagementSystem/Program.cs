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

            // To make the passport unique
            if(context.passengers.Any(p => p.passportNumber == passportNum))
            {
                Console.WriteLine();
                Console.WriteLine("A passenger with this passport number is already registered.");
                return; // To stop here and not adding a duplicated number
            }



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




        public static void AddAircraft()        // Function to add an aircraft 
        {
            Console.WriteLine("=== Add an Aircraft ===");
            Console.WriteLine();

            Console.Write("Enter the Aircraft model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the total seat in the aircraft: ");
            bool isValidNumber = int.TryParse(Console.ReadLine(), out int totalSeat);

            if (!isValidNumber || totalSeat <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid seat count. Please enter a positive number.");
                return;
            }



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




        public static void RegisterPilot()      // Function to add a new pilot 
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
            bool isValidHours = int.TryParse(Console.ReadLine(), out int totalFlightHrs);

            if (!isValidHours || totalFlightHrs < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid flight hours. Please enter a non-negative number.");
                return;
            }

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




        public static void ViewFlights()        // Function to display all the flights 
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




        public static void ScheduleFlight()     // Function to schedule a flight 
        {
            Console.WriteLine("=== Schedule a Flight ===");
            Console.WriteLine();

            // To show only the operational aircraft
            var operationalAircrafts = context.aircrafts.Where(a => a.isOperational).ToList();

            if (operationalAircrafts.Count == 0)
            {
                Console.WriteLine("No operational aircraft available. Add new.");
                return;
            }

            Console.WriteLine("Operational Aircraft:");
            foreach (Aircraft a in operationalAircrafts)
            {
                Console.WriteLine($"  ID: {a.aircraftId} | {a.model} | Seats: {a.totalSeats}");
            }

            Console.Write("Enter the Aircraft ID to assign: ");
            bool isValidAircraftId = int.TryParse(Console.ReadLine(), out int aircraftId);

            Aircraft selectedAircraft = context.aircrafts
                .FirstOrDefault(a => a.aircraftId == aircraftId && a.isOperational);

            if (!isValidAircraftId || selectedAircraft == null)
            {
                Console.WriteLine("Invalid aircraft ID.");
                return;
            }

            // To show only the available pilots
            var availablePilots = context.pilots.Where(p => p.isAvailable).ToList();

            if (availablePilots.Count == 0)
            {
                Console.WriteLine("No available pilots. Register one or wait for one to free up.");
                return;
            }

            Console.WriteLine("Available Pilots:");
            foreach (Pilot p in availablePilots)
            {
                Console.WriteLine($"  ID: {p.pilotId} | {p.pilotName} | License: {p.licenseNumber}");
            }

            Console.Write("Enter the Pilot ID to assign: ");
            bool isValidPilotId = int.TryParse(Console.ReadLine(), out int pilotId);

            Pilot selectedPilot = context.pilots
                .FirstOrDefault(p => p.pilotId == pilotId && p.isAvailable);

            if (!isValidPilotId || selectedPilot == null)
            {
                Console.WriteLine("Invalid or unavailable pilot ID.");
                return;
            }

            
            Console.Write("Enter origin: ");
            string origin = Console.ReadLine();

            Console.Write("Enter destination: ");
            string destination = Console.ReadLine();

            Console.Write("Enter departure date: ");
            string departureDate = Console.ReadLine();

            Console.Write("Enter departure time: ");
            string departureTime = Console.ReadLine();

            Console.Write("Enter ticket price: ");

            bool isValidPrice = decimal.TryParse(Console.ReadLine(), out decimal ticketPrice);

            if (!isValidPrice || ticketPrice <= 0)
            {
                Console.WriteLine("Invalid ticket price.");
                return;
            }

            Console.Write("Enter flight duration in hours: ");
            bool isValidDuration = int.TryParse(Console.ReadLine(), out int durationHours);

            if (!isValidDuration || durationHours <= 0)
            {
                Console.WriteLine("Invalid flight duration.");
                return;
            }

            // Build the Flight - seats come from the aircraft
            int flightId = context.flights.Count + 1;
            string flightCode = $"OA-{200 + flightId}";

            context.flights.Add(
                new Flight
                {
                    flightId = flightId,
                    flightCode = flightCode,
                    aircraftId = selectedAircraft.aircraftId,
                    pilotId = selectedPilot.pilotId,
                    origin = origin,
                    destination = destination,
                    departureDate = departureDate,
                    departureTime = departureTime,
                    ticketPrice = ticketPrice,
                    availableSeats = selectedAircraft.totalSeats,
                    status = "Scheduled",
                    flightDurationHours = durationHours
                }
            );

            // Pilot is now committed to this flight
            selectedPilot.isAvailable = false;

            Console.WriteLine();
            Console.WriteLine("Flight scheduled successfully.");
            Console.WriteLine($"Flight Code: {flightCode} | Flight ID: {flightId}");
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



                    case 5:
                        ScheduleFlight();
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

