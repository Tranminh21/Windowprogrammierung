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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            richTextBox1.AllowDrop = true;

            loadToolStripMenuItem.Click += new EventHandler(MyLoadFunction);
            saveToolStripMenuItem.Click += new EventHandler(MySaveFunction);
            colorToolStripMenuItem.Click += new EventHandler(MyColorFunction);
            fontToolStripMenuItem.Click += new EventHandler(MyFontFunction);
            undoToolStripMenuItem.Click += new EventHandler(MyUndoFunction);
            redoToolStripMenuItem.Click += new EventHandler(MyRedoFunction);
            exitToolStripMenuItem.Click += new EventHandler(MyExitFunction);
            richTextBox1.KeyDown += new KeyEventHandler(MyUndoRedoReworkFunction);
            richTextBox1.DragOver += new DragEventHandler(MyDragFunction);
            richTextBox1.DragDrop += new DragEventHandler(MyAndDropFunction);
        }

        private void MyExitFunction(object sender, EventArgs e)
        {
            Close();
        }

        protected void MyLoadFunction(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.Title = "Open Text File";
            oFileDialog.Filter = "txt files (*.txt)|*.txt|" +
                               "rtf files (*.rtf)|*.rtf";
            oFileDialog.InitialDirectory = @"C:\";

            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (oFileDialog.FilterIndex == 1)
                    richTextBox1.LoadFile(oFileDialog.FileName, RichTextBoxStreamType.PlainText);
                else if (oFileDialog.FilterIndex == 2)
                    richTextBox1.LoadFile(oFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        protected void MySaveFunction(object sender, EventArgs e)
        {
            SaveFileDialog sFileDialog = new SaveFileDialog();
            sFileDialog.Title = "Save Text File";               //optional
            sFileDialog.Filter = "txt files (*.txt)|*.txt|" +
                               "rtf files (*.rtf)|*.rtf";
            sFileDialog.InitialDirectory = @"C:\";

            if (sFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (sFileDialog.FilterIndex == 1)
                    richTextBox1.SaveFile(sFileDialog.FileName, RichTextBoxStreamType.PlainText);
                else if (sFileDialog.FilterIndex == 2)
                    richTextBox1.SaveFile(sFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        protected void MyColorFunction(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();

            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cDialog.Color;
            }

            richTextBox1.Focus();
        }

        protected void MyFontFunction(object sender, EventArgs e)
        {
            FontDialog fDialog = new FontDialog();

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fDialog.Font;
            }

            richTextBox1.Focus();
        }

        protected void MyUndoFunction(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        protected void MyRedoFunction(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        protected void MyUndoRedoReworkFunction(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.KeyCode == Keys.Space)
            {
                this.SuspendLayout();
                rtb.Undo();
                rtb.Redo();
                this.ResumeLayout();
            }
        }

        protected void MyDragFunction(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                    e.Effect = DragDropEffects.Move;
        }

        protected void MyAndDropFunction(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extention = System.IO.Path.GetExtension(file[0]);

            if (extention.ToLower() == ".txt")
                richTextBox1.LoadFile(file[0], RichTextBoxStreamType.PlainText);

            if (extention.ToLower() == ".rtf")
                richTextBox1.LoadFile(file[0], RichTextBoxStreamType.RichText);
        }
    }
}
