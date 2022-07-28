namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar passengerCar = new PassengerCar("легковой автомобиль", 8,42,120,300,1);
            passengerCar.GetDistance();
            passengerCar.GetPowerReserve();
            Truck truck = new Truck("грузовой автомобиль", 8, 42, 120,50, 230);
            truck.GetPowerReserve(230);
            passengerCar.GetTime();
        }
    }
}