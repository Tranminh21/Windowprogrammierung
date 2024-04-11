using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsprogrammierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(ClosingHandler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 Aufgabe13 = new Form13();
            Aufgabe13.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Aufgabe2 = new Form2();
            Aufgabe2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Aufgabe3 = new Form3();
            Aufgabe3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Aufgabe4 = new Form4();
            Aufgabe4.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form5 Aufgabe5 = new Form5();
            Aufgabe5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 Aufgabe6 = new Form6();
            Aufgabe6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 Aufgabe7 = new Form7();
            Aufgabe7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 Aufgabe8 = new Form8();
            Aufgabe8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 Aufgabe9 = new Form9();
            Aufgabe9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 Aufgabe10 = new Form10();
            Aufgabe10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form11 Aufgabe11 = new Form11();
            Aufgabe11.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form12 Aufgabe12 = new Form12();
            Aufgabe12.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void ClosingHandler(object s, CancelEventArgs cea)
        {
            if (MessageBox.Show("Do you wish to exit?", "Exiting Program",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1)
            != DialogResult.Yes)
            {
                cea.Cancel = true;
            }
            else
            {
                cea.Cancel = false;
            }
        }
    }
}
