using System;

namespace _02.ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public void GetSurfaceArea()
        {
            var surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height +
                              2 * this.Width * this.Height;
            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
        }

        public void GetLateralSurfaceArea()
        {
            var laterSurfaceArea = 2 * this.Length * this.Height +
                                   2 * this.Width * this.Height;
            Console.WriteLine($"Lateral Surface Area - {laterSurfaceArea:F2}");
        }

        public void GetVolume()
        {
            var volume = this.Length * this.Width * this.Height;
            Console.WriteLine($"Volume - {volume:F2}");
        }
    }
}