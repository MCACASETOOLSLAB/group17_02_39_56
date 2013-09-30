using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmokersProblem1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                MessageBox.Show("Agent has to select exactly two smokers!!!");
                Form2 f2 = new Form2();
                f2.Show();
                this.Visible = false;
            }
            else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Visible = false;
            }
            else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Visible = false;
            }
            else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Agent has to select exactly two smokers!!!");
                Form2 f2 = new Form2();
                f2.Show();
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Visible = false;
        }
    }
}
