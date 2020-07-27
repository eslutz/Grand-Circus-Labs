using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Week_5_Exercises
{
	class Validator
	{
		public bool IsInt(string input)
		{
			if (int.TryParse(input, out int idontcare))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool IsInt(string input, int min, int max)
		{
			if (int.TryParse(input, out int idontcare) && (idontcare > min && idontcare < max))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public YesNoResponse IsYesNo(string input)
		{
			if(input.ToLower() == "y")
			{
				return YesNoResponse.Yes;
			}
			else if(input.ToLower() == "n")
			{
				return YesNoResponse.No;
			}
			else
			{
				return YesNoResponse.Not_Recognized;
			}
		}

		public int SquareRoot(int number)
		{
			if (number == 0 || number == 1)
				return number;

			// Staring from 1, try all 
			// numbers until i*i is  
			// greater than or equal to x. 
			int i = 1, result = 1;

			while (result <= number)
			{
				i++;
				result = i * i;
			}
			return i - 1;
		}

	}

	enum YesNoResponse
	{
		Yes,
		No,
		Not_Recognized
	}
}
