using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	/*void Hello()
	{
		Console.WriteLine("Hello");
	}---->Error нельзя так писать(метод за классом)*/
	class Fraction
	{
		int integer;
		int numerator;
		int denominator;
		public int Integer
		{
			get
			{
				return integer;
			}
			set
			{
				integer = value;
			}
		}
		public int Numerator
		{
			get => numerator;
			set => numerator = value;
		}
		public int Denominator
		{
			//value == 0 ? denominator = 1 : denominator = value;
			get => denominator;
			set => denominator = (value == 0 ? 1 : value);
		}
		public override string ToString()
		{
			
			string fraction = "0";
			if (numerator != 0)
			{
				fraction = $"{numerator}/{denominator}";
				
			}
			if (integer != 0)
			{
				fraction = $"{integer}" + $"({fraction})";
				//fraction = fraction.Insert(0,Integer.ToString()+$"({fraction})");
				//fraction = fraction.Substring(0, fraction.Length - (Denominator.ToString().Length+Numerator.ToString().Length+1));
				
				
			}
			return fraction;
		}
		//Constructors
		public Fraction()
		{
			Integer = 0;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("DefConstructor:\t" + this.GetHashCode());
		}
		public Fraction(int integer)
		{
			Integer = integer;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("Constructor1:\t"+this.GetHashCode());
		}
		public Fraction(int numerator,int denominator)
		{
			Integer = 0;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Constructor2:\t" + this.GetHashCode());
		}
		public Fraction(int integer,int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Constructor3:\t" + this.GetHashCode());
		}
		~Fraction()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		//operators
		public Fraction ToProper()
		{
			Integer+=numerator / denominator;
			Numerator %= denominator;
			return this;
		}
		public Fraction ToImProper()
		{
			Numerator += Integer * Denominator;
			Integer = 0;
			return this;
		}
		//operators uno & bin
		public static Fraction operator*(Fraction left,Fraction right)
		{
			left.ToImProper();right.ToImProper();

			return new Fraction(left.Numerator*right.Numerator,left.Denominator*right.Denominator).ToProper();
		}
		public static Fraction operator/(Fraction left,Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator).ToProper();
		}
		public static Fraction operator+(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return new Fraction((left.Numerator * right.Denominator) + (right.Numerator * left.Denominator), left.Denominator * right.Denominator).ToProper();
		}
		public static Fraction operator-(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return new Fraction((left.Numerator * right.Denominator) - (right.Numerator * left.Denominator), left.Denominator * right.Denominator).ToProper();
		}
		public static Fraction operator--(Fraction here)
		{
			here.ToImProper();
			return new Fraction(here.Numerator-here.Denominator,here.Denominator).ToProper();
		}
		public static Fraction operator ++(Fraction here)
		{
			here.ToImProper();
			return new Fraction(here.Numerator + here.Denominator, here.Denominator).ToProper();
		}
		public static bool operator>(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return ((left.Numerator * right.Denominator) > (right.Numerator * left.Denominator));
		}
		public static bool operator <(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return ((left.Numerator * right.Denominator) < (right.Numerator * left.Denominator));
		}
		public static bool operator ==(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return ((left.Numerator * right.Denominator) == (right.Numerator * left.Denominator));
		}
		public static bool operator !=(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return ((left.Numerator * right.Denominator) != (right.Numerator * left.Denominator));
		}
		public static bool operator >=(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return ((left.Numerator * right.Denominator) >= (right.Numerator * left.Denominator));
		}
		public static bool operator <=(Fraction left, Fraction right)
		{
			left.ToImProper(); right.ToImProper();
			return ((left.Numerator * right.Denominator) <= (right.Numerator * left.Denominator));
		}
		public static implicit operator int(Fraction obj)
		{
			obj.ToProper();
			return obj.Integer;
		}
		public static implicit operator double(Fraction obj)
		{
			obj.ToProper();

			return ((double)obj.Integer+((double)obj.Numerator/(double)obj.Denominator));
		}
		public static bool operator true(Fraction obj)=> obj.Integer!=0 || obj.Numerator!=0;
		public static bool operator false(Fraction obj) => obj.Integer == 0;
		public static bool operator true(int obj) => obj != 0;
		public static bool operator false(int obj) => obj == 0;

	}
}
