using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6._2
{
	public enum YesNo
	{
		Yes,
		No,
		NotValid
	}

	public static class Validator
	{
		//Validates that the user input is either yes or no.
		//Returns true if it is and false if it isn't.
		//Also outputs a YesNo enum value.
		public static bool YesOrNo(string input, out YesNo output)
		{
			input = input.ToLower();
			if (input == "yes" || input == "y")
			{
				output = YesNo.Yes;
				return true;
			}
			else if(input == "no" || input == "n")
			{
				output = YesNo.No;
				return true;
			}
			else
			{
				output = YesNo.NotValid;
				return false;
			}
		}
	}
}
