using System;

namespace _09.TrafficLights
{
    public class TrafficLight
    {
        public TrafficLight(TrafficLightEnum trafficLightEnum)
        {
            this.TrafficLightEnum = trafficLightEnum;
        }

        public TrafficLightEnum TrafficLightEnum { get; private set; }

        public void ChangeState()
        {
            this.TrafficLightEnum = (TrafficLightEnum) (((int) this.TrafficLightEnum + 1) %
                                                        Enum.GetNames(typeof(TrafficLightEnum)).Length);
        }

        public override string ToString()
        {
            return this.TrafficLightEnum.ToString();
        }
    }
}