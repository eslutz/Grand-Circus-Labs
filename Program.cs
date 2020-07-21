using System;
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
				int[] caseCondition = CaseCondition(translation);

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

		public static string TranslateToPigLatin(string[] words, int[] caseCondition)
		{
			Regex symbols = new Regex(@"(\W|\d)");
			char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
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
				//If there are no vowels in the word, adds "ay" to the end.
				bool vowelFirst = false;
				foreach (char vowel in vowels)
				{
					if(vowel == words[index][0])
					{
						words[index] = words[index] + "way";
						vowelFirst = true;
						break;
					}
				}
				vowelIndex = words[index].IndexOfAny(vowels);
				if (!vowelFirst && (vowelIndex != -1))
				{
					words[index] = words[index].Substring(vowelIndex) + words[index].Substring(0, vowelIndex) + "ay";
				}
				else if(!vowelFirst)
				{
					words[index] += "ay";
				}
			}
			//Once the words are translated, calls the method to fix the case of the word.
			words = FixCase(words, caseCondition);
			//Rebuilds each word back into a sentence.
			string translatedSentence = "";
			foreach (string word in words)
			{
				translatedSentence += word + " ";
			}
			//Returns the completed sentence.
			return translatedSentence;
		}

		//Checks the case condition of the word.
		//Returns 1 for all upper case.
		//Returns 2 for all lower case.
		//Returns 3 for first letter upper.
		//Returns 0 for inconsistent case.
		public static int[] CaseCondition(string[] words)
		{
			Regex firstCap = new Regex(@"^[A-Z][a-z]*");
			int[] caseCondition = new int[words.Length];
			for (int index = 0; index < words.Length; index++)
			{
				int caseCount = 0;
				for (int x = 0; x < words[index].Length; x++)
				{
					if (char.IsUpper(words[index][x]))
					{
						caseCount++;
					}
				}
				//All upper.
				if (caseCount == words[index].Length)
				{
					caseCondition[index] = 1;
				}
				//All lower.
				else if (caseCount == 0)
				{
					caseCondition[index] = 2;
				}
				//First letter upper.
				else if (firstCap.IsMatch(words[index]))
				{
					caseCondition[index] = 3;
				}
				//Mixed case throughout word.
				else
				{
					caseCondition[index] = 0;
				}
			}
			return caseCondition;
		}

		//Matches the case of each word to their original value.
		public static string[] FixCase(string[] words, int[] caseCondition)
		{
			for(int index = 0; index < words.Length; index++)
			{
				switch (caseCondition[index])
				{
					//Mix of cases, so don't do anything.
					case 0:
						continue;
					//Convert to all upper.
					case 1:
						words[index] = words[index].ToUpper();
						break;
					//Convert all to lower.
					case 2:
						words[index] = words[index].ToLower();
						break;
					//Converts the first letter to upper, the rest lower.
					case 3:
						string temp = "";
						temp +=	char.ToUpper(words[index][0]);
						words[index] = words[index].ToLower();
						words[index] = words[index].Remove(0,1);
						words[index] = words[index].Insert(0, temp);
						break;
					//Don't do anything in this case
					default:
						continue;
				}
			}
			return words;
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