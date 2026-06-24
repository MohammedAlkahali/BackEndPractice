# Domain 1 — Library Management System

## Step 1 — Entities and Properties

### Entity: Book

| Property Name | Data Type | Source Tag |
|---|---|---|
| bookId | int | System Generated |
| title | string | User Input |
| author | string | User Input |
| genre | string | User Input |
| totalCopies | int | User Input |
| availableCopies | int | Default Value (= totalCopies on creation) |

### Entity: Member

| Property Name | Data Type | Source Tag |
|---|---|---|
| memberId | int | System Generated |
| fullName | string | User Input |
| email | string | User Input |
| phone | string | User Input |
| registrationDate | string | System Generated |
| isActive | bool | Default Value (= true) |

### Entity: Loan

| Property Name | Data Type | Source Tag |
|---|---|---|
| loanId | int | System Generated |
| memberId | int | From List |
| bookId | int | From List |
| borrowDate | string | System Generated |
| dueDate | string | Calculated (borrowDate + 14 days) |
| returnDate | string | System Generated (set on return) |
| fineAmount | decimal | Calculated (overdue days × rate) |
| status | string | Default Value (= "Active") |

### Entity: Reservation

| Property Name | Data Type | Source Tag |
|---|---|---|
| reservationId | int | System Generated |
| memberId | int | From List |
| bookId | int | From List |
| reservationDate | string | System Generated |
| status | string | Default Value (= "Pending") |

## Step 2 — Entity Relationships

A Member is registered first and given a unique memberId. Each Book is added to the catalog with a title, author, genre, and a set number of copies — availableCopies starts equal to totalCopies.

When a Member borrows a Book, the system checks availableCopies > 0. If available, a new Loan is created, the borrowDate is recorded, the dueDate is automatically set to borrowDate + 14 days, and availableCopies is decremented by 1.

When the Member returns the book, returnDate is stamped, status changes to "Returned", and availableCopies is incremented back. If returnDate > dueDate, fineAmount is calculated (number of overdue days × fine rate) and attached to the Loan.

If availableCopies == 0 and a Member wants the Book, a Reservation is created linking that Member to that Book with status "Pending". When any copy is returned, the system finds the oldest pending Reservation for that Book, updates its status to "Notified", and notifies the Member that the book is now available.

## Step 3 — Services

| # | Service Name | What It Does |
|---|---|---|
| 1 | MemberRegistration | Creates a new Member record with a system-generated ID and today's registration date. |
| 2 | BookAddition | Adds a new Book to the catalog; sets availableCopies equal to totalCopies. |
| 3 | BookBorrowing | Creates a Loan for a member and book, decrements availableCopies, and sets the 14-day due date. |
| 4 | BookReturning | Marks a Loan as Returned, stamps returnDate, restores availableCopies, and triggers fine calculation if overdue. |
| 5 | FineCalculation | Computes the fine on a Loan by multiplying overdue days by the configured fine rate. |
| 6 | BookReservation | Creates a Reservation for a member on a fully-borrowed book with status Pending. |
| 7 | ReservationNotification | Finds the oldest Pending Reservation for a returned book and updates its status to Notified. |
| 8 | ActiveLoansView | Returns all Loan records where status is Active, for the librarian's dashboard. |
| 9 | OverdueLoansView | Returns all Active Loans past their dueDate, sorted descending by how many days overdue. |
| 10 | MostBorrowedBooksReport | Groups all Loans by bookId, counts total borrows per book, and returns the list ranked from most to least borrowed. |
