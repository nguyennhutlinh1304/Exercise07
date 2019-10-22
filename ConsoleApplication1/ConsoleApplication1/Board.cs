using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Board
    {
        private int G1, G2, G3;
        public Board(int group1, int group2, int group3)
        {
            G1 = group1;
            G2 = group2;
            G3 = group3;

        }
        public void Pickball(int group, int balls)
        {
            switch (group)
            {
                case 1:
                    G1 -= balls;
                    break;
                case 2:
                    G2 -= balls;
                    break;
                case 3:
                    G3 -= balls;
                    break;

            }
        }
        
        public void PrintGame()
        {
            Console.Write("Group 1:");
            for (int i = 0; i <G1; i++)
            {
                Console.Write("0");

            }
            Console.WriteLine();
            Console.Write("Gourp 2:");
            for (int i = 0; i <G2; i++)
            {
                Console.Write("0");

            }
            Console.WriteLine();
            Console.Write("Gourp 3:");
            for (int i = 0; i <G3; i++);
            {
                Console.Write("0");
            }
            Console.WriteLine();
        }
        public bool IsGameOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
                return true;
            else
                return false;
        }
    }
}
