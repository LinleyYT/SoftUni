﻿using System.Collections.Generic;

public class Garage
{
    public Garage()
    {
        this.ParkedCars = new List<Car>();
    }

    private List<Car> parkedCars;

    public List<Car> ParkedCars
    {
        get { return this.parkedCars; }
        set { this.parkedCars = value; }
    }
}

