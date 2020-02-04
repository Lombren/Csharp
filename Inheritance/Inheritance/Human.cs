using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Human
    {
        string lastname;
        string firstname;
        uint age;

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {

				if (System.Text.RegularExpressions.Regex.IsMatch(value, @"(![a-z][a-z]{0,22}[a-z])*[0-9]", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    throw new Exception("Имя должно состоять исключительно из букв латинского алфавита");
                }
				
				lastname = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, @"(![a-z][a-z]{0,22}[a-z])*[0-9]", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    throw new Exception("Имя должно состоять исключительно из букв латинского алфавита");
                }
				
				firstname = value;
            }
        }
        public uint Age
        {
            get
            {
                return age;
            }
            set
            {

                if (value >= 150 || value <= 12)
                {
                    throw new Exception("Bad age");
                }
                age = value;
            }
        }
        //Constructor
        public Human(string firstname, string lastname, uint age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Console.WriteLine("Constructor:\t\t" + this.GetHashCode());

        }
        ~Human()
        {
            Console.WriteLine("Destructor:\t\t" + this.GetHashCode());
        }
        public override string ToString()
        {
            //string info = ($"Name: {firstname} {lastname}\nAge: {age} years old");
            //return info;
            return $"Name: {firstname} {lastname}\nAge: {age} years old";
        }
    }
}
