using GameCaroAI.Classes;
using Guna.UI2.WinForms;
using System.Drawing;

namespace GameCaroAI.GUI
{
    partial class FrmAI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAI));
			this.lbl_Computer = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbl_You = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btn_Exit = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Redo = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Undo = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_newGame = new Guna.UI2.WinForms.Guna2GradientButton();
			this.pn_Intruction = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.pn_ChessBoard = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.time_Instruction = new System.Windows.Forms.Timer(this.components);
			this.pn_Intruction.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Computer
			// 
			this.lbl_Computer.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Computer.ForeColor = System.Drawing.Color.Snow;
			this.lbl_Computer.Location = new System.Drawing.Point(435, 61);
			this.lbl_Computer.Name = "lbl_Computer";
			this.lbl_Computer.Size = new System.Drawing.Size(156, 31);
			this.lbl_Computer.TabIndex = 2;
			this.lbl_Computer.Text = "O (Computer):";
			// 
			// lbl_You
			// 
			this.lbl_You.BackColor = System.Drawing.Color.Transparent;
			this.lbl_You.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_You.ForeColor = System.Drawing.Color.Lavender;
			this.lbl_You.Location = new System.Drawing.Point(212, 61);
			this.lbl_You.Name = "lbl_You";
			this.lbl_You.Size = new System.Drawing.Size(91, 31);
			this.lbl_You.TabIndex = 2;
			this.lbl_You.Text = "X (You):";
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.btn_Exit.BorderRadius = 20;
			this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Exit.FillColor = System.Drawing.Color.Moccasin;
			this.btn_Exit.FillColor2 = System.Drawing.Color.Transparent;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Exit.ForeColor = System.Drawing.Color.White;
			this.btn_Exit.Location = new System.Drawing.Point(891, 229);
			this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(112, 45);
			this.btn_Exit.TabIndex = 1;
			this.btn_Exit.Text = "Thoát";
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Redo
			// 
			this.btn_Redo.BackColor = System.Drawing.Color.Transparent;
			this.btn_Redo.BorderRadius = 20;
			this.btn_Redo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Redo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Redo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Redo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Redo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Redo.FillColor = System.Drawing.Color.Moccasin;
			this.btn_Redo.FillColor2 = System.Drawing.Color.Transparent;
			this.btn_Redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Redo.ForeColor = System.Drawing.Color.White;
			this.btn_Redo.Location = new System.Drawing.Point(891, 176);
			this.btn_Redo.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Redo.Name = "btn_Redo";
			this.btn_Redo.Size = new System.Drawing.Size(112, 45);
			this.btn_Redo.TabIndex = 1;
			this.btn_Redo.Text = "Redo";
			// 
			// btn_Undo
			// 
			this.btn_Undo.BackColor = System.Drawing.Color.Transparent;
			this.btn_Undo.BorderRadius = 20;
			this.btn_Undo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Undo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Undo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Undo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Undo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Undo.FillColor = System.Drawing.Color.Moccasin;
			this.btn_Undo.FillColor2 = System.Drawing.Color.Transparent;
			this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Undo.ForeColor = System.Drawing.Color.White;
			this.btn_Undo.Location = new System.Drawing.Point(891, 123);
			this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Undo.Name = "btn_Undo";
			this.btn_Undo.Size = new System.Drawing.Size(112, 45);
			this.btn_Undo.TabIndex = 1;
			this.btn_Undo.Text = "Undo";
			// 
			// btn_newGame
			// 
			this.btn_newGame.BackColor = System.Drawing.Color.Transparent;
			this.btn_newGame.BorderRadius = 20;
			this.btn_newGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_newGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_newGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_newGame.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_newGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_newGame.FillColor = System.Drawing.Color.Moccasin;
			this.btn_newGame.FillColor2 = System.Drawing.Color.Transparent;
			this.btn_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_newGame.ForeColor = System.Drawing.Color.White;
			this.btn_newGame.Location = new System.Drawing.Point(870, 65);
			this.btn_newGame.Margin = new System.Windows.Forms.Padding(4);
			this.btn_newGame.Name = "btn_newGame";
			this.btn_newGame.Size = new System.Drawing.Size(133, 47);
			this.btn_newGame.TabIndex = 1;
			this.btn_newGame.Text = "New Game";
			this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
			// 
			// pn_Intruction
			// 
			this.pn_Intruction.BackColor = System.Drawing.Color.Transparent;
			this.pn_Intruction.BorderColor = System.Drawing.Color.Black;
			this.pn_Intruction.BorderRadius = 20;
			this.pn_Intruction.BorderThickness = 1;
			this.pn_Intruction.Controls.Add(this.guna2HtmlLabel1);
			this.pn_Intruction.FillColor = System.Drawing.Color.PapayaWhip;
			this.pn_Intruction.FillColor2 = System.Drawing.Color.Transparent;
			this.pn_Intruction.Location = new System.Drawing.Point(21, 690);
			this.pn_Intruction.Name = "pn_Intruction";
			this.pn_Intruction.Size = new System.Drawing.Size(1056, 75);
			this.pn_Intruction.TabIndex = 1;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Ivory;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 6);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 31);
			this.guna2HtmlLabel1.TabIndex = 0;
			this.guna2HtmlLabel1.Text = "Hướng dẫn:";
			this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
			// 
			// pn_ChessBoard
			// 
			this.pn_ChessBoard.BackColor = System.Drawing.Color.White;
			this.pn_ChessBoard.BorderColor = System.Drawing.Color.Black;
			this.pn_ChessBoard.BorderThickness = 1;
			this.pn_ChessBoard.Location = new System.Drawing.Point(202, 119);
			this.pn_ChessBoard.Margin = new System.Windows.Forms.Padding(4);
			this.pn_ChessBoard.Name = "pn_ChessBoard";
			this.pn_ChessBoard.Size = new System.Drawing.Size(691, 571);
			this.pn_ChessBoard.TabIndex = 3;
			this.pn_ChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_ChessBoard_Paint);
			// 
			// time_Instruction
			// 
			this.time_Instruction.Tick += new System.EventHandler(this.time_Instruction_Tick);
			// 
			// FrmAI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImage = global::GameCaroAI.Properties.Resources.Khungad2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1105, 843);
			this.Controls.Add(this.lbl_Computer);
			this.Controls.Add(this.pn_ChessBoard);
			this.Controls.Add(this.lbl_You);
			this.Controls.Add(this.pn_Intruction);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Redo);
			this.Controls.Add(this.btn_newGame);
			this.Controls.Add(this.btn_Undo);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmAI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Cờ Caro";
			this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
			this.pn_Intruction.ResumeLayout(false);
			this.pn_Intruction.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
       
        #endregion
        public Guna.UI2.WinForms.Guna2GradientPanel pn_ChessBoard;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Intruction;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_newGame;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Redo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Undo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Computer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_You;
        private System.Windows.Forms.Timer time_Instruction;
    }
}