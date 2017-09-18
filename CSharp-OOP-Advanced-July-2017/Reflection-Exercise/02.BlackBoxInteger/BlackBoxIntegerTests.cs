using System;
using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = typeof(BlackBoxInt);
            var blackBoxInstance = (BlackBoxInt) Activator.CreateInstance(classType, true);
            MethodInfo[] blackBoxMethods =
                classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            string input = String.Empty;
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            while ((input = Console.ReadLine()) != "END")
            {
                var methodGiven = input.Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries)[0];
                var intGiven = int.Parse(input.Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries)[1]);

                blackBoxMethods.FirstOrDefault(m => m.Name == methodGiven)
                    .Invoke(blackBoxInstance, new object[] {intGiven});

                var fieldValue = (int) classFields.FirstOrDefault(f => f.IsPrivate).GetValue(blackBoxInstance);
                Console.WriteLine(fieldValue);
            }
            Console.WriteLine();
        }
    }
}