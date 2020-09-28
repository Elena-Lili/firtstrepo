using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           string myString = "Hello Batman";
            string mickey = "Hello Mickey Mouse";

            Console.WriteLine(myString.Contains("M"));
            Console.WriteLine(myString.Length);
            if (myString != mickey)
            {
                Console.WriteLine("Mickey does not equals myString");

            }
           string result = myString + mickey;
           Stopwatch stopWatch1 = new Stopwatch();
           stopWatch1.Start();




            for (int i = 0; i < 1000; i++)
            {
                result += i; //result = result+i;
            }
            stopWatch1.Stop();
            //Console.WriteLine(result);
            //Console.WriteLine($"With string;{stopWatch1.Elapsed}");

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            StringBuilder builder = new StringBuilder();




            builder.Append(result);

            for (int i = 0; i < 1000; i++)
            {
           
                builder.Append(i);
            //Console.WriteLine(builder);
            }
           stopWatch2.Stop();
            Console.WriteLine($"With stringBuilder;{stopWatch2.Elapsed}");

            //    Console.WriteLine(myString.Length); //afiseaza 12
            //    Console.WriteLine(myString[0]); //afiseaza H
            //    Console.WriteLine(myString.Contains("M")); //false

            //    //if (myString == mickey)
            //    //{
            //    //    Console.WriteLine(}mickey equals mystring");
            string longString = "a, b, c, ddd, s, s";
            Console.WriteLine(longString);
            string replacedString = longString.Replace(",", ";");
            Console.WriteLine(replacedString);

            Console.WriteLine(myString.Remove(6, 6));


            Console.WriteLine("Hello World!");

            decimal number = 12456664343;
            CultureInfo culture = new CultureInfo("en-us");
            //    Console.WriteLine(number.ToString("c", culture));

            //    CultureInfo india = new CultureInfo("en-GB");
            //    Console.WriteLine(number.ToString("c", india));

            //    ultureInfo india = new CultureInfo("ro-RO");
            //    Console.WriteLine(number.ToString("c", india));
        }

            
        
    }
}
