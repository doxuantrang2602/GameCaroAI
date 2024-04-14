using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaroAI.Classes
{
    public class RandomAI
    {
        private string[,] board;
        private Random random;
        public RandomAI(string[,] board)
        {
            this.board = board;
            this.random = new Random();
        }

        public int[] GetRandomMove()
        {
            List<int[]> availableMoves = new List<int[]>();
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        availableMoves.Add(new int[] { i, j });
                    }
                }
            }

            if (availableMoves.Count == 0)
            {
                return null;
            }

            int moveIndex = random.Next(availableMoves.Count);
            return availableMoves[moveIndex];
        }
    }
}
