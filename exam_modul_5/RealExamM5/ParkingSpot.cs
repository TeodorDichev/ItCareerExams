using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class ParkingSpot
{
    private int id;
    private bool occupied;
    private string type;
    private double price;
    protected List<ParkingInterval> parkingIntervals;

    protected ParkingSpot(int id, bool occupied, string type, double price)
    {
        Id = id;
        Occupied = occupied;
        Type = type;
        Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }
    public bool Occupied
    {
        get { return occupied; }
        set { occupied = value; }
    }
    public string Type
    {
        get { return type; }
        private set { type = value; }
    }
    public double Price
    {
        get { return price; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            price = value;
        }
    }

    public List<ParkingInterval> ParkingIntervals
    {
        get { return parkingIntervals; }
    }

    public bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (Occupied || Type != type) return false;
        ParkingInterval parkingInterval = new ParkingInterval(this, registrationPlate, hoursParked);
        parkingIntervals.Add(parkingInterval);
        Occupied = true;
        return true;
    }

    public double CalculateTotal()
    {
        return parkingIntervals.Sum(x => x.Revenue);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"> Parking Spot #{Id}");
        sb.AppendLine($"> Occupied: {Occupied}");
        sb.AppendLine($"> Type: {Type}");
        sb.AppendLine($"> Price per hour: {Price:f2} BGN");

        return sb.ToString().Trim();
    }
}

