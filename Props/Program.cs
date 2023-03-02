using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//для быстрого создания свойства и поля пишем propfull, нажимаем 2 раза Tab


namespace PropsWPU221
{
    class Example
    {
        static int _num;
        public static int Num
        {
            get
            {
                return _num;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    _num = value;
            }
        }
    }

    class PropsWPU221
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Write("Введите целое число: ");
            Example.Num = int.Parse(ReadLine());
            Write("Вы ввели: ");
            WriteLine(Example.Num);
        }
    }
}

