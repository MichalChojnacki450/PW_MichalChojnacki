using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pw_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text !="") && (textBox2.Text !="") && (textBox4.Text !=""))
            {
                label1.ForeColor = Color.Black;
                float waga = Convert.ToInt32(textBox1.Text);
                float wzrost = Convert.ToInt32(textBox2.Text);
                float wiek = Convert.ToInt32(textBox4.Text);
                if (textBox3.Text == "M")
                {
                    Single bmr = ((float)9.99 * waga) + (wzrost * (float)6.25) - (wiek * (float)4.92) + 5;
                    label1.Text = bmr.ToString();
                }
                if(textBox3.Text == "K")
                {
                    Single bmr = ((float)9.99 * waga) + (wzrost * (float)6.25) - (wiek * (float)4.92) - 161;
                    label1.Text = bmr.ToString();
                }
                else
                { 
                    label1.ForeColor = Color.Red;
                    label1.Text = "Złe lub brak danych";
                }
            }
            else
            { 
                label1.ForeColor = Color.Red;
                label1.Text = "Brak danych";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
