using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigNum
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Console.Write("Enter the value: ");
			try
			{
				
				BigInteger n = Convert.ToUInt32(Console.ReadLine());
			

			
			BigInteger f = 1;
			for(ulong i = 1; i <= n; i++)
			{
				f *= i;
				//Console.WriteLine($"{i}!={f}");
			}
			Console.WriteLine($"{n}!={f}");
			}
			catch
			{
				Console.WriteLine("Введите числовое значение в десятичной системе исчисления!");
			}
		}
	}
}
