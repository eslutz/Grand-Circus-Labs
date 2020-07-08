using System;
using System.Text.RegularExpressions;

namespace Lab_2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//validates name only has alphabets, starts with a capital, does not exceed 30
			//after first letter, characters can be upper or lower case
			Regex nameReg = new Regex(@"^[A-Z][A-Za-z]{0,30}$");
			Console.WriteLine("Please enter a valid name:");
			string name = Console.ReadLine();
			bool nameValid = nameReg.IsMatch(name);
			if (nameValid)
			{
				Console.WriteLine("Name is valid!");
			}
			else
			{
				Console.WriteLine("Sorry, the name is not valid!");
			}

			//validates email follows the format of:
			//{5-30 alphanumeric characters w/ no special characters}
			//@{5-10 alphanumeric characters w/ no special characters}
			//.{2-3 alphanumeric characters}
			Regex emailReg = new Regex(@"^\w{5,30}@\w{5,10}.\w{2,3}$");
			Console.WriteLine("\nPlease enter a valid email:");
			string email = Console.ReadLine();
			bool emailValid = emailReg.IsMatch(email);
			if (emailValid)
			{
				Console.WriteLine("Email is valid!");
			}
			else
			{
				Console.WriteLine("Sorry, the email is not valid!");
			}

			//validates phone number format of:
			//313-555-1212
			//313.555.1212
			//(313)-555-1212
			Regex phoneNumberReg = new Regex(@"^[(]{0,1}\d{3}[)]{0,1}[-.]\d{3}[-.]\d{4}$");
			Console.WriteLine("\nPlease enter a valid phone number:");
			string phoneNumber = Console.ReadLine();
			bool phoneNumberValid = phoneNumberReg.IsMatch(phoneNumber);
			if (phoneNumberValid)
			{
				Console.WriteLine("Phone number is valid!");
			}
			else
			{
				Console.WriteLine("Sorry, the phone number is not valid!");
			}

			//validates month with dates 1-31 and months 1-12 of format:
			//dd/mm/yyy
			//d/m/yyyy
			Regex dateReg = new Regex(@"^([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])/([1-9]|0[1-9]|1[0-2])/\d{4}$");
			Console.WriteLine("\nPlease enter a valid date:");
			string date = Console.ReadLine();
			bool dateValid = dateReg.IsMatch(date);
			if (dateValid)
			{
				Console.WriteLine("Date is valid!");
			}
			else
			{
				Console.WriteLine("Sorry, the date is not valid!");
			}

			//validates HTML elements
			Regex htmlReg = new Regex("^<.*>.*</.*>$");
			Console.WriteLine("\nPlease enter a valid HTML element:");
			string html = Console.ReadLine();
			bool htmlValid = htmlReg.IsMatch(html);
			if (htmlValid)
			{
				Console.WriteLine("HTML elements are valid!");
			}
			else
			{
				Console.WriteLine("Sorry, the HTML elements are not valid!");
			}
		}
	}
}
