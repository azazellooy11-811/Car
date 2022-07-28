using System;
namespace Cars
{
    public class PassengerCar: Car
    {
        public int PassengersCount { get; set; } //количество пассажиров
        public PassengerCar(string vehicle, uint consumption, uint volume, uint speed,uint distance, int passengersCount)
            : base(vehicle, consumption, volume,speed, distance)
        {
            PassengersCount = passengersCount;
        }


        public void GetPowerReserve()
        {
            if (PassengersCount > 5)
            {
                Console.WriteLine("Машина не поедет, количество пассажиров больше 5");
            }
            else
            {
                var powerReserve = base.GetDistance() * (100 - (6 * PassengersCount)) / 100;
                Console.WriteLine($"запас хода легкового автомобиля: {powerReserve}");
            }
            
            
        }
    }
}

