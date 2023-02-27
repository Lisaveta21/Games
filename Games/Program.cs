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
            string[] answers = { "Эверест", "Амазонка", "Россия" };
            string[] OtherAnswers = { "Джубга, Эверест", "Москва - река, Амазонка", "Китай, Россия" };
            int countOfRightAnswers = 0;
            string userAnswer;


            for (int i = 0; i < questions.Length; i++)
                for (int j = 0; j< OtherAnswers.Length; j++)
            {
                Write(questions[i]);
                    Write(OtherAnswers[j]);
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
            int count = 1; int i = 0;
            int k = Convert.ToInt32(Console.ReadLine());
            while (count <= 3)

                if (i == k)
                {
                    Console.WriteLine("Правильно!");
                    break;
                }

                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Вы не угадали число. Правильный ответ " + i + "");

                    }
                    Console.WriteLine("Нет это не число " + k + "! Попытка номер" + count + "");
                    k = Convert.ToInt32(Console.ReadLine());

                }



        }




        static void Main(string[] args)
        {
            startQuiz();
            guessNumber();
        }
    }
}

