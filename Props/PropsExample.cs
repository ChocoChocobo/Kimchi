using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//для быстрого создания свойства и поля пишем propfull, нажимаем 2 раза Tab
//для быстрого создания автосвойства пишем prop, нажимаем 2 раза Tab

namespace PropsWPU221
{
    class Example
    {
        public int Id { get; } = DateTime.Now.Year < 2023 ? 2022 : DateTime.Now.Year;
        public int Num { get; set; } = 365;
        public string FirstName { get; set; } = "Donald";
    }

    class Employee
    {
        public int MyProperty { get; set; }

        string _firstName;
        public string FirstName
        {
            get { return _firstName != null ? _firstName : "Аристарх"; }
            set { _firstName = value.ToUpper(); }
        }

        string _lastName;
        public string LastName
        {
            get { return _lastName != null ? _lastName : "Абрикосов"; }
            set { _lastName = value.ToUpper(); }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = (value < 1 || value > 100) ? 0 : value; }
        }

        double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value < 0 ? 0 : value; }
        }

        public void Print()
        {
            WriteLine($"Имя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age}\nЗаработная плата: {Salary}\n");
        }
    }

    class PropsWPU221
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee
            {
                FirstName = "Альберт",
                LastName = "Энштейн",
                Age = 19,
                Salary = 12000
            };

            Employee emp2 = new Employee();

            Employee emp3 = new Employee
            {
                FirstName = "Венцеслав",
                LastName = "Зайцев",
                Age = 123,
                Salary = -100
            };
            emp1.Print();
            emp2.Print();
            emp3.Print();


            /*Example ex1 = new Example();
            WriteLine($"Имя: {ex1.FirstName}\nНомер: {ex1.Num}\nID: {ex1.Id}\n\n");*/
        }
    }
}
