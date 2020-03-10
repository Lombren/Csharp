using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Engine
	{
		uint power;
		double consumption;
		//double consumprionPerSecond;
		//bool started;
		public uint Power
		{
			get => power;
			set
			{
				power=value>=50&&value<=1000?value: throw new Exception("Error: Bad Engine power");
			}
		}
		public double Consumption
		{
			get => consumption;
			private set=>consumption=value;
		}
		public double ConsumptionPerSecond { get; set; }
		public bool Started { get; set; }

		public Engine(uint power)
		{
			Power = power;
			consumption = 0.0002 * (Power / 15);
			ConsumptionPerSecond = Consumption / 100;
			Started = false;
		}
		public override string ToString()
		{
			return $"Power: {Power} HP, Consumption: {Consumption*3600} litr per 100km,ConsumptionPerSecond: {ConsumptionPerSecond} l/s, Engine status: {(Started? "started":"stopped")}";
		}


	}
}
