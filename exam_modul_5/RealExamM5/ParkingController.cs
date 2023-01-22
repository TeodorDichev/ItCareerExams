using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParkingController
{
    private List<ParkingSpot> parkingSpaces;

    public ParkingController()
    {
        parkingSpaces = new List<ParkingSpot>();
    }

    public string CreateParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);

        if (parkingSpaces.Any(x => x.Id == id))
            return $"Parking spot {id} is already registered!";

        if (type == "car") parkingSpaces.Add(new CarParkingSpot(id, occupied, price));
        else if (type == "bus") parkingSpaces.Add(new BusParkingSpot(id, occupied, price));
        else if (type == "subscription")
        {
            string registarationPlate = args[4];
            parkingSpaces.Add(new SubscriptionParkingSpot(id, occupied, price, registarationPlate));
        }
        else return $"Unable to create parking spot!";
        return $"Parking spot {id} was successfully registered in the system!";
    }
    public string ParkVehicle(List<string> args)
    {
        int id = int.Parse(args[0]);
        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];

        ParkingSpot spot = parkingSpaces.FirstOrDefault(x => x.Id == id);
        if (Equals(spot, default(ParkingSpot))) return $"Parking spot {id} not found!";
        if (spot.Type != type || spot.Occupied) return $"Vehicle {registrationPlate} can't park at {id}.";
        spot.ParkVehicle(registrationPlate, hoursParked, type);
        return $"Vehicle {registrationPlate} parked at {id} for {hoursParked} hours.";
    }
    public string FreeParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);

        ParkingSpot spot = parkingSpaces.FirstOrDefault(x => x.Id == id);
        if (Equals(spot, default(ParkingSpot))) return $"Parking spot {id} not found!";
        if (!spot.Occupied) return $"Parking spot {id} is not occupied.";
        spot.Occupied = false;
        return $"Parking spot {id} is now free!";
    }
    public string GetParkingSpotById(List<string> args)
    {
        int id = int.Parse(args[0]);

        ParkingSpot spot = parkingSpaces.FirstOrDefault(x => x.Id == id);
        if (Equals(spot, default(ParkingSpot))) return $"Parking spot {id} not found!";
        return spot.ToString();
    }
    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        StringBuilder sb = new StringBuilder();

        int id = int.Parse(args[0]);
        string registrationPlate = args[1];

        ParkingSpot spot = parkingSpaces.FirstOrDefault(x => x.Id == id);
        if (Equals(spot, default(ParkingSpot))) return $"Parking spot {id} not found!";
        sb.AppendLine($"Parking intervals for parking spot {id}:");
        foreach (ParkingInterval parkingInterval in spot.ParkingIntervals.Where(x => x.RegistrationPlate == registrationPlate))
            sb.AppendLine(parkingInterval.ToString());
        return sb.ToString().Trim();
    }
    public string CalculateTotal()
    {
        return $"Total revenue from the parking: {parkingSpaces.Sum(x => x.CalculateTotal()):F2} BGN";
    }
}
