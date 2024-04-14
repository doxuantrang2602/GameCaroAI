using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCaroAI.Classes;
using System.Windows.Forms;

namespace GameCaroAI.Option
{
    public class AlphaBetaAI
    {
        public string[,] board;
        public int maxDepth;
        public const string AI_PEICE = "0";
        public const string PLAYER_PEICE = "X";

        public AlphaBetaAI(string[,] board, int maxDepth)
        {
            this.board = board;
            this.maxDepth = maxDepth;
        }
        public int[] findBestMove()
        {
            int[] bestMove = new int[2];
            int bestScore = int.MinValue;
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        board[i, j] = AI_PEICE;
                        int score = Minimax(board, 0, false);
                        board[i, j] = null;
                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove[0] = i;
                            bestMove[1] = j;
                        }
                    }
                }
            }
            return bestMove;
        }

        public int Minimax(string[,] board, int depth, bool isMaximizing)
        {
            if (depth == maxDepth || IsGameOver(board))
            {
                return Evaluate(board, AI_PEICE);
            }
            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
                {
                    for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                    {
                        if (board[i, j] == null)
                        {
                            board[i, j] = AI_PEICE;
                            int score = Minimax(board, depth + 1, false);
                            board[i, j] = null;
                            bestScore = Math.Max(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
                {
                    for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                    {
                        if (board[i, j] == null)
                        {
                            board[i, j] = PLAYER_PEICE;
                            int score = Minimax(board, depth + 1, true);
                            board[i, j] = null;
                            bestScore = Math.Min(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
        }
        public int Evaluate(string[,] board, string player)
        {
            int score = 0;

            // Đánh giá các hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH - 5; j++)
                {
                    score += EvaluateLine(board, player, i, j, 0, 1); // Hàng ngang
                }
            }

            // Đánh giá các hàng dọc
            for (int i = 0; i <= Helpers.CHESS_BOARD_HEIGHT - 5; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    score += EvaluateLine(board, player, i, j, 1, 0); // Hàng dọc
                }
            }

            // Đánh giá các đường chéo chính
            for (int i = 0; i <= Helpers.CHESS_BOARD_HEIGHT - 5; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH - 5; j++)
                {
                    score += EvaluateLine(board, player, i, j, 1, 1); // Đường chéo chính
                }
            }

            // Đánh giá các đường chéo phụ
            for (int i = 4; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH - 5; j++)
                {
                    score += EvaluateLine(board, player, i, j, -1, 1); // Đường chéo phụ
                }
            }

            return score;
        }

        // Hàm đánh giá cho từng dãy liên tiếp
        public int EvaluateLine(string[,] board, string player, int row, int col, int dRow, int dCol)
        {
            int score = 0;
            int playerCount = 0; // Số lượng ô đã được chiếm bởi người chơi hiện tại
            int opponentCount = 0; // Số lượng ô đã được chiếm bởi đối thủ

            for (int i = 0; i < 5; i++)
            {
                int r = row + i * dRow;
                int c = col + i * dCol;

                // Đếm số lượng ô đã được chiếm bởi người chơi và đối thủ
                if (board[r, c] == player)
                    playerCount++;
                else if (board[r, c] != null)
                    opponentCount++;
            }

            // Kiểm tra chuỗi 4 không bị chặn 2 đầu
            bool isOpenFour = IsOpenFour(board, row, col, player);
            // Kiểm tra chuỗi 3 không bị chặn 2 đầu
            bool isOpenThree = IsOpenThree(board, row, col, player);
            // Kiểm tra chuỗi 2 không bị chặn 2 đầu
            bool isOpenTwo = IsOpenTwo(board, row, col, player);

            // Đánh giá trường hợp chiến thắng
            if (playerCount == 5)
                score += 1000000;
            else if (playerCount == 4 && opponentCount == 0)
            {
                if (isOpenFour)
                    score += 25000; // Trả về 500 cho dãy 4 mở một đầu
                else
                    score += 10000; // Trả về 10000 cho dãy 4 đóng
            }
            else if (playerCount == 3 && opponentCount == 0)
            {
                if (IsOpenThree(board, row, col, player))
                    score += 2000; // Trả về 200 cho dãy 3 mở hai đầu
                else
                    score += 1000; // Trả về 1000 cho dãy 3 đóng
            }
            else if (playerCount == 2 && opponentCount == 0)
            {
                if (isOpenTwo)
                    score += 100; // Trả về 100 cho dãy 2 mở hai đầu
                else
                    score += 100; // Trả về 100 cho dãy 2 đóng
            }
            else if (playerCount == 1 && opponentCount == 0)
                score += 10; // Trả về 10 cho dãy 1

            // Ngăn chặn đối thủ
            if (opponentCount == 4 && playerCount == 0)
            {
                if (isOpenFour)
                    score += -100000; // Trừ 500 cho dãy 4 mở một đầu của đối thủ
                else
                    score += -100000; // Trừ 10000 cho dãy 4 đóng của đối thủ
            }
            else if (opponentCount == 3 && playerCount == 0)
            {
                if (IsOpenThree(board, row, col, player))
                    score += -2000; // Trừ 200 cho dãy 3 mở hai đầu của đối thủ
                else
                    score += -1000; // Trừ 1000 cho dãy 3 đóng của đối thủ
            }
            else if (opponentCount == 2 && playerCount == 0)
            {
                if (isOpenTwo)
                    score += -100; // Trừ 100 cho dãy 2 mở hai đầu của đối thủ
                else
                    score += -100; // Trừ 100 cho dãy 2 đóng của đối thủ
            }
            else if (opponentCount == 1 && playerCount == 0)
                score += -10; // Trừ 10 cho dãy 1 của đối thủ

            return score;
        }

        public bool IsOpenFour(string[,] board, int row, int col, string player)
        {
            // Kiểm tra theo hàng ngang
            int horizontalCount = 0;
            for (int i = col; i < col + 5; i++)
            {
                if (i >= Helpers.CHESS_BOARD_WIDTH || (board[row, i] != null && board[row, i] != player))
                {
                    break;
                }
                horizontalCount++;
            }
            if (horizontalCount == 4 && (col == 0 || (col + 5 < Helpers.CHESS_BOARD_WIDTH && board[row, col - 1] != player) || (col + 5 == Helpers.CHESS_BOARD_WIDTH)))
            {
                return true;
            }

            // Kiểm tra theo hàng dọc
            int verticalCount = 0;
            for (int i = row; i < row + 5; i++)
            {
                if (i >= Helpers.CHESS_BOARD_HEIGHT || (board[i, col] != null && board[i, col] != player))
                {
                    break;
                }
                verticalCount++;
            }
            if (verticalCount == 4 && (row == 0 || (row + 5 < Helpers.CHESS_BOARD_HEIGHT && board[row - 1, col] != player) || (row + 5 == Helpers.CHESS_BOARD_HEIGHT)))
            {
                return true;
            }

            // Kiểm tra theo đường chéo chính
            int diagonalCount = 0;
            for (int i = 0; i < 5; i++)
            {
                int r = row + i;
                int c = col + i;
                if (r >= Helpers.CHESS_BOARD_HEIGHT || c >= Helpers.CHESS_BOARD_WIDTH || (board[r, c] != null && board[r, c] != player))
                {
                    break;
                }
                diagonalCount++;
            }
            if (diagonalCount == 4 &&
                ((row == 0 && col == 0) ||
                (row + 5 < Helpers.CHESS_BOARD_HEIGHT && col + 5 < Helpers.CHESS_BOARD_WIDTH &&
                (row - 1 >= 0 && col - 1 >= 0 && board[row - 1, col - 1] != player)) ||
                (row + 5 == Helpers.CHESS_BOARD_HEIGHT && col + 5 == Helpers.CHESS_BOARD_WIDTH)))
            {
                return true;
            }

            // Kiểm tra theo đường chéo phụ
            int reverseDiagonalCount = 0;
            for (int i = 0; i < 5; i++)
            {
                int r = row + i;
                int c = col - i;
                if (r >= Helpers.CHESS_BOARD_HEIGHT || c < 0 || (board[r, c] != null && board[r, c] != player))
                {
                    break;
                }
                reverseDiagonalCount++;
            }
            if (reverseDiagonalCount == 4 &&
                ((row == 0 && col == Helpers.CHESS_BOARD_WIDTH - 1) ||
                (row + 5 < Helpers.CHESS_BOARD_HEIGHT && col - 5 >= 0 &&
                (row - 1 >= 0 && col + 1 < Helpers.CHESS_BOARD_WIDTH && board[row - 1, col + 1] != player)) ||
                (row + 5 == Helpers.CHESS_BOARD_HEIGHT && col - 5 == -1)))
            {
                return true;
            }

            return false;
        }
        public bool IsOpenThree(string[,] board, int row, int col, string player)
        {
            // Kiểm tra theo hàng ngang
            int horizontalCount = 0;
            for (int i = col; i < col + 4; i++)
            {
                if (i >= Helpers.CHESS_BOARD_WIDTH || (board[row, i] != null && board[row, i] != player))
                {
                    break;
                }
                horizontalCount++;
            }
            if (horizontalCount == 3 && ((col == 0 || (col + 4 < Helpers.CHESS_BOARD_WIDTH && board[row, col - 1] != player)) || (col + 4 == Helpers.CHESS_BOARD_WIDTH && board[row, col + 3] != player)))
            {
                return true;
            }

            // Kiểm tra theo hàng dọc
            int verticalCount = 0;
            for (int i = row; i < row + 4; i++)
            {
                if (i >= Helpers.CHESS_BOARD_HEIGHT || (board[i, col] != null && board[i, col] != player))
                {
                    break;
                }
                verticalCount++;
            }
            if (verticalCount == 3 && ((row == 0 || (row + 4 < Helpers.CHESS_BOARD_HEIGHT && board[row - 1, col] != player)) || (row + 4 == Helpers.CHESS_BOARD_HEIGHT && board[row + 3, col] != player)))
            {
                return true;
            }

            // Kiểm tra theo đường chéo chính
            int diagonalCount = 0;
            for (int i = 0; i < 4; i++)
            {
                int r = row + i;
                int c = col + i;
                if (r >= Helpers.CHESS_BOARD_HEIGHT || c >= Helpers.CHESS_BOARD_WIDTH || (board[r, c] != null && board[r, c] != player))
                {
                    break;
                }
                diagonalCount++;
            }
            if (diagonalCount == 3 &&
                ((row == 0 && col == 0) ||
                (row + 4 < Helpers.CHESS_BOARD_HEIGHT && col + 4 < Helpers.CHESS_BOARD_WIDTH &&
                (row - 1 >= 0 && col - 1 >= 0 && board[row - 1, col - 1] != player)) ||
                (row + 4 == Helpers.CHESS_BOARD_HEIGHT && col + 4 == Helpers.CHESS_BOARD_WIDTH)))
            {
                return true;
            }


            // Kiểm tra theo đường chéo phụ
            int reverseDiagonalCount = 0;
            for (int i = 0; i < 4; i++)
            {
                int r = row + i;
                int c = col - i;
                if (r >= Helpers.CHESS_BOARD_HEIGHT || c < 0 || (board[r, c] != null && board[r, c] != player))
                {
                    break;
                }
                reverseDiagonalCount++;
            }
            if (reverseDiagonalCount == 3 && ((row == 0 && col == Helpers.CHESS_BOARD_WIDTH - 1) || (row + 4 < Helpers.CHESS_BOARD_HEIGHT && col - 4 >= 0 && board[row + 4, col - 4] != player) || (row + 4 == Helpers.CHESS_BOARD_HEIGHT && col - 4 >= 0 && board[row + 4, col - 4] != player) || (row - 1 >= 0 && col + 1 < Helpers.CHESS_BOARD_WIDTH && board[row - 1, col + 1] != player)))

            {
                return true;
            }

            return false;
        }
        public bool IsOpenTwo(string[,] board, int row, int col, string player)
        {
            // Kiểm tra theo hàng ngang
            int horizontalCount = 0;
            for (int i = col; i < col + 3; i++)
            {
                if (i >= Helpers.CHESS_BOARD_WIDTH || (board[row, i] != null && board[row, i] != player))
                {
                    break;
                }
                horizontalCount++;
            }
            if (horizontalCount == 2 && ((col == 0 || (col + 3 < Helpers.CHESS_BOARD_WIDTH && board[row, col - 1] != player)) || (col + 3 == Helpers.CHESS_BOARD_WIDTH && board[row, col + 2] != player)))
            {
                return true;
            }

            // Kiểm tra theo hàng dọc
            int verticalCount = 0;
            for (int i = row; i < row + 3; i++)
            {
                if (i >= Helpers.CHESS_BOARD_HEIGHT || (board[i, col] != null && board[i, col] != player))
                {
                    break;
                }
                verticalCount++;
            }
            if (verticalCount == 2 && ((row == 0 || (row + 3 < Helpers.CHESS_BOARD_HEIGHT && board[row - 1, col] != player)) || (row + 3 == Helpers.CHESS_BOARD_HEIGHT && board[row + 2, col] != player)))
            {
                return true;
            }

            // Kiểm tra theo đường chéo chính
            int diagonalCount = 0;
            for (int i = 0; i < 3; i++)
            {
                int r = row + i;
                int c = col + i;
                if (r >= Helpers.CHESS_BOARD_HEIGHT || c >= Helpers.CHESS_BOARD_WIDTH || (board[r, c] != null && board[r, c] != player))
                {
                    break;
                }
                diagonalCount++;
            }
            if (diagonalCount == 2 &&
                ((row == 0 && col == 0) ||
                (row + 3 < Helpers.CHESS_BOARD_HEIGHT && col + 3 < Helpers.CHESS_BOARD_WIDTH &&
                (row - 1 >= 0 && col - 1 >= 0 && board[row - 1, col - 1] != player)) ||
                (row + 3 == Helpers.CHESS_BOARD_HEIGHT && col + 3 == Helpers.CHESS_BOARD_WIDTH)))
            {
                return true;
            }


            // Kiểm tra theo đường chéo phụ
            int reverseDiagonalCount = 0;
            for (int i = 0; i < 3; i++)
            {
                int r = row + i;
                int c = col - i;
                if (r >= Helpers.CHESS_BOARD_HEIGHT || c < 0 || (board[r, c] != null && board[r, c] != player))
                {
                    break;
                }
                reverseDiagonalCount++;
            }
            if (reverseDiagonalCount == 2 &&
                ((row == 0 && col == Helpers.CHESS_BOARD_WIDTH - 1) ||
                (row + 3 < Helpers.CHESS_BOARD_HEIGHT && col - 3 >= 0 &&
                (row - 1 >= 0 && col + 1 < Helpers.CHESS_BOARD_WIDTH && board[row - 1, col + 1] != player)) ||
                (row + 3 == Helpers.CHESS_BOARD_HEIGHT && col - 3 == -1)))
            {
                return true;
            }


            return false;
        }

        public bool IsGameOver(string[,] board)
        {
            // Cờ hòa
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        return true;

                    }
                }
            }
            MessageBox.Show("Cờ hòa !");
            return false;
        }
    }
}
