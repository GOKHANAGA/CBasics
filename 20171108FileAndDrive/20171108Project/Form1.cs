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

namespace _20171108Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath;

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Tüm Dosyalar |*.*";
            fd.ShowDialog();

            filePath = fd.FileName;
            txtPath.Text = filePath;
        }

        private void btnCreatepath_Click(object sender, EventArgs e)
        {
            filePath = txtPath.Text+".txt";
            FileStream fs = new FileStream(filePath,FileMode.Create);
            txtPath.Text = string.Empty;
            MessageBox.Show("İşlem Tamamlandı.");

            fs.Close();
        }

        private void btnDeletePath_Click(object sender, EventArgs e)
        {
            filePath = txtPath.Text;
            int index = filePath.LastIndexOf("\\");
            string fileName = filePath.Substring(index, filePath.Length - index);
            File.Delete(filePath);
            MessageBox.Show(fileName.Substring(1) +" Silindi");
            txtPath.Text = string.Empty;
        }

        private void btnGetDrives_Click(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode driveNode = new TreeNode(drive);

                treeViewDrives.Nodes.Add(driveNode);
            }
        }

        private void btnGetFolders_Click(object sender, EventArgs e)
        {
            string[] subFolders = Directory.GetDirectories(treeViewDrives.SelectedNode.Text);

            foreach (string folders in subFolders)
            {
                TreeNode subNode = new TreeNode(folders);
                treeViewFolders.Nodes.Add(folders);
            }


        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            string[] subFiles = Directory.GetFiles(treeViewDrives.SelectedNode.Text);

            foreach (string files in subFiles)
            {
                TreeNode subNode = new TreeNode(files);
                treeViewFiles.Nodes.Add(files);
            }
        }

        private void btnCurrentPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void btnMovePath_Click(object sender, EventArgs e)
        {
            string oldDirectory = txtMovePath.Text;
            string newDirectory = txtNewPath.Text;
            File.Move(oldDirectory, newDirectory);
            MessageBox.Show("Dosya Taşıma Tamamlandı.");
            txtMovePath.Text = string.Empty;
            txtNewPath.Text = string.Empty;
        }


    }
}
