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
            button_Q.Image = imageListQWER.Images[0];
            button_W.Image = imageListQWER.Images[1];
            button_E.Image = imageListQWER.Images[2];
            button_R.Image = imageListQWER.Images[3];
        }

        private void button_Q_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button_W_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button_E_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button_R_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
