using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Week_4_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			//Exercise 42
			bool go = true;
			do
			{
				int x, y;
				Console.Write("Enter an X coordinate: ");
				x = int.Parse(Console.ReadLine());
				Console.Write("Enter a Y coordinate: ");
				y = int.Parse(Console.ReadLine());
				Point newPoint = new Point(x, y);
				Console.WriteLine($"You have created a point object ({newPoint.X}, {newPoint.Y}).");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 43
			go = true;
			do
			{
				int x, y;
				Console.Write("Enter an X coordinate: ");
				x = int.Parse(Console.ReadLine());
				Console.Write("Enter a Y coordinate: ");
				y = int.Parse(Console.ReadLine());
				Point newPoint = new Point(x, y);
				Console.WriteLine($"You have created a point object ({newPoint.X}, {newPoint.Y}).");
				Console.WriteLine($"It has a distance of {newPoint.CalculateDistance()}.");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 44
			go = true;
			do
			{
				int x, y;
				Console.Write("Enter an X1 coordinate: ");
				x = int.Parse(Console.ReadLine());
				Console.Write("Enter a Y1 coordinate: ");
				y = int.Parse(Console.ReadLine());
				Point newPoint = new Point(x, y);
				Console.Write("Enter an X2 coordinate: ");
				x = int.Parse(Console.ReadLine());
				Console.Write("Enter a Y2 coordinate: ");
				y = int.Parse(Console.ReadLine());
				Point newPoint2 = new Point(x, y);
				Console.WriteLine($"The midpoint between ({newPoint.X}, {newPoint.Y}) and ({newPoint2.X}, {newPoint2.Y}) is ({newPoint.CalculateMidpoint(newPoint2).X}, {newPoint.CalculateMidpoint(newPoint2).Y}).");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 45
			go = true;
			do
			{
				Console.Write("Enter a side length: ");
				int side = int.Parse(Console.ReadLine());
				Square newSquare = new Square(side);
				Console.WriteLine($"The square has a side length of {newSquare.SideLength}.  Its area is {newSquare.CalculateArea()} and its perimeter is {newSquare.CalculatePerimeter()}.");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

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

			//Exercise 49
			go = true;
			do
			{
				List<Square> squares = new List<Square>();
				string sideInput;
				do
				{
					Console.Write("Enter a side length (q to quit): ");
					sideInput = Console.ReadLine();
					bool isSquare = int.TryParse(sideInput, out int side);
					if (isSquare)
					{
						squares.Add(new Square(side));
					}
				} while (sideInput != "q");

				Console.WriteLine($"You created {squares.Count} squares.");
				Console.WriteLine($"Largest: {squares.Max(a => a.SideLength)}");
				Console.WriteLine($"Smallest: {squares.Min(a => a.SideLength)}");
				Console.WriteLine($"Average Area: {squares.Average(a => a.CalculateArea()):N2}");
				Console.WriteLine($"Average Perimeter: {squares.Average(a => a.CalculatePerimeter())}");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 50
			go = true;
			do
			{
				List<Triangle> triangles = new List<Triangle>();
				string sideInput;
				do
				{
					Console.Write("Enter side lengths of a triangle (q to quit): ");
					sideInput = Console.ReadLine();
					if (sideInput != "q")
					{
						string[] sides = sideInput.Split(' ');
						int[] triSides = new int[3];
						for (int index = 0; index < triSides.Length; index++)
						{
							triSides[index] = int.Parse(sides[index]);
						}
						triangles.Add(new Triangle(triSides[0], triSides[1], triSides[2]));
					}
				} while (sideInput != "q");

				Console.WriteLine($"You created {triangles.Count} squares.");
				Console.WriteLine($"Average Area: {triangles.Average(a => a.CaclulateArea()):N2}");
				Console.WriteLine($"Average Perimeter: {triangles.Average(a => a.CalculatePerimeter())}");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 58
			Suit ex1 = Suit.Spades;
			Browser ex2 = Browser.Safari;
			Brand ex3 = Brand.Gucci;
			Day ex4 = Day.Thursday;
			Console.WriteLine($"{ex1}, {ex2}, {ex3}, & {ex4}");

			//Exercise 59
			//see Card.cs

			//Exercise 60
			List<Card> deck = new List<Card>();
			foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
			{
				foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
				{
					deck.Add(new Card(rank, suit));
				}
			}

			Random rand = new Random();
			go = true;
			do
			{
				int index = rand.Next(deck.Count);
				Console.WriteLine($"Shuffling... You drew a {deck[index].Rank} of {deck[index].Suit}.");
				
				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

		}

		//Exercise 58
		enum Suit
		{
			Diamonds,
			Hearts,
			Clubs,
			Spades
		}
		enum Browser
		{
			Chrome,
			Firefox,
			Edge,
			Safari
		}
		enum Brand
		{
			Polo,
			Gucci,
			Armani,
			Athleta
		}
		enum Day
		{
			Sunday,
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday
		}
	}
}
