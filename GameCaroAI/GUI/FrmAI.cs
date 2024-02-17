using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private const int MAX_DEPTH = 3;
        public bool isXTurn = true;
        public bool isComputerTurn = true;
        public int xCount = 0;
        public int comCount = 0;
        public string[,] board = new string[Helpers.CHESS_BOARD_WIDTH, Helpers.CHESS_BOARD_HEIGHT];
        private const int WIN_SCORE = -1000000;
        public FrmAI()
        {
            InitializeComponent();
            DrawChessBoard();
        }
        private void DrawChessBoard()
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
                    pn_BanCo.Controls.Add(btn);
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

                if (isXTurn)
                {
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\X.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "X";
                    xCount++;
                    lbl_you.Text = "X (You): " + xCount.ToString();

                    if (CheckWinner(col, row))
                    {
                        MessageBox.Show("YOU WINS!");
                        return;
                    }
                    isXTurn = false;
                    isComputerTurn = true;
                    MachinePlayO();
                }
                else if (isComputerTurn)
                {
                    return;
                }
            }
            
        }

        private void MachinePlayO()
        {
            if (isComputerTurn)
            {
                /*Random random = new Random();

                int row, col;
                do
                {
                    row = random.Next(0, Helpers.CHESS_BOARD_HEIGHT);
                    col = random.Next(0, Helpers.CHESS_BOARD_WIDTH);
                } while (board[col, row] != null);*/
                int[] move = FindBestMove();
                int row, col;
                do
                {                  
                    row = move[0];
                    col = move[1];
                } while (board[col, row] != null);
                
                foreach (Control control in pn_BanCo.Controls)
                {
                    if (control is Guna2ButtonWithPosition btn &&
                        btn.Row == row && btn.Col == col)
                    {
                        btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\O.png");
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        board[col, row] = "O";
                        comCount++;
                        lbl_Computer.Text = "O (Computer): " + comCount.ToString();

                        if (CheckWinner(col, row))
                        {
                            MessageBox.Show("COMPUTER WINS!");
                            return;
                        }

                        isXTurn = true;
                        isComputerTurn = false;
                        return;
                    }
                }
                MessageBox.Show("Guna2Button not found.");
            }
        }
        private int[] FindBestMove()
        {
            int[] bestMove = new int[2];
            int bestScore = int.MinValue;

            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[j, i] == null)
                    {
                        board[j, i] = "O"; 

                        int score = MiniMax(board, 0, false);

                        board[j, i] = null; 

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

        private int MiniMax(string[,] board, int depth, bool isMaximizing)
        {
            if (depth == MAX_DEPTH || IsGameOver(board))
            {
                return Evaluate(board);
            }

            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
                {
                    for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                    {
                        if (board[j, i] == null)
                        {
                            board[j, i] = "O"; 
                            int score = MiniMax(board, depth + 1, false);
                            board[j, i] = null;
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
                        if (board[j, i] == null)
                        {
                            board[j, i] = "X"; 
                            int score = MiniMax(board, depth + 1, true);
                            board[j, i] = null;
                            bestScore = Math.Min(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
        }
        private int Evaluate(string[,] board)
        {
            // Chưa bít làm rì
            return 0;
        }
        private bool IsGameOver(string[,] board)
        {
            // Cũng chưa bít
            return true;
        }       
        private bool CheckWinner(int col, int row)
        {
            string player = isXTurn ? "X" : "O";

            // Kiểm tra hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_WIDTH - 4; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[i + j, row] != player)
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
                    if (board[col, i + j] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra đường chéo chính
            for (int i = -4; i < 1; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH || 
                        row + i + j < 0 || row + i + j >= Helpers.CHESS_BOARD_HEIGHT)
                    {
                        win = false;
                        break;
                    }
                    if (board[col + i + j, row + i + j] != player)
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
                    if (col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH || 
                        row - i - j < 0 || row - i - j >= Helpers.CHESS_BOARD_HEIGHT)
                    {
                        win = false;
                        break;
                    }
                    if (board[col + i + j, row - i - j] != player)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();
        }
    }
}
