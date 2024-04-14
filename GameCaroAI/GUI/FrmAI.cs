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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GameCaroAI.GUI
{
    public partial class FrmAI : Form
    {
        public int levelAI;
        public const int MAX_DEPTH = 3;
        public bool isYourTurn = true; 
        public bool isComputerTurn = true;
        public int xFirstMoveRow;
        public int xFirstMoveCol;
        public int xCount = 0;
        public int comCount = 0;
        public string[,] board = new string[Helpers.CHESS_BOARD_HEIGHT, Helpers.CHESS_BOARD_WIDTH];
        public const int WIN_SCORE = -10000000;
        public int timeLeft;
        public Stack<Move> undoStack = new Stack<Move>();
        public Stack<Move> redoStack = new Stack<Move>();
        public MinimaxAI minimaxAI;
        public RandomAI randomAI;
        public FrmAI(int level)
        {
            InitializeComponent();
            DrawChessBoard();
            levelAI = level;
            InitializeAI(levelAI);
        }
        private void InitializeAI(int level)
        {
            if (level == 0)
            {
                randomAI = new RandomAI(board);
            }
            else if (level == 1) 
            {
                minimaxAI = new MinimaxAI(board, MAX_DEPTH);
            }
            else if (level == 2)
            {

            }
        }

        private void StartCountdown(int seconds)
        {
            timer_Lose.Stop();
            timeLeft = seconds; 
            UpdateLabelTime();
            timer_Lose.Start();
        }
        private void timer_Lose_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; 
                UpdateLabelTime();
            }
            else
            {
                timer_Lose.Stop();
                MessageBox.Show("Time's up!");
            }
        }
        
        private void UpdateLabelTime()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lb_timer.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        public void DrawChessBoard()
        {
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for(int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    Guna2ButtonWithPosition btn = new Guna2ButtonWithPosition()
                    {
                        Width = Helpers.CHESS_WIDTH,
                        Height = Helpers.CHESS_HEIGHT,
                        Location = new Point(j* Helpers.CHESS_WIDTH, i*Helpers.CHESS_HEIGHT),
                        BorderThickness = 1,
                        BackColor = Color.White,
                        FillColor = Color.Transparent,
                        Col = j,
                        Row = i,
                    };
                    pn_ChessBoard.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Guna2ButtonWithPosition btn = sender as Guna2ButtonWithPosition;
            if (btn != null && btn.BackgroundImage == null) 
            {
                int row = btn.Location.Y / Helpers.CHESS_HEIGHT;
                int col = btn.Location.X / Helpers.CHESS_WIDTH;
                if (isYourTurn)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess\\Images\\X.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    board[row, col] = "X";
                    xCount++;
                    lbl_You.Text ="X (You)" + xCount.ToString();
                    if (CheckWinner(row, col))
                    {
                        MessageBox.Show("YOU WINS!");
                        return;
                    }
                    xFirstMoveRow = row;
                    xFirstMoveCol = col;

                    undoStack.Push(new Move(row, col, "X"));
                    redoStack.Clear();

                    isYourTurn = false;
                    isComputerTurn = true;

                    MachinePlayO();
                }
            }
        }

        public void MachinePlayO()
        {
            if(isComputerTurn)
            {
                // Nước đi đầu
                if (xCount == 1 && comCount == 0)
                {
                    int row, col;
                    // Góc trên cùng bên trái
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
                    // Biên bên phải bàn cờ
                    else if (xFirstMoveCol == Helpers.CHESS_BOARD_WIDTH - 1)
                    {
                        // Đánh vào góc trên bên trái
                        row = xFirstMoveRow - 1;
                        col = xFirstMoveCol - 1;
                    }
                    else
                    {
                        // Đánh vào góc chéo bên trái của nước đầu tiên của X
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
                    if (levelAI == 0)
                    {
                        int[] move = randomAI.GetRandomMove();
                        if (move != null)
                        {
                            UpdateBoard(move[0], move[1]); 
                        }
                    }
                    else if(levelAI == 1)
                    {
                        int[] move = minimaxAI.FindBestMove();
                        int row, col;
                        do
                        {
                            row = move[0];
                            col = move[1];
                        } while (board[row, col] != null);

                        UpdateBoard(row, col);
                    }   
                    else if (levelAI == 2)
                    {

                    }
                }
            }
        }

        private void UpdateBoard(int row, int col)
        {
            foreach (Control c in pn_ChessBoard.Controls)
            {
                if (c is Guna2ButtonWithPosition btn && btn.Row == row && btn.Col == col)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Assess\\Images\\O.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);
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
            MessageBox.Show("!");
        }
      
        public bool CheckWinner(int row, int col)
        {
            string player = isYourTurn ? "X" : "O";
            // Kiểm tra hàng ngang
            for (int i = 0; i < Helpers.CHESS_BOARD_WIDTH; i++)
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
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    if (board[i+j, col] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Kiểm tra đường chéo chính
            for (int i = -4; i <= 0; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    int checkRow = row + i + j;
                    int checkCol = col + i + j;
                    if (checkRow < 0 || checkRow >= Helpers.CHESS_BOARD_HEIGHT ||
                        checkCol < 0 || checkCol >= Helpers.CHESS_BOARD_WIDTH ||
                        board[checkRow, checkCol] != player)
                    {
                        win = false;
                        break;
                    } 
                }
                if (win) return true;
            }
            
            // Kiểm tra đường chéo phụ
            for(int i = -4; i <= 0; i++)
            {
                bool win = true;
                for (int j = 0; j < 5; j++)
                {
                    int checkRow = row + i + j;
                    int checkCol = col - i - j;
                    if (checkRow < 0 || checkRow >= Helpers.CHESS_BOARD_HEIGHT ||
                        checkRow < 0 || checkCol >= Helpers.CHESS_BOARD_WIDTH ||
                        board[checkRow, checkCol] != player)
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
            FrmAI frmAI = new FrmAI(levelAI);
            frmAI.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAI frmAI = new FrmAI(levelAI);
            frmAI.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count >= 2) 
            {
                for (int i = 0; i < 2; i++) // Quay lại 2 nước đi
                {
                    Move lastMove = undoStack.Pop();
                    redoStack.Push(new Move(lastMove.Row, lastMove.Col, board[lastMove.Row, lastMove.Col])); // Đẩy vào redoStack
                    board[lastMove.Row, lastMove.Col] = null; // Xóa nước đi khỏi bàn cờ
                    UpdateButtonUI(lastMove.Row, lastMove.Col, null); // Cập nhật UI của nút
                }
                TogglePlayerTurn(); // Đổi lượt chơi
            }
            else
            {
                MessageBox.Show("Không thể thực hiện undo!");
            }
        }
        private void btn_Redo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count >= 2) 
            {
                for (int i = 0; i < 2; i++)
                {
                    Move nextMove = redoStack.Pop();
                    undoStack.Push(new Move(nextMove.Row, nextMove.Col, board[nextMove.Row, nextMove.Col]));
                    board[nextMove.Row, nextMove.Col] = nextMove.Player; 
                    UpdateButtonUI(nextMove.Row, nextMove.Col, nextMove.Player);
                }
                TogglePlayerTurn(); 
            }
            else
            {
                MessageBox.Show("Không còn nước đi để Redo!");
            }
        }


        private void TogglePlayerTurn()
        {
            isYourTurn = !isYourTurn;
            isComputerTurn = !isComputerTurn;
        }
        private void UpdateButtonUI(int row, int col, string player)
        {
            foreach (Control c in pn_ChessBoard.Controls)
            {
                if (c is Guna2ButtonWithPosition btn && btn.Row == row && btn.Col == col)
                {
                    if (player == null)
                    {
                        btn.BackgroundImage = null; 
                    }
                    else
                    {
                        string imagePath = Path.Combine(Application.StartupPath, $"Assess\\Images\\{player}.png");
                        btn.BackgroundImage = Image.FromFile(imagePath);
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    break;
                }
            }
        }

    }
}