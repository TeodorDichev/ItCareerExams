using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ParkingInterval
{
    private ParkingSpot parkingSpot;
    private string registrationPlate;
    private int hoursParked;
    private double revenue;

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        ParkingSpot = parkingSpot;
        RegistrationPlate = registrationPlate;
        HoursParked = hoursParked;
    }

    public double Revenue
    {
        get
        {
            if (parkingSpot is SubscriptionParkingSpot) return 0;
            return parkingSpot.Price * hoursParked;
        }
    }

    public ParkingSpot ParkingSpot
    {
        get { return parkingSpot; }
        private set { parkingSpot = value; }
    }

    public string RegistrationPlate
    {
        get { return registrationPlate; }
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Registration plate can’t be null or empty!");
            registrationPlate = value;
        }
    }

    public int HoursParked
    {
        get { return hoursParked; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Hours parked can’t be zero or negative!");
            hoursParked = value;
        }
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return parkingSpot.ParkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"> Parking Spot #{ParkingSpot.Id}");
        sb.AppendLine($"> RegistrationPlate: {RegistrationPlate}");
        sb.AppendLine($"> HoursParked: {HoursParked}");
        sb.AppendLine($"> Revenue: {Revenue:f2} BGN");

        return sb.ToString().Trim();
    }
}
