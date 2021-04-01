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

            var vehicles = new List<Vehicle>();

            Car c = new Car();
            c.Name = "Car 1";
            c.Year = "1990";
            c.Make = "Honda";
            c.Model = "Civic";
            c.HasTrunk = true;

            Motorcycle m = new Motorcycle();
            m.Name = "Motorcycle 1";
            m.Year = "2009";
            m.Make = "Kawasaki";
            m.Model = "Ninja";
            m.HasSideCar = true;

            Vehicle v1 = new Car();
            v1.Name = "Vehicle 1";
            v1.Year = "2016";
            v1.Make = "Nissan";
            v1.Model = "Rogue";
           
            Vehicle v2 = new Motorcycle();
            v2.Name = "Vehicle 2";
            v2.Year = "1966";
            v2.Make = "BMW";
            v2.Model = "Bike";

            vehicles.Add(c);
            vehicles.Add(m);
            vehicles.Add(v1);
            vehicles.Add(v2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Here are the stats on {item.Name}:");
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine("");
            }

            c.DriveAbstract();
            Console.WriteLine("");
            c.DriveVirtual();
            Console.WriteLine("");
            m.DriveAbstract();
            Console.WriteLine("");
            m.DriveVirtual();


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
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
