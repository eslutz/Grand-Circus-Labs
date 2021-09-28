using System;
using System.Collections.Generic;
using System.Text;

namespace Week_4_Exercises
{
	class Square
	{
		private int sideLength;

		public int SideLength
		{
			get { return sideLength; }
			set { sideLength = value; }
		}

		public Square(int sideLength)
		{
			this.sideLength = sideLength;
		}

		public double CalculatePerimeter()
		{
			return SideLength * 4;
		}

		public double CalculateArea()
		{
			return Math.Pow(SideLength, 2);
		}
	}
}
