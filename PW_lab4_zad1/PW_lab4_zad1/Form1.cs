using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_lab4_zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);
            frm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
