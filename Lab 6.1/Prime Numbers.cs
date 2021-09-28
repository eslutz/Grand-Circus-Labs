using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6._1
{
	public static class Prime_Numbers
	{
		public static int GetPrime(int n)
		{
			int num = 1;
			int count = 0;
			//loops through looking for prime numbers until the counter matches the requested number
			while (count != n)
			{
				num++;
				if (isPrime(num))
				{
					count++;
				}
			}
			return num;
		}

		//Checks if a number is a prime number
		private static bool isPrime(int num)
		{
			for (int i = 2; i < num; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}