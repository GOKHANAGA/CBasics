namespace SilentCinema
{
    partial class GenreDiscount
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
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldDiscountRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim Yapılacak Türü Seçiniz :";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(127, 218);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(99, 30);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "İndirimi Onayla";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // cmbGenres
            // 
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(62, 47);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(229, 21);
            this.cmbGenres.TabIndex = 3;
            this.cmbGenres.SelectedIndexChanged += new System.EventHandler(this.cmbGenres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İndirim Oranını Giriniz % :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(62, 123);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(229, 20);
            this.txtDiscount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kayıtlı İndirim Oranı %:";
            // 
            // txtOldDiscountRate
            // 
            this.txtOldDiscountRate.Location = new System.Drawing.Point(62, 178);
            this.txtOldDiscountRate.Name = "txtOldDiscountRate";
            this.txtOldDiscountRate.ReadOnly = true;
            this.txtOldDiscountRate.Size = new System.Drawing.Size(229, 20);
            this.txtOldDiscountRate.TabIndex = 5;
            // 
            // GenreDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 260);
            this.Controls.Add(this.txtOldDiscountRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.label1);
            this.Name = "GenreDiscount";
            this.Text = "GenreDiscount";
            this.Load += new System.EventHandler(this.GenreDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldDiscountRate;
    }
}