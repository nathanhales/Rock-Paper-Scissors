using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class ScoreKeeper
    {

        private int _player1Wins = 0;
        private int _player2Wins = 0;
        private int _draw = 0;
        private string _p1Name = "Player 1";
        private string _p2Name = "Player 2";

        public string p1Name
        {
            get { return _p1Name; }
            set { _p1Name = value; }
        }

        public string p2Name
        {
            get { return _p2Name; }
            set { _p2Name = value; }
        }

        public void UpdateScore(int winner)
        {
            if (winner == 0)
            {
                _draw++;
            }
            else if (winner == 1)
            {
                _player1Wins++;
            }
            else
            {
                _player2Wins++;
            }
        }

        public int P1Wins
        {
            get { return _player1Wins; }
            set { _player1Wins++; }
        }
        public int P2Wins
        {
            get { return _player2Wins; }
            set { _player2Wins++; }
        }
        public int Draw
        {
            get { return _draw; }
            set { _draw++; }
        }

        public void ShowScoreBoard()
        {
            Console.WriteLine("----- SCORE -----\n");
            Console.WriteLine($"{_p1Name}: {_player1Wins}");
            Console.WriteLine($"{_p2Name}: {_player2Wins}");
            Console.WriteLine($"Draw: {_draw}");
        }

    }
}