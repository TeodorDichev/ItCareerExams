using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SubscriptionParkingSpot : ParkingSpot
{
    private string registrationPlate;

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
    {
        RegistrationPlate = registrationPlate;
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
}
