using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Windowsprogrammierung
{
    public partial class Form10 : Form
    {
        private int CAP = 100000;
        private int pos = 3; //Calculation starts with the second prime number
        private Thread thread;
        private bool isRunning;
        private List<int> primes = new List<int>();

        private delegate void DelegateChangeText(int value);
        private DelegateChangeText changeTextBox;

        private delegate void DelegateChangeProgress(int value);
        private DelegateChangeProgress changeProgress;

        public Form10()
        {
            primes.Add(2);

            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            progressBar1.Maximum = CAP;

            startButton.Click += new EventHandler(startEvent);
            stopButton.Click += new EventHandler(stopEvent);
            weiterButton.Click += new EventHandler(weiterEvent);
            changeProgress += new DelegateChangeProgress(changeProgressEvent);
            changeTextBox += new DelegateChangeText(changeTextBoxEvent);
        }

        private void startEvent(object sender, EventArgs e)
        {
            pos = 3;
            primes.Clear();
            primes.Add(2);
            textBox1.Text = "2\r\n";

            isRunning = true;
            thread = new Thread(new ThreadStart(this.primeCalculator));
            thread.Start();

            startButton.Enabled = false;
            weiterButton.Enabled = false;
        }

        private void stopEvent(object sender, EventArgs e)
        {
            isRunning = false;
            startButton.Enabled = true;
            weiterButton.Enabled = true;
        }

        private void weiterEvent(object sender, EventArgs e)
        {
            isRunning = true;
            thread = new Thread(new ThreadStart(this.primeCalculator));
            thread.Start();

            startButton.Enabled = false;
            weiterButton.Enabled = false;
        }
        
        private void changeTextBoxEvent(int val)
        {
            textBox1.Text += val.ToString() + "\r\n";
        }
        
        private void changeProgressEvent(int val)
        {
            progressBar1.Value = val;
        }

        private void primeCalculator()
        {
            while (isRunning)
            {
                for (int i = pos; i <= CAP; i += 2)
                {
                    int flag = 0;
                    for (int j = 0; j < primes.Count; j++)
                    {
                        if (i % primes[j] == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    Invoke(changeProgress, i);
                    if (flag == 0)
                    {
                        primes.Add(i);
                        Invoke(changeTextBox, i);
                    }
                    if (!isRunning)
                    {
                        pos = i + 2;
                        return;
                    }
                }
                isRunning = false;
            }
        }
    }
}
