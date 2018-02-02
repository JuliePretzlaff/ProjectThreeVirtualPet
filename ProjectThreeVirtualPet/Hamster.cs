﻿using System;
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
        public Hamster ()
            {
            //default constructor
            }

        public Hamster (string name)
        {
            this.name = name;
            this.hunger = 8;
            this.thirst = 8;
            this.boredom = 8;
            this.mood = "happy";
        }


        //Hamster Methods:
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
            if(meal == "meal")
            {
                this.hunger = hunger + 2;
                this.thirst = thirst - 2;
                Console.WriteLine("{0} is not as hungry but is now a little more thirsty!", Name);
            }
            else if(meal == "snack")
            {
                this.hunger = hunger + 1;
                this.thirst = thirst - 2;
                Console.WriteLine("{0} is not as hungry but is now a little more thirsty!", Name);
            }
            else
            {
                Console.WriteLine("{0} is still hungry!", name);
            }

        }

        //method to give water
        public void GiveWater()
        {
            thirst = thirst + 2;
            Console.WriteLine("{0} thanks you for the water.", name);
        }


        //method to have fun
        public void HaveFun(string toyGiven)
        {
            if (toyGiven == "wheel")
            {
                boredom = boredom + 2;
                thirst = thirst - 2;
                hunger = hunger - 2;
            }
            else if (toyGiven == "running ball")
            {
                boredom = boredom + 3;
                thirst = thirst - 3;
                hunger = hunger - 3;
            }
            else if(toyGiven == "ladder")
            {
                boredom = boredom + 1;
                thirst = thirst - 1;
                hunger = hunger - 1;
            }
            else
            {
                Console.WriteLine("That's not a very fun toy...");
            }
        }
        
    }

}

