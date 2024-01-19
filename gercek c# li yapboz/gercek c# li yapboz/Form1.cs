using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gercek_c__li_yapboz
{
    public partial class Form1 : Form
    {
        int sayici;
        public Form1()
        {
            InitializeComponent();
        }
        public void BosYerKontrolcusu(Button Butt1,Button Butt2)
        {
            if (Butt2.Text == "")
            {
                Butt2.Text=Butt1.Text;
                Butt1.Text = "";
            }
        }
        public void dogrumu()
        {
            if(button1.Text=="1"&& button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6"
                && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11"
                && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" )
            {
                MessageBox.Show("Tebrikler oyunu '" + sayici + "'hamlede tamamladiniz", "Yapboz oyunu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            sayici = sayici + 1;
            textBox1.Text = "Tiklama sayisi:" + sayici;
            textBox2.Text=sayici.ToString();
            
        }
        public void karistir()
        {
            int[] bnum = new int[16];
            int i, j, rowchecker;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32(rnd.Next(0, 15) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowchecker)
                    {
                        flag = true;

                        break;
                    }
                }
                if (flag == true)
                {

                    flag = false;
                }
                else
                {
                    bnum[i] = rowchecker;
                    i = i + 1;
                }
            }
            while (i <= 15);
            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = "";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Cikis yapmak istediginize emin misiniz", "Yapboz oyunu", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(cikis == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Cikis yapmak istediginize emin misiniz", "Yapboz oyunu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cikis == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button1.Text=Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            karistir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button1, button2);
            BosYerKontrolcusu(button1, button5);
            dogrumu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button2, button1);
            BosYerKontrolcusu(button2, button3);
            BosYerKontrolcusu(button2, button6);
            dogrumu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button3, button2);
            BosYerKontrolcusu(button3, button4);
            BosYerKontrolcusu(button3, button7);
            dogrumu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button4, button8);
            BosYerKontrolcusu(button4, button3);
            
            dogrumu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button5, button1);
            BosYerKontrolcusu(button5, button9);
            BosYerKontrolcusu(button5, button6);
            dogrumu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button6, button2);
            BosYerKontrolcusu(button6, button5);
            BosYerKontrolcusu(button6, button6);
            BosYerKontrolcusu(button6, button10);
            dogrumu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button7, button3);
            BosYerKontrolcusu(button7, button6);
            BosYerKontrolcusu(button7, button8);
            BosYerKontrolcusu(button7, button11);
            dogrumu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button8, button4);
            BosYerKontrolcusu(button8, button7);
            BosYerKontrolcusu(button8, button12);
            dogrumu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button9, button5);
            BosYerKontrolcusu(button9, button10);
            BosYerKontrolcusu(button9, button13);
            dogrumu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button10, button6);
            BosYerKontrolcusu(button10, button9);
            BosYerKontrolcusu(button10, button11);
            BosYerKontrolcusu(button10, button14);
            dogrumu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button11, button7);
            BosYerKontrolcusu(button11, button10);
            BosYerKontrolcusu(button11, button12);
            BosYerKontrolcusu(button11, button15);
            dogrumu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button12, button8);
            BosYerKontrolcusu(button12, button16);
            BosYerKontrolcusu(button12, button11);
            
            dogrumu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button13, button14);
            BosYerKontrolcusu(button13, button9);
            
            dogrumu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button14, button10);
            BosYerKontrolcusu(button14, button13);
            BosYerKontrolcusu(button14, button15);
            dogrumu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button15, button16);
            BosYerKontrolcusu(button15, button14);
            BosYerKontrolcusu(button15, button11);
            
            dogrumu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button16, button12);
            BosYerKontrolcusu(button16, button15);
            
            dogrumu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sayici = 0;
            karistir();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();
        }
    }
}
