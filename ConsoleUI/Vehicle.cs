using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}
		public int Year { get; set; } = 0;
		public string Make { get; set; } = "Make";
		public string Model { get; set; } = "Model";

		public abstract void DriveAbstract();
		public virtual void DriveVirtual()
		{
			Console.WriteLine("Virtual: Vehicle");
			Console.WriteLine();
		}
	}
}

