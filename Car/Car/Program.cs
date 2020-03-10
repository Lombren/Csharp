using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Program
	{
		static void Main(string[] args)
		{
			//Tank tank = new Tank(40);
			//tank.Fill(10);
			//tank.Fill(20);
			//Console.WriteLine(tank);
			//Engine engine = new Engine(200);
			//Console.WriteLine(engine);

			Car Car = new Car(new Engine(250),new Tank(40));
			Console.WriteLine(Car);

			Console.WriteLine("Your car is ready, press Enter to get in");
			Console.ReadKey();
			Car.GetIn();

			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.Enter:
						if (!Car.Engine.Started) Car.Start();
						else Car.Stop();
						break;
					case ConsoleKey.Escape:
						Car.Stop();
						Car.GetOut();
						break;
					case ConsoleKey.F:
						Car.Control.tControlPanelThred.Suspend();
						Console.WriteLine("How much?");
						Car.Fill(Convert.ToDouble(Console.ReadLine()));
						Car.Control.tControlPanelThred.Resume();
						break;
				}
			}while(key!=ConsoleKey.Escape) ;


		}
	}
}
