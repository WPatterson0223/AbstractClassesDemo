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

		public abstract void DriveAbstract(Vehicle vehicle);
		public virtual void DriveVirtual(Vehicle vehicle)
		{
			Console.WriteLine($"Virtual: My vehicle is a {vehicle.Year} {vehicle.Make}, {vehicle.Model}");
			Console.WriteLine();
		}
	}
}

