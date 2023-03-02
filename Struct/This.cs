using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructWPU221
{
    class Car
    {
        private string driverName;
        private int currentSpeed = 50;
        public Car() : this("Михаэль Шумахер", 60) { }
        public Car(string driverName) : this(driverName, 45) { }
        public Car(string driverName, int currentSpeed)
        {
            this.driverName = driverName;
            this.currentSpeed = currentSpeed;
        }

        public void Print()
        {
            WriteLine($"{driverName} едет со скоростью {currentSpeed} км/ч");
        }

        public void SpeedUp(int delta)
        {
            currentSpeed += delta;
        }
    }

    public class ClassA
    {
        public void MethodA(ClassB obj)
        {
            obj.MethodB(this);
        }
    }

    public class ClassB
    {
        public void MethodB(ClassA obj)
        {
            WriteLine($"Работа с классом {obj.GetType().Name}");
        }
    }


    class StructWPU221
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            a.MethodA(b);

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
