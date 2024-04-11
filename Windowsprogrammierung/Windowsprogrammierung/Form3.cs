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
    public partial class Form3 : Form
    {
        RadioButton[] inNote = new RadioButton[5];

        public Form3()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                inNote[i] = new RadioButton();
                inNote[i].Parent = groupNote;
                inNote[i].Text = (i+1).ToString();
                inNote[i].Location = new Point(15 + (40 * i), 8);
                inNote[i].Size = new Size(25, 15);
                inNote[i].CheckedChanged += new EventHandler(MyNote);
            }

            for (int i = 1; i < 6; i++)
            {
                RadioButton inBeleg = new RadioButton();
                inBeleg.Parent = groupBeleg;
                inBeleg.Text = i.ToString();
                inBeleg.Location = new Point(-25 + (40 * i), 8);
                inBeleg.Size = new Size(25, 15);
                inBeleg.CheckedChanged += new EventHandler(MyBeleg);
            }

            string[] Faecher = { "Computergrafik und Visualisierung II", "Internet Technologien I", "Software-Engineering II", "Windowsprogrammierung" };
            inFach.Items.AddRange(Faecher);
            inFach.DropDownStyle = ComboBoxStyle.DropDownList;

            this.inName.TextChanged += new EventHandler(MyOutput);
            this.inMatr.TextChanged += new EventHandler(MyOutput);
            this.inFach.SelectedValueChanged += new EventHandler(MyOutput);
            this.inEnga.ValueChanged += new EventHandler(MyOutputEnga);
        }

        protected void MyOutput(object sender, EventArgs e)
        {
            this.outName.Text = this.inName.Text;
            this.outMatr.Text = this.inMatr.Text;
            this.outFach.Text = this.inFach.Text;
        }

        protected void MyOutputEnga(object sender, EventArgs e)
        {
            this.outEnga.Text = this.inEnga.Value.ToString() + "%";

            if (this.inEnga.Value >= 90)
            {
                if (inNote[4].Enabled == true)
                {
                    inNote[3].Checked = true;
                }
                inNote[4].Enabled = false;
            }
            else
            {
                inNote[4].Enabled = true;
            }
        }

        protected void MyNote(object sender, EventArgs e)
        {
            this.outNote.Text = ((RadioButton)sender).Text;
        }

        protected void MyBeleg(object sender, EventArgs e)
        {
            this.outBele.Text = ((RadioButton)sender).Text;
        }
    }
}