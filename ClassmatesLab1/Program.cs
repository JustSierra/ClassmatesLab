using System;
using System.Collections.Generic;

namespace ClassmatesLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" Who are you intersted in knowing about? Sierra, Jake, Chris, Michael, or Anna?");
            //string input = Console.ReadLine();

            List<string> studentDirectory = new List<string>();

            studentDirectory.Add("Sierra");
            studentDirectory.Add("Jake");
            studentDirectory.Add("Chris");
            studentDirectory.Add("Michael");
            studentDirectory.Add("Anna");

            List<string> birthPlace = new List<string>();

            birthPlace.Add("Philly");
            birthPlace.Add("Boston");
            birthPlace.Add("Detroit");
            birthPlace.Add("Lansing");
            birthPlace.Add("Somewhere");

            List<string> favoriteFood = new List<string>();

            favoriteFood.Add("Baked Macaroni and Cheese");
            favoriteFood.Add("Hibatchi");
            favoriteFood.Add("Burgers");
            favoriteFood.Add("Homade Mac and Cheese");
            favoriteFood.Add("idk");

            bool cont = true;

            while (cont)
            {
                Console.WriteLine(" Who are you intersted in knowing about? Sierra (1) , Jake (2), Chris (3), Michael(4), or Anna(5)?");
                string input = Console.ReadLine().ToLower();

                try
                {
                    int studentNumber = int.Parse(input);

                    Console.WriteLine(studentDirectory[studentNumber - 1]);


                }
                catch (FormatException)
                {
                    for (int i = 0; i < studentDirectory.Count; i++)
                    {
                        if (studentDirectory[i].ToLower() == input)
                        {
                            Console.WriteLine(birthPlace[i], studentDirectory[i]);
                        }


                    }
                   

                }

                for (int i = 0; i < studentDirectory.Count; i++)
                {
                    if (studentDirectory[i].ToLower() == input)
                    {
                        Console.WriteLine(birthPlace[i], studentDirectory[i]);
                    }

                }

                Console.WriteLine("Woud you be intersted in more information on another classmate? y/n");
                string input2 = Console.ReadLine().ToLower();

                if (input2 == "y")
                {
                    cont = true;
                }
                else
                {
                    cont = false;

                }    



            }
           


            
        }
    }
}
