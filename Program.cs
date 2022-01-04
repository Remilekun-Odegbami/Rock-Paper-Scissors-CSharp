using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;


                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("ROCK, PAPER or SCISSORS???");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random random = new Random();

                    randomInt = random.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose Rock");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Wins\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU Wins\n\n ");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU Wins\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER Wins\n\n ");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER Wins\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU Wins\n\n ");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                    Console.WriteLine("Scores: \t Player: {0} \t Computer: {1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Won!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU Won!");
                } else
                {

                }

                Console.WriteLine("Do you want to play again? (Y/N)");
                string loop = Console.ReadLine();
                loop = loop.ToUpper();

                if (loop == "Y")
                {
                    playAgain = true;
                    Console.Clear();

                } else if (loop == "N") {
                    playAgain = false;
                } else
                {
                }
            }
        }
    }
}
