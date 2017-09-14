﻿public class CarFactory
{
    public Car CreateCar(string type, string brand, string model, int yearOfProduction,
        int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type.ToLower())
        {
            case "performance":
                return new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension,
                    durability);

            case "show":
                return new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);

            default:
                return null;
        }
    }
}