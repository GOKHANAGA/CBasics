namespace JSONSerialization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialization = new System.Windows.Forms.Button();
            this.lstPerson = new System.Windows.Forms.ListBox();
            this.lstSerialized = new System.Windows.Forms.ListBox();
            this.lstDeserialized = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(108, 38);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(108, 64);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(108, 93);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 21);
            this.cmbGender.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(343, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(372, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Listeye Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(26, 194);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(372, 42);
            this.btnSerialize.TabIndex = 4;
            this.btnSerialize.Text = "Serialize Et";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialization
            // 
            this.btnDeserialization.Location = new System.Drawing.Point(433, 194);
            this.btnDeserialization.Name = "btnDeserialization";
            this.btnDeserialization.Size = new System.Drawing.Size(282, 42);
            this.btnDeserialization.TabIndex = 4;
            this.btnDeserialization.Text = "Deserilize Et";
            this.btnDeserialization.UseVisualStyleBackColor = true;
            this.btnDeserialization.Click += new System.EventHandler(this.btnDeserialization_Click);
            // 
            // lstPerson
            // 
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.Location = new System.Drawing.Point(344, 75);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(372, 95);
            this.lstPerson.TabIndex = 5;
            // 
            // lstSerialized
            // 
            this.lstSerialized.FormattingEnabled = true;
            this.lstSerialized.Location = new System.Drawing.Point(26, 256);
            this.lstSerialized.Name = "lstSerialized";
            this.lstSerialized.Size = new System.Drawing.Size(372, 95);
            this.lstSerialized.TabIndex = 5;
            // 
            // lstDeserialized
            // 
            this.lstDeserialized.FormattingEnabled = true;
            this.lstDeserialized.Location = new System.Drawing.Point(433, 256);
            this.lstDeserialized.Name = "lstDeserialized";
            this.lstDeserialized.Size = new System.Drawing.Size(282, 95);
            this.lstDeserialized.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 378);
            this.Controls.Add(this.lstDeserialized);
            this.Controls.Add(this.lstSerialized);
            this.Controls.Add(this.lstPerson);
            this.Controls.Add(this.btnDeserialization);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialization;
        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.ListBox lstSerialized;
        private System.Windows.Forms.ListBox lstDeserialized;
    }
}

