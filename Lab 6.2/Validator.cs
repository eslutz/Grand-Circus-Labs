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
