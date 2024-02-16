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
        public bool isXTurn = true;
        public string[,] board = new string[Helpers.CHESS_BOARD_WIDTH, Helpers.CHESS_BOARD_HEIGHT];
        public FrmAI()
        {
            InitializeComponent();
            DrawChessBoard();
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
                if (CheckWinner(col, row))
                {
                    MessageBox.Show("Người chơi " + (isXTurn ? "X" : "O") + " wins!");
                    
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
            
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();
        }
    }
}
