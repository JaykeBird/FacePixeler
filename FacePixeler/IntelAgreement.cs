using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacePixeler
{
    public partial class IntelAgreement : Form
    {
        public IntelAgreement()
        {
            InitializeComponent();
        }

        private void IntelAgreement_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(Path.GetDirectoryName(
                    Application.ExecutablePath) + "\\IntelLicenseAgreement.txt");
                //string data = reader.ReadToEnd();
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not the 'IntelLicenseAgreement.txt' file.\n\n" + 
                    "Make sure this program was compiled correctly. You can view a copy" +
                    " of this file at the project's GitHub location, shown on the" +
                    "About dialog");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
