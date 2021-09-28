using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._2.Test
{
	public class ValidatorTest
	{
		[Theory]
		[InlineData("Yes", YesNo.Yes)]
		[InlineData("Y", YesNo.Yes)]
		[InlineData("yes", YesNo.Yes)]
		[InlineData("y", YesNo.Yes)]
		[InlineData("No", YesNo.No)]
		[InlineData("N", YesNo.No)]
		[InlineData("no", YesNo.No)]
		[InlineData("n", YesNo.No)]
		public void YesNoTest1(string input, YesNo expected)
		{
			Assert.True(Validator.YesOrNo(input, out YesNo test));
			Assert.Equal(expected, test);
		}

		[Fact]
		public void YesNoTest2()
		{
			Assert.False(Validator.YesOrNo("asdfjhjk73&", out YesNo test));
			Assert.Equal(YesNo.NotValid, test);
		}
	}
}
