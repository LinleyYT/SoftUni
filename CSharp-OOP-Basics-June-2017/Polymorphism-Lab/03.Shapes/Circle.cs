﻿using System;

public class Circle : Shape
{
    public Circle(double radius)
    {
        this.Radius = radius;
    }

    private double radius;

    public double Radius
    {
        get { return this.radius; }
        private set { this.radius = value; }
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}