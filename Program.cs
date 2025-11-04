using System;

public class Program
{
    static void Main()
    {   
        const string InputNameMsg = "What is your name?";
        //currentDay, name, trainingHours, powerLevel
        const string RankOne = "You repeat 2nd call";
        const string RankTwo = "You still mistake the wand for a spoon";
        const string RankThree = "You are a Magic Breeze Summoner.";
        const string RankFour = "Wow! You can summon dragons without burning the lab down!";
        const string RankFive = "You accomplished Arcane Master rank!";
        const int MinHours = 1;
        const int MaxHours = 5;
        const int MinPower = 1;
        const int MaxPower = 10;
        bool validInput = true;
        string StartOfDayMsg = "Day {0}: {1}, you have already medited {2} hours and your power is now {3} points!";
        string TitleMsg = "Your title is {0}";
        string name = "";
        int mageLevel = 1;
        int currentDay = 1;
        int trainingHours = 0;
        int powerLevel = 0;
        string[] possibleTitles = ["Raoden el Elantrí", "Zyn el Buguejat", "Arka Nullpointer", "Elarion de les Brases", "ITB-Wizard el Gris"];
        string title = "";
        Random meditationHours = new Random();
        Random powerLevelGain = new Random();
        const string IntroMsg3 = "You arrive at the magic bitcoin mine.\n";
        const string FoundNothing = "Today is not your lucky day, you found 0 bits.";
        const string GoodMsg = "You unlocked the golden GPU! Your spells are now 120 FPS!";
        const string BadMsg = "Your magics card is still integrated. Time to defeat another dragon!";
        const int MaxAttempts = 5;
        const int BrickChance = 30;
        const int BitBreakpoint = 200;
        string dailyMinedStr = "Today you mined {0} bits.";
        string finalMinedStr = "You mined a total of {0} bits!";
        int currentAttempt = 1;
        int foundSomething = 0;
        int dailyAmountFound = 0;
        int totalFound = 0;
        Random minedAmount = new Random();
        Random found = new Random();
        const string IntroMsg2 = "You arrived at the dragon's dungeon. There are three doors you must open, but they are protected by a code";
        const string DoorMsg = "You reached a door. You must introduce the hidden number between 1 and 5 (both included), you have three attempts in total";
        const string AttemptUpMsg = "That number was incorrect. Try again.";
        const string WrongMsg = "The dragon noticed you and expelled you from the server";
        const string CorrectMsg = "The dragon respects you. You unlocked the next level";
        const string FinalMsg = "You unlocked the final level! Prepare for battle!";
        const string ErrorMsg = "Please introduce a number between 1 and 5";
        const int MaxAttempts2 = 3;
        const int DoorNumber = 3;
        bool correctNum = false;
        bool attemptRunning = true;
        bool pass = true;
        int currentAttempt2 = 1;
        int currentDoor = 1;
        int userNum = 0;
        int currentCode = 0;
        const string MenuTitle = "\n===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string ExitMsg = "Program exited successfully";
        Random doorCode = new Random();
        
        int chosenOption = 0;
        

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            do
            {

                try
                {
                    chosenOption = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(InputErrorMessage);
                    validInput = false;
                }
            }while(!validInput);
            switch (chosenOption)
            {
            case 1: 
                do
                {
                    Console.WriteLine(InputNameMsg);
                    try
                    {
                        name = Console.ReadLine();
                    }
                    catch (NullReferenceException)
                    {
                        validInput = false;
                    }
                } while (!validInput);
                for (currentDay = 1; currentDay < 5; currentDay++)
                {
                    trainingHours += meditationHours.Next(MinHours, MaxHours);
                    powerLevel += powerLevelGain.Next(MinPower, MaxPower);
                    Console.WriteLine(StartOfDayMsg, currentDay, name, trainingHours, powerLevel);

                    switch (powerLevel)
                    {
                        case < 20:
                            Console.WriteLine(RankOne);
                            title = possibleTitles[0];
                            Console.WriteLine(TitleMsg, title);
                            break;
                        case < 30:
                            Console.WriteLine(RankTwo);
                            title = possibleTitles[1];
                            Console.WriteLine(TitleMsg, title);
                            break;
                        case < 35:
                            Console.WriteLine(RankThree);
                            title = possibleTitles[2];
                            Console.WriteLine(TitleMsg, title);
                            break;
                        case < 40:
                            Console.WriteLine(RankFour);
                            title = possibleTitles[3];
                            Console.WriteLine(TitleMsg, title);
                            break;
                        case > 40:
                            Console.WriteLine(RankFive);
                            title = possibleTitles[3];
                            Console.WriteLine(TitleMsg, title);
                            break;

                    }
                }
                break;
            case 2: 
                Console.WriteLine(IntroMsg2);
                while (pass)
                {
                    if (currentDoor <= DoorNumber)
                    {

                        currentAttempt2 = 1;
                        currentCode = doorCode.Next(1, 5);
                        Console.WriteLine(DoorMsg);
                        while (attemptRunning)
                        {
                            while (!correctNum)
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

                            if (userNum == currentCode)
                            {
                                if (currentDoor == DoorNumber)
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
                            else if (currentAttempt2 < MaxAttempts2)
                            {
                                Console.WriteLine(AttemptUpMsg);
                                currentAttempt2++;
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
                break;
            case 3:
                Console.WriteLine(IntroMsg3);
                for (currentAttempt = 1; currentAttempt <= MaxAttempts; currentAttempt++)
                {
                    foundSomething = found.Next(0, 100);
                    if (foundSomething > BrickChance)
                    {
                        dailyAmountFound = minedAmount.Next(5, 50);
                        totalFound += dailyAmountFound;
                        Console.WriteLine(dailyMinedStr, dailyAmountFound);
                    }
                    else
                    {
                        Console.WriteLine(FoundNothing);
                    }
                }
                Console.WriteLine(finalMinedStr, totalFound);
                if (totalFound > BitBreakpoint)
                {
                    Console.WriteLine(GoodMsg);
                }
                else
                {
                    Console.WriteLine(BadMsg);
                }
                break;
            default:
                Console.WriteLine(ExitMsg);
                break;
        }
            

        } while (chosenOption != 0);
        
    }
    
    
}
