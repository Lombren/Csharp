using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the Array [size]: ");
			/*int size = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[size];*/
			int[] arr = { 3, 5, 8, 13, 21 };

			
			//Random rand = new Random();
			/*for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100, 200);
			}
			/*for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}*/ 
			foreach (int i in arr)
			{
				Console.WriteLine(i + '\t');
			}
			Console.WriteLine();
		}
	}
}
