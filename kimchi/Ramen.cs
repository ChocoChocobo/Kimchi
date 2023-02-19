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
        static void startQuiz()
        {
            string[] questions =
            {
                "Самая высокая гора? ",
                "Самая длинная река? ",
                "Самая большая страна? "
            };
            string[] answers =
            {
                "Эверест",
                "Амазонка",
                "Китай"
            };
            int counterOfRightAnswers = 0;
            string userAnswers;

            for(int i = 0; i < questions.Length; i++) 
            {
                Write(questions[i]);
                userAnswers = ReadLine();
                if (userAnswers == answers[i])
                {
                    counterOfRightAnswers++;
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Тупица...");
                }
            }

            WriteLine("Правильных ответов: " + counterOfRightAnswers);
        }

        static void guessNumber()
        {
            WriteLine("Добро пожаловать в игру \" Угадай число от 0 до 100 \"! ");
            Random rand = new  Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int counter = 0;
            do
            {
                WriteLine("Введи число: ");
                userNumber = Int32.Parse(ReadLine());
                counter++;

                if (userNumber < magicNumber)
                {
                    WriteLine("Введенное число меньше загаданного!");
                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Введенное число больше загаданного!");
                }
                else if (userNumber == magicNumber)
                {
                    WriteLine("А ты хорош, верно отгадал! Загаданное число: " + magicNumber);
                    WriteLine($"Тебе понадобилось {counter} попыток"); //Интерполированная строка
                    break;
                }

            }while(userNumber != magicNumber);
        }

        static void Main(string[] args)
        {
            //startQuiz();
            guessNumber();
        }
    }
}