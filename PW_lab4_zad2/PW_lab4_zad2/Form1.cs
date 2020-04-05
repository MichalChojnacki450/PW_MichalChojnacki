using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_lab4_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            int[] T = new int[6];
            for (int i=0;i<=5;i++)
            {
                T[i] = rnd.Next(1,6);
            }
            label1.Text = T[0].ToString();
            
            void key_r(Object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 'r') Close();
            }
        }

        private void label1_Click(object sender,MouseEventArgs  e)
        {
            Clipboard.SetText(label1.Text);
        }
    }

}// tylko tyle jestem wstanie zrobić jak wpadne na to jak to zrobić poprawnie to udostępnie na githubie naprawioną wersje
