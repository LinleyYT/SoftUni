using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    public CarManager()
    {
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
    }

    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    private Garage Garage
    {
        get { return this.garage; }
        set { this.garage = value; }
    }

    private Dictionary<int, Race> Races
    {
        get { return this.races; }
        set { this.races = value; }
    }

    private Dictionary<int, Car> Cars
    {
        get { return this.cars; }
        set { this.cars = value; }
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction,
        int horsepower, int acceleration, int suspension, int durability)
    {
        var carFactory = new CarFactory();
        Car producedCar = carFactory.CreateCar(type, brand, model, yearOfProduction, horsepower, acceleration,
            suspension, durability);
        if (producedCar != null)
        {
            this.Cars.Add(id, producedCar);
        }
    }

    public string Check(int id)
    {
        return this.Cars[id].ToString().Trim();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        var raceFactory = new RaceFactory();
        var producedRace = raceFactory.CreateRace(type, length, route, prizePool);
        if (producedRace != null)
        {
            this.Races.Add(id, producedRace);
        }
    }

    public void Open(int id, string type, int length, string route, int prizePool, int goldTime)
    {
        var raceFactory = new RaceFactory();
        var producedRace = raceFactory.CreateRace(type, length, route, prizePool, goldTime);
        if (producedRace != null)
        {
            this.Races.Add(id, producedRace);
        }
    }

    public void Participate(int carId, int raceId)
    {
        Race currentRace = this.Races[raceId];
        Car currentCar = this.Cars[carId];

        if (!garage.IsCarParked(currentCar))
        {
            currentRace.AddParticipant(currentCar);
        }
    }

    public string Start(int id)
    {
        var currentRace = Races[id];

        if (currentRace.Participants.Count > 0)
        {
            RemoveCompletedRace(id);
            return currentRace.StartRace().Trim();
        }

        return $"{Race.NotEnoughParticipants}";
    }

    public void Park(int id)
    {
        var carToPark = this.Cars[id];
        if (!Races.Values.Any(x => x.Participants.Contains(carToPark)))
        {
            garage.Park(id, carToPark);
        }
    }

    public void Unpark(int id)
    {
        var carToUnpark = this.Cars[id];

        if (garage.IsCarParked(carToUnpark))
        {
            garage.Unpark(id);
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in Garage.ParkedCars)
        {
            car.Value.Tune(tuneIndex, addOn);
        }
    }

    private void RemoveCompletedRace(int id)
    {
        this.Races.Remove(id);
    }
}