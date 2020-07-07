using System;

namespace Lab2._1RoomCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declares all the variables needed for computing area and volume.
			double length, width, height, area, perimeter, volume;
			string roomClassification, keepGoingResponse;
			bool keepGoing = true;

			Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");

			// Loops until the user decides they want to quit.
			while (keepGoing)
			{
				// Gets all the needed input from the user.
				Console.WriteLine("\nEnter the length of the room. =>");
				length = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter the width of the room. =>");
				width = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter the height of the room. =>");
				height = double.Parse(Console.ReadLine());

				// Computes the area and the volume.
				area = length * width;
				perimeter = (length + width) * 2;
				volume = length * width * height;

				// Classifies the room size
				if (area <= 250)
				{
					roomClassification = "small";
				}
				else if (area < 650)
				{
					roomClassification = "medium";
				}
				else
				{
					roomClassification = "large";
				}

				// Displays the computed results.
				Console.WriteLine($"Area: {area}");
				Console.WriteLine($"Perimeter: {perimeter}");
				Console.WriteLine($"Volume: {volume}");
				Console.WriteLine($"The room is {roomClassification}");

				// Checks to see if the user would like to continue or quit.
				Console.WriteLine("\nContinue (y/n) =>");
				keepGoingResponse = Console.ReadLine();
				if (keepGoingResponse == "n")
				{
					keepGoing = false;
				}
			}
			Console.WriteLine("\nThank you for using the Room Detail Generator!");
		}
	}
}
