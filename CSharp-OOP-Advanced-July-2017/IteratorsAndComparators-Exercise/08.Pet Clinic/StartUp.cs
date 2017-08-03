using System;

namespace _08.Pet_Clinic
{
    public class StartUp
    {
        public static void Main()
        {
            var ci = new CommandInterpreter();
            ci.Run();
            Console.WriteLine();
        }
    }
}
