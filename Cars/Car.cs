using System;
namespace Cars
{
    public class Car
    {
        public string Vehicle { get; set; } //транспортное средство
        public uint Consumption { get; set; } //расход топлива
        public uint Volume { get; set; } //объём бака
        public uint Speed { get; set; } //скорость
        public uint Distance { get; set; }

        public Car(string vehicle, uint consumption, uint volume, uint speed, uint distance)
        {
            Vehicle = vehicle;
            Consumption = consumption;
            Volume = volume;
            Speed = speed;
            Distance = distance;
        }

        public double GetDistance()
        {
            //расстояние = объем бака * (100км/расход топлива)
            double distance = (Volume * 100) / Consumption;
            //Console.WriteLine(distance);
            return distance;
        }

        public void GetTime()
        {
            var dist = GetDistance();
            if (dist < Distance)
            {
                Console.WriteLine("Ты не сможешь проехать это расстояние, нужно будет заправиться");
            }
            else
            {
                Console.WriteLine($"ты доедешь вот за такое время в часах:{Distance/Speed}");
            }
        }
    }
}

