using System;

namespace ZombieApocalypse
{
    class Game
    {
        public void codeAboutIt()
        {

        }

        public void startGame()
        {
            Console.WriteLine("On a normal day at work, you look outside the window and see a fight breaking out. Do you choose to investigate it? Type 'yes' or 'no'");
            var x = Console.ReadLine();

            if (x.ToUpper() == "YES")
            {
                Console.WriteLine("You rush to the parking lot, tripping over your shoes. Its already not looking good for you. Do you dare intervene, cause you're clumsy AF? Type 'yes' or 'no'");
                var y = Console.ReadLine();
                {
                    if (y.ToUpper() == "YES")
                    {
                        intervene();
                    }
                    else
                    {
                        Console.WriteLine("Your untied shoes caused your demise =(");
                    }
                }
            }
            else if (x.ToUpper() == "NO")
            {
                Console.WriteLine("Guess it's not your problem. GET BACK TO WORK!!!");
                getBackToWork(x);
            }

            else if (x.ToUpper() != "YES" || x.ToUpper() != "NO")
            {
                Console.WriteLine("WTF is wrong with you, enter 'yes' or 'no'");
                var y = Console.ReadLine();
                if (y.ToUpper() == "YES")
                {
                    startGame();
                }
                else
                {
                    //Need to have a path to access this
                    Console.WriteLine("You turn around back to your desk. Your day is dreadfully boring as you stare at a blank screen. You hear a blood curdling scream from outside! Do you code about it or do you go and grab a beer from the kitchen? Type 'Code about it' or 'Grab a beer'");
                    var w = Console.ReadLine();
                    if (w.ToUpper() == "Code about it")
                    {
                        codeAboutIt();
                    }
                    else if (w.ToUpper() == "Grab a beer")
                    {
                        Console.WriteLine("Go on and enjoy that beer, champ!");
                    }
                    else
                    {
                        startGame();
                    }

                }


            }
        }
        public void intervene()
        {
            Console.WriteLine("Despite being clumsy AF you've decided to take action, good for YOU!!! What action would you like to take? Type 'Call the police' or Jump into the fight!!!'");
            var x = Console.ReadLine();

        }

        public void getBackToWork(string x)
        {
            if (x == "no")
            {
                Console.WriteLine("You turn around back to your desk.  Your day is dreadfull boring as you stare at a blank screen.  You hear a blood curdling scream from outside! Do you code about it or do you go and grab a beer from the kitchen? Type 'Code about it' or 'Grab a beer'");
                Console.ReadLine();
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            game.startGame();
            game.codeAboutIt();
            game.intervene();
        }

    }
}