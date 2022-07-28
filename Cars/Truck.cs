using System;
namespace Cars
{
    public class Truck:Car
    {
        public int Carrying { get; set; } //грузоподъемность
        public Truck(string vehicle, uint consumption, uint volume, uint speed, uint distance, int carrying)
            : base(vehicle, consumption, volume, distance, speed)
        {
            Carrying = carrying;
        }

        public void GetPowerReserve(int carrying)
        {
            if (carrying > Carrying)
            {
                Console.WriteLine("Машина не поедет, много груза");
            }
            else
            {
                var wholePart = Convert.ToInt16(carrying/200);
                var powerReserve = base.GetDistance() * (100 - (4 * wholePart)) / 100;
                Console.WriteLine($"запас хода грузового автомобиля: {powerReserve}");
            }


        }
    }
}

