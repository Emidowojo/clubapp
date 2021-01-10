using System;

namespace Clubapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int personOneage = 0;
            Console.Write("Welcome to Incongurous Christiana, how old are you?: " );
            personOneage = int.Parse(Console.ReadLine());
            if(personOneage >= 18)
            {
                Console.WriteLine("Youre old enough to drink here! ");
            }
            else if (personOneage<= 11)
            {
                Console.WriteLine("You shouldn't be here!");
            }
            else
            {
                Console.WriteLine("You're too young to be here, Please leave");
            }

            int personTwoage = 0;
            Console.Write("Hi Susan, how old are you?: " );
            personTwoage = int.Parse(Console.ReadLine());
            if(personTwoage >= 18)
            {
                Console.WriteLine("Welcome to Incongurous, what can i get you?: ");
            }
            else if (personTwoage<= 11)
            {
                Console.WriteLine("You shouldn't be here!");
            }
            else
            {
                Console.WriteLine("You're too young to be here, Please leave");
            }

            int personThreeage = 0;
            Console.Write("Hi Jael, how old are you?: " );
            personThreeage = int.Parse(Console.ReadLine());
            if(personThreeage >= 18)
            {
                Console.WriteLine("Welcome to Incongurous, what can i get you?: ");
            }
            else if (personThreeage<= 11)
            {
                Console.WriteLine("You shouldn't be here!");
            }
            else
            {
                Console.WriteLine("You're too young to be here, Please leave");
            }
        }
    }
}
