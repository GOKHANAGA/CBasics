namespace SilentCinema
{
    partial class DeleteGenre
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
            this.cmbMovieGenres = new System.Windows.Forms.ComboBox();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Türü Seçiniz :";
            // 
            // cmbMovieGenres
            // 
            this.cmbMovieGenres.FormattingEnabled = true;
            this.cmbMovieGenres.Location = new System.Drawing.Point(194, 55);
            this.cmbMovieGenres.Name = "cmbMovieGenres";
            this.cmbMovieGenres.Size = new System.Drawing.Size(165, 21);
            this.cmbMovieGenres.TabIndex = 1;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(134, 115);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(138, 52);
            this.btnDeleteGenre.TabIndex = 2;
            this.btnDeleteGenre.Text = "Film Türünü Sil";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // DeleteGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 219);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.cmbMovieGenres);
            this.Controls.Add(this.label1);
            this.Name = "DeleteGenre";
            this.Text = "DeleteGenre";
            this.Load += new System.EventHandler(this.DeleteGenre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMovieGenres;
        private System.Windows.Forms.Button btnDeleteGenre;
    }
}