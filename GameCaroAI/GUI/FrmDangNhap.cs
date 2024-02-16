using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCaroAI.GUI;

namespace GameCaroAI
{
    public partial class FrmDangNhap : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DanhMay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();   
            this.Show();
        }
        private void btn_haiNguoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TwoPlayers frm_two = new Frm_TwoPlayers();
            frm_two.ShowDialog();
            this.Show();
        }

        private void btn_ChoiOnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAI frmAI = new FrmAI();
            frmAI.ShowDialog();
            this.Show();
        }

        private void bnt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void ptb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }
        private void pn_DangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pn_DangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new System.Drawing.Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new System.Drawing.Size(diff));
            }
        }

        private void pn_DangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        
    }
}
