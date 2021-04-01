using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
    //    public override Motorcycle()
    //    {
            
    //}
        public bool HasSideCar { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle Drive Abstract Override");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Don't drive virtual");
        }

    }
}
