using System;
using System.Collections.Generic;
using System.Text;

namespace Week_4_Exercises
{
	class Point
	{
		private int x;
		private int y;

		public int X
		{
			get { return x;  }
			set { x = value; }
		}

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public double CalculateDistance()
		{
			double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
			return distance;
		}

		public Point CalculateMidpoint(Point point2)
		{
			int midX = (this.X + point2.X) / 2;
			int midY = (this.Y + point2.Y) / 2;
			Point midPoint = new Point(midX, midY);

			return midPoint;
		}
	}
}
