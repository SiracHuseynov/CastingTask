using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        private Vehicle[] _vehicles = new Vehicle[] { };
        private Car[] _cars = new Car[] { };
        private Truck[] _trucks = new Truck[] { };

        public int CarLimit { get; set; }
        public int TruckLimit { get; set; } 

        public void AddVehicle(Vehicle vehicle)
        {
            if(vehicle is Car)
            {
                if(_cars.Length < CarLimit)
                {
                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = (Car)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Car elave etmek olmaz, limit asildi!");
                }
            }
            if(vehicle is Truck)
            {
                if(_trucks.Length < TruckLimit)
                {
                    Array.Resize(ref _trucks, _trucks.Length + 1);
                    _trucks[_trucks.Length - 1] = (Truck)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Truck elave etmek olmaz, limit asildi!");
                }
            }
        }

        public void ShowAllVehicles()
        {
            foreach(Vehicle item in _vehicles)
            {
                if(item is Car)
                {
                    item.ShowInfo();
                }
                else if(item is Truck)
                {
                    item.ShowInfo();
                }
            }
        }
    }
}
