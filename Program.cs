using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Lab_4._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Pig Latin Translator!");

			//Loops through until the user is done translating.
			string yesOrNo;
			do
			{
				//Calls method to get input from the user of sentence to translate.
				string translation = LineToBeTranslated();
				//Sends users input to the method to translate and returns the translation.
				translation = TranslateToPigLatin(translation);
				//Prints out the translation
				Console.WriteLine($"Translation: {translation}");

				//Asks the user if they want to continue translating and validates their input.
				Console.Write("\nTranslate another line? (y/n): ");
				yesOrNo = Console.ReadLine().ToLower();
				while (!(yesOrNo == "yes" || yesOrNo == "y" || yesOrNo == "no" || yesOrNo == "n"))
				{
					Console.Write("Invalid input.  Please enter (y/n): ");
					yesOrNo = Console.ReadLine().ToLower();
				}
			} while (yesOrNo == "yes" || yesOrNo == "y");
			Console.WriteLine("\nThanks for using the Pig Latin Translator!");
		}

		public static string LineToBeTranslated()
		{
			Console.Write("\nEnter a line to be translated: ");
			string input = Console.ReadLine();
			return input;
		}

		public static string TranslateToPigLatin(string input)
		{
			Regex vowels = new Regex("^[AEIOUaeiou]");
			if (vowels.IsMatch(input))
			{
				input += "way";
			}


			return input;
		}
	}
}
