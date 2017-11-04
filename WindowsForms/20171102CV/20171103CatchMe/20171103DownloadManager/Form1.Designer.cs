namespace _20171103DownloadManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnVS2013 = new System.Windows.Forms.RadioButton();
            this.rdbtnVS2015 = new System.Windows.Forms.RadioButton();
            this.rdbtnMSSQL2014 = new System.Windows.Forms.RadioButton();
            this.rdbtnMSOffice2017 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirmek istediğiniz programı seçin: ";
            // 
            // rdbtnVS2013
            // 
            this.rdbtnVS2013.AutoSize = true;
            this.rdbtnVS2013.Location = new System.Drawing.Point(54, 63);
            this.rdbtnVS2013.Name = "rdbtnVS2013";
            this.rdbtnVS2013.Size = new System.Drawing.Size(116, 17);
            this.rdbtnVS2013.TabIndex = 1;
            this.rdbtnVS2013.Text = "Visual Studio  2013";
            this.rdbtnVS2013.UseVisualStyleBackColor = true;
            this.rdbtnVS2013.CheckedChanged += new System.EventHandler(this.rdbtnVS2013_CheckedChanged);
            // 
            // rdbtnVS2015
            // 
            this.rdbtnVS2015.AutoSize = true;
            this.rdbtnVS2015.Location = new System.Drawing.Point(54, 87);
            this.rdbtnVS2015.Name = "rdbtnVS2015";
            this.rdbtnVS2015.Size = new System.Drawing.Size(113, 17);
            this.rdbtnVS2015.TabIndex = 2;
            this.rdbtnVS2015.Text = "Visual Studio 2015";
            this.rdbtnVS2015.UseVisualStyleBackColor = true;
            this.rdbtnVS2015.CheckedChanged += new System.EventHandler(this.rdbtnVS2015_CheckedChanged);
            // 
            // rdbtnMSSQL2014
            // 
            this.rdbtnMSSQL2014.AutoSize = true;
            this.rdbtnMSSQL2014.Location = new System.Drawing.Point(54, 111);
            this.rdbtnMSSQL2014.Name = "rdbtnMSSQL2014";
            this.rdbtnMSSQL2014.Size = new System.Drawing.Size(126, 17);
            this.rdbtnMSSQL2014.TabIndex = 3;
            this.rdbtnMSSQL2014.Text = "MS SQL Server 2014";
            this.rdbtnMSSQL2014.UseVisualStyleBackColor = true;
            this.rdbtnMSSQL2014.CheckedChanged += new System.EventHandler(this.rdbtnMSSQL2014_CheckedChanged);
            // 
            // rdbtnMSOffice2017
            // 
            this.rdbtnMSOffice2017.AutoSize = true;
            this.rdbtnMSOffice2017.Location = new System.Drawing.Point(54, 135);
            this.rdbtnMSOffice2017.Name = "rdbtnMSOffice2017";
            this.rdbtnMSOffice2017.Size = new System.Drawing.Size(99, 17);
            this.rdbtnMSOffice2017.TabIndex = 4;
            this.rdbtnMSOffice2017.Text = "MS Office 2017";
            this.rdbtnMSOffice2017.UseVisualStyleBackColor = true;
            this.rdbtnMSOffice2017.CheckedChanged += new System.EventHandler(this.rdbtnMSOffice2017_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 423);
            this.Controls.Add(this.rdbtnMSOffice2017);
            this.Controls.Add(this.rdbtnMSSQL2014);
            this.Controls.Add(this.rdbtnVS2015);
            this.Controls.Add(this.rdbtnVS2013);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnVS2013;
        private System.Windows.Forms.RadioButton rdbtnVS2015;
        private System.Windows.Forms.RadioButton rdbtnMSSQL2014;
        private System.Windows.Forms.RadioButton rdbtnMSOffice2017;
    }
}

