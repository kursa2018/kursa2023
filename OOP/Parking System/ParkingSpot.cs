using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ParkingSpot
{
    private int id;
    private bool occupied;
    private string type;
    private double price;
    protected List<ParkingInterval> parkingIntervals;
   
    public int Id
    {
        get
        {
            return this.id;
        }

        set
        {
            this.id = value;
        }
    }

    public bool Occupied
    {
        get
        {
            return this.occupied;
        }

        set
        {
            this.occupied = value;
        }
    }

    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            this.type = value;
        }

    }

    public double Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value<=0)
            {
                throw new AccessViolationException("Parking price cannot be less or equal to 0!");
            }
            this.price = value;
        }
    }

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
        this.parkingIntervals = new List<ParkingInterval>();
    }
    
    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public virtual double CalculateTotal()
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

}
