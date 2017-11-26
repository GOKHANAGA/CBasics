namespace SilentCinema
{
    partial class ShowTickets
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
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(13, 13);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(270, 394);
            this.lstTickets.TabIndex = 0;
            // 
            // ShowTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 461);
            this.Controls.Add(this.lstTickets);
            this.Name = "ShowTickets";
            this.Text = "ShowTickets";
            this.Load += new System.EventHandler(this.ShowTickets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTickets;
    }
}