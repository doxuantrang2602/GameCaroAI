namespace GameCaroAI.GUI
{
    partial class Frm_LevelAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LevelAI));
            this.gr_level = new System.Windows.Forms.GroupBox();
            this.rdb_easy = new System.Windows.Forms.RadioButton();
            this.rdb_medium = new System.Windows.Forms.RadioButton();
            this.rdb_hard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gr_level.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_level
            // 
            this.gr_level.BackColor = System.Drawing.Color.White;
            this.gr_level.Controls.Add(this.btn_Start);
            this.gr_level.Controls.Add(this.label1);
            this.gr_level.Controls.Add(this.rdb_hard);
            this.gr_level.Controls.Add(this.rdb_medium);
            this.gr_level.Controls.Add(this.rdb_easy);
            this.gr_level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_level.Location = new System.Drawing.Point(0, 0);
            this.gr_level.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gr_level.Name = "gr_level";
            this.gr_level.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gr_level.Size = new System.Drawing.Size(331, 287);
            this.gr_level.TabIndex = 0;
            this.gr_level.TabStop = false;
            this.gr_level.Text = "Lựa chọn";
            // 
            // rdb_easy
            // 
            this.rdb_easy.AutoSize = true;
            this.rdb_easy.Location = new System.Drawing.Point(85, 90);
            this.rdb_easy.Name = "rdb_easy";
            this.rdb_easy.Size = new System.Drawing.Size(58, 29);
            this.rdb_easy.TabIndex = 1;
            this.rdb_easy.TabStop = true;
            this.rdb_easy.Text = "Dễ";
            this.rdb_easy.UseVisualStyleBackColor = true;
            // 
            // rdb_medium
            // 
            this.rdb_medium.AutoSize = true;
            this.rdb_medium.Location = new System.Drawing.Point(85, 125);
            this.rdb_medium.Name = "rdb_medium";
            this.rdb_medium.Size = new System.Drawing.Size(129, 29);
            this.rdb_medium.TabIndex = 2;
            this.rdb_medium.TabStop = true;
            this.rdb_medium.Text = "Trung Bình";
            this.rdb_medium.UseVisualStyleBackColor = true;
            // 
            // rdb_hard
            // 
            this.rdb_hard.AutoSize = true;
            this.rdb_hard.Location = new System.Drawing.Point(85, 160);
            this.rdb_hard.Name = "rdb_hard";
            this.rdb_hard.Size = new System.Drawing.Size(69, 29);
            this.rdb_hard.TabIndex = 3;
            this.rdb_hard.TabStop = true;
            this.rdb_hard.Text = "Khó";
            this.rdb_hard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hãy chọn mức độ mong muốn";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BorderRadius = 20;
            this.btn_Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Start.FillColor = System.Drawing.Color.Navy;
            this.btn_Start.FillColor2 = System.Drawing.Color.Teal;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.HoverState.Image = global::GameCaroAI.Properties.Resources.mũitengo1;
            this.btn_Start.Location = new System.Drawing.Point(85, 214);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(136, 45);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "Bắt đầu";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Frm_LevelAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 287);
            this.Controls.Add(this.gr_level);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_LevelAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mức độ ";
            this.gr_level.ResumeLayout(false);
            this.gr_level.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_hard;
        private System.Windows.Forms.RadioButton rdb_medium;
        private System.Windows.Forms.RadioButton rdb_easy;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Start;
    }
}