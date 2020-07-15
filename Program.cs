using System;

namespace Rock__Paper__Scissors
{
    class Program
    {


        static void Main(string[] args)
        {
            string input_player, input_cpu;
            int random_int;
            string quit;
            bool play_again = true;

            while (play_again)
            {
                int score_cpu = 0, score_player = 0;

                while (score_player < 3 && score_cpu < 3)
                {

                    Console.WriteLine("Enter first character R:ROCK, P:PAPER and S:SCISSORS");
                    Console.WriteLine("(R) ROCK");
                    Console.WriteLine("(P) PAPER");
                    Console.WriteLine("(S) SCISSORS");
                    Console.Write(":");
                    input_player = Console.ReadLine().ToUpper();

                    Random rnd = new Random();
                    random_int = rnd.Next(1, 4);

                    if (input_player == "R" || input_player == "S" || input_player == "P")
                    {
                        switch (random_int)
                        {
                            case 1:
                                input_cpu = "ROCK";
                                Console.WriteLine("Computer chose ROCK");
                                if (input_player == "R")
                                {
                                    Console.WriteLine("DRAW!!!\n\n");
                                    score_cpu += 1;
                                    score_player += 1;
                                }
                                else if (input_player == "P")
                                {
                                    Console.WriteLine("PLAYER WINS!!!\n\n");
                                    score_player += 1;
                                }
                                else if (input_player == "S")
                                {
                                    Console.WriteLine("COMPUTER WINS!!!\n\n");
                                    score_cpu += 1;
                                }
                                break;
                            case 2:
                                input_cpu = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                if (input_player == "R")
                                {
                                    Console.WriteLine("COMPUTER WINS!!!\n\n");
                                    score_cpu += 1;

                                }
                                else if (input_player == "P")
                                {
                                    Console.WriteLine("DRAW!!!\n\n");
                                    score_cpu += 1;
                                    score_player += 1;
                                }
                                else if (input_player == "S")
                                {
                                    Console.WriteLine("PLAYER WINS!!!\n\n");
                                    score_player += 1;
                                }
                                break;
                            case 3:
                                input_cpu = "SCISSORS";
                                Console.WriteLine("Computer chose SCISSORS");
                                if (input_player == "R")
                                {
                                    Console.WriteLine("PLAYER WINS!!!\n\n");
                                    score_player += 1;
                                }
                                else if (input_player == "P")
                                {
                                    Console.WriteLine("COMPUTER WINS!!!\n\n");
                                    score_cpu += 1;
                                }
                                else if (input_player == "S")
                                {
                                    Console.WriteLine("DRAW!!!\n\n");
                                    score_cpu += 1;
                                    score_player += 1;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid entry.!!!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry.!!!\n\n");
                    }
                }
                if (score_player == 3)
                {
                    Console.WriteLine("CONGRATULATION YOU ARE THE WINNER!!!");
                    Console.WriteLine($"Score Player:{score_player}");
                    Console.WriteLine($"Score Computer:{score_cpu}");
                }
                else if (score_player == score_cpu)
                {
                    Console.WriteLine("PLAYER & COMPUTER DRAW!!!");
                    Console.WriteLine($"Score Player:{score_player}");
                    Console.WriteLine($"Score Computer:{score_cpu}");

                }
                else
                {
                    Console.WriteLine("COMPUTER IS THE WINNER!!!");
                    Console.WriteLine($"Score Player:{score_player}");
                    Console.WriteLine($"Score Computer:{score_cpu}");
                }

                Console.Write("\n\nDo you want to play again?(y/n):");
                quit = Console.ReadLine();

                if (quit == "n" || quit == "N")
                {
                    Console.WriteLine("Thank you for playing...The End.");
                    play_again = false;
                }
                else
                    Console.Clear();

            }
            Console.ReadKey();
        }
    }
}
