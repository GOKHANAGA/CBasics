namespace CalarSaat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.lblAlarmText = new System.Windows.Forms.Label();
            this.txtAlarmText = new System.Windows.Forms.TextBox();
            this.btnAlarmStop = new System.Windows.Forms.Button();
            this.btnStartAlarm = new System.Windows.Forms.Button();
            this.pctHour = new System.Windows.Forms.PictureBox();
            this.tmrHour = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeCheck = new System.Windows.Forms.Timer(this.components);
            this.tmrAlarmOperations = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctHour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(13, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Tarih :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(101, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(13, 48);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Saat :";
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(101, 45);
            this.mskTime.Mask = "00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(200, 20);
            this.mskTime.TabIndex = 2;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblAlarmText
            // 
            this.lblAlarmText.AutoSize = true;
            this.lblAlarmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmText.Location = new System.Drawing.Point(13, 81);
            this.lblAlarmText.Name = "lblAlarmText";
            this.lblAlarmText.Size = new System.Drawing.Size(81, 13);
            this.lblAlarmText.TabIndex = 0;
            this.lblAlarmText.Text = "Alarm Metni :";
            // 
            // txtAlarmText
            // 
            this.txtAlarmText.BackColor = System.Drawing.Color.White;
            this.txtAlarmText.Location = new System.Drawing.Point(101, 73);
            this.txtAlarmText.Multiline = true;
            this.txtAlarmText.Name = "txtAlarmText";
            this.txtAlarmText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlarmText.Size = new System.Drawing.Size(200, 86);
            this.txtAlarmText.TabIndex = 3;
            // 
            // btnAlarmStop
            // 
            this.btnAlarmStop.BackgroundImage = global::CalarSaat.Properties.Resources.stop;
            this.btnAlarmStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlarmStop.Location = new System.Drawing.Point(422, 168);
            this.btnAlarmStop.Name = "btnAlarmStop";
            this.btnAlarmStop.Size = new System.Drawing.Size(80, 70);
            this.btnAlarmStop.TabIndex = 5;
            this.btnAlarmStop.UseVisualStyleBackColor = true;
            this.btnAlarmStop.Click += new System.EventHandler(this.btnAlarmStop_Click);
            // 
            // btnStartAlarm
            // 
            this.btnStartAlarm.BackgroundImage = global::CalarSaat.Properties.Resources.başlat;
            this.btnStartAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartAlarm.Location = new System.Drawing.Point(331, 168);
            this.btnStartAlarm.Name = "btnStartAlarm";
            this.btnStartAlarm.Size = new System.Drawing.Size(80, 70);
            this.btnStartAlarm.TabIndex = 5;
            this.btnStartAlarm.UseVisualStyleBackColor = true;
            this.btnStartAlarm.Click += new System.EventHandler(this.btnStartAlarm_Click);
            // 
            // pctHour
            // 
            this.pctHour.Image = global::CalarSaat.Properties.Resources.ÇalarSaat;
            this.pctHour.Location = new System.Drawing.Point(331, 13);
            this.pctHour.Name = "pctHour";
            this.pctHour.Size = new System.Drawing.Size(171, 146);
            this.pctHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHour.TabIndex = 4;
            this.pctHour.TabStop = false;
            // 
            // tmrHour
            // 
            this.tmrHour.Enabled = true;
            this.tmrHour.Interval = 1000;
            this.tmrHour.Tick += new System.EventHandler(this.tmrHour_Tick);
            // 
            // tmrTimeCheck
            // 
            this.tmrTimeCheck.Interval = 1000;
            this.tmrTimeCheck.Tick += new System.EventHandler(this.tmrTimeCheck_Tick);
            // 
            // tmrAlarmOperations
            // 
            this.tmrAlarmOperations.Interval = 1000;
            this.tmrAlarmOperations.Tick += new System.EventHandler(this.tmrAlarmOperations_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Çalar Saat";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 270);
            this.Controls.Add(this.btnAlarmStop);
            this.Controls.Add(this.btnStartAlarm);
            this.Controls.Add(this.pctHour);
            this.Controls.Add(this.txtAlarmText);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblAlarmText);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.Label lblAlarmText;
        private System.Windows.Forms.TextBox txtAlarmText;
        private System.Windows.Forms.PictureBox pctHour;
        private System.Windows.Forms.Button btnStartAlarm;
        private System.Windows.Forms.Button btnAlarmStop;
        private System.Windows.Forms.Timer tmrHour;
        private System.Windows.Forms.Timer tmrTimeCheck;
        private System.Windows.Forms.Timer tmrAlarmOperations;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

