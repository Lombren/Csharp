using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Tank
	{
		uint volume;
		double fuel;
		public uint Volum
		{
			get=>volume;
			private set => volume = value >= 40 && value <= 120 ? value : throw new Exception("Error: Bad tank volum");
		}
		public double Fuel
		{
			get => fuel;
			set
			{
				fuel = value;
				if (fuel < 0) fuel = 0;
				if (fuel > Volum) fuel = Volum;
			}
		}
		public Tank(uint volum)
		{
			Volum = volum;
			Fuel = fuel;

		}
		public void Fill(double fuel)
		{
			Fuel += fuel;
		}
		public override string ToString()
		{
			return $"Tank volume: {Volum};\nFuel level: {Fuel};";
		}

	}
}
