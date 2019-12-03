using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeObj
{
	class Program
	{
		static void Main(string[] args)
		{
			#region DataType
			/*Object obj = 1;
			Console.WriteLine(obj.GetType());
			bool bvar = false;
			Console.WriteLine(bvar.GetType());
			//or
			System.Boolean bvar2 = true;
			Console.WriteLine(bvar2.GetType());
			sbyte b;
			Console.WriteLine("Char Max: " + Convert.ToInt32(char.MaxValue) + "\tmin: " + Convert.ToInt32(char.MinValue));//чар содержит 1 символ в кодировке юникод(UTF-16) и потому занимает 2 байта. 
			Console.WriteLine("Byte Max: " + byte.MaxValue + "\tmin: " + byte.MinValue);
			Console.WriteLine("sByteMax: " + sbyte.MaxValue + "\tmin: " + sbyte.MinValue);
			Console.WriteLine("shortMax: " + short.MaxValue + "\tmin: " + short.MinValue);
			Console.WriteLine("ushortMax: " + ushort.MaxValue + "\tmin: " + ushort.MinValue);
			Console.WriteLine("intMax: " + int.MaxValue + "\tmin: " + int.MinValue);
			Console.WriteLine("uintMax: " + uint.MaxValue + "\tmin: " + uint.MinValue);
			Console.WriteLine("longMax: " + long.MaxValue + "\tmin: " + long.MinValue);
			Console.WriteLine("ulongMax: " + ulong.MaxValue + "\tmin: " + ulong.MinValue);
			Console.WriteLine("floatMax: " + float.MaxValue + "\tmin: " + float.MinValue);
			Console.WriteLine("doubleMax: " + double.MaxValue + "\tmin: " + double.MinValue);
			Console.WriteLine("decimalMax: " + decimal.MaxValue + "\tmin: " + decimal.MinValue);
			/*Преобразование типов:
			 Также как и в языке С++ существует явное и не явное преобразование типов. Также существует преобразование от меньшего к большему и наоборот. Последнее может привести к потере данных и поэтому неявно компилятор их не выполняет. Неявные преобразования возможны только от меньшего к большему и то не всегда.
			 При необходимости всегда можно сделать явное преобразование. Явное преобразование можно делать указывая желанный тип данных в -> () или же при помощи класса Convert.
			 */
			//byte b = 123;
			//Console.WriteLine("Enter num: ");
			//double num = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine($"You enter this num: {num}");
			#endregion
			#region calc
			try
			{
				Console.WriteLine("Введите выражение: ");
				string exception = Console.ReadLine();
				exception = exception.Replace('.', ',');
				Console.WriteLine(exception);
				double a = Convert.ToDouble(exception.Split("+-*/".ToCharArray())[0]);
				double b = Convert.ToDouble(exception.Split("+-*/".ToCharArray())[1]);
				//Console.WriteLine(a);
				//Console.WriteLine(b);
				//Console.WriteLine(exception + '=' + (a + b));
				#region CalcByif
				//if (exception.Contains('+'))
				//{
				//	Console.WriteLine($"{exception}={a + b}");//интерполяция строк
				//}
				//else if (exception.Contains('-'))
				//{
				//	Console.WriteLine($"{exception}={a - b}");//интерполяция строк
				//}
				//else if (exception.Contains('*'))
				//{
				//	Console.WriteLine($"{exception}={a * b}");//интерполяция строк
				//}
				//else if (exception.Contains('/'))
				//{
				//	Console.WriteLine($"{exception}={a / b}");//интерполяция строк
				//}
				//else
				//{
				//	Console.Error("Такого не предусмотрено!");
				//} 
				#endregion

				switch (exception[exception.IndexOfAny(("+-*/").ToCharArray())])//метод который возвращает индекс какогото значения . в суме возвращает символ
				{
					case '+': Console.WriteLine($"{exception}={a + b}"); break;
					case '-': Console.WriteLine($"{exception}={a - b}"); break;
					case '*': Console.WriteLine($"{exception}={a * b}"); break;
					case '/': Console.WriteLine($"{exception}={a / b}"); break;
					default: Console.WriteLine("Error.Не предусмотрено!"); break;
				}
			}
			catch (FormatException e)
			{
				//Console.WriteLine(e.Message);для простого Exception
				Console.WriteLine("Error: Ты не прав! Это всего лишь калькулятор на C#");
				Console.WriteLine(e.GetType());
				
			}
			#endregion
		}
	}
}
