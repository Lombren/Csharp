using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Teacher: Human
	{
		uint exp;
		string subject;
		public uint Exp
		{
			get => exp;
			set => exp = value;
		}
		public string Subject
		{
			get => subject;
			set => subject = value;
		}
		public Teacher(string firstname,string lastname,uint age,uint exp,string subject):base(firstname,lastname,age)
		{
			Exp = exp;
			Subject = subject;
			Console.WriteLine("TeacherConstructor:\t" + this.GetHashCode());
		}
		~Teacher()
		{
			Console.WriteLine("TeacherDestructor:\t" + this.GetHashCode());
		}
		public override string ToString()
		{
			return base.ToString()+$"\nExp: {exp}, Sub.: {subject}";
		}
	}
}
