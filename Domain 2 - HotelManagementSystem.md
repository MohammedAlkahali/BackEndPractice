# Domain 2 — Hotel Management System

## Step 1 — Source Tags

### Entity: Guest

| Property Name | Data Type | Source Tag |
|---|---|---|
| guestId | int | System Generated |
| fullName | string | User Input |
| phoneNumber | string | User Input |
| emailAddress | string | User Input |
| nationality | string | User Input |
| dateRegistered | string | System Generated |

### Entity: Room

| Property Name | Data Type | Source Tag |
|---|---|---|
| roomId | int | System Generated |
| roomNo | string | User Input |
| category | string | From List (Single / Double / Suite) |
| floor | int | User Input |
| pricePerNight | decimal | Calculated (derived from category) |
| availabilityStatus | bool | Default Value (= true) |

### Entity: Booking

| Property Name | Data Type | Source Tag |
|---|---|---|
| bookingId | int | System Generated |
| guestId | int | From List |
| roomId | int | From List |
| arrivalDate | string | User Input |
| departureDate | string | User Input |
| stayDuration | int | Calculated (departureDate − arrivalDate) |
| totalCost | decimal | Calculated (stayDuration × pricePerNight) |
| bookingStatus | string | Default Value (= "Confirmed") |

### Entity: CheckInRecord

| Property Name | Data Type | Source Tag |
|---|---|---|
| recordId | int | System Generated |
| bookingId | int | From List (linked to active booking) |
| guestId | int | Calculated (copied from Booking) |
| roomId | int | Calculated (copied from Booking) |
| checkInTime | string | System Generated (today's date/time) |
| checkOutTime | string | System Generated (set when guest checks out) |
| finalCost | decimal | Calculated (actual nights × pricePerNight) |

## Step 2 — Entity Relationships

A Guest is registered first, receiving a unique guestId. Rooms are pre-loaded with their category (Single, Double, Suite) and their pricePerNight is automatically derived from the category; availabilityStatus starts as true.

When a Guest books a Room, the system verifies availabilityStatus == true. A new Booking is created linking guestId and roomId; stayDuration and totalCost are calculated automatically; the Room's availabilityStatus is set to false and bookingStatus defaults to "Confirmed".

A Booking can be cancelled before check-in: its bookingStatus changes to "Cancelled" and the Room's availabilityStatus is restored to true immediately.

When the guest physically arrives, a CheckInRecord is created from the Booking — guestId, roomId, and bookingId are copied across, and checkInTime is stamped by the system.

When the guest checks out, checkOutTime is stamped, finalCost is calculated from the actual stay length, and the Room's availabilityStatus is restored to true so it can be booked again.

## Step 3 — Services

| # | Service Name | What It Does |
|---|---|---|
| 1 | GuestRegistration | Creates a new Guest record with a system-generated ID and today's registration date. |
| 2 | RoomAddition | Adds a Room to the system; pricePerNight is set by category; availabilityStatus defaults to true. |
| 3 | RoomBooking | Creates a Booking for a guest and room, calculates stayDuration and totalCost, marks room unavailable. |
| 4 | BookingCancellation | Sets a Booking's bookingStatus to Cancelled and restores the Room's availabilityStatus to true. |
| 5 | GuestCheckIn | Creates a CheckInRecord from a Confirmed Booking and stamps the checkInTime. |
| 6 | GuestCheckOut | Stamps checkOutTime, calculates finalCost, and sets the Room back to available. |
| 7 | AvailableRoomsView | Returns all Rooms where availabilityStatus == true, optionally filtered by category. |
| 8 | ActiveBookingsView | Lists all Bookings with bookingStatus Confirmed, for the front-desk dashboard. |
| 9 | GuestStayHistory | Returns all Bookings and CheckInRecords linked to a specific guestId. |
