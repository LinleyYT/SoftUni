using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Mankind.Models;

namespace _03.Mankind
{
    public class Mankind
    {
        public static void Main()
        {
            try
            {
                var studentArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = studentArgs[0];
                var lastName = studentArgs[1];
                var facNum = studentArgs[2];

                var student = new Student(firstName, lastName, facNum);

                var workerArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var workerFirstName = workerArgs[0];
                var workerLastName = workerArgs[1];
                var salary = decimal.Parse(workerArgs[2]);
                var hours = decimal.Parse(workerArgs[3]);

                var worker = new Worker(workerFirstName, workerLastName, salary, hours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
