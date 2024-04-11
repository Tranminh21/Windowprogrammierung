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
    public partial class Form5 : Form
    {
        public bool toolTip;
        public string Language = "Deutsch";

        public Form5()
        {
            InitializeComponent();
            comboBox1.Text = "Deutsch";

            textBox1.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;

            comboBox1.SelectedIndexChanged += new EventHandler(MyLanguageChange);
            checkBox1.CheckedChanged += new EventHandler(MyToolTippChecked);
        }

        private void MyLanguageChange(object sender, EventArgs e)
        {
            Language = string.Format("{0}", comboBox1.SelectedItem);
        }

        private void MyToolTippChecked(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                toolTip = true;
            }
            else
            {
                toolTip = false;
            }
        }
    }
}
