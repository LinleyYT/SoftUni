using System;

namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public void GetSurfaceArea()
        {
            var surfaceArea = 2 * this.length * this.width + 2 * this.length * this.height +
                              2 * this.width * this.height;
            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
        }

        public void GetLateralSurfaceArea()
        {
            var laterSurfaceArea = 2 * this.length * this.height +
                                   2 * this.width * this.height;
            Console.WriteLine($"Lateral Surface Area - {laterSurfaceArea:F2}");
        }

        public void GetVolume()
        {
            var volume = this.length * this.width * this.height;
            Console.WriteLine($"Volume - {volume:F2}");
        }
    }
}