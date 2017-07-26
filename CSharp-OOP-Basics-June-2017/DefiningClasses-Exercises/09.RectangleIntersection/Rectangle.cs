using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        public string ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double[] Coordinates { get; set; }

        public Rectangle(string ID, double width, double height, double[] coords)
        {
            this.ID = ID;
            this.Width = width;
            this.Height = height;
            this.Coordinates = coords;
        }

        public bool RectangleIntersect(Rectangle rectangle)
        {
            if (rectangle.Coordinates[0] <= this.Coordinates[0] + this.Width && rectangle.Coordinates[0] + rectangle.Width >= this.Coordinates[0] && rectangle.Coordinates[1] <= this.Coordinates[1] + this.Height && rectangle.Coordinates[1] + rectangle.Height >= this.Coordinates[1])
            {
                return true;
            }
            return false;
        }
    }
}
