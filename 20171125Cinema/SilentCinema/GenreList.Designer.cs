namespace SilentCinema
{
    partial class GenreList
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
            this.lstGenres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstGenres
            // 
            this.lstGenres.FormattingEnabled = true;
            this.lstGenres.Location = new System.Drawing.Point(13, 13);
            this.lstGenres.Name = "lstGenres";
            this.lstGenres.Size = new System.Drawing.Size(264, 407);
            this.lstGenres.TabIndex = 0;
            // 
            // GenreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 446);
            this.Controls.Add(this.lstGenres);
            this.Name = "GenreList";
            this.Text = "GenreList";
            this.Load += new System.EventHandler(this.GenreList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGenres;
    }
}