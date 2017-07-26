using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            var specs = Console.ReadLine().Trim()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var n = specs[0];
            var m = specs[1];

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var rectangleSpecs = Console.ReadLine().Trim()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var id = rectangleSpecs[0];
                var width = double.Parse(rectangleSpecs[1]);
                var height = double.Parse(rectangleSpecs[2]);
                var coords = new double[2] { double.Parse(rectangleSpecs[3]), double.Parse(rectangleSpecs[4])};

                var currentRect = new Rectangle(id, width, height, coords);
                rectangles.Add(currentRect);
            }

            for (int i = 0; i < m; i++)
            {
                var IDs = Console.ReadLine().Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstID = IDs[0];
                var secondID = IDs[1];

                var rectOne = rectangles.Where(x => x.ID == firstID).FirstOrDefault();
                var rectTwo = rectangles.Where(x => x.ID == secondID).FirstOrDefault();

                var result = rectOne.RectangleIntersect(rectTwo);

                if (result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
