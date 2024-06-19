

namespace Rock_Paper_Scissors
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame PlayGame = new RockPaperScissorsGame();
            PlayGame.Run();
        }

    }
    
}

enum PlayerChoice { Rock, Paper, Scissors }
