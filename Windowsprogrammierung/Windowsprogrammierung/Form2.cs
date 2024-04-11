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
    public partial class Form2 : Form
    {
        Point oldpoint;
        public Form2()
        {
            InitializeComponent();
            label2.Text = "X";
            oldpoint = new Point(0, 0);
            label2.Location = new Point(Size.Width / 2, Size.Height / 2);

            this.Resize += new EventHandler(MyCharCenter);
            this.KeyPress += new KeyPressEventHandler(MyCharChange);
            this.KeyDown += new KeyEventHandler(MyArrow);

            this.MouseDown += new MouseEventHandler(MyMouseDown);
            this.MouseMove += new MouseEventHandler(MyMouseMove);
            this.MouseMove += new MouseEventHandler(MyMousePos);
        }

        protected void MyCharCenter(object sender, EventArgs e)
        {
            label2.Location = new Point(Size.Width / 2, Size.Height / 2);
        }

        protected void MyCharChange(object sender, KeyPressEventArgs e)
        {
            label2.Text = e.KeyChar.ToString();
        }

        protected void MyArrow(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: label2.Left += 10; break;
                case Keys.Left: label2.Left -= 10; break;
                case Keys.Up: label2.Top -= 10; break;
                case Keys.Down: label2.Top += 10; break;
            }
        }


        protected void MyMouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Application.DoEvents();
            g.DrawString("MouseButtons." + e.Button.ToString(), Font, Brushes.Black, e.X, e.Y);
            g.Dispose();
        }

        protected void MyMouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button != MouseButtons.None)
            {
                g.DrawLine(Pens.Black, oldpoint, new Point(e.X, e.Y));
            }
            oldpoint = new Point(e.X, e.Y);
            g.Dispose();
        }

        protected void MyMousePos(object sender, MouseEventArgs e)
        {
            label1.Text = "X:" + e.X + " Y:" + e.Y;
        }
    }
}
