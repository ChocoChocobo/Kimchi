using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Struct
{
    class Student
    {
        int _studentId;
        string _firstName = "John";
        string _lastName = "Connor";
        string _group;

        public void Print()
        {
            WriteLine($"Студент {_firstName} {_lastName}");
        }
    }

    class MyClass
    {
        public readonly int var = 10;
        public readonly int[] myArr = { 1, 2, 3 };
    }

    class Bank
    {
        public static float balance = 1000000;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank filial1 = new Bank();
            Bank filial2 = new Bank();

            WriteLine($"Первому филиалу доступно {Bank.balance}");
            WriteLine($"Второму филиалу доступно {Bank.balance}");
            WriteLine($"В первом филиале взяли кредит на 100000, осталось {Bank.balance -= 100000}");
            WriteLine($"Второму филиалу доступно {Bank.balance}");
            WriteLine($"В втором филиале взяли кредит на 200000, осталось {Bank.balance -= 200000}");
            WriteLine($"Первому филиалу доступно {Bank.balance}");
            WriteLine($"В первом филиале открыли депозит на 500000, осталось {Bank.balance += 500000}");
            WriteLine($"Второму филиалу доступно {Bank.balance}");


            MyClass obj = new MyClass();
            /*obj.var = 100;
            obj.myArr = new int[10];*/
            obj.myArr[0] = 11;


            Student st1;
            st1 = new Student();
            st1.Print();

            Student st2;
            st2 = new Student();
            st2.Print();
        }
    }
}
