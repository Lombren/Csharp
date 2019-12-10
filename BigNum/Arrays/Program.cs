using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void FillRand(int[][] arr)
		{
			Random rand = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					arr[i][j] = rand.Next(10, 20);
				}
			}
		}
		static void Main(string[] args)
		{
			#region SimpleArray
			//Console.Write("Enter the Array [size]: ");
			///*int size = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new int[size];*/
			//int[] arr = { 3, 5, 8, 13, 21 };


			////Random rand = new Random();
			///*for(int i = 0; i < arr.Length; i++)
			//{
			//	arr[i] = rand.Next(100, 200);
			//}
			///*for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}*/
			//foreach (int i in arr)
			//{
			//	Console.WriteLine(i + "\t");
			//Console.WriteLine();
			//} 
			#endregion
			#region multiArray
			////type[,] name = new type[rows, cols];
			////name[i, j];
			//Console.Write("Enter rows num: ");
			//const int ROWS = 3;//Convert.ToInt32(Console.ReadLine());
			//Console.Write("Enter cols num: \n");
			//const int COLS = 3;//Convert.ToInt32(Console.ReadLine());

			//int[,] arr = new int[ROWS, COLS]
			//{
			//	{ 3,5,8},
			//	{ 13,21,34},
			//	{ 55,89,144}
			//};
			////foreach(int i in arr)
			////{
			////	Console.Write(i + "\t");
			////}
			////Console.WriteLine();
			////Console.Write(arr.Rank);
			////Console.WriteLine(arr.Length);

			////for(int i=0;i<ROWS;i++)
			////{
			////	for(int j = 0; j < COLS; j++)
			////	{
			////		Console.Write(arr[i, j] + "\t");
			////	}
			////	Console.WriteLine();
			////}
			//for (int i = 0; i < arr.GetLength(0); i++)
			//{
			//	for (int j = 0; j < arr.GetLength(1); j++)
			//	{
			//		Console.Write(arr[i, j] + "\t");
			//	}
			//	Console.WriteLine();
			//} 
			#endregion
			Console.Write("Enter rows num: ");
			int rows =Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter cols num: ");
			int cols =Convert.ToInt32(Console.ReadLine());

			int[][] arr = new int[][]
				{
					new int[]{3,5,8,13 },
					new int[]{34,55,89 },
					new int[]{144,233,377,610 }
				};
			//Program for_rand = new Program();
			//for_rand.FillRand(arr);
			//for(int i=0;i<arr.Length;i++)
			//{
			//	arr[i] = new int[cols];
			//}
			FillRand(arr);
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
