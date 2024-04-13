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
        public const int MAX_DEPTH = 5;
        public bool isYourTurn = true;
        public bool isComputerTurn = true;
        public int xFirstMoveRow;
        public int xFirstMoveCol;
        public int xCount = 0;
        public int comCount = 0;
        public string[,] board = new string[Helpers.CHESS_BOARD_HEIGHT, Helpers.CHESS_BOARD_WIDTH];
        public const int WIN_SCORE = -10000000;
        private int timeLeft;
        private Stack<Move> undoStack = new Stack<Move>();
        private Stack<Move> redoStack = new Stack<Move>();

        public FrmAI()
        {
            InitializeComponent();
            DrawChessBoard();
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
                    string imagePath = Path.Combine(Application.StartupPath, "Assess\\Images\\X.png");
                    btn.BackgroundImage = Image.FromFile(imagePath);

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
            StartCountdown(60);
        }

        public void UpdateBoard(int row, int col)
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
                    undoStack.Push(new Move(row, col, "O")); 
                    redoStack.Clear();
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
            int alpha = int.MinValue;
            int beta = int.MaxValue;
            int bestScore = int.MinValue;

            List<int[]> possibleMoves = GeneratePossibleMoves(); // Tạo danh sách các nước đi có thể

            foreach (int[] move in possibleMoves)
            {
                int i = move[0];
                int j = move[1];

                // Thử thực hiện nước đi và đánh giá
                board[i, j] = "O";
                int score = Minimax_AlphaBeta(board, 0, alpha, beta, false);
                board[i, j] = null;

                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove[0] = i;
                    bestMove[1] = j;
                }
            }
            return bestMove;
        }

        public List<int[]> GeneratePossibleMoves()
        {
            List<int[]> possibleMoves = new List<int[]>();

            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        possibleMoves.Add(new int[] { i, j });
                    }
                }
            }

            return possibleMoves;
        }

        public int Minimax_AlphaBeta(string[,] board, int depth, int alpha, int beta, bool isMaximizing)
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
                            int score = Minimax_AlphaBeta(board, depth + 1, alpha, beta, false);
                            board[i, j] = null;
                            bestScore = Math.Max(score, bestScore);
                            alpha = Math.Max(alpha, bestScore);
                            if (beta <= alpha)
                            {
                                break;
                            }
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
                            board[i, j] = "X";
                            int score = Minimax_AlphaBeta(board, depth + 1, alpha, beta, true);
                            board[i, j] = null;
                            bestScore = Math.Min(score, bestScore);
                            beta = Math.Min(beta, bestScore);
                            if (beta <= alpha)
                            {
                                break;
                            }
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

            // Đánh giá khả năng tấn công và phòng ngự, ưu tiên nước đi gần trung tâm và tạo chuỗi
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == null)
                    {
                        board[i, j] = player;
                        score += EvaluateDefenseAndAttack(board, i, j, player);
                        board[i, j] = null;
                    }
                }
            }

            // Đánh giá đồng đội và đối thủ
            int playerCount = CountPieces(board, player);
            int opponentCount = CountPieces(board, GetOpponent(player));

            // Đánh giá trạng thái của bảng cờ dựa trên số lượng quân cờ của mỗi đội
            score += (playerCount - opponentCount) * 10; // Tăng điểm nếu máy kiểm soát nhiều quân cờ hơn

            return score;
        }
        // Hàm đánh giá phòng ngự và tấn công, ưu tiên nước đi gần trung tâm và tạo chuỗi
        private int EvaluateDefenseAndAttack(string[,] board, int row, int col, string player)
        {
            int score = 0;
            int centerRow = Helpers.CHESS_BOARD_HEIGHT / 2;
            int centerCol = Helpers.CHESS_BOARD_WIDTH / 2;
            int distanceToCenter = Math.Abs(centerRow - row) + Math.Abs(centerCol - col);

            // Ưu tiên nước đi gần trung tâm
            if (distanceToCenter != 0)
            {
                score += (int)(10 / distanceToCenter);
            }
            else
            {
                // Xử lý trường hợp khi distanceToCenter bằng 0
                // Ví dụ: Gán một giá trị mặc định
                score += 0; // Ví dụ: Không cộng điểm nếu distanceToCenter bằng 0
            }


            // Ưu tiên các nước đi tạo thành chuỗi
            if (IsPotentialWinningMove(board, row, col, player))
                score += 1000;

            // Kiểm tra khả năng tấn công và phòng ngự
            if (IsAttackingMove(board, row, col, player))
                score += 500;
            else if (IsDefendingMove(board, row, col, player))
                score += 100;

            return score;
        }
        private int CountPieces(string[,] board, string player)
        {
            int count = 0;
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    if (board[i, j] == player)
                        count++;
                }
            }
            return count;
        }
        // Kiểm tra xem nước đi có tiềm năng tạo thành chuỗi không
        private bool IsPotentialWinningMove(string[,] board, int row, int col, string player)
        {
            return IsPotentialWinningLine(board, player, row, col, 0, 1) || // Hàng ngang
                   IsPotentialWinningLine(board, player, row, col, 1, 0) || // Hàng dọc
                   IsPotentialWinningLine(board, player, row, col, 1, 1) || // Đường chéo chính
                   IsPotentialWinningLine(board, player, row, col, -1, 1);  // Đường chéo phụ
        }

        // Kiểm tra xem nước đi có tạo cơ hội tấn công không
        private bool IsAttackingMove(string[,] board, int row, int col, string player)
        {
            return IsPotentialAttackingLine(board, player, row, col, 0, 1) || // Hàng ngang
                   IsPotentialAttackingLine(board, player, row, col, 1, 0) || // Hàng dọc
                   IsPotentialAttackingLine(board, player, row, col, 1, 1) || // Đường chéo chính
                   IsPotentialAttackingLine(board, player, row, col, -1, 1);  // Đường chéo phụ
        }

        // Kiểm tra xem nước đi có ngăn chặn đối thủ chiến thắng không
        private bool IsDefendingMove(string[,] board, int row, int col, string player)
        {
            return IsPotentialDefendingLine(board, player, row, col, 0, 1) || // Hàng ngang
                   IsPotentialDefendingLine(board, player, row, col, 1, 0) || // Hàng dọc
                   IsPotentialDefendingLine(board, player, row, col, 1, 1) || // Đường chéo chính
                   IsPotentialDefendingLine(board, player, row, col, -1, 1);  // Đường chéo phụ
        }

        // Hàm kiểm tra hàng có thể tạo thành chuỗi
        private bool IsPotentialWinningLine(string[,] board, string player, int row, int col, int dRow, int dCol)
        {
            int count = 0;
            for (int i = -4; i <= 4; i++)
            {
                int r = row + i * dRow;
                int c = col + i * dCol;
                if (r >= 0 && r < Helpers.CHESS_BOARD_HEIGHT && c >= 0 && c < Helpers.CHESS_BOARD_WIDTH)
                {
                    if (board[r, c] == player || board[r, c] == null)
                        count++;
                }
            }
            return count >= 5;
        }

        // Hàm kiểm tra hàng có thể tạo cơ hội tấn công
        private bool IsPotentialAttackingLine(string[,] board, string player, int row, int col, int dRow, int dCol)
        {
            int countPlayer = 0;
            int countOpponent = 0;
            for (int i = -4; i <= 4; i++)
            {
                int r = row + i * dRow;
                int c = col + i * dCol;
                if (r >= 0 && r < Helpers.CHESS_BOARD_HEIGHT && c >= 0 && c < Helpers.CHESS_BOARD_WIDTH)
                {
                    if (board[r, c] == player)
                        countPlayer++;
                    else if (board[r, c] != null)
                        countOpponent++;
                }
            }
            return countPlayer == 4 && countOpponent == 0;
        }

        // Hàm kiểm tra hàng có thể tạo cơ hội phòng ngự
        private bool IsPotentialDefendingLine(string[,] board, string player, int row, int col, int dRow, int dCol)
        {
            int countPlayer = 0;
            int countOpponent = 0;
            for (int i = -4; i <= 4; i++)
            {
                int r = row + i * dRow;
                int c = col + i * dCol;
                if (r >= 0 && r < Helpers.CHESS_BOARD_HEIGHT && c >= 0 && c < Helpers.CHESS_BOARD_WIDTH)
                {
                    if (board[r, c] == player)
                        countPlayer++;
                    else if (board[r, c] != null)
                        countOpponent++;
                }
            }
            return countOpponent == 4 && countPlayer == 0;
        }
        // Lấy thông tin đối thủ của một người chơi
        public string GetOpponent(string player)
        {
            if (player == "X")
            {
                return "O";
            }
            else if (player == "O")
            {
                return "X";
            }
            else
            {
                throw new ArgumentException("Invalid player");
            }
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
            this.Close();
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