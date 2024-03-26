using System;
using GameCaroAI.Classes;
using Guna.UI2.WinForms;
using System.Drawing;

namespace GameCaroAI.GUI
{
    partial class Frm_TwoPlayers
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TwoPlayers));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pn_Diem = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_O = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_X = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Redo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Undo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_newGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pn_HuongDan = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_Anh = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ptb_Anh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_BanCo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.mnstCaro = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GradientPanel1.SuspendLayout();
            this.pn_Diem.SuspendLayout();
            this.pn_HuongDan.SuspendLayout();
            this.pn_Anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.mnstCaro.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pn_Diem);
            this.guna2GradientPanel1.Controls.Add(this.pn_HuongDan);
            this.guna2GradientPanel1.Controls.Add(this.pn_Anh);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(752, 30);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(333, 658);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // pn_Diem
            // 
            this.pn_Diem.BorderColor = System.Drawing.Color.Black;
            this.pn_Diem.BorderThickness = 1;
            this.pn_Diem.Controls.Add(this.lbl_O);
            this.pn_Diem.Controls.Add(this.lbl_X);
            this.pn_Diem.Controls.Add(this.btn_Thoat);
            this.pn_Diem.Controls.Add(this.btn_Redo);
            this.pn_Diem.Controls.Add(this.btn_Undo);
            this.pn_Diem.Controls.Add(this.btn_newGame);
            this.pn_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Diem.Location = new System.Drawing.Point(0, 465);
            this.pn_Diem.Name = "pn_Diem";
            this.pn_Diem.Size = new System.Drawing.Size(333, 193);
            this.pn_Diem.TabIndex = 2;
            // 
            // lbl_O
            // 
            this.lbl_O.BackColor = System.Drawing.Color.Transparent;
            this.lbl_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_O.ForeColor = System.Drawing.Color.Red;
            this.lbl_O.Location = new System.Drawing.Point(8, 36);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(28, 31);
            this.lbl_O.TabIndex = 2;
            this.lbl_O.Text = "O:";
            // 
            // lbl_X
            // 
            this.lbl_X.BackColor = System.Drawing.Color.Transparent;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.ForeColor = System.Drawing.Color.Blue;
            this.lbl_X.Location = new System.Drawing.Point(8, 6);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(26, 31);
            this.lbl_X.TabIndex = 2;
            this.lbl_X.Text = "X:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BorderRadius = 20;
            this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thoat.FillColor = System.Drawing.Color.Navy;
            this.btn_Thoat.FillColor2 = System.Drawing.Color.Navy;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(194, 123);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(99, 45);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_Redo
            // 
            this.btn_Redo.BorderRadius = 20;
            this.btn_Redo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Redo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Redo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Redo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Redo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Redo.FillColor = System.Drawing.Color.Navy;
            this.btn_Redo.FillColor2 = System.Drawing.Color.Navy;
            this.btn_Redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Redo.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.Location = new System.Drawing.Point(7, 123);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(105, 45);
            this.btn_Redo.TabIndex = 1;
            this.btn_Redo.Text = "Redo";
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BorderRadius = 20;
            this.btn_Undo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Undo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Undo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Undo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Undo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Undo.FillColor = System.Drawing.Color.Navy;
            this.btn_Undo.FillColor2 = System.Drawing.Color.Navy;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.Location = new System.Drawing.Point(4, 70);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(108, 45);
            this.btn_Undo.TabIndex = 1;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.BorderRadius = 20;
            this.btn_newGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newGame.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newGame.FillColor = System.Drawing.Color.Teal;
            this.btn_newGame.FillColor2 = System.Drawing.Color.Navy;
            this.btn_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.ForeColor = System.Drawing.Color.White;
            this.btn_newGame.Location = new System.Drawing.Point(165, 70);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(146, 45);
            this.btn_newGame.TabIndex = 1;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // pn_HuongDan
            // 
            this.pn_HuongDan.BorderColor = System.Drawing.Color.Black;
            this.pn_HuongDan.BorderThickness = 1;
            this.pn_HuongDan.Controls.Add(this.guna2HtmlLabel1);
            this.pn_HuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_HuongDan.FillColor = System.Drawing.SystemColors.Info;
            this.pn_HuongDan.FillColor2 = System.Drawing.Color.PapayaWhip;
            this.pn_HuongDan.Location = new System.Drawing.Point(0, 264);
            this.pn_HuongDan.Name = "pn_HuongDan";
            this.pn_HuongDan.Size = new System.Drawing.Size(333, 201);
            this.pn_HuongDan.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(7, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Hướng dẫn:";
            // 
            // pn_Anh
            // 
            this.pn_Anh.BorderColor = System.Drawing.Color.Black;
            this.pn_Anh.BorderThickness = 2;
            this.pn_Anh.Controls.Add(this.ptb_Anh);
            this.pn_Anh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Anh.Location = new System.Drawing.Point(0, 0);
            this.pn_Anh.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Anh.Name = "pn_Anh";
            this.pn_Anh.Size = new System.Drawing.Size(333, 264);
            this.pn_Anh.TabIndex = 0;
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_Anh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Anh.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Anh.Image")));
            this.ptb_Anh.ImageRotate = 0F;
            this.ptb_Anh.Location = new System.Drawing.Point(0, 0);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(333, 264);
            this.ptb_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Anh.TabIndex = 0;
            this.ptb_Anh.TabStop = false;
            // 
            // pn_BanCo
            // 
            this.pn_BanCo.BackColor = System.Drawing.Color.White;
            this.pn_BanCo.BorderColor = System.Drawing.Color.Black;
            this.pn_BanCo.BorderThickness = 1;
            this.pn_BanCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_BanCo.Location = new System.Drawing.Point(0, 30);
            this.pn_BanCo.Margin = new System.Windows.Forms.Padding(4);
            this.pn_BanCo.Name = "pn_BanCo";
            this.pn_BanCo.Size = new System.Drawing.Size(752, 658);
            this.pn_BanCo.TabIndex = 3;
            // 
            // mnstCaro
            // 
            this.mnstCaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnstCaro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnstCaro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnstCaro.Location = new System.Drawing.Point(0, 0);
            this.mnstCaro.Name = "mnstCaro";
            this.mnstCaro.Size = new System.Drawing.Size(1085, 30);
            this.mnstCaro.TabIndex = 4;
            this.mnstCaro.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Frm_TwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 688);
            this.Controls.Add(this.pn_BanCo);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.mnstCaro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnstCaro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_TwoPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Cờ Caro";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.pn_Diem.ResumeLayout(false);
            this.pn_Diem.PerformLayout();
            this.pn_HuongDan.ResumeLayout(false);
            this.pn_HuongDan.PerformLayout();
            this.pn_Anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            this.mnstCaro.ResumeLayout(false);
            this.mnstCaro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Anh;
        public Guna.UI2.WinForms.Guna2GradientPanel pn_BanCo;
        private System.Windows.Forms.MenuStrip mnstCaro;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_Anh;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_HuongDan;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Diem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_newGame;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Redo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Undo;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Thoat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_O;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_X;
    }
}