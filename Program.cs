using System;
using System.Collections;
using System.Security.Cryptography;

namespace _221StarterCode
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variable Declarations
            int UserChoice;
            Random r = new Random();
            int OpponentChoice = r.Next(1, 4);
            //
            Console.WriteLine("Let's Play ... Rock, Paper, Scissors ");
            Console.WriteLine("To move throughout console, Press ENTER to continue...");
            Console.ReadKey();
            //Menu Options
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Start a New Game");
            Console.WriteLine("2. End");
            string input = Console.ReadLine();
            if (int.TryParse(input, out UserChoice))
            {

                switch (UserChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Choose your Weapon");
                        Console.WriteLine("1. Rock");
                        Console.WriteLine("2. Paper");
                        Console.WriteLine("3. Scissors");
                        UserChoice = int.Parse(Console.ReadLine());
                        switch (UserChoice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("You chose Rock");
                                if (OpponentChoice == 1)
                                {
                                    Console.WriteLine("Opponent Chose Rock");
                                    Console.WriteLine("Tie");
                                }
                                else if (OpponentChoice == 2)
                                {
                                    Console.WriteLine("Opponent Chose Paper");
                                    Console.WriteLine("Opponent Wins");
                                }
                                else if (OpponentChoice == 3)
                                {
                                    Console.WriteLine("Opponent Chose Scissors");
                                    Console.WriteLine("You Win!");
                                }
                                Environment.Exit(0);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("You chose Paper");
                                if (OpponentChoice == 1)
                                {
                                    Console.WriteLine("Opponent Chose Rock");
                                    Console.WriteLine("You Win!");
                                }
                                else if (OpponentChoice == 2)
                                {
                                    Console.WriteLine("Opponent Chose Paper");
                                    Console.WriteLine("Tie");
                                }
                                else if (OpponentChoice == 3)
                                {
                                    Console.WriteLine("Opponent Chose Scissors");
                                    Console.WriteLine("Opponent Wins");
                                }
                                Environment.Exit(0);
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("You chose Scissors");
                                if (OpponentChoice == 1)
                                {
                                    Console.WriteLine("Opponent Chose Rock");
                                    Console.WriteLine("Opponent Wins");
                                }
                                else if (OpponentChoice == 2)
                                {
                                    Console.WriteLine("Opponent Chose Paper");
                                    Console.WriteLine("You Win!");
                                }
                                else if (OpponentChoice == 3)
                                {
                                    Console.WriteLine("Opponent Chose Scissors");
                                    Console.WriteLine("Tie");
                                }
                                Environment.Exit(0);
                                break;
                            default:
                                if (UserChoice != 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input//Press any key to exit...");
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input//Press any key to exit...");
                                    Environment.Exit(0);
                                }

                                break;
                        }
            
                        break;
                    case 2:
                        Environment.Exit(0);
                        Console.Clear();
                        break;
                    default:
                        if (UserChoice != 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Input");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Invalid Input");
                            Environment.Exit(0);
                        }
                        break;
                }
            }
           else 
            {
                //Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
            }

                }

        }
    }

