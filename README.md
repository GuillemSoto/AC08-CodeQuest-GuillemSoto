
- Tots els *chapters* han de definir el **joc de proves** per després fer-lo servir al *Debug*.  
- El **repositori** ha d’incloure un `README.md` amb el **joc de proves** i la **descripció del projecte**.  

## Chapter 1. Path of the learning mage

I made a program here which just asks for the player's name and then calculates random numbers for the training hours and the power level gained, which prints a message at the start of the day.
I used the Random class to get the random numbers and a for loop so that it only happens five times.
At the end of each day, a message with your current power level and your current title appears, and this is made with a switch.

Trial game:

Let's say name is always the same, as it doesn't really affect the program.

CurrentDay=1
TrainingHours=0+3
PowerLevel=0+6
Message with current stats
PowerLevel==6, so it enters the switch's first level where it prints the lowest title.
CurrentDay++

CurrentDay=2
TrainingHours=3+5
PowerLevel=6+9
Message with current stats
PowerLevel==15, so it enters the switch's first level where it prints the lowest title.
CurrentDay++

CurrentDay=3
TrainingHours=8+2
PowerLevel=15+4
Message with current stats
PowerLevel==19, so it enters the switch's first level where it prints the lowest title.
CurrentDay++

CurrentDay=4
TrainingHours=10+7
PowerLevel=19+2
Message with current stats
PowerLevel==21, so it enters the switch's second level where it prints the second lowest title.
CurrentDay++

CurrentDay=5
TrainingHours=17+5
PowerLevel=21+3
Message with current stats
PowerLevel==24, so it enters the switch's second level where it prints the second lowest title.
CurrentDay++

CurrentDay=6, so it gets out of for range and the program ends.

## Chapter 2. RAMon The Powerful's Dungeon

This is a program with some fairly complicated loop logic, so basically I had to use two booleans, one to control if the player has finished the game, either by completing it or by losing at it, and the other to control the attempts of the current door, which is a maximum of three.
Each of the three doors can be unlocked by inserting the correct number, which is a Random from one to five, and so to test whether the program worked correctly I had to use breakpoints to check the value of the random variable.
The rest is some simple if/else logic to check if the inputted number is correct and if the number of attempts reached three or not, in which case the game would finish. The other way to finish the game would be beating it, in which case a message would pop up on the console confirming you beat it.

Trial game:

pass=true
doorNumber=1, so when confirming if the reached door is one of the three it will say true and run the program until door 4 is reached, in which case the program will finish and tell you you won.
currentAttempt=1, the user has three attempts per door.
currentCode=2, a code is generated randomly.
userNum=0, this makes sure that user won't skip checks by inputting a null value.
userNum=2, The program then prompts the user to introduce a number and keeps trying until the user enters a valid one (so for example no 124 and no ñ)
2=2, If the number matches the code, it will advance to the next door unless it's already door number 3, in which case the user will be told that they won.
If the number is wrong, the program will add 1 to currentAttempt unless it's already the third attempt, in which case he will lose and the program will end, which is made by making pass=false.
After getting out of the door the boolean attemptRunning will be false, and it will proceed to the next one and repeat the loop.


## Chapter 3. Looting the treasure

This program is automated, so the loop will always run five times (for loop).
It just randomly decides whether you find something (a Random from 1 to 100), and you will find nothing 30% of the time
Then if you do find something it will be randomly between 5 and 50 bitcoins, also random.
Every attempt will be shown to the user and in the end a message telling them the total recollected and a good or bad message depending on the amount obtained.

Trial game:

CurrentAttempt=1
FoundSomething=20
FoundSomething>BrickChance=false
FoundNothing message
CurrentAttempt++

CurrentAttempt=2
FoundSomething=40
FoundSomething>BrickChance=true
DailyAmountFound=10
TotalAmount=0+10
Daily message
CurrentAttempt++

CurrentAttempt=3
FoundSomething=60
FoundSomething>BrickChance=true
DailyAmountFound=20
TotalAmount=10+20
Daily message
CurrentAttempt++

CurrentAttempt=4
FoundSomething=80
FoundSomething>BrickChance=true
DailyAmountFound=40
TotalAmount=30+40
Daily message
CurrentAttempt++

CurrentAttempt=5
FoundSomething=100
FoundSomething>BrickChance=true
DailyAmountFound=50
TotalAmount=70+50
Daily message
CurrentAttempt++

CurrentAttempt=6

Total message
TotalAmount(120) < 200 = true
Bad message
