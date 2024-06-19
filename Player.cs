using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public PlayerChoice GetChoice()
        {
            while (true)
            {
                Console.WriteLine(Name + " - Rock, Paper, Scissors?\n");
                string choice = Console.ReadLine().ToLower();

                if (Enum.TryParse<PlayerChoice>(choice, true, out PlayerChoice playerChoice))
                {
                    return playerChoice;
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again\n");
                }
            }
        }
    }
}
