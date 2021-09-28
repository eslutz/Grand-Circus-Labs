using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._1.Test
{
	public class Prime_Numbers_Test
	{
		[Theory]
		[InlineData(1, 2)]
		[InlineData(2, 3)]
		[InlineData(3, 5)]
		[InlineData(4, 7)]
		[InlineData(5, 11)]
		[InlineData(6, 13)]
		[InlineData(7, 17)]
		[InlineData(8, 19)]
		[InlineData(9, 23)]
		[InlineData(10, 29)]
		[InlineData(45, 197)]
		public void TestThePrimes(int nthPrime, int expected)
		{
			int result = Prime_Numbers.GetPrime(nthPrime);

			Assert.Equal(expected, result);
		}

		//[Fact]
		//public void Test1()
		//{
		//	Prime_Numbers prime = new Prime_Numbers();
		//	int result = prime.GetPrime(1);

		//	Assert.Equal(2, result);
		//}
	}
}
