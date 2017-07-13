using System.Collections.Generic;

public class Garage
{
    public Garage()
    {
        this.ParkedCars = new Dictionary<int, Car>();
    }

    private Dictionary<int, Car> parkedCars;

    public Dictionary<int, Car> ParkedCars
    {
        get { return this.parkedCars; }
        private set { this.parkedCars = value; }
    }

    public void Park(int id, Car car)
    {
        if (!this.ParkedCars.ContainsKey(id))
        {
            this.ParkedCars.Add(id, car);
        }
        else
        {
            this.ParkedCars[id] = car;
        }
    }

    public void Unpark(int id)
    {
        this.ParkedCars.Remove(id);
    }

    public bool IsCarParked(Car car)
    {
        if (this.ParkedCars.ContainsValue(car))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

