namespace FileIO
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
            this.btnFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFileRead = new System.Windows.Forms.Button();
            this.btnFileWrite = new System.Windows.Forms.Button();
            this.rchFileText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchBinaryText = new System.Windows.Forms.RichTextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(13, 13);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(121, 54);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Dosya Seç";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(161, 13);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(377, 54);
            this.txtPath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchFileText);
            this.groupBox1.Controls.Add(this.btnFileWrite);
            this.groupBox1.Controls.Add(this.btnFileRead);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Stream";
            // 
            // btnFileRead
            // 
            this.btnFileRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileRead.Location = new System.Drawing.Point(6, 40);
            this.btnFileRead.Name = "btnFileRead";
            this.btnFileRead.Size = new System.Drawing.Size(130, 28);
            this.btnFileRead.TabIndex = 0;
            this.btnFileRead.Text = "Dosyadan Oku";
            this.btnFileRead.UseVisualStyleBackColor = true;
            this.btnFileRead.Click += new System.EventHandler(this.btnFileRead_Click);
            // 
            // btnFileWrite
            // 
            this.btnFileWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileWrite.Location = new System.Drawing.Point(241, 40);
            this.btnFileWrite.Name = "btnFileWrite";
            this.btnFileWrite.Size = new System.Drawing.Size(130, 28);
            this.btnFileWrite.TabIndex = 0;
            this.btnFileWrite.Text = "Dosyaya Yaz";
            this.btnFileWrite.UseVisualStyleBackColor = true;
            this.btnFileWrite.Click += new System.EventHandler(this.btnFileWrite_Click);
            // 
            // rchFileText
            // 
            this.rchFileText.Location = new System.Drawing.Point(7, 75);
            this.rchFileText.Name = "rchFileText";
            this.rchFileText.Size = new System.Drawing.Size(364, 110);
            this.rchFileText.TabIndex = 1;
            this.rchFileText.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchBinaryText);
            this.groupBox2.Controls.Add(this.btnBinaryWrite);
            this.groupBox2.Controls.Add(this.btnBinaryRead);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(396, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Binary Reader/Writer";
            // 
            // rchBinaryText
            // 
            this.rchBinaryText.Location = new System.Drawing.Point(7, 75);
            this.rchBinaryText.Name = "rchBinaryText";
            this.rchBinaryText.Size = new System.Drawing.Size(364, 110);
            this.rchBinaryText.TabIndex = 1;
            this.rchBinaryText.Text = "";
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBinaryWrite.Location = new System.Drawing.Point(224, 41);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(130, 28);
            this.btnBinaryWrite.TabIndex = 0;
            this.btnBinaryWrite.Text = "Dosyaya Yaz";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBinaryRead.Location = new System.Drawing.Point(7, 40);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(130, 28);
            this.btnBinaryRead.TabIndex = 0;
            this.btnBinaryRead.Text = "Dosyadan Oku";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFileWrite;
        private System.Windows.Forms.Button btnFileRead;
        private System.Windows.Forms.RichTextBox rchFileText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchBinaryText;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
    }
}

