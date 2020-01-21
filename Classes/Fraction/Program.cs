//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSTRUCTORS_CHECK
			Fraction A = new Fraction(3, 4123, 50);
			Console.WriteLine(A);
			A.ToImProper();
			Console.WriteLine(A);
			A.ToProper();
			Console.WriteLine(A); 
#endif
			Fraction A = new Fraction( 1, 1, 2);
			Fraction B = new Fraction(2, 1, 2);
			Console.WriteLine(A*B);
			Console.WriteLine(A/B);
			Console.WriteLine(A + B);
			Console.WriteLine(A - B);
			Console.WriteLine("--А == " + --A);
			Console.WriteLine("++А == " + ++A);
			Console.WriteLine("================Bool '<' '>'======================");
			Console.WriteLine(A>B);
			Console.WriteLine(A < B);
			Console.WriteLine("================Bool '==' '!='======================");
			Console.WriteLine(A == B);
			Console.WriteLine(A != B);
			Console.WriteLine("================Bool '>=' '<='======================");
			Console.WriteLine(A >= B);
			Console.WriteLine(A <= B);
			Console.WriteLine(A);
			Console.WriteLine(B);

			int b = A;
			double a = B;
			Console.WriteLine("==================int====================");
			Console.WriteLine(b);
			Console.WriteLine("===================double===================");
			Console.WriteLine(a);
			Console.WriteLine("======================================");
			Fraction n = new Fraction(5);
			while (n--) Console.WriteLine($"{n}");
			
			
		}
	}
}
