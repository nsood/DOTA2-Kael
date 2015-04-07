﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Kael_Practice
{
    public partial class KaelPractice : Form
    {
        public Random rand = new Random();
        public int KeyPressCount = 0;
        public int RightSkillCount = 0;
        public int WrongSkillCount = 0;
        //技能值无顺序乘性组合，为三个基础技能点定义质数值；
        public int Qvalue = 1;  
        public int Wvalue = 3;
        public int Evalue = 5;

        public int Rvalue = 1;        //定义技能初始乘值
        public int SkillValue = 0;        //定义技能随机值，由乘性法则规定

        public KaelPractice()
        {
            InitializeComponent();
        }

        private void KaelPractice_Load(object sender, EventArgs e)
        {
            //初始化界面图标
            button_Q.Image = imageListQWER.Images[0];
            button_W.Image = imageListQWER.Images[1];
            button_E.Image = imageListQWER.Images[2];
            button_R.Image = imageListQWER.Images[3];
            pictureBox_1st.Image = imageListQWER.Images[4];
            pictureBox_2nd.Image = imageListQWER.Images[4];
            pictureBox_3th.Image = imageListQWER.Images[4];
            pictureBox_1st.Tag = 0;
            pictureBox_2nd.Tag = 0;
            pictureBox_3th.Tag = 0;
            skillRandom();
        }

        private void keyPress()
        {
            //全局按键计数
            KeyPressCount++;
        }

        private void skillRandom()
        {
            int random = rand.Next(10);
            pictureBox_Random.Image = imageListSKILL.Images[random];
            switch (random)
            {
                case 0: SkillValue = 1;     break;  //QQQ:  1*1*1=1
                case 1: SkillValue = 27;    break;  //WWW:  3*3*3=27
                case 2: SkillValue = 125;   break;  //EEE:  5*5*5=125
                case 3: SkillValue = 3;     break;  //QQW:  1*1*3=3
                case 4: SkillValue = 5;     break;  //QQE:  1*1*5=5
                case 5: SkillValue = 9;     break;  //WWQ:  3*3*1=9
                case 6: SkillValue = 45;    break;  //WWE:  3*3*5=45
                case 7: SkillValue = 25;    break;  //EEQ:  5*5*1=25
                case 8: SkillValue = 75;    break;  //EEW:  5*5*3=75
                case 9: SkillValue = 15;    break;  //QWE:  1*3*5=15
                default: break;
            }
        }

        private void imageChanged(Image i,Int32 tag)
        {
            //组合技能picturebox更新
            pictureBox_1st.Image = pictureBox_2nd.Image;
            pictureBox_2nd.Image = pictureBox_3th.Image;
            pictureBox_3th.Image = i;
            //组合技能tag质数值更新
            pictureBox_1st.Tag = pictureBox_2nd.Tag;
            pictureBox_2nd.Tag = pictureBox_3th.Tag;
            pictureBox_3th.Tag = tag;
        }

        private void checkCorrect()
        {
            //技能组合检测匹配
            Rvalue = (int)pictureBox_1st.Tag * (int)pictureBox_2nd.Tag * (int)pictureBox_3th.Tag;
            if (Rvalue == SkillValue)
            {
                richTextBox_record.Text += "●";
                RightSkillCount++;
            }
            else
            {
                richTextBox_record.Text += "〇";  
                WrongSkillCount++;
            }
            if ((RightSkillCount+WrongSkillCount) % 10 == 0)
            {
                richTextBox_record.Text += '\n';
            }
            richTextBox_record.SelectionStart += richTextBox_record.Text.Length;
        }

        private void KaelPractice_KeyDown(object sender, KeyEventArgs e)
        {
            keyPress();

            switch ((Keys)e.KeyCode)
            {
                case Keys.Q: 
                    imageChanged(button_Q.Image,1);        
                    break;
                case Keys.W: 
                    imageChanged(button_W.Image,3);
                    break;
                case Keys.E: 
                    imageChanged(button_E.Image,5);
                    break;
                case Keys.D: 
                    break;
                case Keys.F: 
                    break;
                case Keys.R: 
                    checkCorrect();
                    break;
                default:
                    break;
            }

            this.Refresh();
        }
    }
}
