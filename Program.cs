using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
				//Determines the case of the sentence.
				int caseCondition = CaseCondition(translation);
				//Calls translation method and prints out the translation.
				Console.WriteLine($"Translation: {TranslateToPigLatin(translation, caseCondition)}");

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

		//Gets the input from the user what they want to translate and verifies it isn't blank.
		public static string[] LineToBeTranslated()
		{
			Console.Write("\nEnter a line to be translated: ");
			string input = Console.ReadLine();
			string[] words = input.Split(" ");
			if (string.IsNullOrWhiteSpace(input))
			{
				Console.Write("You have to enter something.\n");
				words = LineToBeTranslated();
			}

			return words;
		}

		//Checks the case condition of the word.
		//Returns 0 for all lower case.
		//Returns 1 for all upper case.
		//Returns 3 for a mix.
		public static int CaseCondition(string[] words)
		{
			foreach(string word in words)
			{
				for(int x = 0; x < word.Length; x++)
				{
					if (char.IsUpper(word[x]))
					{

					}
				}
			}
			return 0;
		}

		public static string TranslateToPigLatin(string[] words, int caseCondition)
		{
			Regex symbols = new Regex(@"(\W|\d)");
			char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
			int vowelIndex;
			
			//Loops through each word in the sentence
			for(int index = 0; index < words.Length; index++)
			{
				//Checks if word needs to be skipped due to symbols or numbers.
				if (symbols.IsMatch(words[index]))
				{
					continue;
				}
				//First check to see if the word starts with a vowel.
				//If it does, translate it.
				//If it doesn't, get the index of the first vowel for word and then translates the word.
				bool vowelFirst = false;
				foreach (char vowel in vowels)
				{
					if(vowel == words[index][0])
					{
						words[index] = words[index] + "way";
						vowelFirst = true;
					}
				}
				if (!vowelFirst)
				{
					vowelIndex = words[index].IndexOfAny(vowels);
					words[index] = words[index].Substring(vowelIndex) + words[index].Substring(0, vowelIndex) + "ay";
				}
			}

			//Rebuilds each word back into a sentence.
			string translatedSentence = "";
			foreach (string word in words)
			{
				translatedSentence += word + " ";
			}

			//Returns the completed sentence.
			return translatedSentence;
		}
	}
}

//Attempt to do translate with Regex.  Keeping for reference.
//Regex symbols = new Regex(@"(\W|\d)");
//Regex vowels = new Regex(@"^[AEIOUaeiou]");
//Regex consonants = new Regex(@"^[B-DF-HJ-NP-TV-Zb-df-hj-np-tv-z][B-DF-HJ-NP-TV-Zb-df-hj-np-tv-z]");
//Regex consonants2 = new Regex(@"^[B-DF-HJ-NP-TV-Zb-df-hj-np-tv-z]");
//for (int index = 0; index < words.Length; index ++)
//{
//	//Checks if the word starts with a vowel and applies the appropriate translation
//	if (symbols.IsMatch(words[index]))
//	{
//		continue;
//	}
//	else if (vowels.IsMatch(words[index]))
//	{
//		words[index] = words[index] + "way";
//	}
//	else if (consonants.IsMatch(words[index]))
//	{
//		words[index] = words[index].Substring(2) + words[index].Substring(0, 2) + "ay";
//	}
//	else if (consonants2.IsMatch(words[index]))
//	{
//		words[index] = words[index].Substring(1) + words[index].Substring(0, 1) + "ay";
//	}
//}