namespace GameCaroAI.GUI
{
    partial class Frm_Login
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_VsComputer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_TwoPlayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cb_Rules = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_PlayOnl = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_LoginRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ptb_Exit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pn_LoginRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VsComputer
            // 
            this.btn_VsComputer.BorderRadius = 20;
            this.btn_VsComputer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_VsComputer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_VsComputer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_VsComputer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_VsComputer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_VsComputer.FillColor = System.Drawing.Color.Teal;
            this.btn_VsComputer.FillColor2 = System.Drawing.Color.Navy;
            this.btn_VsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VsComputer.ForeColor = System.Drawing.Color.White;
            this.btn_VsComputer.Location = new System.Drawing.Point(51, 213);
            this.btn_VsComputer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_VsComputer.Name = "btn_VsComputer";
            this.btn_VsComputer.Size = new System.Drawing.Size(231, 57);
            this.btn_VsComputer.TabIndex = 0;
            this.btn_VsComputer.Text = "ĐÁNH VỚI MÁY";
            this.btn_VsComputer.Click += new System.EventHandler(this.btn_VsComputer_Click);
            // 
            // btn_TwoPlayer
            // 
            this.btn_TwoPlayer.BorderRadius = 20;
            this.btn_TwoPlayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TwoPlayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TwoPlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TwoPlayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TwoPlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TwoPlayer.FillColor = System.Drawing.Color.Teal;
            this.btn_TwoPlayer.FillColor2 = System.Drawing.Color.Navy;
            this.btn_TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TwoPlayer.ForeColor = System.Drawing.Color.White;
            this.btn_TwoPlayer.Location = new System.Drawing.Point(51, 278);
            this.btn_TwoPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TwoPlayer.Name = "btn_TwoPlayer";
            this.btn_TwoPlayer.Size = new System.Drawing.Size(231, 54);
            this.btn_TwoPlayer.TabIndex = 0;
            this.btn_TwoPlayer.Text = "HAI NGƯỜI CHƠI";
            this.btn_TwoPlayer.Click += new System.EventHandler(this.btn_TwoPlayer_Click);
            // 
            // cb_Rules
            // 
            this.cb_Rules.BackColor = System.Drawing.Color.Transparent;
            this.cb_Rules.BorderColor = System.Drawing.Color.Black;
            this.cb_Rules.BorderRadius = 15;
            this.cb_Rules.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Rules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Rules.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Rules.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.cb_Rules.ForeColor = System.Drawing.Color.Black;
            this.cb_Rules.ItemHeight = 30;
            this.cb_Rules.Items.AddRange(new object[] {
            "Gomoku (Luật tự do)",
            "Gomoku (Luật tiêu chuẩn)",
            "Caro (Chặn hai đầu)",
            "Luật Renju"});
            this.cb_Rules.Location = new System.Drawing.Point(51, 159);
            this.cb_Rules.Name = "cb_Rules";
            this.cb_Rules.Size = new System.Drawing.Size(231, 36);
            this.cb_Rules.StartIndex = 0;
            this.cb_Rules.TabIndex = 1;
            // 
            // btn_PlayOnl
            // 
            this.btn_PlayOnl.BorderRadius = 20;
            this.btn_PlayOnl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_PlayOnl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_PlayOnl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PlayOnl.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PlayOnl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_PlayOnl.FillColor = System.Drawing.Color.Teal;
            this.btn_PlayOnl.FillColor2 = System.Drawing.Color.Navy;
            this.btn_PlayOnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_PlayOnl.ForeColor = System.Drawing.Color.White;
            this.btn_PlayOnl.Location = new System.Drawing.Point(51, 340);
            this.btn_PlayOnl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PlayOnl.Name = "btn_PlayOnl";
            this.btn_PlayOnl.Size = new System.Drawing.Size(231, 54);
            this.btn_PlayOnl.TabIndex = 0;
            this.btn_PlayOnl.Text = "CHƠI ONLINE";
            this.btn_PlayOnl.Click += new System.EventHandler(this.btn_PlayOnl_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(522, 522);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(522, 522);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pn_LoginRight
            // 
            this.pn_LoginRight.Controls.Add(this.ptb_Exit);
            this.pn_LoginRight.Controls.Add(this.btn_Exit);
            this.pn_LoginRight.Controls.Add(this.label1);
            this.pn_LoginRight.Controls.Add(this.cb_Rules);
            this.pn_LoginRight.Controls.Add(this.btn_VsComputer);
            this.pn_LoginRight.Controls.Add(this.btn_PlayOnl);
            this.pn_LoginRight.Controls.Add(this.btn_TwoPlayer);
            this.pn_LoginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_LoginRight.Location = new System.Drawing.Point(522, 0);
            this.pn_LoginRight.Name = "pn_LoginRight";
            this.pn_LoginRight.Size = new System.Drawing.Size(314, 522);
            this.pn_LoginRight.TabIndex = 3;
            this.pn_LoginRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_LoginRight_MouseDown);
            this.pn_LoginRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_LoginRight_MouseMove);
            this.pn_LoginRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_LoginRight_MouseUp);
            // 
            // ptb_Exit
            // 
            this.ptb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Exit.Image")));
            this.ptb_Exit.ImageRotate = 0F;
            this.ptb_Exit.Location = new System.Drawing.Point(274, 0);
            this.ptb_Exit.Name = "ptb_Exit";
            this.ptb_Exit.Size = new System.Drawing.Size(37, 35);
            this.ptb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_Exit.TabIndex = 8;
            this.ptb_Exit.TabStop = false;
            this.ptb_Exit.Click += new System.EventHandler(this.ptb_Exit_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BorderRadius = 20;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Blue;
            this.btn_Exit.FillColor2 = System.Drawing.Color.Blue;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(108, 413);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(123, 45);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cờ Caro";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 522);
            this.Controls.Add(this.pn_LoginRight);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pn_LoginRight.ResumeLayout(false);
            this.pn_LoginRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_VsComputer;
        private Guna.UI2.WinForms.Guna2GradientButton btn_TwoPlayer;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Rules;
        private Guna.UI2.WinForms.Guna2GradientButton btn_PlayOnl;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_LoginRight;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Exit;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_Exit;
    }
}