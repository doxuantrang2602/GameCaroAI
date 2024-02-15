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
        public FrmAI()
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
                //BackColor = Color.White,
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
                        //BackColor = Color.White,
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
                if (isXTurn)
                {
                    btn.Text = "X";
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\X.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    btn.Text = "O";
                    btn.BackgroundImage = Image.FromFile("D:\\Code_C#\\WinForm\\GameCaroAI\\GameCaroAI\\Assess\\Images\\O.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
                isXTurn = !isXTurn;
            }
        }
    }
}
