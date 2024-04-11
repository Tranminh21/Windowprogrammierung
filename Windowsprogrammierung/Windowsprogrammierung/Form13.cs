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
    public partial class Form13 : Form
    {
        public Form13()
        {
            Timer timer             = new Timer();
            Button button           = new Button();
            RadioButton radioButton = new RadioButton();
            TextBox textBox         = new TextBox();
            TrackBar trackBar       = new TrackBar();

            InitializeComponent();

            //allgemeine Ereignisse und Ereignis-Bearbeiter
            Paint                           += new PaintEventHandler(Event);    //using PaintEventArgs
            Resize                          += new EventHandler(Event);         //using EventArgs
            Move                            += new EventHandler(Event);         //using EventArgs
            MouseDown                       += new MouseEventHandler(Event);    //using MouseEventArgs
            MouseUp                         += new MouseEventHandler(Event);    //using MouseEventArgs
            MouseMove                       += new MouseEventHandler(Event);    //using MouseEventArgs
            MouseWheel                      += new MouseEventHandler(Event);    //using MouseEventArgs
            KeyPress                        += new KeyPressEventHandler(Event); //using KeyPressEventArgs
            KeyDown                         += new KeyEventHandler(Event);      //using KeyEventArgs
            KeyUp                           += new KeyEventHandler(Event);      //using KeyEventArgs
            this.Closing                    += new CancelEventHandler(Event);   //using CancelEventArgs
            this.DragDrop                   += new DragEventHandler(Event);     //using EventArgs   !!!this.AllowDrop = true!!!
            this.DragOver                   += new DragEventHandler(Event);     //using EventArgs   !!!this.AllowDrop = true!!!
            timer.Tick                      += new EventHandler(Event);         //using EventArgs
            button.Click                    += new EventHandler(Event);         //using EventArgs
            radioButton.CheckedChanged      += new EventHandler(Event);         //using EventArgs
            textBox.TextChanged             += new EventHandler(Event);         //using EventArgs
            trackBar.ValueChanged           += new EventHandler(Event);         //using EventArgs

            //Standarddialoge und deren Anwendung
            colorDialogButton.Click         += new EventHandler(colorDialogEvent);
            folderBrowserDialogButton.Click += new EventHandler(folderBrowserDialogEvent);
            fontDialogButton.Click          += new EventHandler(fontDialogEvent);
            openFileDialogButton.Click      += new EventHandler(openFileDialogEvent);
            saveFileDialogButton.Click      += new EventHandler(saveFileDialogEvent);
        }

        private void colorDialogEvent(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //set values with x = dialog.wantedVariable;
                Pen penColor = new Pen(dialog.Color);
                penColor.Color = dialog.Color;
                colorDialogPictureBox.BackColor = dialog.Color;
            }
        }

        private void folderBrowserDialogEvent(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //set values with x = dialog.wantedVariable;
                folderBrowserDialogLabel.Text = dialog.SelectedPath;
            }
        }

        private void fontDialogEvent(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //set values with x = dialog.wantedVariable;
                Font font = dialog.Font;
                fontDialogLabel.Text = dialog.Font.Name;
                int fontSize = (int) dialog.Font.Size;
            }
        }

        private void openFileDialogEvent(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Bild öffnen";
            dialog.Filter = "txt files (*.txt)|*.txt|" +
                   "rtf files (*.rtf)|*.rtf";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                    openFileRichTextBox.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
                else if (dialog.FilterIndex == 2)
                    openFileRichTextBox.LoadFile(dialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void saveFileDialogEvent(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save Text File";                //optional; default = Speichern unter
            dialog.Filter = "txt files (*.txt)|*.txt|" +
                               "rtf files (*.rtf)|*.rtf";   //preferred; default = all formats
            dialog.InitialDirectory = @"C:\";               //optional; default = Desktop

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //dialog.FilterIndex = ordered by dialog.Filter inputs
                if (dialog.FilterIndex == 1)
                    saveFileRichTextBox.SaveFile(dialog.FileName, RichTextBoxStreamType.PlainText);
                else if (dialog.FilterIndex == 2)
                    saveFileRichTextBox.SaveFile(dialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Event(object sender, PaintEventArgs e)
        {

        }

        private void Event(object sender, CancelEventArgs e)
        {

        }

        private void Event(object sender, DragEventArgs e)
        {

        }

        private void Event(object sender, MouseEventArgs e)
        {

        }

        private void Event(object sender, KeyPressEventArgs e)
        {

        }

        private void Event(object sender, KeyEventArgs e)
        {

        }

        private void Event(object sender, EventArgs e)
        {

        }
    }
}
