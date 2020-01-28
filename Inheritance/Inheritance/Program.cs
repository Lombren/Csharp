using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Human One = new Human("Adam", "Mazdam", 33);
			Console.WriteLine(One);
			Console.WriteLine("==========================================");
			Student Two = new Student("Вася", "Куст", 23, 80, "STPV34v", 4);
			Console.WriteLine(Two);
			Console.WriteLine("==========================================");
			Teacher Three = new Teacher("Antonio", "Fruit", 50, 1000, "C#");
			Console.WriteLine(Three);
			Console.WriteLine("==========================================");
			Graduate Four = new Graduate("Вася", "Куст", 23, 80, "STPV34v", 4, "Массовое подвальное производство метамфетамина, используя рабский детский труд.");

			Console.WriteLine(Four);
			
			Console.WriteLine("==================foreach=================");
			Human[] Group = { One, Two, Three, Four };
			foreach (Human i in Group)
			{
				Console.WriteLine($"{i}");
				Console.WriteLine("==========================================");
			}
			Console.WriteLine("==================foreachEnd==============");
		}
	}
}
