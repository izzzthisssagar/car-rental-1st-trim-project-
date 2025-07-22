# Car Rental Management System

A simple, console-based Car Rental Management System developed in C# for academic demonstration purposes. The project is designed to help users rent cars, manage bookings, and maintain car and customer records with an intuitive menu-driven interface.

## Features

- **Car Management**:  
  - Add, edit, and remove cars from the fleet.
  - View all available, rented, and returned cars.

- **Booking & Rental Management**:  
  - Create new car rental bookings.
  - Return cars and update their status.
  - View all current and historical bookings.

- **Customer Management**:  
  - Add, edit, view, and delete customer records.
  - View rental history for each customer.

- **Category Management**:  
  - Add and manage car categories (e.g., economy, SUV, luxury).
  - Assign vehicles to specific categories.

## Technologies Used

- **Language**: C#
- **Framework**: .NET (Console Application)
- **Data Handling**: In-memory classes (no external database)
- **IDE**: Visual Studio

## Project Structure

```plaintext
car-rental-1st-trim-project-
├─ bookingpage.cs       // Handles booking functionality
├─ homepage.cs          // Initial user and admin menu logic
├─ homepage2.cs         // Alternate UI/menu implementation
├─ program1.cs          // Alternative entry point (possible backup)
├─ Program.cs           // Main application entry point
├─ Database.cs          // Main in-memory data handling
├─ Database2.cs         // Additional/experimental data logic
├─ .gitignore
├─ 2.sln
└─ README.md
```

## Getting Started

### Prerequisites

- Visual Studio 2019 or newer
- .NET Framework (version 4.7.2 or higher recommended)

### How to Run

1. **Clone this repository** to your local machine:

    ```bash
    git clone https://github.com/izzzthisssagar/car-rental-1st-trim-project-
    ```

2. **Open the solution** file (`2.sln`) in Visual Studio.

3. **Build the project** using `Build > Build Solution`.

4. **Run the application** (F5 or `Debug > Start Debugging`).

## Usage

- Upon launching, choose your desired action from the menu:
    - Add/view cars
    - Book a car
    - Return a car
    - Manage customers
    - View reports

- Follow on-screen prompts to input data. All records are managed in memory and reset when the application is restarted.

## Sample Code Flow

```csharp
// Main menu sample
Console.WriteLine("1. Add Car");
Console.WriteLine("2. Book Car");
Console.WriteLine("3. Return Car");
Console.WriteLine("4. Manage Customers");
Console.WriteLine("5. Exit");
```

## Known Limitations

- Data is not persisted after closing the application.
- No advanced security/authentication implemented.
- UI is console-based.
- For demonstration/learning use only.

## Contributing

Pull requests are welcome for bug fixes or feature suggestions. Please fork the repo, make your changes, and create a pull request.

## License

This project is open-source and free to use for educational purposes.

## Credits

Developed for academic purposes by izzzthisssagar.  
Special thanks to open-source resources and the C# developer community for sample code and documentation inspiration[1][2][3].

## Contact

For questions or suggestions, please open an issue on the repository.
