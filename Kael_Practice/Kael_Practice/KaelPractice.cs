using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kael_Practice
{
    public partial class KaelPractice : Form
    {
        public KaelPractice()
        {
            InitializeComponent();
        }

        private void KaelPractice_Load(object sender, EventArgs e)
        {
        }

        private void frm_test_show_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Q)
            {
                button_Q_Click(sender, e);
            }
            if ((Keys)e.KeyChar == Keys.W)
            {
                button_W_Click(sender, e);
            }
            if ((Keys)e.KeyChar == Keys.E)
            {
                button_E_Click(sender, e);
            }
            if ((Keys)e.KeyChar == Keys.R)
            {
                button_R_Click(sender, e);
            }
            if ((Keys)e.KeyChar == Keys.D)
            {
                button_D_Click(sender, e);
            }
            if ((Keys)e.KeyChar == Keys.F)
            {
                button_F_Click(sender, e);
            }
        }
        private void button_Q_Click(object sender, EventArgs e)
        {
            button_Q.Text="ok!";
        }

        private void button_W_Click(object sender, EventArgs e)
        {

        }

        private void button_E_Click(object sender, EventArgs e)
        {

        }

        private void button_R_Click(object sender, EventArgs e)
        {

        }

        private void button_D_Click(object sender, EventArgs e)
        {

        }

        private void button_F_Click(object sender, EventArgs e)
        {

        }
    }
}
