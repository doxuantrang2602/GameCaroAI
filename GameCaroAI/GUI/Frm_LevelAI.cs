using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaroAI.GUI
{
    public partial class Frm_LevelAI : Form
    {
        public Frm_LevelAI()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int level;
            if (rdb_easy.Checked)
                level = 0;
            else if (rdb_medium.Checked)
                level = 1;
            else if (rdb_hard.Checked)
                level = 2;
            else
                level = 0;
            this.Hide();
            FrmAI frmAI = new FrmAI(level);
            frmAI.ShowDialog();
            this.Close();
        }


		private void ptb_Exit_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
