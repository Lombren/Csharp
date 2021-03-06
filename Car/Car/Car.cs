﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Car
{
	class Car
	{
		Engine engine;
		Tank tank;
		uint speed;
		uint max_speed;
		public Engine Engine { get=>engine; private set => engine=value; }
		public Tank Tank { get=>tank; private set=>tank = value; }
		public uint Speed { get => speed; set => speed = value < max_speed ? value : max_speed; }
		public uint MaxSpeed { get => max_speed; private set => max_speed = value <= 420 ? value : throw new Exception("Error: You violated the laws of physics 0_0"); }
		public bool DriverInside { get; set; }
		public Control Control { get; set; }
		
		public Car(Engine engine,Tank tank)
		{
			Engine = engine;
			Tank = tank;
			if (Engine.Power >= 50 && Engine.Power <= 200)
			{
				MaxSpeed = Engine.Power * 14 / 10;
			}
			else if (Engine.Power > 200 && Engine.Power <= 300)
			{
				MaxSpeed = Engine.Power * 13 / 10;
			}
			else if (Engine.Power > 300 && Engine.Power <= 500)
			{
				MaxSpeed = Engine.Power * 8 / 10;
			}
			else
			{
				MaxSpeed = Engine.Power * 4 / 10;
			}
			Control = new Control();
		}
		public void Panel()
		{
			while (DriverInside)
			{
				Console.Clear();
				Console.WriteLine($"Engine is {(engine.Started ? "started" : "stopped")}");
				Console.WriteLine($"Fuel level: {tank.Fuel}.");
				if (tank.Fuel < 5)
				{
					ConsoleColor defaultColor = Console.ForegroundColor;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Alert: Low Fuel!");
					Console.ForegroundColor = defaultColor;
				}

				Thread.Sleep(1000);
			}
		}
		public void Fill(double amount)
		{
			tank.Fill(amount);
		}
		public void GetIn()
		{
			DriverInside = true;
			Control.tControlPanelThred = new Thread(Panel);
			Control.tControlPanelThred.Start();
		}
		public void GetOut()
		{
			DriverInside = false;
			Control.tControlPanelThred.Join();
		}
		public void Start()
		{
			if (tank.Fuel > 0)
			{
				engine.Started = true;
			Control.tEngineIdleThread = new Thread(EngineIdle);
				Control.tEngineIdleThread.Start();
			}
			else
			{
				Console.WriteLine("Alert: No Fuel ! ");
			}
			//return engine.Started;
		}
		public void Stop()
		{
			engine.Started = false;
			if(Control.tEngineIdleThread!=null)Control.tEngineIdleThread.Join();
		}
		public void EngineIdle()
		{
			while (engine.Started && Tank.Fuel>0)
			{
				tank.Fuel -= engine.ConsumptionPerSecond;
				Thread.Sleep(1000);
			}
		}
		public override string ToString()
		{
			return $"Engine {Engine.ToString()}\n{Tank.ToString()}\nMaxSpeed: {MaxSpeed} km/h";
		}
	}
}
