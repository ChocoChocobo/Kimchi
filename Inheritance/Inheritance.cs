using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    public class Human
    {
        protected string _firstName;
        protected string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public void Show()
        {
            WriteLine($"First Name: {_firstName}\nLast Name: {_lastName}\n" +
                $"Birth Date: {_birthDate.ToShortDateString()}");
        }
    }

    public class Employee : Human
    {
        double _salary;

        public Employee(string firstName, string lastName) : base(firstName, lastName) { }

        public Employee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            _salary = salary;
        }

        public Employee(string firstName, string lastName, DateTime birthDate, double salary) : 
            base(firstName, lastName, birthDate)
        {
            _salary = salary;
        }

        public void Print()
        {
            base.Show();
            WriteLine($"Salary: {_salary}$\n");
        }
    }

    class Jedi : Employee
    {
        string _rank;
        string _swordColor;

        public Jedi(string firstName, string lastName,DateTime birthDate, double salary, 
            string rank, string swordColor) : base(firstName, lastName, birthDate, salary)
        {
            _rank = rank;
            _swordColor = swordColor;
        }

        public new void ShowJedi()
        {
            base.Print();
            WriteLine($"Rank of Jedi: {_rank}\n Sword Color: {_swordColor}\n");
        }
    }

    class Sith : Employee
    {
        string _rank;
        string _swordColor;
        string _mentor;

        public Sith(string firstName, string lastName, DateTime birthDate, double salary,
            string rank, string swordColor, string mentor) : base(firstName, lastName, birthDate, salary)
        {
            _rank = rank;
            _swordColor = swordColor;
            _mentor = mentor;
        }

        public new void ShowSith()
        {
            base.Print();
            WriteLine($"Rank of Sith: {_rank}\nSword Color: {_swordColor}\nMentor: {_mentor}\n");
        }
    }

    class Citizen : Employee
    {
        string _planet;
        string _whichSide;

        public Citizen(string firstName, string lastName, DateTime birthDate, double salary,
            string planet, string whichSide) : base (firstName, lastName, birthDate, salary)
        {
            _planet = planet;
            _whichSide = whichSide;
        }

        public void ShowCitizen() 
        {
            base.Show();
            WriteLine($"Planet: {_planet}\nChosen side {_whichSide}\n");
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Employee jedi1 = new Jedi("Luke", "Skywalker", new DateTime(1970, 11, 11), 100000,
                "Master-Jedi", "Blue");

            Employee[] employees =
            {
                jedi1,
                new Sith("Anakin", "Skywalker", new DateTime(1947,02,24), 250000, "Lord", "Red",
                "Palpatine"),
                new Citizen("Han", "Solo", new DateTime(1945,3,14), 300000, "Corellia", "Republic"),
                new Citizen("Jaja", "Binks", new DateTime(1897,4,12), 5000, "Nabu", "Republic")
            };

            Employee emp1 = new Employee("Luke", "Skywalker", 100000);
            emp1.Print();

            Employee emp2 = new Employee("Han", "Solo", new DateTime(1945,3,14), 300000);
            emp2.Print();

            Employee emp3 = new Employee("Jaja", "Binks");
            emp3.Print();

            foreach(Employee item in employees ) 
            {
                //Способ 1. Явное приведение к типу класса
                try
                {
                    ((Jedi)item).ShowJedi();
                }
                catch { }

                //Способ 2. Запись iteam, как объект нужного класса
                Sith sith = item as Sith;
                if(sith != null)
                {
                    sith.ShowSith();
                }

                //Способ 3. Сравнение типов и приведение через Is
                if(item is Citizen)
                {
                    (item as Citizen).ShowCitizen();
                }
            }
        }
    }
}
