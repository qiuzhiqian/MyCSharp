using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] pathPic;
        int picId=0;

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = @"C:\";
            openFileDlg.Filter = "png文件|*.png|jpg文件|*.jpg|所有文件|*.*";
            openFileDlg.FilterIndex = 1;
            openFileDlg.Multiselect=true;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                pathPic = openFileDlg.FileNames;
                pathlbe.Text = pathPic[0];
                pictureBox1.Image = Image.FromFile(pathPic[0]);
                int lastindex = pathPic[0].LastIndexOf("\\");
                String dirpath = pathPic[0].Substring(0, lastindex);
                pathPic = Directory.GetFiles(dirpath);
                
            }

        }

        private void preBtn_Click(object sender, EventArgs e)
        {
            if (picId <= 0) picId = pathPic.Length-1;
            else
            {
                picId--;
            }
            pathlbe.Text = pathPic[picId];
            pictureBox1.Image = Image.FromFile(pathPic[picId]);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (picId < pathPic.Length - 1) picId++;
            else
            {
                picId = 0;
            }
            pathlbe.Text = pathPic[picId];
            pictureBox1.Image = Image.FromFile(pathPic[picId]);
        }

        private void V_DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void V_PlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void V_AutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void V_CenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
