using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCaroAI.Classes;
using Guna.UI2.WinForms;

namespace GameCaroAI.GUI
{
    public partial class FrmAI : Form
    {
        public const int MAX_DEPTH = 3;
        public bool isYourTurn = true;
        public bool isComputerTurn = true;
        public int xFirstMoveRow;
        public int xFirstMoveCol;
        public int xCount = 0;
        public int comCount = 0;
        public string[,] board = new string[Helpers.CHESS_BOARD_HEIGHT, Helpers.CHESS_BOARD_WIDTH];
        public const int WIN_SCORE = -10000000;

        public FrmAI()
        {
            InitializeComponent();
            DrawChessBoard();
        }
        public void DrawChessBoard()
        {
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    Guna2ButtonWithPosition btn = new Guna2ButtonWithPosition()
                    {
                        Width = Helpers.CHESS_WIDTH,
                        Height = Helpers.CHESS_HEIGHT,
                        Location = new Point(j * Helpers.CHESS_WIDTH, i * Helpers.CHESS_HEIGHT),
                        BorderThickness = 1,
                        BackColor = Color.White,
                        FillColor = Color.Transparent,
                        Col = j,
                        Row = i
                    };
                    pn_ChessBoard.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn != null && btn.BackgroundImage == null)
            {
                int row = btn.Location.Y / Helpers.CHESS_HEIGHT;
                int col = btn.Location.X / Helpers.CHESS_WIDTH;

                if (isYourTurn)
                {
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\X.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[row, col] = "X";
                    xCount++;
                    lbl_You.Text = "X (You): " + xCount.ToString();
                    if (CheckWinner(row, col))
                    {
                        MessageBox.Show("YOU WINS!");
                        return;
                    }
                    xFirstMoveRow = row;
                    xFirstMoveCol = col;

                    isYourTurn = false;
                    isComputerTurn = true;
                    MachinePlayO();
                }
            }
        }
        public void MachinePlayO()
        {
            if (isComputerTurn)
            {
                // Nước đi đầu
                if (xCount == 1 && comCount == 0)
                {
                    int row, col;

                    // Góc trên cùng bên phải 
                    if (xFirstMoveRow == 0 && xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc dưới bên trái
                        row = xFirstMoveRow + 1;
                        col = xFirstMoveCol - 1;
                    }
                    // Góc dưới cùng bên trái
                    else if (xFirstMoveRow == Helpers.CHESS_BOARD_HEIGHT - 1 && xFirstMoveCol == 0)
                    {
                        // Đánh vào góc trên bên phải 
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Góc trên cùng bên trái của bàn cờ
                    else if (xFirstMoveRow == 0 && xFirstMoveCol == 0)
                    {
                        // Đánh vào góc dưới bên phải
                        row = xFirstMoveRow + 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Góc dưới cùng bên phải
                    else if (xFirstMoveRow == Helpers.CHESS_BOARD_HEIGHT - 1 && xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    // Biên trên cùng bàn cờ
                    else if (xFirstMoveRow == 0)
                    {
                        // Đánh vào góc dưới bên phải
                        row = xFirstMoveRow + 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Biên dưới cùng bàn cờ
                    else if (xFirstMoveRow == Helpers.CHESS_BOARD_HEIGHT - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    // Biên bên trái của bàn cờ
                    else if (xFirstMoveCol == 0)
                    {
                        // Đánh vào góc trên bên phải
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol + 1;
                    }
                    // Biên bên phải của bàn cờ
                    else if (xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    else
                    {
                        // Đánh vào góc chéo trên bên trái của nước đầu tiên của X
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }

                    while (board[row, col] != null)
                    {
                        row++;
                        col++;
                    }
                    UpdateBoard(row, col);
                }
                else
                {
                    int[] move = FindBestMove();
                    int row, col;
                    do
                    {
                        row = move[0];
                        col = move[1];
                    } while (board[row, col] != null);

                    UpdateBoard(row, col);
                }
            }
        }

        public void UpdateBoard(int row, int col)
        {
            foreach (Control c in pn_ChessBoard.Controls)
            {
                if (c is Guna2ButtonWithPosition btn && btn.Row == row && btn.Col == col)
                {
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\O.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[row, col] = "O";
                    comCount++;
                    lbl_Computer.Text = "O (Computer): " + comCount.ToString();
                    if (CheckWinner(row, col))
                    {
                        MessageBox.Show("COMPUTER WINS!");
                        return;
                    }
                    isYourTurn = true;
                    isComputerTurn = false;
                    return;
                }
            }
            MessageBox.Show("Guna2Button not found !");
        }
        public int[] FindBestMove()
        {
            int[] bestMove = new int[2];
            int bestScore = int.MinValue;
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        board[i, j] = "O";
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
            if (depth == MAX_DEPTH || IsGameOver(board))
            {
                return Evaluate(board, "O");
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
                            board[i, j] = "O";
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
                        board[i, j] = "X";
                        int score = Minimax(board, depth + 1, true);
                        board[i, j] = null;
                        bestScore = Math.Min(score, bestScore);
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

            // Đánh giá trường hợp chiến thắng
            if (playerCount == 5)
                score += 1000000;
            else if (playerCount == 4 && opponentCount == 0)
                score += 10000;
            else if (playerCount == 3 && opponentCount == 0)
                score += 1000;
            else if (playerCount == 2 && opponentCount == 0)
                score += 100;
            else if (playerCount == 1 && opponentCount == 0)
                score += 10;

            // Ngăn chặn đối thủ
            if (opponentCount == 4 && playerCount == 0)
                score -= 10000;
            else if (opponentCount == 3 && playerCount == 0)
                score -= 1000;
            else if (opponentCount == 2 && playerCount == 0)
                score -= 100;
            else if (opponentCount == 1 && playerCount == 0)
                score -= 10;

            return score;
        }



        private bool IsGameOver(string[,] board)
        {
            // Kiểm tra bàn cờ đầy
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
        public bool CheckWinner(int row, int col)
        {
            string player = isYourTurn ? "X" : "O";

            // Kiểm tra hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_WIDTH - 4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[row, i + j] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra hàng dọc
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT - 4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[i + j, col] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiếm tra đường chéo chính
            for (int i = -4; i < 1; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (row + i + j < 0 || row + i + j >= Helpers.CHESS_BOARD_HEIGHT ||
                       col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH)
                    {
                        win = false;
                        break;
                    }
                    else if (board[row + i + j, col + i + j] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra đường chéo phụ
            for (int i = -4; i < 1; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (row + i + j < 0 || row + i + j >= Helpers.CHESS_BOARD_HEIGHT ||
                       col - i - j < 0 || col - i - j >= Helpers.CHESS_BOARD_WIDTH)
                    {
                        win = false;
                        break;
                    }
                    else if (board[row + i + j, col - i - j] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;

            }

            return false;
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void time_Instruction_Tick(object sender, EventArgs e)
        {

        }

		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{

		}

		private void pn_ChessBoard_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}