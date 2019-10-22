using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Viet");
            P2 = new Player("Hao");
            Game = new Board(3, 4, 6);

        }
        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                Console.WriteLine(P1.GetName() + "'a turn");
                P1.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + "loses");
                    Console.WriteLine(P1.GetName() + "wins");
                    break;

                }
                Console.WriteLine(P2.GetName() + "' a turn");
                P2.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() + " loses");
                    Console.WriteLine(P1.GetName() + "wins");
                    break;
                }
            }
        }





    }
}
