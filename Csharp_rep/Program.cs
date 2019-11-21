//Подключается пространство имен
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//Каждое приложение должно быть в своем именном пространстве 
namespace Csharp_rep
{
    class Program
    {
        static void Main(string[] args)
        {
			System.Console.ForegroundColor = System.ConsoleColor.Green;
			System.Console.Title="C# Developing";
			System.Console.WindowHeight = 10;
			System.Console.WindowWidth=50;
			System.Console.BufferWidth=50;
			System.Console.BufferHeight=10;
			System.Console.CursorVisible = false;//невидимый курсор

			//System.Console.WriteLine("Hello");
			#region strings
			/*System.Console.Write("\t\t\t\t\t\tHello world\n");
				System.Console.WriteLine("Сам привет^^");
				string name;
				string age;
				System.Console.Write("Write your name: ");
				name = System.Console.ReadLine();
				System.Console.Write("How old are you? ");
				age = System.Console.ReadLine();
				//конкатенация
				System.Console.WriteLine("Hello " + name + " you're " + age + " years old.");
				//форматирование строк
				System.Console.WriteLine("Hello {0}, you are {1} years old",name,age);
				//интерполяция строк
				System.Console.WriteLine($"Hello {name}, you are {age} years old");
				System.Console.WriteLine("C:\\Windows\\System32\\...");
				//дословная строка veratim string
				System.Console.WriteLine(@"C:\Windows\System32\...");*/
			//System.Console.WriteLine(/*"Hello"*/); 
			#endregion
			//System.Console.Clear();//чистит экран

			

		}
	}
}
