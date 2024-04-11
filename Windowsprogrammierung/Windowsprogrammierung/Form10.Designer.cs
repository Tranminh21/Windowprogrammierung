
namespace Windowsprogrammierung
{
    partial class Form10
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
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.weiterButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(657, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(131, 53);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(775, 63);
            this.progressBar1.TabIndex = 3;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(657, 120);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(131, 53);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // weiterButton
            // 
            this.weiterButton.Location = new System.Drawing.Point(657, 179);
            this.weiterButton.Name = "weiterButton";
            this.weiterButton.Size = new System.Drawing.Size(131, 53);
            this.weiterButton.TabIndex = 5;
            this.weiterButton.Text = "Weiter";
            this.weiterButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 356);
            this.textBox1.TabIndex = 6;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.weiterButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startButton);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button weiterButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}