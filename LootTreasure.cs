using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuest
{
    public class LootTreasure
    {
        public static void Loot()
        {
            const string IntroMsg = "You arrive at the magic bitcoin mine.\n";
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
            Console.WriteLine(IntroMsg);
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
        }
    }
}
