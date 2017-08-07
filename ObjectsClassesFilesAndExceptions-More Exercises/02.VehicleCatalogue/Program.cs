using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehicleCatalogue
{
    class Program
    {
        public class Vehicles
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public long HorsePower { get; set; }
        }
        static void Main(string[] args)
        {
            var newVehicles = new List<Vehicles>(); //Data Collector.

            long horsePowerTruck = 0;
            var countTrucks = 0;
            long horsePowerCar = 0;
            var countCars = 0;
            decimal carAverageHorsePower = 0.0M;
            decimal truckAverageHorsePower = 0.0M;

            // Cars data collecting.
            var vehiclesInput = Console.ReadLine();
            while (vehiclesInput != "End")
            {
                if (vehiclesInput != "End")
                {
                    var dataReading = vehiclesInput
                        .Split(' ')
                        .ToArray();

                    var eachVehicle = new Vehicles();

                    //Getting first letter Capital.
                    if (dataReading[0].ToLower() == "truck") eachVehicle.Type = "Truck";
                    else if (dataReading[0].ToLower() == "car") eachVehicle.Type = "Car";

                    eachVehicle.Model = dataReading[1];
                    eachVehicle.Color = dataReading[2].ToLower();
                    eachVehicle.HorsePower = long.Parse(dataReading[3]);

                    newVehicles.Add(eachVehicle);
                }
                vehiclesInput = Console.ReadLine();
            }

            //Printing listed cars.
            var vehicleSearch = Console.ReadLine();
            while (vehicleSearch != "Close the Catalogue")
            {
                if (vehicleSearch != "Close the Catalogue")
                {
                    foreach (var vehicle in newVehicles)
                    {
                        if (vehicleSearch == vehicle.Model)
                        {
                            Console.WriteLine($"Type: {vehicle.Type}");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        }
                    }
                }
                vehicleSearch = Console.ReadLine();
            }

            //Cars and Trucks Average HP.
            foreach (var vehicle in newVehicles)
            {
                if (vehicle.Type == "Truck")
                {
                    horsePowerTruck += vehicle.HorsePower;
                    countTrucks++;
                }
                else if (vehicle.Type == "Car")
                {
                    horsePowerCar += vehicle.HorsePower;
                    countCars++;
                }
            }
            if (horsePowerCar != 0 || countCars != 0) carAverageHorsePower = (decimal)horsePowerCar / countCars;
            if (horsePowerTruck != 0 || countTrucks != 0) truckAverageHorsePower = (decimal)horsePowerTruck / countTrucks;
            Console.WriteLine($"Cars have average horsepower of: {carAverageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorsePower:f2}.");
        }
    }
}
