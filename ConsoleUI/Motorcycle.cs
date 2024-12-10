using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar;
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is agile!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This motorcycle is fast!");
        }
    }
}
