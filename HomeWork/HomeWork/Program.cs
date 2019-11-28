using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What your name? ");
			string name = Console.ReadLine();
			Console.Title = "Player -> " + name;

			Console.WriteLine("Choose your color! ");
			ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
			for(int i=0;i<colors.Length;i++)
			{
				Console.ForegroundColor = colors[i];
				Console.WriteLine(i + "\t" + colors[i]);
			}
			//Console.ForegroundColor = colors[Console.Read()-48];
			Console.ForegroundColor = (ConsoleColor)(Convert.ToInt32(Console.ReadLine())%colors.Length);//преобразуем стринг в инт32 который потом преобразуем в консол колор
			 

			int xSize = 100;
			int ySize = 30;
			int x = 15;
			int y = 15;
			Console.SetWindowSize(xSize, ySize);
			Console.SetBufferSize(xSize, ySize);
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;//true вместо \b
												//Console.Write("\b");//Backspace
												//Console.WriteLine("\t" + key);


				switch (key)
				{
					#region shooter
					//case ConsoleKey.W: Console.WriteLine("Вперед"); break;
					//case ConsoleKey.S: Console.WriteLine("Назад"); break;
					//case ConsoleKey.A: Console.WriteLine("Лево"); break;
					//case ConsoleKey.D: Console.WriteLine("Право"); break;
					//case ConsoleKey.Enter: Console.WriteLine("Огонь"); break;
					//case ConsoleKey.Escape: Console.WriteLine("Выход"); break;
					//default: Console.WriteLine("Error"); break; 

					#endregion

					case ConsoleKey.UpArrow:
					case ConsoleKey.W:if(y>0) y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: if(y<ySize-2)y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: if(x>0)x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: if(x<xSize-2)x++; break;

				}
				Console.Clear();
				Console.SetCursorPosition(x, y);
				Console.WriteLine((char)2);

			} while (key != ConsoleKey.Escape);
		}
	}
}
