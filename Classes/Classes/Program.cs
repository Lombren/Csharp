using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			Point A=new Point(5,2);
			//A.setX(2);
			//A.setY(3);
			//Console.WriteLine(A);
			//A.X = 123;
			//A.Y = 456;
			Console.WriteLine(A);

			Point B = new Point(A);
			Console.WriteLine(B);

			Point C = new Point();
			C = A + B;
			Console.WriteLine(C);
		}
	}
}
