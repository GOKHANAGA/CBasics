namespace SilentCinema
{
    partial class SellTicket
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.dtpTicketDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTicketMovie = new System.Windows.Forms.ComboBox();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnSubmitTickets = new System.Windows.Forms.Button();
            this.btnCancelTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seçilen Film :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tarih :";
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(119, 39);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.ReadOnly = true;
            this.txtTicketID.Size = new System.Drawing.Size(200, 20);
            this.txtTicketID.TabIndex = 1;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(119, 219);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.ReadOnly = true;
            this.txtTicketPrice.Size = new System.Drawing.Size(200, 20);
            this.txtTicketPrice.TabIndex = 1;
            // 
            // dtpTicketDate
            // 
            this.dtpTicketDate.Location = new System.Drawing.Point(119, 99);
            this.dtpTicketDate.Name = "dtpTicketDate";
            this.dtpTicketDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTicketDate.TabIndex = 2;
            // 
            // cmbTicketMovie
            // 
            this.cmbTicketMovie.FormattingEnabled = true;
            this.cmbTicketMovie.Location = new System.Drawing.Point(119, 159);
            this.cmbTicketMovie.Name = "cmbTicketMovie";
            this.cmbTicketMovie.Size = new System.Drawing.Size(200, 21);
            this.cmbTicketMovie.TabIndex = 3;
            this.cmbTicketMovie.SelectedIndexChanged += new System.EventHandler(this.cmbTicketMovie_SelectedIndexChanged);
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Location = new System.Drawing.Point(45, 271);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(91, 33);
            this.btnNewTicket.TabIndex = 4;
            this.btnNewTicket.Text = "Bilet Ekle";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // btnSubmitTickets
            // 
            this.btnSubmitTickets.Location = new System.Drawing.Point(158, 271);
            this.btnSubmitTickets.Name = "btnSubmitTickets";
            this.btnSubmitTickets.Size = new System.Drawing.Size(91, 33);
            this.btnSubmitTickets.TabIndex = 4;
            this.btnSubmitTickets.Text = "Biletleri Onayla";
            this.btnSubmitTickets.UseVisualStyleBackColor = true;
            this.btnSubmitTickets.Click += new System.EventHandler(this.btnSubmitTickets_Click);
            // 
            // btnCancelTickets
            // 
            this.btnCancelTickets.Location = new System.Drawing.Point(271, 271);
            this.btnCancelTickets.Name = "btnCancelTickets";
            this.btnCancelTickets.Size = new System.Drawing.Size(91, 33);
            this.btnCancelTickets.TabIndex = 4;
            this.btnCancelTickets.Text = "Bilet İptal";
            this.btnCancelTickets.UseVisualStyleBackColor = true;
            this.btnCancelTickets.Click += new System.EventHandler(this.btnCancelTickets_Click);
            // 
            // SellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 325);
            this.Controls.Add(this.btnCancelTickets);
            this.Controls.Add(this.btnSubmitTickets);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.cmbTicketMovie);
            this.Controls.Add(this.dtpTicketDate);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.txtTicketID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellTicket";
            this.Text = "SellTicket";
            this.Load += new System.EventHandler(this.SellTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.DateTimePicker dtpTicketDate;
        private System.Windows.Forms.ComboBox cmbTicketMovie;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnSubmitTickets;
        private System.Windows.Forms.Button btnCancelTickets;
    }
}