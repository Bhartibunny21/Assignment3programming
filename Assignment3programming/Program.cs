// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different vehicles
        Car car = new Car("Camry", "Toyota", 2020, 50.0, 5, "Petrol", "Automatic", false);
        Truck truck = new Truck("F150", "Ford", 2018, 80.0, 2.5, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2019, 30.0, 600, "Petrol", true);

        // Displaying details of each vehicle
        Console.WriteLine("Car Details:");
        car.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle.DisplayDetails();
        Console.WriteLine();

        // Demonstrating rental agency functionality
        RentalAgency rentalAgency = new RentalAgency(3);
        rentalAgency.AddVehicle(car, 0);
        rentalAgency.AddVehicle(truck, 1);
        rentalAgency.AddVehicle(motorcycle, 2);

        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue:C}");

        rentalAgency.RentVehicle(1); // Renting truck
        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue:C}");
    }
}
