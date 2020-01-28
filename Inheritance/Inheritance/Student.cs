using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Student : Human
	{
		int rating;
		string group;
		uint cource;
		public int Rating
		{
			get => rating;
			set => rating = value;
		}
		public string Group
		{
			get => group;
			set => group = value;
		}
		public uint Cource
		{
			get => cource;
			set => cource = value;
		}
		public Student(string firstname, string lastname, uint age,int rating,string group,uint cource) :base(firstname,lastname,age)
		{
			Rating = rating;
			Group = group;
			Cource = cource;
			Console.WriteLine("StudentConstructor:\t" + this.GetHashCode());
		}
		~Student()
		{
			Console.WriteLine("StudentDestructor:\t" + this.GetHashCode());
		}
		//public override string ToString()
		//{

		//	string info = $"\nRating: {Rating}, Cource: {Cource}, Group: {Group}";
		//	return info;
		//}
		public override string ToString()
		{
			return base.ToString()+ $"\nRating: {Rating}, Cource: {Cource}, Group: {Group}";
		}
	}
}
