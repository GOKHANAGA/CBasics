namespace _20171108Project
{
    partial class Form1
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnCreatepath = new System.Windows.Forms.Button();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.treeViewDrives = new System.Windows.Forms.TreeView();
            this.treeViewFolders = new System.Windows.Forms.TreeView();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetDrives = new System.Windows.Forms.Button();
            this.btnGetFolders = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.txtMovePath = new System.Windows.Forms.TextBox();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.btnMovePath = new System.Windows.Forms.Button();
            this.btnCurrentPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(378, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(13, 39);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Dosya Seç";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnCreatepath
            // 
            this.btnCreatepath.Location = new System.Drawing.Point(217, 39);
            this.btnCreatepath.Name = "btnCreatepath";
            this.btnCreatepath.Size = new System.Drawing.Size(75, 23);
            this.btnCreatepath.TabIndex = 2;
            this.btnCreatepath.Text = "Dizin Oluştur";
            this.btnCreatepath.UseVisualStyleBackColor = true;
            this.btnCreatepath.Click += new System.EventHandler(this.btnCreatepath_Click);
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Location = new System.Drawing.Point(299, 39);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePath.TabIndex = 3;
            this.btnDeletePath.Text = "Dizin Sil";
            this.btnDeletePath.UseVisualStyleBackColor = true;
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // treeViewDrives
            // 
            this.treeViewDrives.Location = new System.Drawing.Point(12, 85);
            this.treeViewDrives.Name = "treeViewDrives";
            this.treeViewDrives.Size = new System.Drawing.Size(160, 124);
            this.treeViewDrives.TabIndex = 4;
            // 
            // treeViewFolders
            // 
            this.treeViewFolders.Location = new System.Drawing.Point(178, 85);
            this.treeViewFolders.Name = "treeViewFolders";
            this.treeViewFolders.Size = new System.Drawing.Size(158, 124);
            this.treeViewFolders.TabIndex = 5;
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(342, 85);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(157, 124);
            this.treeViewFiles.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCurrentPath);
            this.groupBox1.Controls.Add(this.btnMovePath);
            this.groupBox1.Controls.Add(this.txtNewPath);
            this.groupBox1.Controls.Add(this.txtMovePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dizin Taşıma";
            // 
            // btnGetDrives
            // 
            this.btnGetDrives.Location = new System.Drawing.Point(57, 215);
            this.btnGetDrives.Name = "btnGetDrives";
            this.btnGetDrives.Size = new System.Drawing.Size(75, 37);
            this.btnGetDrives.TabIndex = 8;
            this.btnGetDrives.Text = "Diskleri Getir";
            this.btnGetDrives.UseVisualStyleBackColor = true;
            this.btnGetDrives.Click += new System.EventHandler(this.btnGetDrives_Click);
            // 
            // btnGetFolders
            // 
            this.btnGetFolders.Location = new System.Drawing.Point(225, 216);
            this.btnGetFolders.Name = "btnGetFolders";
            this.btnGetFolders.Size = new System.Drawing.Size(75, 37);
            this.btnGetFolders.TabIndex = 9;
            this.btnGetFolders.Text = "İçindeki Klasörler";
            this.btnGetFolders.UseVisualStyleBackColor = true;
            this.btnGetFolders.Click += new System.EventHandler(this.btnGetFolders_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(397, 216);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(75, 37);
            this.btnGetFiles.TabIndex = 10;
            this.btnGetFiles.Text = "İçindeki Dosyalar";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // txtMovePath
            // 
            this.txtMovePath.Location = new System.Drawing.Point(99, 31);
            this.txtMovePath.Name = "txtMovePath";
            this.txtMovePath.Size = new System.Drawing.Size(251, 20);
            this.txtMovePath.TabIndex = 0;
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(99, 59);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(251, 20);
            this.txtNewPath.TabIndex = 1;
            // 
            // btnMovePath
            // 
            this.btnMovePath.Location = new System.Drawing.Point(192, 85);
            this.btnMovePath.Name = "btnMovePath";
            this.btnMovePath.Size = new System.Drawing.Size(75, 23);
            this.btnMovePath.TabIndex = 2;
            this.btnMovePath.Text = "Taşı";
            this.btnMovePath.UseVisualStyleBackColor = true;
            this.btnMovePath.Click += new System.EventHandler(this.btnMovePath_Click);
            // 
            // btnCurrentPath
            // 
            this.btnCurrentPath.Location = new System.Drawing.Point(360, 28);
            this.btnCurrentPath.Name = "btnCurrentPath";
            this.btnCurrentPath.Size = new System.Drawing.Size(105, 80);
            this.btnCurrentPath.TabIndex = 3;
            this.btnCurrentPath.Text = "Neredeyim";
            this.btnCurrentPath.UseVisualStyleBackColor = true;
            this.btnCurrentPath.Click += new System.EventHandler(this.btnCurrentPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taşınacak Dizin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Dizin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 399);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnGetFolders);
            this.Controls.Add(this.btnGetDrives);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeViewFiles);
            this.Controls.Add(this.treeViewFolders);
            this.Controls.Add(this.treeViewDrives);
            this.Controls.Add(this.btnDeletePath);
            this.Controls.Add(this.btnCreatepath);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnCreatepath;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.TreeView treeViewDrives;
        private System.Windows.Forms.TreeView treeViewFolders;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCurrentPath;
        private System.Windows.Forms.Button btnMovePath;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.TextBox txtMovePath;
        private System.Windows.Forms.Button btnGetDrives;
        private System.Windows.Forms.Button btnGetFolders;
        private System.Windows.Forms.Button btnGetFiles;
    }
}

