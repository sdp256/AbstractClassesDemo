using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; } = "Car year";
        public string Make { get; set; } = "Manufacturer";
        public string Model { get; set; } = "Model type";
        public string Name { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Drive Virtual");
        }



    }
}
