using System;

namespace TestForDaTest
{
	public class MyPoint
	{
		private decimal x, y;

		public MyPoint(decimal x, decimal y)
		{
			this.x = x;
			this.y = y;
		}

		public bool isInCircle()
		{
			decimal distanceFromCenter = (decimal) Math.Sqrt((double)(this.x * this.x + this.y * this.y));
		
			return distanceFromCenter <= 0.5m;
		}
	}
}

