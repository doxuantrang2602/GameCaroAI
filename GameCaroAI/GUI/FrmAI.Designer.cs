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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAI));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pn_Diem = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pn_HuongDan = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pn_Anh = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ptb_Anh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_BanCo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.mnstCaro = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GradientPanel1.SuspendLayout();
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
            this.pn_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Diem.Location = new System.Drawing.Point(0, 451);
            this.pn_Diem.Name = "pn_Diem";
            this.pn_Diem.Size = new System.Drawing.Size(333, 207);
            this.pn_Diem.TabIndex = 2;
            // 
            // pn_HuongDan
            // 
            this.pn_HuongDan.BorderColor = System.Drawing.Color.Black;
            this.pn_HuongDan.BorderThickness = 1;
            this.pn_HuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_HuongDan.Location = new System.Drawing.Point(0, 264);
            this.pn_HuongDan.Name = "pn_HuongDan";
            this.pn_HuongDan.Size = new System.Drawing.Size(333, 187);
            this.pn_HuongDan.TabIndex = 1;
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
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.fileToolStripMenuItem.Text = "File";
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
            this.Controls.Add(this.pn_BanCo);
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
    }
}