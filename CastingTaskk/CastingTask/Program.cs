using Core.Models;

namespace CastingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car();
            car.Marka = "Bmw";
            car.Year = 2024;
            car.PassangerCapacity = 4;
            car.Model = "F30";

            Car car1 = new Car();
            car1.Marka = "Bmw1";
            car1.Year = 2024;
            car1.PassangerCapacity = 4;
            car1.Model = "F30";

            Car car2 = new Car();
            car2.Marka = "Bmw2";
            car2.Year = 2024;
            car2.PassangerCapacity = 4;
            car2.Model = "F30";

            Car car3 = new Car();
            car3.Marka = "Bmw3";
            car3.Year = 2024;
            car3.PassangerCapacity = 4;
            car3.Model = "F30";


            Truck truck = new Truck();
            truck.Marka = "Mercedes";
            truck.Year = 1999;
            truck.CarryingCapacity = 50;
            truck.Model = "C63";

            Truck truck1 = new Truck();
            truck1.Marka = "Mercedes1";
            truck1.Year = 1999;
            truck1.CarryingCapacity = 50;
            truck1.Model = "C63";

            Truck truck2 = new Truck();
            truck2.Marka = "Mercedes2";
            truck2.Year = 1999;
            truck2.CarryingCapacity = 50;
            truck2.Model = "C23";

            Truck truck3 = new Truck();
            truck3.Marka = "Mercedes3";
            truck3.Year = 1999;
            truck3.CarryingCapacity = 50;
            truck3.Model = "C63";

            RentCar rentCar = new RentCar();
            rentCar.CarLimit = 3;
            rentCar.TruckLimit = 3;

            rentCar.AddVehicle(car);
            rentCar.AddVehicle(car1);
            rentCar.AddVehicle(car2);
            //rentCar.AddVehicle(car3);

            rentCar.AddVehicle(truck);
            rentCar.AddVehicle(truck1);
            rentCar.AddVehicle(truck2);
            //rentCar.AddVehicle(truck3);

            rentCar.ShowAllVehicles();



        }
    }
}