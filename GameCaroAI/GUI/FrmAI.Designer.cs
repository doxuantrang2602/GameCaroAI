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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAI));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pn_Activity = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_Computer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_You = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Redo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Undo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_newGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pn_Intruction = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_Anh = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ptb_PicCaro = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_ChessBoard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.mnstCaro = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GradientPanel1.SuspendLayout();
            this.pn_Activity.SuspendLayout();
            this.pn_Intruction.SuspendLayout();
            this.pn_Anh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_PicCaro)).BeginInit();
            this.mnstCaro.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pn_Activity);
            this.guna2GradientPanel1.Controls.Add(this.pn_Intruction);
            this.guna2GradientPanel1.Controls.Add(this.pn_Anh);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(752, 30);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(333, 658);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // pn_Activity
            // 
            this.pn_Activity.BorderColor = System.Drawing.Color.Black;
            this.pn_Activity.BorderThickness = 1;
            this.pn_Activity.Controls.Add(this.lbl_Computer);
            this.pn_Activity.Controls.Add(this.lbl_You);
            this.pn_Activity.Controls.Add(this.btn_Exit);
            this.pn_Activity.Controls.Add(this.btn_Redo);
            this.pn_Activity.Controls.Add(this.btn_Undo);
            this.pn_Activity.Controls.Add(this.btn_newGame);
            this.pn_Activity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Activity.Location = new System.Drawing.Point(0, 465);
            this.pn_Activity.Name = "pn_Activity";
            this.pn_Activity.Size = new System.Drawing.Size(333, 193);
            this.pn_Activity.TabIndex = 2;
            // 
            // lbl_Computer
            // 
            this.lbl_Computer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Computer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Computer.Location = new System.Drawing.Point(8, 36);
            this.lbl_Computer.Name = "lbl_Computer";
            this.lbl_Computer.Size = new System.Drawing.Size(156, 31);
            this.lbl_Computer.TabIndex = 2;
            this.lbl_Computer.Text = "O (Computer):";
            // 
            // lbl_You
            // 
            this.lbl_You.BackColor = System.Drawing.Color.Transparent;
            this.lbl_You.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_You.ForeColor = System.Drawing.Color.Blue;
            this.lbl_You.Location = new System.Drawing.Point(8, 6);
            this.lbl_You.Name = "lbl_You";
            this.lbl_You.Size = new System.Drawing.Size(91, 31);
            this.lbl_You.TabIndex = 2;
            this.lbl_You.Text = "X (You):";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BorderRadius = 20;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Navy;
            this.btn_Exit.FillColor2 = System.Drawing.Color.Navy;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(200, 135);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 45);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
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
            this.btn_Redo.Location = new System.Drawing.Point(8, 135);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(108, 45);
            this.btn_Redo.TabIndex = 1;
            this.btn_Redo.Text = "Redo";
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
            this.btn_Undo.Location = new System.Drawing.Point(8, 82);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(108, 45);
            this.btn_Undo.TabIndex = 1;
            this.btn_Undo.Text = "Undo";
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
            this.btn_newGame.Location = new System.Drawing.Point(181, 82);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(130, 45);
            this.btn_newGame.TabIndex = 1;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // pn_Intruction
            // 
            this.pn_Intruction.BorderColor = System.Drawing.Color.Black;
            this.pn_Intruction.BorderThickness = 1;
            this.pn_Intruction.Controls.Add(this.guna2HtmlLabel1);
            this.pn_Intruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Intruction.FillColor = System.Drawing.SystemColors.Info;
            this.pn_Intruction.FillColor2 = System.Drawing.Color.PapayaWhip;
            this.pn_Intruction.Location = new System.Drawing.Point(0, 264);
            this.pn_Intruction.Name = "pn_Intruction";
            this.pn_Intruction.Size = new System.Drawing.Size(333, 201);
            this.pn_Intruction.TabIndex = 1;
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
            this.pn_Anh.Controls.Add(this.ptb_PicCaro);
            this.pn_Anh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Anh.Location = new System.Drawing.Point(0, 0);
            this.pn_Anh.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Anh.Name = "pn_Anh";
            this.pn_Anh.Size = new System.Drawing.Size(333, 264);
            this.pn_Anh.TabIndex = 0;
            // 
            // ptb_PicCaro
            // 
            this.ptb_PicCaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_PicCaro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_PicCaro.Image = ((System.Drawing.Image)(resources.GetObject("ptb_PicCaro.Image")));
            this.ptb_PicCaro.ImageRotate = 0F;
            this.ptb_PicCaro.Location = new System.Drawing.Point(0, 0);
            this.ptb_PicCaro.Name = "ptb_PicCaro";
            this.ptb_PicCaro.Size = new System.Drawing.Size(333, 264);
            this.ptb_PicCaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_PicCaro.TabIndex = 0;
            this.ptb_PicCaro.TabStop = false;
            // 
            // pn_ChessBoard
            // 
            this.pn_ChessBoard.BackColor = System.Drawing.Color.White;
            this.pn_ChessBoard.BorderColor = System.Drawing.Color.Black;
            this.pn_ChessBoard.BorderThickness = 1;
            this.pn_ChessBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ChessBoard.Location = new System.Drawing.Point(0, 30);
            this.pn_ChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ChessBoard.Name = "pn_ChessBoard";
            this.pn_ChessBoard.Size = new System.Drawing.Size(752, 658);
            this.pn_ChessBoard.TabIndex = 3;
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
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // FrmAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 688);
            this.Controls.Add(this.pn_ChessBoard);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.mnstCaro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnstCaro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Cờ Caro";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.pn_Activity.ResumeLayout(false);
            this.pn_Activity.PerformLayout();
            this.pn_Intruction.ResumeLayout(false);
            this.pn_Intruction.PerformLayout();
            this.pn_Anh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_PicCaro)).EndInit();
            this.mnstCaro.ResumeLayout(false);
            this.mnstCaro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        #endregion
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Anh;
        public Guna.UI2.WinForms.Guna2GradientPanel pn_ChessBoard;
        private System.Windows.Forms.MenuStrip mnstCaro;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_PicCaro;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Intruction;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Activity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_newGame;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Redo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Undo;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Computer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_You;
    }
}