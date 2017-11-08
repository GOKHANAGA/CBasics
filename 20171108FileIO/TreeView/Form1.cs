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

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*----GetLogicalDrives() metodu bilgisayarda var olan sürücüleri getirir----*/
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                /*----TreeView de eklediğimiz her bir alana node denir----*/
                TreeNode driveNode = new TreeNode(drive);

                treeView.Nodes.Add(driveNode);
                try
                {

                    string[] driveFiles = Directory.GetFiles(drive);
                    foreach (string file in driveFiles)
                    {
                        driveNode.Nodes.Add(file);
                    }
                    /*----GetDirectories(drive) drive içindeki sürücü klasörlerini getirir----*/
                    string[] childFolders = Directory.GetDirectories(drive);

                    foreach (string folder in childFolders)
                    {
                        TreeNode childNode = new TreeNode(folder);
                        driveNode.Nodes.Add(childNode);
                        string[] childFiles = Directory.GetDirectories(folder);
                        foreach (string files in childFiles)
                        {
                            childNode.Nodes.Add(files);
                        }
                    }


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Hata");
                }
            }
        }
    }
}
