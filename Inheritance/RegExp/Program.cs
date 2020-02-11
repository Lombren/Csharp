using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegExp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region CHECK_NAME
			/*Console.WriteLine("Input name: ");
			string name = "Vasya";
			if (Regex.IsMatch(name, "^[A-Z][a-z]{1,20}$"))
			{
				Console.WriteLine(name);
			}
			else
			{
				Console.WriteLine("Error: Bad name");
			}*/
			#endregion
			Console.WriteLine("Input Group: ");
			string delim = "(_|\\s|-)";
			string group = "PS-SB_ITV_34";

			//if (Regex.IsMatch(group, $"^(ST|PS(_| |-)(SB|VS))_(PV|PU|ITV|ITU)_\\d{{2}}[abv]?$"))
			//if (Regex.IsMatch(group, $"^(ST|PS{delim}(SB|VS)){delim}(PV|PU|ITV|ITU){delim}\\d{{2}}[abv]?$"))
			if (Regex.IsMatch(group, $"^(ST|PS{delim}(SB|VS)){delim}(PV|PU|ITV|ITU){delim}\\d{{2}}[abv]?$"))
			{
				Console.WriteLine(group);
			}
			else
			{
				Console.WriteLine("Error: Bad Group");
			}
		}
	}
}
