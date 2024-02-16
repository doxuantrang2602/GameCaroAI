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
    public partial class Frm_TwoPlayers : Form
    {
        public bool isXTurn = true;
        public string[,] board = new string[Helpers.CHESS_BOARD_WIDTH, Helpers.CHESS_BOARD_HEIGHT];
        private Stack<Point> moveHistory = new Stack<Point>(); 
        private Stack<Point> undoneMoves = new Stack<Point>();
        public Frm_TwoPlayers()
        {
            InitializeComponent();
            DrawChessBoard();
        }

        public void DrawChessBoard()
        {
            Guna2Button oldButton = new Guna2Button()
            {
                Width = 0,
                Location = new Point(0, 0),
                BorderThickness = 1,
                BackColor = Color.White,
                FillColor = Color.Transparent,
            };
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    Guna2Button btn = new Guna2Button()
                    {
                        Width = Helpers.CHESS_WIDTH,
                        Height = Helpers.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BorderThickness = 1,
                        BackColor = Color.White,
                        FillColor = Color.Transparent,
                    };
                    pn_BanCo.Controls.Add(btn);
                    oldButton = btn;
                    btn.Click += Btn_Click;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Helpers.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
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
                }
                else
                {
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\O.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "O";
                }
                moveHistory.Push(new Point(col, row)); // Thêm nước mới vào lịch sử
                undoneMoves.Clear();
                if (CheckWinner(col, row))
                {
                    MessageBox.Show((isXTurn ? "X" : "O") + " wins!");

                }
                else
                {
                    isXTurn = !isXTurn;
                }

            }

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
                    if (col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH || row + i + j < 0 || row + i + j >= Helpers.CHESS_BOARD_HEIGHT)
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
                    if (col + i + j < 0 || col + i + j >= Helpers.CHESS_BOARD_WIDTH || row - i - j < 0 || row - i - j >= Helpers.CHESS_BOARD_HEIGHT)
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
            this.Close();
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
            if (moveHistory.Count > 0)
            {
                Point lastMove = moveHistory.Pop();
                undoneMoves.Push(lastMove);

                int col = lastMove.X;
                int row = lastMove.Y;
                Guna2Button btn = pn_BanCo.Controls.Cast<Control>()
                    .FirstOrDefault(control => control.Location.X / Helpers.CHESS_WIDTH == col 
                                    && control.Location.Y / Helpers.CHESS_HEIGHT == row) 
                    as Guna2Button;
                btn.BackgroundImage = null;
                board[col, row] = null;
            }
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if (undoneMoves.Count > 0)
            {
                Point redoMove = undoneMoves.Pop();
                moveHistory.Push(redoMove);

                int col = redoMove.X;
                int row = redoMove.Y;

                Guna2Button btn = pn_BanCo.Controls.Cast<Control>().FirstOrDefault(control => control.Location.X / Helpers.CHESS_WIDTH == col && control.Location.Y / Helpers.CHESS_HEIGHT == row) as Guna2Button;
                if (isXTurn)
                {
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\X.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "X";
                }
                else
                {
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\O.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[col, row] = "O";
                }

                if (CheckWinner(col, row))
                {
                    MessageBox.Show((isXTurn ? "X" : "O") + " wins!");                 
                }
                //isXTurn = !isXTurn;               
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();
        }
    }
}
