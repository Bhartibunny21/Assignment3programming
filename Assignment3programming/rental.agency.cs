// RentalAgency.cs
using System;

public class RentalAgency
{
    private Vehicle[] Fleet;
    public double TotalRevenue { get; private set; }

    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
    }

    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    public void RemoveVehicle(int index)
    {
        Fleet[index] = null;
    }

    public void RentVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            Fleet[index] = null;
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }

    // Additional methods for managing fleet can be added here
}
