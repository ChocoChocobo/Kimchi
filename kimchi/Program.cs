using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace kimchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double x = 3.3;
            double y = 7.7;

            int z = (int)x;
            WriteLine(z);*/

            /*WriteLine("Enter your name: ");
            string name;
            name = ReadLine();
            if(name == "") 
            {
                WriteLine("Hello world!");
            }
            else
            {
                WriteLine("Hello, " + name);
            }*/

            Write("Введите целое число: ");
            string numberString = ReadLine();
            int number = Convert.ToInt32(numberString);
            int number1 = Int32.Parse(numberString);
            WriteLine("Число: " + number);
            WriteLine("Число: " + number1);
        }
    }
}
