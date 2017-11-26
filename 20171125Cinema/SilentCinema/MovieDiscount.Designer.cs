namespace SilentCinema
{
    partial class MovieDiscount
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim Uygulanacak Filmi Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seçilen Film İçin İndirim Oranını Giriniz% :";
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(128, 71);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(243, 21);
            this.cmbMovie.TabIndex = 1;
            this.cmbMovie.SelectedIndexChanged += new System.EventHandler(this.cmbMovie_SelectedIndexChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(128, 134);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(243, 20);
            this.txtDiscount.TabIndex = 2;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(192, 255);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(102, 44);
            this.btnAddDiscount.TabIndex = 3;
            this.btnAddDiscount.Text = "İndirmi Onayla";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seçilen Filmin Şimdiki İndirim Oranı %:";
            // 
            // txtOldDiscount
            // 
            this.txtOldDiscount.Location = new System.Drawing.Point(128, 205);
            this.txtOldDiscount.Name = "txtOldDiscount";
            this.txtOldDiscount.Size = new System.Drawing.Size(243, 20);
            this.txtOldDiscount.TabIndex = 2;
            // 
            // MovieDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 324);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.txtOldDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovieDiscount";
            this.Text = "MovieDiscount";
            this.Load += new System.EventHandler(this.MovieDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldDiscount;
    }
}