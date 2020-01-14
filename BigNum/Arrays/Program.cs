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
			#region SimpleArrays
			////jagged Array
			//Console.Write("Введите размер массива: ");
			////int size = Convert.ToInt32(Console.ReadLine());

			////int[] arr = new int[size];
			//int[] arr = { 3, 5, 8, 13, 21 };

			//Random rand = new Random();

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	arr[i] = rand.Next(100, 200);
			//}

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}
			//Console.WriteLine();

			//foreach (int i in arr)//range-based-for C++
			//{
			//	Console.Write(i + "\t");
			//}
			//Console.WriteLine(); 
			#endregion

			//type[,] name = new type[rows, cols];
			//name[i, j];
			int a = 2;
			int b = 3;
			Console.WriteLine(a.CompareTo(b));
			#region MultiArray
			//const int ROWS = 3;
			//const int COLS = 4;

			//int[,] arr = new int[ROWS, COLS]
			//{
			//	{ 2, 3, 5, 8},
			//	{ 13, 21, 34, 35},
			//	{ 55, 89, 144, 155}
			//};

			////foreach (int i in arr)
			////{
			////	Console.Write(i + "\t");
			////}
			////Console.WriteLine();
			////Console.WriteLine(arr.Rank);
			//Console.WriteLine(arr.GetLength(0));
			//Console.WriteLine(arr.GetLength(1));
			//for (int i = 0; i < arr.GetLength(0); i++)
			//{
			//	for (int j = 0; j < arr.GetLength(1); j++)
			//	{
			//		Console.Write(arr[i, j] + "\t");
			//	}
			//	Console.WriteLine();
			//} 
			#endregion

			//Jagged arrays:
			//type[][] arr = new int[rows][]
			//{
			//	new type[size1],
			//	new type[size2],
			//	.......
			//	new type[sizeN]
			//};

			//Console.Write("Введите количество строк: ");			int rows = Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите количество элементов строки: ");	int cols = Convert.ToInt32(Console.ReadLine());

			int[][] arr = new int[][]
			{
				new int[]{ 3, 5, 8, 13, 21 },
				new int[]{ 34, 55, 89 },
				new int[]{ 144, 233, 377, 600 }
			};
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	arr[i] = new int[cols];
			//}

			//Program for_rand = new Program();
			//for_rand.FillRand(arr);

			MyArray<int>.FillRand(arr);
			MyArray<int>.Print(arr);
			MyArray<int>.Sort(arr);
			MyArray<int>.Print(arr);

			double[][] drr = new double[][]
			{
				new double[]{ 2.5, 3.14, 1.8},
				new double[]{ 6.6, 8.3, 1230, 44.4},
				new double[]{ 10.11, 2.2}
			};

			MyArray<double>.Print(drr);
			MyArray<double>.Sort(drr);
			MyArray<double>.Print(drr);

		}
	}

	class MyArray<T> where T:IComparable
	{
		public static void FillRand(int[][] arr)
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

		public static void Print(T[][] arr)
		{
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	for (int j = 0; j < arr[i].Length; j++)
			//	{
			//		Console.Write(arr[i][j] + "\t");
			//	}
			//	Console.WriteLine();
			//}

			foreach (T[] i in arr)
			{
				foreach (T j in i)
				{
					Console.Write(j + "\t");
				}
				Console.WriteLine();
			}
			//Console.Write(i + "\t");
			Console.WriteLine();
		}
		public static void Sort(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i].CompareTo(arr[j]) < 0)
					{
						Exchange(ref arr[i], ref arr[j]);	
					
					}
				}
			}

		}

		public static void Sort(T[][] arr)
		{

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					for (int k = i; k < arr.Length; k++)
					{
						for (int l = k == i ? j + 1 : 0; l < arr[k].Length; l++)
						{
							//if (arr[k][l] < arr[i][j])
							if (arr[k][l].CompareTo(arr[i][j])<0)
							{
								Exchange(ref arr[i][j], ref arr[k][l]);
							}
						}
					}
				}
			}
		}

		static void Exchange(ref T a, ref T b)
		{
			T buffer = a;
			a = b;
			b = buffer;
		}
	}
}