using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}
		public bool HasTrunk { get; set; }
		public bool Has4WheelDrive { get; set; }

        public override void DriveAbstract(Vehicle car)
        {
			Console.WriteLine($"My car is a {car.Year} {car.Make}, {car.Model}");
			Console.WriteLine();
        }
    }
}

