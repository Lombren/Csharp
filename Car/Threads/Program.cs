using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread thread0 = new Thread(Print0);
			Thread thread1 = new Thread(Print1);//нужнозапускать потоки
			thread0.Start();
			thread1.Start();
			thread0.Join();
			thread1.Join();
		}
		public static void Print0()
		{
			for (int i = 0; i < 1000; i++)
			{
				Console.Write(0);
				Thread.Sleep(100);
			}
		}
		public static void Print1()
		{
			for (int i = 0; i < 1000; i++)
			{
				Console.Write(1);
				Thread.Sleep(100);

			}
		}

	}
}
