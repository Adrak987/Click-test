using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deskt1
{
    public partial class Form1c : Form
    {
        private int licznik = 0;
        private int licznik2 = 5;
        private int[] tablica = new int[5];
        public Form1c()
        {
            InitializeComponent();
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            licznik++;
            label1.Text = licznik.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            licznik2--;
            label2.Text = licznik2.ToString();
            if (licznik2 == 0)
            {
                timer1.Stop();
                button1.Hide();
                button2.Show();
                if (Convert.ToInt16(label1.Text) > Convert.ToInt16(label7.Text))
                {
                    label7.Text = label1.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button1.Show();
            label2.Text = "5";
            licznik2 = 5;
            licznik = 0;
        }
    }
}
