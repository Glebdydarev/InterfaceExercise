using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -Done

            //Create 3 classes called Car , Truck , & SUV -DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.-Done
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company-Done
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class- Done
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.-Done
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();

            var truck1 = new Truck
            {
                Make = "Ford",
                Model = "F-150",
                HasHook = true,
                HasBed = true,
                EngineSize = 5.5,
                SeatCount = 5,
                CompanyName = "Ford",
                Logo = "Ford"

                




            };

            var SUV = new SUV
            {
                FourWeelDrive = true,
                HasSevenSeats = true,
                EngineSize = 2.5,
                Make = "Subaru",
                Model = "Foroster",
                SeatCount = 5,
                CompanyName = "Subaru",
                Logo = "Subaru",


            };

            var car = new Car
            {
                Hastrunk = false,
                IsConvertible = true,
                HasLeatherSeats = true,
                EngineSize = 6.0,
                Make = "Ferari",
                Model = "F-1",
                SeatCount = 2,
                CompanyName = "Ferari",
                Logo = "Ferari"

            };

            vehicles.Add(SUV);
            vehicles.Add(truck1);
            vehicles.Add(car);


            foreach (var vehicle in vehicles )
            {
                Console.WriteLine($"Vehcle.{vehicle.EngineSize},{vehicle.Make}, {vehicle.Model}, {vehicle.SeatCount}");
                Console.WriteLine();
            }




        }
    }
}
