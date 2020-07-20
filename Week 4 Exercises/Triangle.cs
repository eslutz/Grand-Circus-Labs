using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Week_4_Exercises
{
	class Triangle
	{
		private int side1Length, side2Length, side3Length;

		public int Side1Length
		{
			get { return side1Length; }
			set { side1Length = value; }
		}

		public int Side2Length
		{
			get { return side2Length; }
			set { side2Length = value; }
		}

		public int Side3Length
		{
			get { return side3Length; }
			set { side3Length = value; }
		}

		public Triangle(int side1Length, int side2Length, int side3Length)
		{
			this.side1Length = side1Length;
			this.side2Length = side2Length;
			this.side3Length = side3Length;
		}

		public double CaclulateArea()
		{
			double s = CalculatePerimeter() / 2;
			return Math.Sqrt(s * (s - Side1Length) * (s - Side2Length) * (s - Side3Length));
		}

		public double CalculatePerimeter()
		{
			return Side1Length + Side2Length + Side3Length;
		}
	}
}
