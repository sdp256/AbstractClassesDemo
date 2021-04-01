using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Car Drive Abstract Override");
        }


    }
}
