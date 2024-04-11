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
    public partial class Form7 : Form
    {
        Pen pencil = new Pen(Color.Black, 1);
        SolidBrush textColor = new SolidBrush(Color.Black);
        Point oldpoint;
        Font textFont = new Font("Arial", 12);
        String[] cBoxList = { "Durchgehend", "Gestrichelt" };
        String[] radioText = { "Freihand", "Linie", "Ellipse", "Rechteck", "Text" };
        String mode = "Freihand";
        public Form7()
        {
            InitializeComponent();

            oldpoint = new Point(0, 0);
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.Black;
            comboBox1.Items.AddRange(cBoxList);
            comboBox1.Text = "Durchgehend";
            this.KeyPreview = true;

            for (int i = 0; i < radioText.Count(); i++)
            {
                RadioButton selection = new RadioButton();
                selection.Parent = groupBox1;
                selection.Text = radioText[i];
                selection.Location = new Point(10, 20 + (24 * i));
                selection.Size = new Size(100, 20);
                selection.CheckedChanged += new EventHandler(MySelectionChanged);
                if (i == 0)
                {
                    selection.Checked = true;
                }
            }

            pictureBox1.MouseDown += new MouseEventHandler(MyMouseDown);
            pictureBox1.MouseUp += new MouseEventHandler(MyMouseUp);
            pictureBox1.MouseMove += new MouseEventHandler(MyMouseMove);
            button3.Click += new EventHandler(MyColor);
            button4.Click += new EventHandler(MyFont);
            this.KeyDown += new KeyEventHandler(MyKeyPress);
            numericUpDown1.ValueChanged += new EventHandler(MyThickness);
            comboBox1.SelectedIndexChanged += new EventHandler(MyBrush);

            neuToolStripMenuItem.Click += new EventHandler(MyNewBitmap);
            öffnenToolStripMenuItem.Click += new EventHandler(MyOpenBitmap);
            speichernToolStripMenuItem.Click += new EventHandler(MySaveBitmap);

            kopierenToolStripMenuItem.Click += new EventHandler(MyCopyEvent);
            einfügenToolStripMenuItem.Click += new EventHandler(MyPasteEvent);
        }

        private void MyNewBitmap(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        
        private void MyOpenBitmap(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Bild öffnen";
            dialog.Filter = "Bitmap Image (*.bmp)|*.bmp|" + "All Files (*.*)|*.*";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(dialog.FileName);
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawImage(b, 0, 0, b.Width, b.Height);
                g.Dispose();
            }
        }
        
        private void MySaveBitmap(object sender, EventArgs e)
        {
            Image img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(img);
            g.CopyFromScreen(PointToScreen(pictureBox1.Location), new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap Image (*.bmp)|*.bmp|" +
                                "Portable Network Graphics (*.png)|*.png|" +
                                "All Files (*.*)|*.*";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                switch (dialog.FilterIndex)
                {
                    case 1:
                        img.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        img.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
            g.Dispose();
        }

        private void MyCopyEvent(object sender, EventArgs e)
        {
            CopyFunction();
        }

        private void MyPasteEvent(object sender, EventArgs e)
        {
            PasteFunction();
        }

        protected void MyThickness(object sender, EventArgs e)
        {
            pencil.Width = (float) numericUpDown1.Value;
        }

        private void MyBrush(object sender, EventArgs e)
        {
            ComboBox brushComboBox = (ComboBox)sender;
            if (brushComboBox.Text == "Durchgehend")
                pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            if (brushComboBox.Text == "Gestrichelt")
                pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void MyColor(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = cDialog.Color;
                pencil.Color = cDialog.Color;
                textColor.Color = cDialog.Color;
            }
        }

        private void MyFont(object sender, EventArgs e)
        {
            FontDialog fDialog = new FontDialog();
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                label3.Text = fDialog.Font.Name.ToString();
                textFont = fDialog.Font;
            }
        }

        protected void MySelectionChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            mode = r.Text;
        }

        protected void MyMouseDown(object sender, MouseEventArgs e)
        {
            oldpoint = new Point(e.X, e.Y);
            if (mode == "Text")
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawString(textBox1.Text, textFont, textColor, oldpoint);
                g.Dispose();
            }
        }

        protected void MyMouseMove(object sender, MouseEventArgs e)
        {            
            if (mode == "Freihand" && e.Button != MouseButtons.None)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(pencil, oldpoint, new Point(e.X, e.Y));
                oldpoint = new Point(e.X, e.Y);
                g.Dispose();
            }
        }

        protected void MyMouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            switch (mode)
            {
                case "Linie": g.DrawLine(pencil, oldpoint, new Point(e.X, e.Y)); break;
                case "Ellipse": g.DrawEllipse(pencil, new Rectangle(oldpoint.X, oldpoint.Y, e.X - oldpoint.X, e.Y - oldpoint.Y)); break;
                case "Rechteck": g.DrawRectangle(pencil, new Rectangle(
                    Math.Min(oldpoint.X, e.X), 
                    Math.Min(oldpoint.Y, e.Y), 
                    Math.Abs(e.X - oldpoint.X), 
                    Math.Abs(e.Y - oldpoint.Y))); 
                    break;
            }
            g.Dispose();
        }

        protected void MyKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)      // Ctrl-C
            {
                CopyFunction();
            }
            else if (e.Control && e.KeyCode == Keys.V)     // Ctrl-V
            {
                PasteFunction();
            }
        }

        protected void CopyFunction()
        {
            Image img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(img);
            g.CopyFromScreen(PointToScreen(pictureBox1.Location), new Point(0, 0), new Size(pictureBox1.Width, pictureBox1.Height));
            Clipboard.SetImage(img);
            g.Dispose();
        }
        
        protected void PasteFunction()
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(typeof(Bitmap)))
            {
                Bitmap b = (Bitmap)data.GetData(typeof(Bitmap));
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawImage(b, 0, 0, b.Width, b.Height);
                g.Dispose();
            }
        }
    }
}