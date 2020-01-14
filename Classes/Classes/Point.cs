using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Point
	{
		double x;
		double y;
		public double getX()
		{
			return x;
		}
		public double getY()
		{
			return y;
		}

		public void setX(double x)
		{
			this.x = x;
		}
		public void setY(double y)
		{
			this.y = y;
		}
		//properties
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				if (value>=0&&value<1000)
				{
					this.x = value; 
				}
				else
				{
					this.x = 0;
				}
			}
		}
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				if (value >= 0 && value < 1000)
				{
					this.y = value;
				}
				else
				{
					this.y = 0;
				}
			}
		}
		public Point(double x=0,double y=0)
		{
			X = x;
			Y = y;
			Console.WriteLine("Constructor");
		}
		public Point(Point other)
		{
			this.x = other.x;
			this.y = other.y;
			Console.WriteLine("CopyConstructor");
		}
		//Operators
		public static Point operator +(Point left, Point right) {
			//Point result = new Point(left.X + right.X,left.Y + right.Y);
			//result.X = left.X + right.X;
			//result.Y = left.Y + right.Y;
			//return result;
			return new Point(left.X + right.X, left.Y + right.Y);
		}

		public override string ToString()
		{
			return $"x = {x}\ty = {y}";
		}
	}
}
