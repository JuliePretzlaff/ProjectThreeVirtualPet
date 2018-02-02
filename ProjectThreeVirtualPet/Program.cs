﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThreeVirtualPet
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Greeintg:
            Console.WriteLine("Hello, please meet your new virtual hamster! Isn't it cute!?");

            //method to display art of super cute hamster:
            Hamster.HamsterArt();

            Console.WriteLine("\nTo begin, type in a whole number to find out if your hamster is male or female: ");
            int genderNumber = int.Parse(Console.ReadLine());
           
         

         

            //Determining the hamster gender & naming:
            Console.WriteLine(Hamster.GenderSurprise(genderNumber));

            Console.WriteLine("\nNow, please give your hamster a name: ");
            string nameIt = Console.ReadLine();

            //Creating the new hamster instance:
            Hamster userHamsterOne = new Hamster(nameIt);

            //Menu discription and access:
            Console.WriteLine("\nGreat name!  Now let's begin!  \nBelow you will see the current status display for your hamster. \nAll hamster conditions are based on a scale of 1-10.  \nThe higher the value, the more satisfied {0} is.  \nThe lower the value, the less satisfied {0} is. \nBe aware of any low values, as {0} might be need of your attention! \nThe current status display will try to alert you of any alarming values. ", userHamsterOne.Name);

            int userMenuInput;
            do
            {
                string[] conditions = new string[4] { "Hunger", "Thirst", "Boredom", "Mood" };
                Console.WriteLine("\nCurrent status of " + userHamsterOne.Name + ": ");
                Console.WriteLine(conditions[0] + ": " + userHamsterOne.Hunger);
                Console.WriteLine(conditions[1] + ": " + userHamsterOne.Thirst);
                Console.WriteLine(conditions[2] + ": " + userHamsterOne.Boredom);
                Console.WriteLine(conditions[3] + ": " + userHamsterOne.Mood);


                //some contitionals to call attention to certain statuses:
                if(userHamsterOne.Boredom<1)
                {
                    userHamsterOne.TooBored();
                }

                if (userHamsterOne.Hunger < 4)
                {
                    Console.WriteLine("Your pet is very hungry!  Why won't you feed it?!");
                }

                if (userHamsterOne.Thirst < 4)
                {
                    Console.WriteLine("Your pet is very thirsty!  Isn't it about time to give it some water?!");
                }

                
                Console.WriteLine("\nChoose an option from the menu to continue: ");
                Console.WriteLine("Type 1 to feed {0}.", userHamsterOne.Name);
                Console.WriteLine("Type 2 to give water to {0}.", userHamsterOne.Name);
                Console.WriteLine("Type 3 to give {0} a toy to play with.", userHamsterOne.Name);
                Console.WriteLine("Type 4 to cuddle with {0} to improve mood.", userHamsterOne.Name);
                Console.WriteLine("Type 5 to quit this program.");
                userMenuInput = int.Parse(Console.ReadLine());
                userHamsterOne.Tick();
                switch (userMenuInput)
                {
                    case 1:
                        Console.WriteLine("Would you like to feed {0} a meal or a snack?", userHamsterOne.Name);
                        string mealChoice = Console.ReadLine().ToLower();
                        userHamsterOne.FeedHamster(mealChoice);
                        break;

                    case 2:
                        userHamsterOne.GiveWater();
                        break;

                    case 3:
                        Console.WriteLine("Please select a toy to play with:  wheel, running ball, ladder");
                        string toyChoice = Console.ReadLine().ToLower();
                        userHamsterOne.HaveFun(toyChoice);

                        break;

                    case 4:
                        userHamsterOne.MoodImprovement();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice!");
                        break;
                }

               
            } while (userMenuInput != 5);






        }
    }
}
