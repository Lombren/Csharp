using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Graduate:Student
	{
		string diploma_theme;
		public string Diplom
		{
			get => diploma_theme;
			set => diploma_theme = value;
		}
		public Graduate(string firstname,string lastname,uint age,int rating,string group,uint cource,string diploma_theme) : base(firstname, lastname, age, rating, group, cource)
		{
			Diplom = diploma_theme;
			Console.WriteLine("GraduateConstructor:\t" + this.GetHashCode());
		}
		~Graduate()
		{
			Console.WriteLine("GraduateDestructor:\t" + this.GetHashCode());
		}
		public override string ToString()
		{
			return base.ToString() + $"\nDiplom: {diploma_theme}";
		}
	}
}
