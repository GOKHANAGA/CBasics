namespace SilentCinema
{
    partial class AddMovieGenre
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
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.btnSaveGenre = new System.Windows.Forms.Button();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Türünün Adı :";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(142, 50);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(267, 20);
            this.txtGenreName.TabIndex = 1;
            // 
            // btnSaveGenre
            // 
            this.btnSaveGenre.Location = new System.Drawing.Point(165, 186);
            this.btnSaveGenre.Name = "btnSaveGenre";
            this.btnSaveGenre.Size = new System.Drawing.Size(97, 33);
            this.btnSaveGenre.TabIndex = 2;
            this.btnSaveGenre.Text = "Kaydet";
            this.btnSaveGenre.UseVisualStyleBackColor = true;
            this.btnSaveGenre.Click += new System.EventHandler(this.btnSaveGenre_Click);
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(47, 106);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(131, 17);
            this.chkDiscount.TabIndex = 3;
            this.chkDiscount.Text = "İndirim Uygulansın Mı?";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.chkDiscount_CheckedChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(134, 134);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(44, 138);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "İndirim Oranı :";
            this.lblDiscount.Visible = false;
            // 
            // AddMovieGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.btnSaveGenre);
            this.Controls.Add(this.txtGenreName);
            this.Controls.Add(this.label1);
            this.Name = "AddMovieGenre";
            this.Text = "AddMovieGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Button btnSaveGenre;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
    }
}