namespace Rock_Paper_Scissors
{
    class RockPaperScissorsGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public ScoreKeeper Score { get; set; }


        public RockPaperScissorsGame()
        {
            Player Player1 = new Player("Player 1");
            Player Player2 = new Player("Player 2");
        }

        public void Run()
        {
            // GAME START

            ScoreKeeper Score = new ScoreKeeper();

            Console.WriteLine("----- ROCK, PAPER, SCISSORS -----\n");
            Console.WriteLine("Player 1, please enter your name... \n");
            string player1Name = Console.ReadLine();
            Player Player1 = new Player(player1Name);
            Score.p1Name = Player1.Name;

            //PLAYER TWO NAME SELECT

            Console.Clear();
            Console.WriteLine("Player 2, please enter your name... \n");
            string player2Name = Console.ReadLine();
            Player Player2 = new Player(player2Name);
            Score.p2Name = Player2.Name;

            Console.Clear();
            Console.WriteLine($"Hello {player1Name} and {player2Name}, lets begin!\n");
            Console.WriteLine("-------- Press ANY KEY to start --------\n");
            Console.ReadKey();
            Console.Clear();

            int player1Wins = Score.P1Wins;
            int player2Wins = Score.P2Wins;

            int DetermineWinner(PlayerChoice choice1, PlayerChoice choice2)
            {
                if (choice1 == choice2)
                {
                    Console.WriteLine("It's a Draw\n");
                    Score.UpdateScore(0);
                    return 0;
                }
                else if (choice1 == PlayerChoice.Rock)
                {
                    if (choice2 == PlayerChoice.Scissors)
                    {
                        Score.UpdateScore(1);
                        Console.WriteLine(player1Name + " Wins!\n");
                    }
                    else
                    {
                        Score.UpdateScore(2);
                        Console.WriteLine(player2Name + " Wins!\n");
                    }
                    return choice2 == PlayerChoice.Scissors ? 1 : 2;
                }
                else if (choice1 == PlayerChoice.Scissors)
                {
                    if (choice2 == PlayerChoice.Paper)
                    {
                        Score.UpdateScore(1);
                        Console.WriteLine(player1Name + " Wins!\n");
                    }
                    else
                    {
                        Score.UpdateScore(2);
                        Console.WriteLine(player2Name + " Wins!\n");
                    }
                    return choice2 == PlayerChoice.Paper ? 1 : 2;
                }
                else
                {
                    Console.WriteLine(player1Name + " Wins!\n");
                    return choice2 == PlayerChoice.Rock ? 1 : 2;
                }
            }
            
                        while (player1Wins != 5 && player2Wins != 5)
                        {
                            PlayerChoice choice1 = Player1.GetChoice();
                            Console.Clear();
                            PlayerChoice choice2 = Player2.GetChoice();
                            Console.Clear();

                            int winner = DetermineWinner(choice1, choice2);

                            if (winner == 1)
                            {
                                player1Wins++;
                            }
                            else if (winner == 2)
                            {
                                player2Wins++;
                            }

                            Score.ShowScoreBoard();
                            Console.WriteLine("\nPress ANY key to Continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
            
        }
    }
}













