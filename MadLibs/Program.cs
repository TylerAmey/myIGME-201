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
            //Get the template from the text file
            string[] madLibs = System.IO.File.ReadAllLines(@"c:\\templates\\MadLibsTemplate.txt");
            //Boolean to start the game
            bool bStartTruth = false;
            //Gets the amount of times played
            int nTimesPlayed = 0;
            //String to get the players name 
            string sName = "";
            //Number of times they failed to enter yes or no :/ 
            int nFails = 0;
            //Loop to keep the program running in all facets
            while (bStartTruth == false)
            {
                //If the player is new, prompt them to play again without their name
                if (nTimesPlayed == 0)
                {
                    Console.WriteLine("Would you like to play MadLibs? (Enter yes or no)");
                }
                //If the player already played, prompt them to play again with their name
                else
                {
                    Console.WriteLine("Would you like to play again " + sName + "? (Enter yes or no)");
                }
                //See if the user wanted to play
                string sStart = Console.ReadLine();
                sStart = sStart.ToLower();
                //If yes, play the game!
                if (sStart == "yes")
                {
                    //Start the game
                    bStartTruth = true;
                    //Final string to output
                    string resultString = "";
                    //If it's their first time
                    if(nTimesPlayed == 0)
                    {
                        //Prompt for their name
                        Console.WriteLine("What is your name?");
                        sName = Console.ReadLine();
                    }
                    //To see if a valid number was entered
                    bool bNumTruth = false;
                    int nStory = 0;
                    while(bNumTruth == false)
                    {
                        //Prompt the user to choose which story they want to do
                        Console.WriteLine("Chose between stories 1-7 (Story 7 for Lucy in the sky extra credit)");
                        string sStory = Console.ReadLine();
                        //Catching only valid inputs
                        try
                        {
                            nStory = int.Parse(sStory) - 1;
                        }
                        catch
                        {
                            //gives a number that will be out of bounds to toss an exception
                            nStory = 1000;
                        }
                        //If the number is within the bounds...
                        if (nStory >= 0 && nStory <= 6)
                        {
                            //Set to true to avoid the loop
                            bNumTruth = true;
                            //Get the stories
                            string madLib = madLibs[nStory];
                            string[] words = madLib.Split();
                            //check to see if there's a new line /n
                            bool bNewLine = false;
                            //NEW repeat functionality
                            //boolean for found, and word to repeat
                            bool bRepeatFound = false;
                            string sRepeatedWord = "";
                            foreach (string word in words)
                            {
                                //Check to see if its a word to fill in
                                if (word.Contains('{'))
                                {
                                    //Replace all brackets and such within the word to fill
                                    string newWord = word.Replace("{", "");
                                    newWord = newWord.Replace("}", "");
                                    newWord = newWord.Replace("_", " ");
                                    newWord = newWord.Replace(",", "");

                                    string sGiven = "";
                                    //If the fill bracket contains a "Repeat" AND theres no word to repeat yet...
                                    if (newWord.Contains("Repeat") && bRepeatFound == false)
                                    {
                                        //Repleace the repeat in the prompt
                                        newWord = newWord.Replace("Repeat ", "");
                                        bRepeatFound = true;
                                        //Prompt the user to enter a word
                                        Console.WriteLine(newWord + ":");
                                        //Store the word for replacement and 
                                        sGiven = Console.ReadLine();
                                        sRepeatedWord = sGiven;
                                    }
                                    //If the bracket contains repeat AND the repeat word was found
                                    else if (newWord.Contains("Repeat") && bRepeatFound == true)
                                    {
                                        //make the word to replace the repeated word
                                        sGiven = sRepeatedWord;
                                    }
                                    else
                                    {
                                        //If there is no repeat, then ask the user for an input
                                        Console.WriteLine(newWord + ":");
                                        sGiven = Console.ReadLine();
                                    }
                                    //If a new line was called
                                    if (bNewLine == true)
                                    {
                                        //add the input to the string to start the new line
                                        resultString = resultString + sGiven;
                                        bNewLine = false;
                                    }
                                    //Add input of the string
                                    else
                                    {
                                        resultString = resultString + " " + sGiven;
                                    }
                                }
                                //If the word contains a new line
                                else if (word.Contains($@"\n"))
                                {
                                    //Make a new line and set new line to true
                                    resultString = resultString + "\n";
                                    bNewLine = true;
                                }
                                //if the word is a period or comma add it
                                else if (word == "." || word == ",")
                                {
                                    resultString = resultString + word;
                                }
                                else
                                {
                                    //if the new line boolean is true create a new line
                                    if (bNewLine == true)
                                    {
                                        resultString = resultString + word;
                                        bNewLine = false;
                                    }
                                    //if it is empty add the word
                                    else if (resultString == "")
                                    {
                                        resultString = resultString + word;
                                    }
                                    //otherwise add the word with a space
                                    else
                                    {
                                        resultString = resultString + " " + word;
                                    }
                                }
                            }
                            //Write the finished string and increment the times played
                            Console.WriteLine(resultString);
                            nTimesPlayed++;
                            bStartTruth = false;
                        }
                        //If the number is out of bounds write that its an invalid input
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                }
                //If no, leave
                else if (sStart == "no")
                {
                    bStartTruth = true;
                    Console.WriteLine("Goodbye!");
                }
                //If neither yes or no...
                else
                {
                    if(nFails  >= 2)
                    {
                        //If they don't answer in 3 tries, get a little angry
                        Console.WriteLine("Can you not... read? Please enter a valid input");
                    }
                    else
                    {
                        //Prompt the user to say yes or no
                        Console.WriteLine("Please enter valid input");
                        nFails++;
                    }
                }
            }
 
        }
    }
}
