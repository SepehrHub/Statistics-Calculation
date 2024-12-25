using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        void Clear_Text(params Control[] ctrls)
        {
            foreach (Control ct in ctrls)
            {
                ct.Text = "";
            }
        }
        //=========================================
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.95;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string [] ar = richTextBox1.Text.Split(new char[] { '\n' });
            int len=0;
            foreach(string s in ar)
            {
                if(s!="")
                    len++;
            }
            double[] val = new double[len];
            for (int i = 0; i <len; i++)
            {
                if(ar[i]!="")
                val[i] = Convert.ToDouble(ar[i]);
            }
            //=========================================
            Statistics amar = new Statistics();
            double[] info = new double[len];
            for (int i = 0; i < len; i++)
            {
                info[i] = val[i];
            }
            Array.Sort(info);
            textBox1.Text = val.Length.ToString();
            textBox2.Text = val.Sum().ToString();
            textBox3.Text = amar.Miyangin(val).ToString();
            textBox4.Text = amar.Varians(val).ToString();
            textBox5.Text = amar.Enherafe_Meyar(val).ToString();
            foreach (double d in info)
            {
                textBox6.Text += d.ToString() + ",";
            }
            //=========================================
            Array.Sort(info);
            if (info.Length % 2 == 1)
            {
                int z = (int)(len / 2);
                textBox7.Text = info[z].ToString();
            }
            else
            {
                int x =  (int)(len/ 2);
                int y = x - 1;
                textBox7.Text = ((int)(info[x] + info[y]) / 2).ToString();
            }
            //=========================================
            textBox8.Text = (amar.Enherafe_Meyar(val) / amar.Miyangin(val)).ToString();
            //=========================================
            int f = (int)(val.Max());
            int[] count = new int[f];
            for (int i = 0; i < f; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < len; i++)
            {
                count[(int)(val[i])-1]++;
            }
            textBox9.Text = (Array.IndexOf(count, count.Max()) + 1).ToString();
            //==========================================
            textBox10.Text = amar.Multiply(val).ToString();
            //==========================================
            textBox11.Text = val.Max().ToString();
            //==========================================
            textBox12.Text = val.Min().ToString();
            
            



            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_Text(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, richTextBox1,textBox9,textBox10,textBox11,textBox12);
            richTextBox1.Select();
            richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string about = "";
            about = "نویسنده برنامه : سالار اشگی \n" + "تحت زبان : سی شارپ 2008 \n" + "دی 88 ";
            MessageBox.Show(about, "... درباره ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
