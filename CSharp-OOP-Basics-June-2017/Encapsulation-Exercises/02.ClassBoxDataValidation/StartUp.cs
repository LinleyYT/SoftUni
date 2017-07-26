using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.ClassBoxDataValidation
{
    public class StartUp
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length, width, height);
                box.GetSurfaceArea();
                box.GetLateralSurfaceArea();
                box.GetVolume();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
