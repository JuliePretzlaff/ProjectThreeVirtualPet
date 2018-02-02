using System;
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
            Console.WriteLine("Hello, please meet your new virtual hamster! Isn't it cute!?  To begin, type in a whole number to find out if your hamster is male or female: ");
            int genderNumber = int.Parse(Console.ReadLine());
         

            //Determining the hamster gender & naming:
            Console.WriteLine(Hamster.GenderSurprise(genderNumber));

            Console.WriteLine("Now, please give your hamster a name: ");
            string nameIt = Console.ReadLine();

            //Creating the new hamster instance:
            Hamster userHamsterOne = new Hamster(nameIt);

            //Menu discription and access:
            Console.WriteLine("Great name!  Now let's begin!  Below you will see the current status of your hamster. \nAll hamster conditions are based on a scale of 1-10.  \nThe higher the value, the more satisfied {0} is.  \nThe lower the value, the less satisfied {0}, and might be need of your attention!", userHamsterOne.Name);

            int userMenuInput;
            do
            {
                Console.WriteLine("Current status of " + userHamsterOne.Name + ": ");
                Console.WriteLine("Hunger: " + userHamsterOne.Hunger);
                Console.WriteLine("Thirst: " + userHamsterOne.Thirst);
                Console.WriteLine("Boredom: " + userHamsterOne.Boredom);
                Console.WriteLine("Mood: " + userHamsterOne.Mood);
                Console.WriteLine("Choose an option from the menu to continue: ");
                Console.WriteLine("Type 1 to feed {0}.", userHamsterOne.Name);
                Console.WriteLine("Type 2 to give water to {0}.", userHamsterOne.Name);
                Console.WriteLine("Type 3 to give {0} a toy to play with.", userHamsterOne.Name);
                Console.WriteLine("Type 4 to cuddle with {0} to improve mood.", userHamsterOne.Name);
                Console.WriteLine("Type 5 to quit this program.");
                userMenuInput = int.Parse(Console.ReadLine());

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
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice!");
                        break;
                }
            } while (userMenuInput != 5);






        }
    }
}
