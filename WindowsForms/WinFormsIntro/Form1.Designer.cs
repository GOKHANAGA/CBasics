namespace WinFormsIntro
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
            this.components = new System.ComponentModel.Container();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.chkOgrenci = new System.Windows.Forms.CheckBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblCityShow = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(83, 31);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(70, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Kullanıcı Adı :";
            this.lblAd.Click += new System.EventHandler(this.lblAd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(83, 66);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(34, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Şifre :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "İstanbul",
            "Konya",
            "Kocaeli",
            "Ankara",
            "Ağrı",
            "Ardahan",
            "Diyarbakır",
            "Bolu"});
            this.cmbCity.Location = new System.Drawing.Point(174, 95);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(100, 21);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(83, 103);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(74, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Şehir Seçiniz: ";
            // 
            // chkOgrenci
            // 
            this.chkOgrenci.AutoSize = true;
            this.chkOgrenci.Location = new System.Drawing.Point(174, 149);
            this.chkOgrenci.Name = "chkOgrenci";
            this.chkOgrenci.Size = new System.Drawing.Size(15, 14);
            this.chkOgrenci.TabIndex = 7;
            this.chkOgrenci.UseVisualStyleBackColor = true;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(86, 149);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(69, 13);
            this.lblCheck.TabIndex = 8;
            this.lblCheck.Text = "Ogrenci mi? :";
            this.lblCheck.MouseHover += new System.EventHandler(this.lblCheck_MouseHover);
            // 
            // lblCityShow
            // 
            this.lblCityShow.AutoSize = true;
            this.lblCityShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCityShow.Location = new System.Drawing.Point(464, 24);
            this.lblCityShow.Name = "lblCityShow";
            this.lblCityShow.Size = new System.Drawing.Size(37, 15);
            this.lblCityShow.TabIndex = 9;
            this.lblCityShow.Text = "label1";
            this.lblCityShow.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(174, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Gokhan";
            this.notifyIcon1.BalloonTipTitle = "Irmak";
            this.notifyIcon1.Text = "notifyGokhan";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 410);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCityShow);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.chkOgrenci);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAd);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "YeniForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.CheckBox chkOgrenci;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblCityShow;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

