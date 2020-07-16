using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Week_3_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			//Exercise 31
			bool go = true;
			do
			{
				int[] array = { 2, 8, 0, 24, 51 };
				Console.Write("Enter an index of the array => ");
				int index = int.Parse(Console.ReadLine());
				if (index >= array.Length)
				{
					Console.WriteLine("That number is too big.  Try again!");
					continue;
				}
				else
				{
					Console.WriteLine($"The value of the array at {index} is {array[index]}.");
				}

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 32
			go = true;
			do
			{
				int[] array = { 2, 8, 0, 24, 51 };
				Console.Write("Enter a number => ");
				int input = int.Parse(Console.ReadLine());
				if (Array.IndexOf(array, input) != -1)
				{
					Console.WriteLine($"The value {input} can be found at {Array.IndexOf(array, input)}");
					continue;
				}
				else
				{
					Console.WriteLine($"The value {input} cannot be found.");
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 33
			go = true;
			do
			{
				int[] array = { 2, 8, 0, 24, 51 };
				Console.Write("Enter an index of the array => ");
				int index = int.Parse(Console.ReadLine());
				if (index >= array.Length)
				{
					Console.WriteLine("That number is too big.  Try again!");
					continue;
				}
				else
				{
					Console.Write($"The value of the array at {index} is {array[index]}.  Would you like to change it? (y/n) => ");
					string changeIt = Console.ReadLine();
					if (changeIt == "y")
					{
						Console.Write($"Enter a new value at index {index}. => ");
						int input = int.Parse(Console.ReadLine());
						array[index] = input;
						Console.Write($"The value of the array at {index} is {array[index]}.  Would you like to continue? (y/n) => ");
						string inputCont = Console.ReadLine();
						if (inputCont == "n")
						{
							go = false;
						}
					}
				}
			} while (go);

			//Exercise 34
			go = true;
			int[] arrayZero = { 16, 32, 64, 128, 256 };
			do
			{
				Console.Write("Enter a command. (half/double) => ");
				string command = Console.ReadLine();
				if (command == "half" || command == "double")
				{
					if (command == "half")
					{
						for (int x = 0; x < arrayZero.Length; x++)
						{
							arrayZero[x] /= 2;
						}
					}
					else
					{
						for (int x = 0; x < arrayZero.Length; x++)
						{
							arrayZero[x] *= 2;
						}
					}
					Console.Write("The array now contains: ");
					foreach (int x in arrayZero)
					{
						Console.Write(x + ", ");
					}

				}
				else
				{
					Console.WriteLine("Invalid input.  Try again.");
					continue;
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 35
			go = true;
			do
			{
				string[] array = { "cow", "elephant", "jaguar", "horse", "crow" };
				Console.Write("Enter two indices. => ");
				string input = Console.ReadLine();
				string[] index = input.Split(" ");
				if (int.Parse(index[0]) > array.Length)
				{
					Console.WriteLine("Those are not valid indices.  Try again.");
					continue;
				}
				else
				{
					if (int.Parse(index[1]) > array[int.Parse(index[0])].Length)
					{
						Console.WriteLine("Those are not valid indices.  Try again.");
						continue;
					}
					else
					{
						Console.WriteLine($"The value at index {index[0]} is {array[int.Parse(index[0])]}.  The letter at index {index[1]} is {array[int.Parse(index[0])][int.Parse(index[1])]}.");
					}
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 36
			go = true;
			do
			{
				int[] number = { 12, 11, 10, 9, 8 };
				string[] word = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

				for (int x = 0; x < number.Length; x++)
				{
					Console.WriteLine(number[x] + " " + word[x]);
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 37
			go = true;
			do
			{
				int[] number = new int[5];
				int sum = 0;
				string output = "";
				for (int x = 0; x < number.Length; x++)
				{
					Console.Write("Enter a number. => ");
					number[x] = int.Parse(Console.ReadLine());
				}
				foreach (int num in number)
				{
					sum += num;
				}
				for (int x = 0; x < number.Length - 1; x++)
				{
					output += $"{number[x]} + ";
				}
				Console.WriteLine($"{output}{number[number.Length - 1]} = {sum}");

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 38
			go = true;
			do
			{
				int[] number = new int[5];
				int sum = 0;
				string output = "";
				for (int x = 0; x < number.Length; x++)
				{
					Console.Write("Enter a number. => ");
					number[x] = int.Parse(Console.ReadLine());
				}
				foreach (int num in number)
				{
					sum += num;
				}
				for (int x = 0; x < number.Length - 1; x++)
				{
					output += $"{number[x]} + ";
				}
				Console.WriteLine($"({output}{number[number.Length - 1]})/{number.Length} = {sum / number.Length}");

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 39
			go = true;
			do
			{
				int[] number = new int[5];
				for (int x = 0; x < number.Length; x++)
				{
					Console.Write("Enter a number. => ");
					number[x] = int.Parse(Console.ReadLine());
				}
				Array.Sort(number);
				foreach (int x in number)
				{
					Console.Write(x + " ");
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 40
			go = true;
			do
			{
				int[] number = new int[5];
				string output = "";
				for (int x = 0; x < number.Length; x++)
				{
					Console.Write("Enter a number. => ");
					number[x] = int.Parse(Console.ReadLine());
				}
				Array.Sort(number);
				for (int x = 0; x < number.Length - 1; x++)
				{
					output += $"{number[x]}, ";
				}
				Console.WriteLine($"The median of ({output}{number[number.Length - 1]}) is {number[(number.Length - 1) / 2]}.");

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 41
			go = true;
			do
			{
				Console.Write("Enter a number. => ");
				double num1 = double.Parse(Console.ReadLine());
				Console.Write("Enter a number. => ");
				double num2 = double.Parse(Console.ReadLine());
				if (num2 == 0)
				{
					Console.WriteLine("You cannot devide by zero.  Try again.");
					continue;
				}
				Console.WriteLine($"{num1}/{num2} is approximately {num1 / num2:N2}");

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 47
			go = true;
			List<string> sentenceZero = new List<string>();
			do
			{
				Console.Write("Enter some text. => ");
				sentenceZero.Add(Console.ReadLine());
				Console.Write("You have entered => ");
				foreach (string text in sentenceZero)
				{
					Console.Write(text + " ");
				}
				Console.WriteLine();

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 48
			go = true;
			Regex numberReg = new Regex(@"^\d*$");
			do
			{
				List<int> number = new List<int>();
				while (true)
				{
					Console.Write("Enter a number. => ");
					string input = Console.ReadLine().ToLower();
					if (input == "q")
					{
						string output = "";
						int sum = 0;
						for (int x = 0; x < number.Count - 1; x++)
						{
							output += $"{number[x]} + ";
						}
						foreach (int num in number)
						{
							sum += num;
						}
						Console.WriteLine($"{output}{number[number.Count - 1]} = {sum}");
						break;
					}
					else if (!numberReg.IsMatch(input))
					{
						Console.WriteLine("You did not enter a numer.  Try again.");
						continue;
					}
					else
					{
						number.Add(int.Parse(input));
					}
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 51
			go = true;
			do
			{
				Dictionary<string, string> translations = new Dictionary<string, string>()
				{
					["hello"] = "hola",
					["food"] = "comida",
					["world"] = "mundo",
					["computer"] = "computadora",
					["exercise"] = "ejercicio",
				};
				Console.Write("Enter a word in English. => ");
				string word = Console.ReadLine();
				if (translations.ContainsKey(word))
				{
					Console.WriteLine($"{word} in Spanish is {translations[word]}");
				}
				else
				{
					Console.WriteLine($"{word} cannot be translated.");
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
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
