using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._2.Test
{
	public class ValidatorTest
	{
		[Fact]
		public void YesNoTest1()
		{
			Assert.True(Validator.YesOrNo("Yes", out YesNo test));
			Assert.Equal(YesNo.Yes, test);
		}

		[Fact]
		public void YesNoTest2()
		{
			Assert.True(Validator.YesOrNo("yes", out YesNo test));
			Assert.Equal(YesNo.Yes, test);
		}

		[Fact]
		public void YesNoTest3()
		{
			Assert.True(Validator.YesOrNo("Y", out YesNo test));
			Assert.Equal(YesNo.Yes, test);
		}

		[Fact]
		public void YesNoTest4()
		{
			Assert.True(Validator.YesOrNo("y", out YesNo test));
			Assert.Equal(YesNo.Yes, test);
		}

		[Fact]
		public void YesNoTest5()
		{
			Assert.True(Validator.YesOrNo("No", out YesNo test));
			Assert.Equal(YesNo.No, test);
		}

		[Fact]
		public void YesNoTest6()
		{
			Assert.True(Validator.YesOrNo("no", out YesNo test));
			Assert.Equal(YesNo.No, test);
		}

		[Fact]
		public void YesNoTest7()
		{
			Assert.True(Validator.YesOrNo("N", out YesNo test));
			Assert.Equal(YesNo.No, test);
		}

		[Fact]
		public void YesNoTest8()
		{
			Assert.True(Validator.YesOrNo("n", out YesNo test));
			Assert.Equal(YesNo.No, test);
		}

		[Fact]
		public void YesNoTest9()
		{
			Assert.False(Validator.YesOrNo("asdfjhjk73&", out YesNo test));
			Assert.Equal(YesNo.NotValid, test);
		}
	}
}
