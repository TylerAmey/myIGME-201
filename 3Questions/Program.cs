using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _3Questions
{
    static internal class Program {

        static bool bTimeOut = false;

        static Timer timeOutTimer;

        static void Main(string[] args)
        {
            bool bPlaying = true;

            while (bPlaying == true)
            {
                /*timeOutTimer = new Timer(5000);
                ElapsedEventHandler elapsedEventHandler;
                elapsedEventHandler = new ElapsedEventHandler(TimesUp);
                timeOutTimer.Elapsed += elapsedEventHandler;*/
                Console.WriteLine("Choose your question (1-3):");
                string sQuestionNum = Console.ReadLine();
                if (sQuestionNum != "1" && sQuestionNum != "2" && sQuestionNum != "3")
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    if (sQuestionNum == "1")
                    {
                        Console.WriteLine("You have 5 seconds to answer the following question: ");
                        while (bTimeOut != true)
                        {
                            timeOutTimer = new Timer(5000);
                            ElapsedEventHandler elapsedEventHandler;
                            elapsedEventHandler = new ElapsedEventHandler(TimesUp);
                            timeOutTimer.Elapsed += elapsedEventHandler;
                            timeOutTimer.Start();
                            Console.WriteLine("What is your favorite color?");
                            string sAnswer = Console.ReadLine();
                            if (sAnswer.ToLower() == "black")
                            {
                                Console.WriteLine("Well Done!");
                                timeOutTimer.Stop();
                                bTimeOut = true;
                            }
                            else
                            {
                                Console.WriteLine("The answer is: black");
                                timeOutTimer.Stop();
                                bTimeOut = true;
                            }
                        }
                        Console.WriteLine("test:");

                    }
                    else if (sQuestionNum == "2")
                    {
                        Console.WriteLine("You have 5 seconds to answer the following question: ");
                        while (bTimeOut != true)
                        {
                            timeOutTimer = new Timer(5000);
                            ElapsedEventHandler elapsedEventHandler;
                            elapsedEventHandler = new ElapsedEventHandler(TimesUp);
                            timeOutTimer.Elapsed += elapsedEventHandler;
                            timeOutTimer.Start();
                            Console.WriteLine("What is the answer to life, the universe and everything?");
                            string sAnswer = Console.ReadLine();
                            if (sAnswer.ToLower() == "42")
                            {
                                Console.WriteLine("Well Done!");
                                timeOutTimer.Stop();
                                bTimeOut = true;
                            }
                            else
                            {
                                Console.WriteLine("The answer is: 42");
                                timeOutTimer.Stop();
                                bTimeOut = true;
                            }
                        }
                        Console.WriteLine("test:");
                    }
                    else if (sQuestionNum == "3")
                    {
                        Console.WriteLine("You have 5 seconds to answer the following question: ");
                        while (bTimeOut != true)
                        {
                            timeOutTimer = new Timer(5000);
                            ElapsedEventHandler elapsedEventHandler;
                            elapsedEventHandler = new ElapsedEventHandler(TimesUp);
                            timeOutTimer.Elapsed += elapsedEventHandler;
                            timeOutTimer.Start();
                            Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                            string sAnswer = Console.ReadLine();
                            if (sAnswer.ToLower() == "what do you mean? african or european swallow?")
                            {
                                Console.WriteLine("Well Done!");
                                timeOutTimer.Stop();
                                bTimeOut = true;
                            }
                            else
                            {
                                Console.WriteLine("The answer is: What do you mean? African or European swallow?");
                                timeOutTimer.Stop();
                                bTimeOut = true;
                            }
                        }
                        Console.WriteLine("test:");
                    }
                }
                bool bAgainValid = false;
                while(bAgainValid != true)
                {
                    Console.WriteLine("Play again?");
                    string sAgain = Console.ReadLine();
                    if (sAgain.ToLower() == "yes")
                    {
                        bAgainValid = true;
                        continue;
                    }
                    else if (sAgain.ToLower() == "no")
                    {
                        bAgainValid = true;
                        Console.WriteLine("Goodbye!");
                        bPlaying = false;
                    }
                    else
                    {
                        Console.WriteLine("Cmon, yes or no");
                    }
                }
            }
        }   

        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("Time's Up!");
            bTimeOut = true;
            timeOutTimer.Stop();
        }
    }
}
