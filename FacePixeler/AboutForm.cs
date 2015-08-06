using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FacePixeler
{
    public class AboutForm : Form
    {
        private IContainer components = (IContainer) null;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private Label label7;
        private Button button1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;

        public AboutForm()
        {
            this.InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.gnu.org/licenses/lgpl.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.emgu.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.gnu.org/licenses/gpl.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://notes.ericwillis.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int num = (int) new IntelAgreement().ShowDialog((IWin32Window) this);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JaykeBird/FacePixeler");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/JaykeBird");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.linkLabel1 = new LinkLabel();
            this.linkLabel2 = new LinkLabel();
            this.label4 = new Label();
            this.label5 = new Label();
            this.linkLabel3 = new LinkLabel();
            this.linkLabel4 = new LinkLabel();
            this.label7 = new Label();
            this.button1 = new Button();
            this.linkLabel5 = new LinkLabel();
            this.linkLabel6 = new LinkLabel();
            this.linkLabel7 = new LinkLabel();
            this.label6 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();

            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face Pixeler software written by Jayke R. Huempfner";
            this.label10.AutoSize = true;
            this.label10.Location = new Point(12, 28);
            this.label10.Name = "label10";
            this.label10.Size = new Size(112, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Version 1.1";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made 30 March, 2015";
            this.label9.AutoSize = true;
            this.label9.Location = new Point(12, 54);
            this.label9.Name = "label9";
            this.label9.Size = new Size(112, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Updated 5 August, 2015";
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new Point(13, 67);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new Size(135, 13);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "View this project on GitHub";
            this.linkLabel5.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new Point(13, 80);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new Size(174, 13);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Find Jayke on Twitter (@JaykeBird)";
            this.linkLabel6.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);

            
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new Size((int) sbyte.MaxValue, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Licensed Under LGPL v3";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new Point(12, 119);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(145, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View the LGPL license online";
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new Size(147, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Includes the EmguCV libraries";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new Size(265, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Licensed Under GPL v3 (commercial version available)";
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new Point(12, 173);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new Size(56, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "emgu.com";
            this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new Point(12, 186);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new Size(143, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "View the GPL License online";
            this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);

            this.label7.AutoSize = true;
            this.label7.Location = new Point(12, 212);
            this.label7.Name = "label7";
            this.label7.Size = new Size(170, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Includes code written by Eric Willis";
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new Point(12, 225);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new Size(97, 13);
            this.linkLabel4.TabIndex = 6;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "notes.ericwillis.com";
            this.linkLabel4.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            
            this.label6.AutoSize = true;
            this.label6.Location = new Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new Size(241, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Includes Haas Cascade Data Written for OpenCV";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(12, 264);
            this.label8.Name = "label8";
            this.label8.Size = new Size(257, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Licensed by Intel Corporation under OpenCV License";
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new Point(13, 277);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new Size(189, 13);
            this.linkLabel7.TabIndex = 7;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "View the Intel License Agreement here";
            this.linkLabel7.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);


            this.button1.Location = new Point(107, 319);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);

            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 354);
            this.Controls.Add((Control) this.label8);
            this.Controls.Add((Control) this.linkLabel7);
            this.Controls.Add((Control) this.label6);
            this.Controls.Add((Control) this.linkLabel6);
            this.Controls.Add((Control) this.linkLabel5);
            this.Controls.Add((Control) this.button1);
            this.Controls.Add((Control) this.linkLabel4);
            this.Controls.Add((Control) this.label7);
            this.Controls.Add((Control) this.linkLabel3);
            this.Controls.Add((Control) this.linkLabel2);
            this.Controls.Add((Control) this.label4);
            this.Controls.Add((Control) this.label5);
            this.Controls.Add((Control) this.linkLabel1);
            this.Controls.Add((Control) this.label3);
            this.Controls.Add((Control) this.label2);
            this.Controls.Add((Control) this.label1);
            this.Controls.Add((Control) this.label10);
            this.Controls.Add((Control) this.label9);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About Face Pixeler";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
