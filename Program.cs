using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {

            void categorise(animal[] allAnimalz, string category, string HasTail)
            {

                ArrayList names = new ArrayList();

                for (int a = 0; a < allAnimalz.Length; a++)
                {

                    if (allAnimalz[a].Category.Equals(category))
                    {
                        names.Add(allAnimalz[a].AnimalName);
                        if (HasTail.Equals("Yes") && allAnimalz[a].Tail.Equals("No"))
                        {
                            names.Remove(allAnimalz[a].AnimalName);
                        }
                        if (HasTail.Equals("No") && allAnimalz[a].Tail.Equals("Yes"))
                        {
                            names.Remove(allAnimalz[a].AnimalName);
                        }
                    }
                }
                Console.WriteLine("Based on your selections, here are your {0}s:", category);
                foreach (object obj in names)
                {
                    Console.WriteLine(obj);
                }

            }

            //Initialize all animals as an object with 3 attributes: Name ,Category, Tail: Yes/No
            animal Baboon = new animal("Baboon", "Primate", "Yes");
            animal Chimpanzee = new animal("Chimpanzee", "Primate", "Yes");
            animal Crocodile = new animal("Crocodile", "Reptile", "Yes");
            animal Hippopotamus = new animal("Hippopotamus", "Mammal", "Yes");
            animal Snake = new animal("Snake", "Reptile", "No");
            animal Lion = new animal("Lion", "Mammal", "Yes");
            animal Zebra = new animal("Zebra", "Mammal", "Yes");
            animal Cheetah = new animal("Cheetah", "Mammal", "Yes");
            animal Gorilla = new animal("Gorilla", "Primate", "No");
            animal Giraffe = new animal("Giraffe", "Mammal", "Yes");
            animal Lizard = new animal("Lizard", "Reptile", "Yes");

            //Array containing all animals
            animal[] allAnimals = new animal[] {Baboon, Chimpanzee, Crocodile, Hippopotamus, Snake, Lion, Zebra, Cheetah,
            Gorilla, Giraffe, Lizard};


        start:
            //User Input

            //Obtaining string variable for categories Mammal, Primate, Reptile.
            Console.WriteLine("What category are you interested in?");
            Console.WriteLine("1. Mammals");
            Console.WriteLine("2. Primates");
            Console.WriteLine("3. Reptiles");
            string strCategory = "";
        category:
            bool success = int.TryParse(Console.ReadLine(), out int intCategory);
            if (success && intCategory > 0 && intCategory < 4)
            {
                switch (intCategory)
                {
                    case 1:
                        strCategory = "Mammal";
                        break;
                    case 2:
                        strCategory = "Primate";
                        break;
                    case 3:
                        strCategory = "Reptile";
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again:");
                goto category;
            }


            Console.WriteLine("Would you like to see animals with tails or without?");
            Console.WriteLine("1. With");
            Console.WriteLine("2. Without");
            Console.WriteLine("3. Both");

            //Obtaining string variable for tails, option to search for both tails & no tails is provided. 
            string strTail = "";
        tail:
            bool success1 = int.TryParse(Console.ReadLine(), out int intTail);
            if (success && intTail > 0 && intTail < 4)
            {
                switch (intTail)
                {
                    case 1:
                        strTail = "Yes";
                        break;
                    case 2:
                        strTail = "No";
                        break;
                    case 3:
                        strTail = "Both";
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again:");
                goto tail;
            }
            //Function to categorise as stated
            categorise(allAnimals, strCategory, strTail);

            //Final Prompt
            Console.WriteLine("Would you like to search again? Y/N");
            string response = Console.ReadLine();
            if (!response.Equals("Y") && !response.Equals("N"))
            {
                Console.WriteLine("Invalid Input");
            }
            else if (response.Equals("Y"))
            {
                Console.Clear();
                goto start;
            }
            else if (response.Equals("N"))
            {
                Console.WriteLine("Press any key to end program.");
            }


            Console.Read();
        }
    }
}
