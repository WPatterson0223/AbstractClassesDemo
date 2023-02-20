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
		public bool HasWindShield { get; set; }

        public override void DriveAbstract(Vehicle moto)
        {
            Console.WriteLine($"My car is a {moto.Year} {moto.Make}, {moto.Model}");
            Console.WriteLine();
        }
        public override void DriveVirtual(Vehicle moto)
        {
            Console.WriteLine($"Virtual: My car is a {moto.Year} {moto.Make}, {moto.Model}");
            Console.WriteLine();
        }
    }
}

