
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

## Chapter 2. El calabós del Drac RAMón el Poderós 🐉

El teu mag ha de demostrar el seu entrenament i ha d’entrar al **Calabós del Drac RAMón el Poderós**, on cada porta està protegida per un **codi d’accés digital**.

- Hi ha **3 portes**.  
- Cada una té un **codi aleatori entre 1 i 5**.  
- Tens **3 intents per porta**.

Regles del joc:

- ❌ Si falles una porta, el joc acaba amb el missatge: El drac ha detectat la teva presència i t’ha expulsat del servidor!
- ✅ Si encertes, apareix el missatge: El drac et respecta. Has desbloquejat el següent nivell!
- 🏆 Si arribes a la **tercera porta** i l’obres amb èxit: Has desbloquejat el nivell final. Prepara’t per la batalla!

> 🔍 **TIP:** Pensa en **bucles imbricats** per resoldre aquest repte.

---

## Chapter 3. Lotejar el botí 💰

Has derrotat al drac i has trobat una mina plena de **bitcoins màgics!**

- Cada cop que mines, obtens una quantitat **aleatòria entre 5 i 50 bits**, o potser **res**.
- Només pots fer **5 excavacions**.
- Mostra el resultat de cada excavació.

A cada intent d’excavació pot haver-hi una **probabilitat de no trobar res**.  
Si això passa, mostra:

Avui no és el teu dia de sort, has trobat 0 bits.

Finalment:

- Si el total **> 200 bits**: Has desbloquejat la GPU d’or! Els teus encanteris van ara a 120 FPS!
- Si el total **≤ 200 bits**: La teva targeta màgia encara és integrada. Toca derrotar a un altre drac!

---

> ✨ *Recorda: cada mag comença com a aprenent, però fins i tot el millor arcanista va començar amb un bucle `for`...*



