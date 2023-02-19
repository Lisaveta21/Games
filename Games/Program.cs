using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Games
{
    internal class Program
    {
        static void startQuiz()
        {
            string[] questions = {

                "Самая высокая гора?",
            "Самая длинная река?",
            "Самая большая страна?"
            };
            string[] answers = { "Эверест", "Амазонка","Россия"};
            int countOfRightAnswers = 0;
            string userAnswer;


            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer == answers[0])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный");


                }
                else
                {
                    WriteLine("Ответ неверный");
                }
            }
            WriteLine("Правильных ответов: " + countOfRightAnswers);



        }

        static void guessNumber()
        {
            WriteLine("Угадай число от 0 до 100!");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int count = 0;
            do
            {
                WriteLine("Введи число ");
                userNumber = Int32.Parse(ReadLine());
                count++;
                if (userNumber < magicNumber)
                {
                    WriteLine("Введенное число меньше загаданного");

                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Введенное число больше загаданного");

                }
                else if (userNumber == magicNumber)
                {
                    WriteLine("Введенное число больше загаданного");
                    WriteLine($"Тебе понадобилось {count} попыок");
                }

                

            }

            while (userNumber != magicNumber);

        }
        static void Main(string[] args)
        {
            startQuiz();
            guessNumber();
        }
    }
}
