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
    public partial class Form3 : Form
    {
        int sayici;
        public Form3()
        {
            InitializeComponent();
        }
        public void BosYerKontrolcusu(Button Butt1, Button Butt2)
        {
            if (Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }
        public void dogrumu()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6"
                && button7.Text == "7" && button8.Text == "8" )
            {
                MessageBox.Show("Tebrikler oyunu '"+sayici+"'hamlede tamamladiniz", "Yapboz oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sayici = sayici + 1;
            textBox1.Text = "Tiklama sayisi:" + sayici;
            textBox2.Text = sayici.ToString();

        }
        public void karistir()
        {
            int[] bnum = new int[9];
            int i, j, rowchecker;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32(rnd.Next(0, 8) + 1);
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
            while (i <= 8);
            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            
            button16.Text = "";

        }
        

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Cikis yapmak istediginize emin misiniz", "Yapboz oyunu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cikis == DialogResult.No)
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
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            
            button16.Text = "";

        }

        

        

        private void button18_Click(object sender, EventArgs e)
        {
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button1, button2);
            BosYerKontrolcusu(button1, button4);
            dogrumu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button2, button1);
            BosYerKontrolcusu(button2, button3);
            BosYerKontrolcusu(button2, button5);
            dogrumu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button3, button2);
            BosYerKontrolcusu(button3, button6);

            dogrumu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button4, button1);
            BosYerKontrolcusu(button4, button5);
            BosYerKontrolcusu(button4, button7);
            dogrumu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button5, button2);
            BosYerKontrolcusu(button5, button4);

            BosYerKontrolcusu(button5, button6);
            BosYerKontrolcusu(button5, button8);
            dogrumu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button6, button3);
            BosYerKontrolcusu(button6, button5);
            BosYerKontrolcusu(button6, button16);

            dogrumu();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button7, button4);
            BosYerKontrolcusu(button7, button8);


            dogrumu();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            BosYerKontrolcusu(button8, button5);
            BosYerKontrolcusu(button8, button7);
            BosYerKontrolcusu(button8, button16);
            dogrumu();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {

            BosYerKontrolcusu(button16, button6);
            BosYerKontrolcusu(button16, button8);

            dogrumu();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            sayici = 0;
            karistir();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);

            button16.Text = "";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Cikis yapmak istediginize emin misiniz", "Yapboz oyunu",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cikis == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            karistir();
        }
    }
}
