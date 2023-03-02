using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructWPU221
{
    class Bank
    {
        private double _currentBalance;
        private static double _bonus;

        public Bank(double balance)
        {
            _currentBalance = balance;
        }

        static Bank()
        {
            _bonus = 1.3;
        }

        public static void SetBonus(double newRate)
        {
            _bonus = newRate;
        }

        public static double GetBonus()
        {
            return _bonus;
        }

        public double GetPercents(double sum)
        {
            if ((_currentBalance - sum) > 0)
            {
                double percent = sum * _bonus;
                _currentBalance -= percent;
                return percent;
            }
            return -1;
        }
    }

    class StructWPU221
    {
        static void Main(string[] args)
        {
            Bank filial1 = new Bank(1000000);
            WriteLine($"Текущий бонусный процент: {Bank.GetBonus()}");
            WriteLine($"Ваш депозит на 100000, в кассе забрать: {filial1.GetPercents(100000)}");
        }
    }
}