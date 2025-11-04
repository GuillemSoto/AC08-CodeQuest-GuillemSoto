using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuest
{
    public class RAMonDungeon
    {
        public static void EnterDungeon()
        {
            const string IntroMsg = "You arrived at the dragon's dungeon. There are three doors you must open, but they are protected by a code";
            const string DoorMsg = "You reached a door. You must introduce the hidden number between 1 and 5 (both included), you have three attempts in total";
            const string AttemptUpMsg = "That number was incorrect. Try again.";
            const string WrongMsg = "The dragon noticed you and expelled you from the server";
            const string CorrectMsg = "The dragon respects you. You unlocked the next level";
            const string FinalMsg = "You unlocked the final level! Prepare for battle!";
            const string ErrorMsg = "Please introduce a number between 1 and 5";
            const int MaxAttempts = 3;
            const int DoorNumber = 3;
            bool correctNum = false;
            bool attemptRunning = true;
            bool pass = true;
            int currentAttempt = 1;
            int currentDoor = 1;
            int userNum = 0;
            int currentCode = 0;
            Random doorCode = new Random();
            Console.WriteLine(IntroMsg);
            while(pass)
            {
                if(currentDoor <= DoorNumber)
                {

                    currentAttempt = 1;
                    currentCode = doorCode.Next(1, 5);
                    Console.WriteLine(DoorMsg);
                    while (attemptRunning)
                    {
                        while(!correctNum)
                        {
                            userNum = 0;
                            try
                            {
                                userNum = int.Parse(Console.ReadLine());
                                if (userNum > 5 || userNum < 1)
                                {
                                    Console.WriteLine(ErrorMsg);
                                    correctNum = false;
                                }
                                else
                                {
                                    correctNum = true;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(ErrorMsg);
                            }
                        }
                        
                        if(userNum == currentCode)
                        {
                            if(currentDoor == DoorNumber)
                            {
                                Console.WriteLine(FinalMsg);
                                pass = false;
                            }
                            else
                            {
                                Console.WriteLine(CorrectMsg);
                            }
                            attemptRunning = false;
                        }
                        else if (currentAttempt < MaxAttempts)
                        {
                            Console.WriteLine(AttemptUpMsg);
                            currentAttempt++;
                        }
                        else
                        {
                            pass = false;
                            attemptRunning = false;
                            Console.WriteLine(WrongMsg);
                        }
                        correctNum = false;
                    }
                    attemptRunning = true;
                    currentDoor++;
                }
                else pass = false;
            }
        }
    }
}
