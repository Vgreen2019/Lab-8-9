

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> index = new List<int>() { 1, 2, 3 };
            IList<string> name = new List<string>() { "Victoria", "Tyson", "Patrik" };
            IList<string> favFood = new List<string>() { "Mac n' Cheese", "Chicken Stew", "Ice Cream" };
            IList<string> hometown = new List<string>() { "Highland Park", "Detroit", "Westland" };

            Console.WriteLine("Welcome to our C# class.  Which student would you like to learn more about? \n (To choose a student enter a corresponding number 1-3) \n");
            Console.WriteLine("1) Victoria");
            Console.WriteLine("2) Tyson");
            Console.WriteLine("3) Patrik \n");


            while (true)
            {
                int response = int.Parse(Console.ReadLine());
                 

                switch (response)
                {
                    case 1:
                        if (index.Contains(1))
                        {

                            Console.WriteLine($"\n Student {response} is {name[0]}. What would you like to know? ");

                            while (true)
                            {
                                Console.WriteLine("\n 1) Hometown \n 2) Favorite Food");

                                int response3 = int.Parse(Console.ReadLine());

                                if (response3 == 1)
                                {
                                    Console.WriteLine($"\nHometown: {hometown[0]} \n");
                                    Console.WriteLine("Anything else? (Yes/No)");

                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else if (response3 == 2)
                                {
                                    Console.WriteLine($"\nFavorite Food: {favFood[0]}");
                                    Console.WriteLine("Anything else? (Yes/No)");

                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("That data does not exist.  Please try again.");
                                    Console.WriteLine("\n 1) Hometown \n 2) Favorite Food");
                                    string response4 = Console.ReadLine();

                                    if(response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                ;
                            }

                            Console.WriteLine("Would you like to learn more about another student? (Yes/No)");
                            string response2 = Console.ReadLine();

                            if (response2 == "yes" | response2 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nPlease choose another student... \n (To choose a student enter a corresponding number 1-3) \n");
                                Console.WriteLine("1) Victoria");
                                Console.WriteLine("2) Tyson");
                                Console.WriteLine("3) Patrik \n");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nGood Bye");
                                Environment.Exit(0);

                            }

                        }
                        break;

                    case 2:
                        if (index.Contains(1))
                        {

                            Console.WriteLine($"\n Student {response} is {name[1]}. What would you like to know? ");

                            while (true)
                            {
                                Console.WriteLine("\n 1) Hometown \n 2) Favorite Food");

                                int response3 = int.Parse(Console.ReadLine());

                                if (response3 == 1)
                                {
                                    Console.WriteLine($"\nHometown: {hometown[1]} \n");
                                    Console.WriteLine("Anything else? (Yes/No)");

                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else if (response3 == 2)
                                {
                                    Console.WriteLine($"\nFavorite Food: {favFood[1]}");
                                    Console.WriteLine("Anything else? (Yes/No)");

                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("That data does not exist.  Please try again.");
                                    Console.WriteLine("\n 1) Hometown \n 2) Favorite Food");
                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                ;
                            }

                            Console.WriteLine("Would you like to learn more about another student? (Yes/No)");
                            string response2 = Console.ReadLine();

                            if (response2 == "yes" | response2 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nPlease choose another student... \n (To choose a student enter a corresponding number 1-3) \n");
                                Console.WriteLine("1) Victoria");
                                Console.WriteLine("2) Tyson");
                                Console.WriteLine("3) Patrik \n");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nGood Bye");
                                Environment.Exit(0);

                            }

                        }
                        break;

                    case 3:
                        if (index.Contains(1))
                        {

                            Console.WriteLine($"\n Student {response} is {name[2]}. What would you like to know? ");

                            while (true)
                            {
                                Console.WriteLine("\n 1) Hometown \n 2) Favorite Food");

                                int response3 = int.Parse(Console.ReadLine());

                                if (response3 == 1)
                                {
                                    Console.WriteLine($"\nHometown: {hometown[2]} \n");
                                    Console.WriteLine("Anything else? (Yes/No)");

                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else if (response3 == 2)
                                {
                                    Console.WriteLine($"\nFavorite Food: {favFood[2]}");
                                    Console.WriteLine("Anything else? (Yes/No)");

                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("That data does not exist.  Please try again.");
                                    Console.WriteLine("\n 1) Hometown \n 2) Favorite Food");
                                    string response4 = Console.ReadLine();

                                    if (response4 == "yes" | response4 == "Yes")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                ;
                            }

                            Console.WriteLine("Would you like to learn more about another student? (Yes/No)");
                            string response2 = Console.ReadLine();

                            if (response2 == "yes" | response2 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("\nPlease choose another student... \n (To choose a student enter a corresponding number 1-3) \n");
                                Console.WriteLine("1) Victoria");
                                Console.WriteLine("2) Tyson");
                                Console.WriteLine("3) Patrik \n");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nBye Bye!");
                                Environment.Exit(0);

                            }

                        }
                        break;

                    default:
                        Console.WriteLine("\nThat student does not exist.  Please try again. (enter a number 1-3):");
                        break;

                }



            }
        }


    }
}
