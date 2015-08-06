using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using System.IO;

namespace FacePixeler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.cbbEffect.SelectedIndex = 1;

            this.bkgdWorker.DoWork += bkgdWorker_DoWork;
            this.bkgdWorker.ProgressChanged += bkgdWorker_ProgressChanged;
            this.bkgdWorker.RunWorkerCompleted += bkgdWorker_RunWorkerCompleted;
        }

        #region Image Processing

        void bkgdWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
        }

        private void bkgdWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == -1)
            {
                ((ListViewItem) e.UserState).SubItems[3].Text = "\u2611";
            }
            else
            {
                ((ListViewItem) e.UserState).SubItems[2].Text = e.ProgressPercentage.ToString();
            }
        }

        private void bkgdWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Tuple<List<ListViewItem>, string, int, int> tuple = (Tuple<List<ListViewItem>, string, int, int>) e.Argument;
            foreach (ListViewItem listViewItem in tuple.Item1)
            {
                
                this.HandleImage(listViewItem, tuple.Item2, tuple.Item3, tuple.Item4);
            }
        }

        private void HandleImage(ListViewItem item, string dir, int effect, int strength)
        {
            Image<Bgr, byte> image1 = new Image<Bgr, byte>(item.SubItems[1].Text);
            List<Rectangle> list = FaceDetection.Detect(image1, "haarcascade_frontalface_default.xml");
            this.bkgdWorker.ReportProgress(list.Count, (object) item);
            Bitmap image2 = image1.ToBitmap();

            if (effect != 2)
            {
                bool usePixelate = (effect == 1) ? true : false;

                foreach (Rectangle rectangle in list)
                {
                    image2 = usePixelate ? ImageProcessor.Pixelate(image2, rectangle, strength) : ImageProcessor.Blur(image2, rectangle, strength);
                }
            }

            string text = item.SubItems[0].Text;
            string str1 = ".png";
            string str2 = dir + "\\" + text.Substring(0, text.LastIndexOf("."));
            bool flag = true;
            int num = 0;
            string str3 = "";
            while (flag)
            {
                if (File.Exists(str2 + str3 + str1))
                {
                    ++num;
                    str3 = "(" + num.ToString() + ")";
                }
                else
                    flag = false;
            }
            image2.Save(str2 + str3 + str1);
            image2.Dispose();
            image1.Dispose();
            this.bkgdWorker.ReportProgress(-1, (object) item);
        }

        #endregion

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // set up output path
            string path = this.txtOutput.Text.Replace("/", "\\");
            if (path.EndsWith("\\"))
            {
                path = path.Substring(0, path.Length - 1);
            }

            new DirectoryInfo(path).Create(); // "if this directory already exists, this method does nothing"

            int effect = this.cbbEffect.SelectedIndex;
            int num = Convert.ToInt32(this.nbbStrength.Value);

            List<ListViewItem> list = new List<ListViewItem>();

            foreach (ListViewItem item in this.listInput.Items)
            {
                item.SubItems[3].Text = "\u2610";
                list.Add(item);
            }

            this.btnStart.Enabled = false;
            this.bkgdWorker.RunWorkerAsync(new Tuple<List<ListViewItem>, string, int, int>(list, path, effect, num));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ImagesDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in this.ImagesDialog.FileNames)
                {
                    ListViewItem listViewItem = this.listInput.Items.Add(new FileInfo(str).Name);
                    listViewItem.SubItems.Add(str);
                    listViewItem.SubItems.Add("-");
                    listViewItem.SubItems.Add("\u2610");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.listInput.SelectedIndices.Count != 0)
            {
                List<ListViewItem> list = new List<ListViewItem>();

                foreach (ListViewItem listViewItem in this.listInput.SelectedItems)
                {
                    list.Add(listViewItem);
                }
                list.Reverse();
                foreach (ListViewItem listViewItem in list)
                {
                    this.listInput.Items.Remove(listViewItem);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.OutputDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = this.OutputDialog.SelectedPath;
            }
        }

    }
}
