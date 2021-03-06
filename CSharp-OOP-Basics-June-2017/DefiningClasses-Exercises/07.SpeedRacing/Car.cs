﻿using System;

namespace _07.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }

        public Car(string model, double fuelAmount, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = consumption;
            this.Distance = 0;
        }

        public void Drive(double km)
        {
            var maxDistance = this.FuelAmount / this.FuelConsumption;
            if (km > maxDistance)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.Distance += km;
                this.FuelAmount -= this.FuelConsumption * km;
            }
        }
    }
}