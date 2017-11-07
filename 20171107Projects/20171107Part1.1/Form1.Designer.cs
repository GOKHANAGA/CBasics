namespace _20171107Part1._1
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
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMessageCount = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecondNr = new System.Windows.Forms.TextBox();
            this.txtFirstNr = new System.Windows.Forms.TextBox();
            this.btnGetPrime = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNrToFraction = new System.Windows.Forms.TextBox();
            this.btnGetFraction = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstConvertedNumber = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblSplitSecond = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnWait = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnClearBar = new System.Windows.Forms.Button();
            this.btnStartFilling = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtTimerToProgress = new System.Windows.Forms.TextBox();
            this.btnClearProgressTime = new System.Windows.Forms.Button();
            this.btnStartProgressTime = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.tmrTimeLimited = new System.Windows.Forms.Timer(this.components);
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnLivedDays = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(34, 39);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(132, 22);
            this.txtLimit.TabIndex = 0;
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(32, 71);
            this.btnShowMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(133, 27);
            this.btnShowMessage.TabIndex = 1;
            this.btnShowMessage.Text = "Sayıları Göster";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLimit);
            this.groupBox1.Controls.Add(this.btnShowMessage);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(223, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirtilen Sayıya Kadar Sayma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMessageCount);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Location = new System.Drawing.Point(16, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(223, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yazılan Mesajı Verilen Sayı Kadar Tekrarla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mesaj Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mesajınız :";
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.Location = new System.Drawing.Point(20, 111);
            this.txtMessageCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(132, 22);
            this.txtMessageCount.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(20, 68);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(132, 22);
            this.txtMessage.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(19, 158);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(133, 27);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Mesajı Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSecondNr);
            this.groupBox3.Controls.Add(this.txtFirstNr);
            this.groupBox3.Controls.Add(this.btnGetPrime);
            this.groupBox3.Location = new System.Drawing.Point(259, 173);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(216, 238);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İki Sayı Arasındaki Asal Sayılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İkinci Sayınızı Giriniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlk Sayınızı Giriniz :";
            // 
            // txtSecondNr
            // 
            this.txtSecondNr.Location = new System.Drawing.Point(24, 119);
            this.txtSecondNr.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondNr.Name = "txtSecondNr";
            this.txtSecondNr.Size = new System.Drawing.Size(132, 22);
            this.txtSecondNr.TabIndex = 0;
            // 
            // txtFirstNr
            // 
            this.txtFirstNr.Location = new System.Drawing.Point(27, 65);
            this.txtFirstNr.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstNr.Name = "txtFirstNr";
            this.txtFirstNr.Size = new System.Drawing.Size(132, 22);
            this.txtFirstNr.TabIndex = 0;
            // 
            // btnGetPrime
            // 
            this.btnGetPrime.Location = new System.Drawing.Point(24, 166);
            this.btnGetPrime.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetPrime.Name = "btnGetPrime";
            this.btnGetPrime.Size = new System.Drawing.Size(133, 27);
            this.btnGetPrime.TabIndex = 1;
            this.btnGetPrime.Text = "Asal Göster";
            this.btnGetPrime.UseVisualStyleBackColor = true;
            this.btnGetPrime.Click += new System.EventHandler(this.btnGetPrime_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNrToFraction);
            this.groupBox4.Controls.Add(this.btnGetFraction);
            this.groupBox4.Location = new System.Drawing.Point(259, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(216, 150);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ondalıklı Sayı Kontrolü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sayınızı Giriniz :";
            // 
            // txtNrToFraction
            // 
            this.txtNrToFraction.Location = new System.Drawing.Point(27, 39);
            this.txtNrToFraction.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrToFraction.Name = "txtNrToFraction";
            this.txtNrToFraction.Size = new System.Drawing.Size(132, 22);
            this.txtNrToFraction.TabIndex = 0;
            // 
            // btnGetFraction
            // 
            this.btnGetFraction.Location = new System.Drawing.Point(27, 71);
            this.btnGetFraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFraction.Name = "btnGetFraction";
            this.btnGetFraction.Size = new System.Drawing.Size(133, 27);
            this.btnGetFraction.TabIndex = 1;
            this.btnGetFraction.Text = "Sonuç Göster";
            this.btnGetFraction.UseVisualStyleBackColor = true;
            this.btnGetFraction.Click += new System.EventHandler(this.btnGetFraction_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstConvertedNumber);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtBinary);
            this.groupBox5.Controls.Add(this.txtDecimal);
            this.groupBox5.Controls.Add(this.btnConvert);
            this.groupBox5.Location = new System.Drawing.Point(487, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(433, 205);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decimal-Binary Çevirici";
            // 
            // lstConvertedNumber
            // 
            this.lstConvertedNumber.FormattingEnabled = true;
            this.lstConvertedNumber.ItemHeight = 16;
            this.lstConvertedNumber.Location = new System.Drawing.Point(181, 39);
            this.lstConvertedNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lstConvertedNumber.Name = "lstConvertedNumber";
            this.lstConvertedNumber.Size = new System.Drawing.Size(223, 132);
            this.lstConvertedNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Binary Değer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Onluk Değer :";
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(27, 98);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(4);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(132, 22);
            this.txtBinary.TabIndex = 0;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(27, 44);
            this.txtDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(132, 22);
            this.txtDecimal.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(27, 145);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 27);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Dönüştür";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnChangeName);
            this.groupBox6.Controls.Add(this.pictureBox5);
            this.groupBox6.Controls.Add(this.pictureBox4);
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(501, 467);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(537, 161);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Form Arka Planı Değiştir";
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(213, 106);
            this.btnChangeName.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(139, 28);
            this.btnChangeName.TabIndex = 1;
            this.btnChangeName.Text = "Renk Değiştir";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_20171107Part1._1.Properties.Resources.Solid_Purple;
            this.pictureBox5.Location = new System.Drawing.Point(452, 21);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 64);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_20171107Part1._1.Properties.Resources.orange;
            this.pictureBox4.Location = new System.Drawing.Point(346, 21);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 64);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_20171107Part1._1.Properties.Resources.blue;
            this.pictureBox3.Location = new System.Drawing.Point(234, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 64);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_20171107Part1._1.Properties.Resources.indir;
            this.pictureBox2.Location = new System.Drawing.Point(120, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_20171107Part1._1.Properties.Resources.red;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblSplitSecond);
            this.groupBox7.Controls.Add(this.lblSecond);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.lblMinute);
            this.groupBox7.Controls.Add(this.btnStop);
            this.groupBox7.Controls.Add(this.btnWait);
            this.groupBox7.Controls.Add(this.btnStart);
            this.groupBox7.Location = new System.Drawing.Point(16, 418);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(459, 211);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kronometre";
            // 
            // lblSplitSecond
            // 
            this.lblSplitSecond.AutoSize = true;
            this.lblSplitSecond.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSplitSecond.Location = new System.Drawing.Point(305, 49);
            this.lblSplitSecond.Name = "lblSplitSecond";
            this.lblSplitSecond.Size = new System.Drawing.Size(87, 67);
            this.lblSplitSecond.TabIndex = 3;
            this.lblSplitSecond.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.Location = new System.Drawing.Point(180, 49);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(87, 67);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(255, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 67);
            this.label12.TabIndex = 1;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(136, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 67);
            this.label11.TabIndex = 1;
            this.label11.Text = ":";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinute.Location = new System.Drawing.Point(57, 49);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(87, 67);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "00";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(273, 147);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 36);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(171, 147);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(96, 36);
            this.btnWait.TabIndex = 0;
            this.btnWait.Text = "Duraklat";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(69, 147);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnClearBar);
            this.groupBox8.Controls.Add(this.btnStartFilling);
            this.groupBox8.Controls.Add(this.progressBar1);
            this.groupBox8.Location = new System.Drawing.Point(833, 238);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(310, 211);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Progress Bar Doldurma";
            // 
            // btnClearBar
            // 
            this.btnClearBar.Location = new System.Drawing.Point(163, 151);
            this.btnClearBar.Name = "btnClearBar";
            this.btnClearBar.Size = new System.Drawing.Size(86, 36);
            this.btnClearBar.TabIndex = 1;
            this.btnClearBar.Text = "Sıfırla";
            this.btnClearBar.UseVisualStyleBackColor = true;
            this.btnClearBar.Click += new System.EventHandler(this.btnClearBar_Click);
            // 
            // btnStartFilling
            // 
            this.btnStartFilling.Location = new System.Drawing.Point(63, 151);
            this.btnStartFilling.Name = "btnStartFilling";
            this.btnStartFilling.Size = new System.Drawing.Size(86, 36);
            this.btnStartFilling.TabIndex = 1;
            this.btnStartFilling.Text = "Başla";
            this.btnStartFilling.UseVisualStyleBackColor = true;
            this.btnStartFilling.Click += new System.EventHandler(this.btnStartFilling_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 41);
            this.progressBar1.TabIndex = 0;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.txtTimerToProgress);
            this.groupBox9.Controls.Add(this.btnClearProgressTime);
            this.groupBox9.Controls.Add(this.btnStartProgressTime);
            this.groupBox9.Controls.Add(this.progressBar2);
            this.groupBox9.Location = new System.Drawing.Point(501, 238);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(307, 211);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ProgressBar Süre Sınırlı Doldurma";
            // 
            // txtTimerToProgress
            // 
            this.txtTimerToProgress.Location = new System.Drawing.Point(20, 61);
            this.txtTimerToProgress.Name = "txtTimerToProgress";
            this.txtTimerToProgress.Size = new System.Drawing.Size(260, 22);
            this.txtTimerToProgress.TabIndex = 2;
            // 
            // btnClearProgressTime
            // 
            this.btnClearProgressTime.Location = new System.Drawing.Point(159, 151);
            this.btnClearProgressTime.Name = "btnClearProgressTime";
            this.btnClearProgressTime.Size = new System.Drawing.Size(86, 36);
            this.btnClearProgressTime.TabIndex = 1;
            this.btnClearProgressTime.Text = "Sıfırla";
            this.btnClearProgressTime.UseVisualStyleBackColor = true;
            this.btnClearProgressTime.Click += new System.EventHandler(this.btnClearProgressTime_Click);
            // 
            // btnStartProgressTime
            // 
            this.btnStartProgressTime.Location = new System.Drawing.Point(59, 151);
            this.btnStartProgressTime.Name = "btnStartProgressTime";
            this.btnStartProgressTime.Size = new System.Drawing.Size(86, 36);
            this.btnStartProgressTime.TabIndex = 1;
            this.btnStartProgressTime.Text = "Başla";
            this.btnStartProgressTime.UseVisualStyleBackColor = true;
            this.btnStartProgressTime.Click += new System.EventHandler(this.btnStartProgressTime_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(20, 104);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(260, 41);
            this.progressBar2.TabIndex = 0;
            // 
            // tmrTimeLimited
            // 
            this.tmrTimeLimited.Interval = 1000;
            this.tmrTimeLimited.Tick += new System.EventHandler(this.tmrTimeLimited_Tick);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(10, 76);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 22);
            this.birthDatePicker.TabIndex = 8;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.btnLivedDays);
            this.groupBox10.Controls.Add(this.birthDatePicker);
            this.groupBox10.Location = new System.Drawing.Point(927, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(216, 205);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Yaşanılan Gün Sayısı Bulma";
            // 
            // btnLivedDays
            // 
            this.btnLivedDays.Location = new System.Drawing.Point(33, 118);
            this.btnLivedDays.Name = "btnLivedDays";
            this.btnLivedDays.Size = new System.Drawing.Size(162, 54);
            this.btnLivedDays.TabIndex = 9;
            this.btnLivedDays.Text = "Gün Sayısını Getir";
            this.btnLivedDays.UseVisualStyleBackColor = true;
            this.btnLivedDays.Click += new System.EventHandler(this.btnLivedDays_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "İşlem Süresi Giriniz :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Doğum Gününüzü Seçiniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 641);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessageCount;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecondNr;
        private System.Windows.Forms.TextBox txtFirstNr;
        private System.Windows.Forms.Button btnGetPrime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrToFraction;
        private System.Windows.Forms.Button btnGetFraction;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ListBox lstConvertedNumber;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblSplitSecond;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnClearBar;
        private System.Windows.Forms.Button btnStartFilling;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtTimerToProgress;
        private System.Windows.Forms.Button btnClearProgressTime;
        private System.Windows.Forms.Button btnStartProgressTime;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer tmrTimeLimited;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnLivedDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

