using System;
namespace Cars
{
    public class SportsCar:Car
    {
        public SportsCar(string vehicle, uint consumption, uint volume, uint speed,uint distance)
            :base(vehicle, consumption, volume, speed, distance)
        {
        }
    }
}

