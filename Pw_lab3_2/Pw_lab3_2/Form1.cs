using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pw_lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String P = textBox1.Text;
            int d = P.Length;
            Debug.WriteLine(d);
            Debug.WriteLine(P[10]);
            int suma = (1 * P[0]) + (3 * P[1]) + (7 * P[2]) + (9 * P[3]) + (1 * P[4]) + (3 * P[5]) + (7 * P[6]) + (9 * P[7]) + (1 * P[8]) + (3 * P[9]);
            int suma1 = suma % 10;
            int suma2 = 10 - suma1;
            int suma3 = suma2 % 10;
            int cyfra = 10 - suma3;
            if (cyfra.ToString() == P[10].ToString())
            {
                label3.Text = "PESEL jest poprawny";
            }
            if (cyfra.ToString() != P[10].ToString())
            {
                label3.Text = "PESEL jest niepoprawny";
            }
        }
    }
}
