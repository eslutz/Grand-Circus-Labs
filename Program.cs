using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Lab_3._3
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				//Asks the user for a word to reverse and takes the input.
				Console.Write("Please enter a word you would like to reverse. => ");
				string input = Console.ReadLine();
				//Uses regex to verify the word(s) only contain letters and not symbols and numbers.
				Regex validation = new Regex(@"^[A-Za-z\s]*$");
				while (!validation.IsMatch(input))
				{
					Console.Write("Sorry, that is not valid input.  Try again. => ");
					input = Console.ReadLine();
				}
				//Passes the users input to the Reverse method and prints out the return.
				Console.WriteLine($"Your word in reverse is: {Reverse(input)}");

				//Asks if the user wants to go again and either continues or breaks from loop depending on the users answer.
				Console.Write("\nDo you want to go again? (yes/no) => ");
				string goAgain = Console.ReadLine().ToLower();
				while (!(goAgain == "yes" || goAgain == "y" || goAgain == "no" || goAgain == "n"))
				{
					Console.Write("\nInvalid input.  Please enter \"yes\" or \"no\" => ");
					goAgain = Console.ReadLine().ToLower();
				}
				if (goAgain == "no" || goAgain == "n")
				{
					break;
				}
				else
				{
					Console.Clear();
				}
			}
		}

		static string Reverse(string sentence)
		{
			string reversedSentence = "";
			//Splits the users string into individual words.
			string[] words = sentence.Split(' ');
			//Runs through each word.
			foreach (string word in words)
			{
				string reversedWord = "";
				//Declares a stack to load in the characters making up the word
				Stack<char> reverseOrder = new Stack<char>();
				//Goes through the char array adding each letter to the stack.
				char[] letters = word.ToCharArray();
				foreach(char letter in letters)
				{
					reverseOrder.Push(letter);
				}
				//Goes through the stack adding the letters into the reversed word.
				while(reverseOrder.TryPop(out char currentLetter))
				{
					reversedWord += currentLetter;
				}
				//Builds the sentence in with the words reversed.
				reversedSentence += (reversedWord + " ");
			}
			//Returns the new sentence.
			return reversedSentence;
		}
	}
}