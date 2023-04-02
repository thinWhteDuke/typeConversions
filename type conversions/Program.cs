using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversions

            short impExample = 8;
            int impExample2 = impExample;
            
            //explicit conversions
            
            //a. convert

            string age = "19";
            int myAge = Convert.ToInt32(age);
            Console.WriteLine("I am {0} years old.", myAge);

            float pi = 3.14f;
            string piNumber = Convert.ToString(pi);
            Console.WriteLine("Pi is {0}", piNumber);

            //b. parse (string to number variables)

            string year = "2023";
            int currentYear = int.Parse(year);
            Console.WriteLine("It's currently {0}", currentYear);
            
            //c. toString 
            
            char star = '*';
            String st5 = star.ToString();
            
            //d. cast
            
            float numberFifteen = 15.0f;
            int numberFourteen = (int)numberFifteen;













        }
    }
}