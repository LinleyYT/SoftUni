using System;
using System.Collections.Generic;

namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            IShape circle = new Circle();
            IShape square = new Square();
            IShape rectangle = new Rectangle();

            var listOfShapes = new List<IShape>() {circle, rectangle, square};

            foreach (var shape in listOfShapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
