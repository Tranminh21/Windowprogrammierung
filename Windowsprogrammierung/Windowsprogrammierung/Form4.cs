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
    public partial class Form4 : Form
    {
        Form5 m_aufg5 = new Form5();
        ToolTip tt = new ToolTip();

        private Boolean m_toolTip;
        public Boolean Tooltip
        {
            set { m_toolTip = value; }
            get { return m_toolTip; }
        }

        private String m_lang;
        public String Language
        {
            set { m_lang = value; }
            get { return m_lang; }
        }

        public Form4()
        {
            InitializeComponent();

            ImageList ilist = new ImageList();
            set_tooltip();
            try
            {
                ilist.Images.Add(new Bitmap("1.ico"));
                listView1.SmallImageList = ilist;
                listView1.LargeImageList = ilist;
            } catch
            {

            }
            

            listView1.View = View.List;

            treeView1.Nodes.Add(new TreeNode("1. Reihe", 0, 0));
            treeView1.Nodes[0].Nodes.Add(new TreeNode("Max", 0, 0));
            treeView1.Nodes[0].Nodes.Add(new TreeNode("Leon", 0, 0));
            treeView1.Nodes[0].Nodes.Add(new TreeNode("Tom", 0, 0));

            treeView1.Nodes.Add(new TreeNode("2. Reihe", 0, 0));
            treeView1.Nodes[1].Nodes.Add(new TreeNode("Tobias", 0, 0));
            treeView1.Nodes[1].Nodes.Add(new TreeNode("Maria", 0, 0));
            treeView1.Nodes[1].Nodes.Add(new TreeNode("Josi", 0, 0));

            treeView1.Nodes.Add(new TreeNode("3. Reihe", 0, 0));
            treeView1.Nodes[2].Nodes.Add(new TreeNode("Phillip", 0, 0));
            treeView1.Nodes[2].Nodes.Add(new TreeNode("Sarah", 0, 0));

            trackbar1.ValueChanged += new EventHandler(MyProgress);
            listView1.SelectedIndexChanged += new EventHandler(MyListItem);
            treeView1.AfterSelect += new TreeViewEventHandler(MyTreeItem);
            treeAdd.Click += new EventHandler(MyAddButton);
            button1.Click += new EventHandler(Aufg5_options_Click);
        }

        protected void MyProgress(object sender, EventArgs e)
        {
            label1.Text = trackbar1.Value.ToString() + "%";
            progressBar1.Value = trackbar1.Value;
        }

        protected void MyListItem(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            for (int i = 0; i < lv.SelectedItems.Count; i++)
            {
                listSelected.Text = lv.SelectedItems[i].Text + "(" + lv.SelectedItems.Count.ToString() + ")";
            }
        }

        protected void MyTreeItem(object sender, TreeViewEventArgs e)
        {
            treeSelected.Text = e.Node.Text;

            if (e.Node.Text == "1. Reihe" || e.Node.Text == "2. Reihe" || e.Node.Text == "3. Reihe")
            {
                listView1.Clear();
                for (int i = 0; i < e.Node.Nodes.Count; i++)
                {
                    listView1.Items.Add(new ListViewItem(e.Node.Nodes[i].Text, 0));
                }
            }
        }

        protected void MyAddButton(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Das Eingabefeld darf nicht leer sein.");
            }
            else
            {
                if (treeView1.SelectedNode.Level == 1)
                {
                    treeView1.SelectedNode.Parent.Nodes.Add((new TreeNode(textBox3.Text, 0, 0)));
                }
                textBox3.Clear();
            }
        }

        protected void set_tooltip()
        {
            if (m_toolTip == true)
            {
                if (m_aufg5.Language == "Deutsch")
                {
                    tt.SetToolTip(progressBar1, "DEUTSCH - TEST");
                }
                else
                {
                    tt.SetToolTip(progressBar1, "ENGLISH - TEST");
                }
            }
            else
            {
                tt.RemoveAll();
            }
        }

        protected void Aufg5_options_Click(object sender, EventArgs e)
        {
            if (m_aufg5.ShowDialog() == DialogResult.OK)
            {
                if (m_aufg5.toolTip)
                {
                    m_lang = m_aufg5.Language;
                    m_toolTip = m_aufg5.toolTip;
                    set_tooltip();
                }
                else
                {
                    tt.RemoveAll();
                }
            }
        }
    }
}
