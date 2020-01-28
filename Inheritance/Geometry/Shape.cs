using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	abstract class Shape
	{
		string color;
		public string Color
		{
			get => color;
			set => color = value;
		}
		public abstract void get_Area();
		public abstract void get_Perimetr();
	}
}
