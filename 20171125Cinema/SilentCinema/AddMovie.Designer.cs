namespace SilentCinema
{
    partial class AddMovie
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dtpStartOfRelease = new System.Windows.Forms.DateTimePicker();
            this.dtpEndOfRelease = new System.Windows.Forms.DateTimePicker();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vizyon Tarihi :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(64, 300);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 13);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "İndirim Oranı :";
            this.lblDiscount.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(154, 296);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.Visible = false;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(154, 134);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(200, 21);
            this.cmbGenre.TabIndex = 2;
            // 
            // dtpStartOfRelease
            // 
            this.dtpStartOfRelease.Location = new System.Drawing.Point(154, 196);
            this.dtpStartOfRelease.Name = "dtpStartOfRelease";
            this.dtpStartOfRelease.Size = new System.Drawing.Size(200, 20);
            this.dtpStartOfRelease.TabIndex = 3;
            // 
            // dtpEndOfRelease
            // 
            this.dtpEndOfRelease.Location = new System.Drawing.Point(406, 196);
            this.dtpEndOfRelease.Name = "dtpEndOfRelease";
            this.dtpEndOfRelease.Size = new System.Drawing.Size(200, 20);
            this.dtpEndOfRelease.TabIndex = 3;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(67, 273);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(131, 17);
            this.chkDiscount.TabIndex = 4;
            this.chkDiscount.Text = "İndirim Uygulansın Mı?";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.chkDiscount_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "--------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bitiş";
            // 
            // btnSaveMovie
            // 
            this.btnSaveMovie.Location = new System.Drawing.Point(295, 339);
            this.btnSaveMovie.Name = "btnSaveMovie";
            this.btnSaveMovie.Size = new System.Drawing.Size(106, 42);
            this.btnSaveMovie.TabIndex = 5;
            this.btnSaveMovie.Text = "Filmi Ekle";
            this.btnSaveMovie.UseVisualStyleBackColor = true;
            this.btnSaveMovie.Click += new System.EventHandler(this.btnSaveMovie_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 447);
            this.Controls.Add(this.btnSaveMovie);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.dtpEndOfRelease);
            this.Controls.Add(this.dtpStartOfRelease);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dtpStartOfRelease;
        private System.Windows.Forms.DateTimePicker dtpEndOfRelease;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveMovie;
    }
}