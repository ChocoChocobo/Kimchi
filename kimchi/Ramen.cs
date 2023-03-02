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
        static void menu()
        {
            int game = 0;            
            WriteLine("1. Quiz.");
            WriteLine("2. Guess a number.");
            WriteLine("3. Exit.");
            Write("Choose an option: ");
            game = Int32.Parse(ReadLine());
            switch (game)
            {
                case 1: startQuiz(); break;
                case 2: guessNumber(); break;
                case 3: WriteLine("Good Bye!"); break;
            }
        }

        static void startQuiz()
        {
            string[] questions =
            {
                "What`s the highest mountain? ",
                "What`s the longest river? ",
                "What`s the biggest country? ",
                "What`s your teachers name? ",
                "What`s 2 + 2? ",
                "What`s 2 + 2 * 2? "
            };
            string[] answers =
            {
                "Everest",
                "Amazon",
                "Russia",
                "Stanislav",
                "4",
                "6"
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
                    WriteLine("Correct!");
                }
                else
                {
                    WriteLine("Dummy :(");
                }
            }

            WriteLine("Correct answers: " + counterOfRightAnswers);
            if (counterOfRightAnswers >= 5) 
            {
                WriteLine("You rock!");
            }
            else if (counterOfRightAnswers > 3 && counterOfRightAnswers < 5) 
            {
                WriteLine("Well, not bad!");
            }
            else if (counterOfRightAnswers < 3)
            {
                WriteLine("Have you ever considered visiting a school?");
            }

            WriteLine("Would you like to restart the quiz?");
            WriteLine("1. Restart the quiz.");
            WriteLine("2. Return to main menu.");
            WriteLine("3. Exit.");
            int option = 0;
            option = Int32.Parse(ReadLine());
            switch(option)
            {
                case 1: startQuiz(); break;
                case 2: menu(); break;
                case 3: exit(); break;
            }
        }

        static void guessNumber()
        {
            WriteLine("Welcome to \"Magic number 0 to 100 v1\"! ");
            WriteLine("You got 10 tries only so think harder!");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int counter = 0;
            int option = 0;
            int tries = 10;
            do
            {               
                Write("Enter a number: ");
                userNumber = Int32.Parse(ReadLine());
                counter++;
                tries--;

                if (userNumber < magicNumber)
                {
                    WriteLine("Entered number is lesser than the magic number!");
                    WriteLine($"You got {(counter - 10) * -1} tries remaining.");
                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Entered number is bigger than the magic number!");
                    WriteLine($"You got {(counter - 10) * -1} tries remaining.");
                }
                else if (userNumber == magicNumber)
                {
                    WriteLine("You rock! The magic number is " + magicNumber);
                    WriteLine($"You needed {counter} tries"); //Интерполированная строка
                    WriteLine("Would you like to try again?");
                    WriteLine("1. Restart \"Magic number 0 to 100 v1\".");
                    WriteLine("2. Return to main menu.");
                    WriteLine("3. Exit.");
                    option = Int32.Parse(ReadLine());
                    switch (option)
                    {
                        case 1: guessNumber(); break;
                        case 2: menu(); break;
                        case 3: exit(); break;
                    }
                    //break;
                }
                
                if (tries == 0)
                {
                    WriteLine("You lose!");
                    WriteLine("Would you like to try again?");
                    WriteLine("1. Restart \"Magic number 0 to 100 v1\".");
                    WriteLine("2. Return to main menu.");
                    WriteLine("3. Exit.");
                    option = Int32.Parse(ReadLine());
                    switch (option)
                    {
                        case 1: guessNumber(); break;
                        case 2: menu(); break;
                        case 3: exit(); break;
                    }
                }
            } while (userNumber != magicNumber || tries == 0);
        }

        static void exit()
        {
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            WriteLine("Welcome to Quick Interactive games!");
            menu();

        }
    }
}