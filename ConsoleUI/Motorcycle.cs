using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}
		public bool HasSideCar { get; set; }
		

        public override void DriveAbstract()
        {
            Console.WriteLine($"Abstract: Motorcycle");
            Console.WriteLine();
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Virtual: Motorcycle");
            Console.WriteLine();
        }
    }
}

