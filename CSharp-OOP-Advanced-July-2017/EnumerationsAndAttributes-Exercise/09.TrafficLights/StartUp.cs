using System;
using System.Collections.Generic;

namespace _09.TrafficLights
{
    public class StartUp
    {
        public static void Main()
        {
            List<TrafficLight> allTraficLights = new List<TrafficLight>();

            var inputSignal = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            foreach (var signal in inputSignal)
            {
                TrafficLightEnum initialColorState = (TrafficLightEnum) Enum.Parse(typeof(TrafficLightEnum), signal);
                allTraficLights.Add(new TrafficLight(initialColorState));
            }

            for (int i = 0; i < n; i++)
            {
                foreach (var trafficLight in allTraficLights)
                {
                    trafficLight.ChangeState();
                }

                Console.WriteLine(String.Join(" ", allTraficLights));
            }
        }
    }
}