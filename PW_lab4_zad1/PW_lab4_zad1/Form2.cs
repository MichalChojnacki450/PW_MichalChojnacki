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
    public partial class Form2 : Form
    {
        public Form2(string strTextBox, string strTextBox1, string strTextBox2 ,string strTextBox3 ,string strTextBox4)
        {
            InitializeComponent();
            label1.Text = strTextBox;
            label2.Text = strTextBox1;
            label3.Text = strTextBox2;
            label4.Text = strTextBox3;
            label5.Text = strTextBox4;
        }
    }
}
