
namespace Windowsprogrammierung
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackbar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listSelected = new System.Windows.Forms.Label();
            this.treeSelected = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.treeAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackbar1
            // 
            this.trackbar1.Location = new System.Drawing.Point(12, 12);
            this.trackbar1.Maximum = 100;
            this.trackbar1.Name = "trackbar1";
            this.trackbar1.Size = new System.Drawing.Size(286, 45);
            this.trackbar1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(403, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(286, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Option";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aktuelle Auswahl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Aktuelle Auswahl:";
            // 
            // listSelected
            // 
            this.listSelected.AutoSize = true;
            this.listSelected.Location = new System.Drawing.Point(12, 366);
            this.listSelected.Name = "listSelected";
            this.listSelected.Size = new System.Drawing.Size(35, 13);
            this.listSelected.TabIndex = 22;
            this.listSelected.Text = "Name";
            // 
            // treeSelected
            // 
            this.treeSelected.AutoSize = true;
            this.treeSelected.Location = new System.Drawing.Point(400, 366);
            this.treeSelected.Name = "treeSelected";
            this.treeSelected.Size = new System.Drawing.Size(35, 13);
            this.treeSelected.TabIndex = 23;
            this.treeSelected.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 382);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 20);
            this.textBox3.TabIndex = 24;
            // 
            // treeAdd
            // 
            this.treeAdd.Location = new System.Drawing.Point(403, 408);
            this.treeAdd.Name = "treeAdd";
            this.treeAdd.Size = new System.Drawing.Size(286, 23);
            this.treeAdd.TabIndex = 25;
            this.treeAdd.Text = "Eintrag Hinzufügen";
            this.treeAdd.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 274);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(403, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(286, 274);
            this.treeView1.TabIndex = 27;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.treeSelected);
            this.Controls.Add(this.listSelected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackbar1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.trackbar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label listSelected;
        private System.Windows.Forms.Label treeSelected;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button treeAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
    }
}