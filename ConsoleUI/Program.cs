using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            List<Vehicle> vehicles = new List<Vehicle>();
            Car car1 = new Car()
            {
                Year = 1965,
                Make = "Ford",
                Model = "Mustang",
                HasTrunk = true,
                Has4WheelDrive = false
            };
            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = 2001,
                Make = "Harley",
                Model = "Sportster",
                HasSideCar = false,
                HasWindShield = true
            };
            Vehicle car2 = new Car()
            {
                Year = 1996,
                Make = "Lincoln",
                Model = "Mark VIII",
                HasTrunk = true,
                Has4WheelDrive = false
            };
            Vehicle motorcycle2 = new Motorcycle()
            {
                Year = 2023,
                Make = "Harley",
                Model = "Fat Boy",
                HasSideCar = false,
                HasWindShield = false
            };
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make}, {item.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract(car1);
            car1.DriveVirtual(car1);
            motorcycle1.DriveAbstract(motorcycle1);
            motorcycle1.DriveVirtual(motorcycle1);
            #endregion            
            Console.ReadLine();
        }
    }
}
