using System;

namespace Lab_3._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Arrays of student information
			string[] studentName = { "Rick Vickery", "Adam Gerecke", "Eric Slutz", "Tyler Satkowiak", "Aaron Rudzki", "Chuck Allen", "Manny Salazar", "Kathryn Pidek", "Eugene Hill", "Brendan Burch", "Jim Nofs", "David Heizer", "Zach Scholts", "Dave Gedert" };
			string[] studentFood = { "Sushi", "Pie", "Hamburger", "Pizza", "Cheese", "Steak", "Chicken", "Calzone", "Pasta", "Subs", "PB&J", "Taco", "Burrito", "Fish" };
			string[] studentPrevTitle = { "Emperor", "Ceasar", "Archduke", "Grand Prince", "Lord", "Count", "Barron", "Duchess", "King", "Earl", "Grand Duke", "Marquess", "Lordship", "Esquire" };

			while (true)
			{
				Console.Write("Welcome to out Dev.Build class.  Which student would you like to learn more about? (enter a number 1-14) => ");
				int student;
				bool isValid = int.TryParse(Console.ReadLine(), out student);
				//Checks that the user entered a valid number that is between 1 and 16.  If it isn't the user has to try again.
				while (!isValid || !(student >= 1 && student <= 14))
				{
					Console.Write("\nThat student does not exist.  Please try again. (enter a number 1-16) => ");
					isValid = int.TryParse(Console.ReadLine(), out student);
				}

				//Takes the users input and converts it to a zero based index
				int index = student - 1;
				//Gets the students first name
				string firstName = studentName[index].Substring(0, studentName[index].IndexOf(' '));
				//Displays the picked student and asks the user what they want to know about them and takes that input
				Console.Write($"\nStudent {student} is {studentName[index]}. What would you like to know about {firstName}? (enter \"favorite food\" or \"previous title\") => ");
				string factChoice = Console.ReadLine();
				while (!(String.Equals(factChoice, "favorite food") || String.Equals(factChoice, "previous title")))
				{
					Console.Write("\nThat data does not exist.  Please try again. (enter \"favorite food\" or \"previous title\") => ");
					factChoice = Console.ReadLine();
				}

				//Displays the info about the student that was requested
				bool food = true;
				if (String.Equals(factChoice, "favorite food"))
				{
					Console.WriteLine($"\n{firstName}'s favorite food is {studentFood[index]}.");
					food = true;
				}
				else if (String.Equals(factChoice, "previous title"))
				{
					Console.WriteLine($"\n{firstName}'s previous title is {studentPrevTitle[index]}.");
					food = false;
				}

				Console.Write($"\nWould you like to know more about {firstName}? (yes or no) => ");
				string learnMore = Console.ReadLine().ToLower();
				while (!(learnMore == "yes" || learnMore == "no"))
				{
					Console.Write("\nInvalid input.  Please enter \"yes\" or \"no\" =>");
					learnMore = Console.ReadLine().ToLower();
				}
				if (learnMore == "yes" && food)
				{
					Console.WriteLine($"\n{firstName} also held the previous title of {studentPrevTitle[index]}.");
				}
				else if (learnMore == "yes" && !food)
				{
					Console.WriteLine($"\n{firstName} also likes the food {studentFood[index]}.");
				}

				Console.Write("\nWould you like to know about another student? (yes or no) => ");
				string keepGoing = Console.ReadLine().ToLower();
				while (!(keepGoing == "yes" || keepGoing == "no"))
				{
					Console.Write("\nInvalid input.  Please enter \"yes\" or \"no\" =>");
					keepGoing = Console.ReadLine().ToLower();
				}
				if(keepGoing == "no")
				{
					Console.Clear();
					break;
				}
				else
				{
					Console.Clear();
				}
			}

			//Asks the user if they want a list of all the students
			Console.Write("Would you like to see a list of all the students? (yes or no) => ");
			string allStudents = Console.ReadLine().ToLower();
			while (!(allStudents == "yes" || allStudents == "no"))
			{
				Console.Write("\nInvalid input.  Please enter \"yes\" or \"no\" => ");
				allStudents = Console.ReadLine().ToLower();
			}
			if (allStudents == "yes")
			{
				Console.WriteLine();
				//runs through a loop to display all info about all the students
				for(int x = 0; x < 14; x++)
				{
					Console.WriteLine($"Student {x + 1} is {studentName[x]} with the prvious title of {studentPrevTitle[x]} and their favorite food is {studentFood[x]}.");
				}
			}
		}
	}
}
