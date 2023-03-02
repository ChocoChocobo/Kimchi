using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Struct
{
    class Car
    {
        private string _driverName;
        private int _currentSpeed = 50;
        public Car()
        {
            _driverName = "Михаэль Шумахер";
        }

        public Car(string name)
        {
            _driverName = name;
        }

        public Car(string name, int currentSpeed)
        {
            _driverName = name;
            _currentSpeed = currentSpeed;
        }

        public void Print()
        {
            WriteLine($"{_driverName} едет со скоростью {_currentSpeed} км/ч");
        }

        public void SpeedUp(int delta)
        {
            _currentSpeed += delta;
        }
    }


    class StructConstructors
    {
        static void Main(string[] args)
        {
            Car ferrariCar = new Car();
            for (int i = 0; i <= 10; i++)
            {
                ferrariCar.Print();
                ferrariCar.SpeedUp(31);
            }
            WriteLine();

            Car mersedesCar = new Car("Льюис Хэмилтон");
            for (int i = 0; i <= 10; i++)
            {
                mersedesCar.Print();
                mersedesCar.SpeedUp(27);
            }
            WriteLine();

            Car hondaCar = new Car("Энди Грин", 167);
            for (int i = 0; i <= 10; i++)
            {
                hondaCar.Print();
                hondaCar.SpeedUp(67);
            }
        }
    }
}
