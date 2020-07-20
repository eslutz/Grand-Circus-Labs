using System;
using System.Security.Cryptography.X509Certificates;

namespace Week_4_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			//Exercise 42
			bool go = true;
			//do
			//{
			//	int x, y;
			//	Console.Write("Enter an X coordinate: ");
			//	x = int.Parse(Console.ReadLine());
			//	Console.Write("Enter a Y coordinate: ");
			//	y = int.Parse(Console.ReadLine());
			//	Point newPoint = new Point(x, y);
			//	Console.WriteLine($"You have created a point object ({newPoint.X}, {newPoint.Y}).");

			//	Console.Write("Would you like to continue (y/n)? ");
			//	string input = Console.ReadLine();
			//	if (input == "n")
			//	{
			//		go = false;
			//	}
			//} while (go);

			////Exercise 43
			//go = true;
			//do
			//{
			//	int x, y;
			//	Console.Write("Enter an X coordinate: ");
			//	x = int.Parse(Console.ReadLine());
			//	Console.Write("Enter a Y coordinate: ");
			//	y = int.Parse(Console.ReadLine());
			//	Point newPoint = new Point(x, y);
			//	Console.WriteLine($"You have created a point object ({newPoint.X}, {newPoint.Y}).");
			//	Console.WriteLine($"It has a distance of {newPoint.CalculateDistance()}.");

			//	Console.Write("Would you like to continue (y/n)? ");
			//	string input = Console.ReadLine();
			//	if (input == "n")
			//	{
			//		go = false;
			//	}
			//} while (go);

			////Exercise 44
			//go = true;
			//do
			//{
			//	int x, y;
			//	Console.Write("Enter an X1 coordinate: ");
			//	x = int.Parse(Console.ReadLine());
			//	Console.Write("Enter a Y1 coordinate: ");
			//	y = int.Parse(Console.ReadLine());
			//	Point newPoint = new Point(x, y);
			//	Console.Write("Enter an X2 coordinate: ");
			//	x = int.Parse(Console.ReadLine());
			//	Console.Write("Enter a Y2 coordinate: ");
			//	y = int.Parse(Console.ReadLine());
			//	Point newPoint2 = new Point(x, y);
			//	Console.WriteLine($"The midpoint between ({newPoint.X}, {newPoint.Y}) and ({newPoint2.X}, {newPoint2.Y}) is ({newPoint.CalculateMidpoint(newPoint2).X}, {newPoint.CalculateMidpoint(newPoint2).Y}).");

			//	Console.Write("Would you like to continue (y/n)? ");
			//	string input = Console.ReadLine();
			//	if (input == "n")
			//	{
			//		go = false;
			//	}
			//} while (go);

			////Exercise 45
			//go = true;
			//do
			//{
			//	Console.Write("Enter a side length: ");
			//	int side = int.Parse(Console.ReadLine());
			//	Square newSquare = new Square(side);
			//	Console.WriteLine($"The square has a side length of {newSquare.SideLength}.  Its area is {newSquare.CalculateArea()} and its perimeter is {newSquare.CalculatePerimeter()}.");

			//	Console.Write("Would you like to continue (y/n)? ");
			//	string input = Console.ReadLine();
			//	if (input == "n")
			//	{
			//		go = false;
			//	}
			//} while (go);

			//Exercise 46
			go = true;
			do
			{
				Console.Write("Enter side 1 length: ");
				int side1 = int.Parse(Console.ReadLine());
				Console.Write("Enter side 2 length: ");
				int side2 = int.Parse(Console.ReadLine());
				Console.Write("Enter side 3 length: ");
				int side3 = int.Parse(Console.ReadLine());
				Triangle newTri = new Triangle(side1, side2, side3);
				Console.WriteLine($"The triangle has a side lengths of {newTri.Side1Length}, {newTri.Side2Length}, and {newTri.Side3Length}.  Its area is {newTri.CaclulateArea()} and its perimeter is {newTri.CalculatePerimeter()}.");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);
		}
	}
}
