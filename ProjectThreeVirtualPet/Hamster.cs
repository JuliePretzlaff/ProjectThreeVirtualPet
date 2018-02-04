using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThreeVirtualPet
{
    class Hamster
    {

        //Hamster Fields
        private string name;
        private int hunger;
        private int thirst;
        private int boredom;
        private string mood;


        //Hamster Properties;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
        }

        public int Thirst
        {
            get { return this.thirst; }
        }

        public int Boredom
        {
            get { return this.boredom; }
        }

        public string Mood
        {
            get { return this.mood; }
        }


        //Hamster Constructors:
        public Hamster()
        {
            //default constructor
        }

        public Hamster(string name)
        {
            this.name = name;
            this.hunger = 8;
            this.thirst = 8;
            this.boredom = 8;
            this.mood = "happy";
        }


        //Hamster Methods:

        //method to determine gender:
        public static string GenderSurprise(int userNumber)
        {
            if (userNumber % 2 == 0)
            {
                return "Your hamster is a female!";
            }
            else
            {
                return "Your hamster is a male!";
            }
        }


        //method to feed
        public void FeedHamster(string meal)
        {
            if (meal == "meal")
            {
                this.hunger = hunger + 3;
                this.thirst = thirst - 2;
                Console.WriteLine("\n{0} is not as hungry but is now a little more thirsty!", Name);
            }
            else if (meal == "snack")
            {
                this.hunger = hunger + 2;
                this.thirst = thirst - 2;
                Console.WriteLine("\n{0} is not as hungry but is now a little more thirsty!", Name);
            }
            else
            {
                Console.WriteLine("\n{0} is still hungry!", name);
            }

        }

        //method to give water
        public void GiveWater()
        {
            thirst = thirst + 2;
            Console.WriteLine("\n{0} thanks you for the water.", name);
        }


        //method to have fun
        public void HaveFun(string toyGiven)
        {
            if (toyGiven == "wheel")
            {
                boredom = boredom + 2;
                thirst = thirst - 1;
                hunger = hunger - 1;
            }
            else if (toyGiven == "running ball")
            {
                boredom = boredom + 3;
                thirst = thirst - 1;
                hunger = hunger - 1;
            }
            else if (toyGiven == "ladder")
            {
                boredom = boredom + 1;
                thirst = thirst - 1;
                hunger = hunger - 1;
            }
            else
            {
                Console.WriteLine("\nThat's not a very fun toy...");
            }
        }

        //method to change mood
        public void MoodImprovement()
        {
            mood = "happy";
            Console.WriteLine("\n{0} is now {1}!", name, mood);
        }

        //too bored method, called if hamster gets too bored:
        public void TooBored()
        {
            Console.WriteLine("\nYour pet was bored to tears and bit you!  It's not so bored anymore...");
            boredom = boredom + 3;
        }


        //too hungry method, called if hamster gets too hungery:
        public void TooHungry()
        {
            Console.WriteLine("\nYour hamster was starving so it broke into the fridge to eat your carrots!");
            hunger = hunger + 3;
        }
       


        //tick method, generating random results to change the hamster's status
        //executed each time the loop is completed/menu is displayed:
        public void Tick()
        {
            //decrease hunger
            hunger = hunger - 1;

            //random number generator to determine mood and boredom level:
            Random r = new Random();
            int[] luckyNumbers = new int[1];
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = r.Next(-2, 2);
            }

            //determining level of boredom using random number:
            boredom = boredom + luckyNumbers[0];

            //determinining mood: using random number:
            if (luckyNumbers[0] == -2)
            {
                mood = "scared";
            }
            else if (luckyNumbers[0] == -1)
            {
                mood = "sleepy";
            }
            else if (luckyNumbers[0] == 0)
            {
                mood = "cranky";
            }
            else if (luckyNumbers[0] == 1)
            {
                mood = "content";
            }
            else if (luckyNumbers[0] == 2)
            {
                mood = "happy";
            }
        }

        //method to display hamster art:
        public static void HamsterArt()
        {
            Console.WriteLine(@"        _           _");
            Console.WriteLine(@"      (`-`;-'```'-;`-`) ");
            Console.WriteLine(@"       \.'         './");
            Console.WriteLine(@"       /             \");
            Console.WriteLine(@"       ;   0     0   ;");
            Console.WriteLine(@"      /| =         = |\");
            Console.WriteLine(@"     ; \   '._Y_.'   / ;");
            Console.WriteLine(@"    ;   `-._ \|/ _.-'   ;");
            Console.WriteLine(@"    ;       `---'       ;");
            Console.WriteLine(@"    ;    ---.   .---    ;");
            Console.WriteLine(@"   /;  '--._ \ / _.--   ;\");
            Console.WriteLine(@"  :  `.   `/|| ||\`   .'  :");
            Console.WriteLine(@"   '.  '-._       _.-'   .'");
            Console.WriteLine(@"    (((-`  -------   `-)))");
            Console.WriteLine(@"jgs image from http://www.chris.com/ascii/joan/www.geocities.com/SoHo/7373/pets2.html");


        }
    }
}

