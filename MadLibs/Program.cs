using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] madLibs = System.IO.File.ReadAllLines(@"c:\\templates\\MadLibsTemplate.txt");
            bool bStartTruth = false;
            int nTimesPlayed = 0;
            string sName = "";
            while (bStartTruth == false)
            {
                if(nTimesPlayed == 0)
                {
                    Console.WriteLine("Would you like to play MadLibs? (Enter yes or no)");
                }
                else
                {
                    Console.WriteLine("Would you like to play again " + sName + "? (Enter yes or no)");
                }
                string sStart = Console.ReadLine();
                sStart = sStart.ToLower();
                if (sStart == "yes")
                {
                    bStartTruth = true;
                    string resultString = "";
                    if(nTimesPlayed == 0)
                    {
                        Console.WriteLine("What is your name?");
                        sName = Console.ReadLine();
                    }
                    bool bNumTruth = false;
                    int nStory = 0;
                    while(bNumTruth == false)
                    {
                        Console.WriteLine("Chose between stories 1-6");
                        string sStory = Console.ReadLine();
                        nStory = int.Parse(sStory) - 1;
                        if (nStory >= 0 && nStory <= 5)
                        {
                            bNumTruth = true;
                            string madLib = madLibs[nStory];
                            string[] words = madLib.Split();
                            bool bNewLine = false;
                            foreach (string word in words)
                            {
                                if (word.Contains('{'))
                                {
                                    string newWord = word.Replace("{", "");
                                    newWord = newWord.Replace("}", "");
                                    newWord = newWord.Replace("_", " ");
                                    newWord = newWord.Replace(",", "");
                                    Console.WriteLine(newWord + ":");
                                    string sGiven = Console.ReadLine();
                                    if(bNewLine == true)
                                    {
                                        resultString = resultString + sGiven;
                                        bNewLine = false;
                                    }
                                    else
                                    {
                                        resultString = resultString + " " + sGiven;
                                    }
                                }
                                else if(word == "\n")
                                {
                                    resultString = resultString + '\n';
                                    bNewLine = true;
                                }
                                else
                                {
                                    if(bNewLine == true)
                                    {
                                        resultString = resultString + word;
                                        bNewLine=false;
                                    }
                                    else
                                    {
                                        resultString = resultString + " " + word;
                                    }
                                }
                            }

                            Console.WriteLine(resultString);
                            nTimesPlayed++;
                            bStartTruth = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number input");
                        }
                    }
                }
                if (sStart == "no")
                {
                    bStartTruth = true;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
 
        }
    }
}
