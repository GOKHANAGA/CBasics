namespace Giyotin
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
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.pnlPeople = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(464, 12);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(175, 51);
            this.btnFilePath.TabIndex = 0;
            this.btnFilePath.Text = "Öğrenci Listesi Seç";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(464, 69);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(175, 49);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Öğrencileri Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pnlPeople
            // 
            this.pnlPeople.AutoScroll = true;
            this.pnlPeople.Location = new System.Drawing.Point(12, 12);
            this.pnlPeople.Name = "pnlPeople";
            this.pnlPeople.Size = new System.Drawing.Size(446, 633);
            this.pnlPeople.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 657);
            this.Controls.Add(this.pnlPeople);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel pnlPeople;
    }
}

