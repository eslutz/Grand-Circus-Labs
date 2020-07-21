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
				string[] translation = LineToBeTranslated();
				//Calls translation method and prints out the translation
				Console.WriteLine($"Translation: {TranslateToPigLatin(translation)}");

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

		public static string[] LineToBeTranslated()
		{
			Console.Write("\nEnter a line to be translated: ");
			string input = Console.ReadLine();
			string[] words = input.Split(" ");
			return words;
		}

		public static string TranslateToPigLatin(string[] input)
		{
			Regex vowels = new Regex(@"^[AEIOUaeiou]");
			Regex consonants = new Regex(@"^[B-DF-HJ-NP-TV-Zb-df-hj-np-tv-z][B-DF-HJ-NP-TV-Zb-df-hj-np-tv-z]");
			Regex consonants2 = new Regex(@"^[B-DF-HJ-NP-TV-Zb-df-hj-np-tv-z]");
			for (int index = 0; index < input.Length; index ++)
			{
				//Checks if the word starts with a vowel and applies the appropriate translation
				if (vowels.IsMatch(input[index]))
				{
					input[index] = input[index] + "way";
				}
				else if (consonants.IsMatch(input[index]))
				{
					input[index] = input[index].Substring(2) + input[index].Substring(0, 2) + "ay";
				}
				else if (consonants2.IsMatch(input[index]))
				{
					input[index] = input[index].Substring(1) + input[index].Substring(0, 1) + "ay";
				}

			}

			string translatedSentence = "";
			foreach(string word in input)
			{
				translatedSentence += word + " ";
			}

			return translatedSentence;
		}
	}
}
