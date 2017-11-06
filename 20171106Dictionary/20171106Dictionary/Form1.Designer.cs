namespace _20171106Dictionary
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCityCode = new System.Windows.Forms.TextBox();
            this.btnMoveToList = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 182);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(45, 46);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(132, 22);
            this.txtCityName.TabIndex = 1;
            // 
            // txtCityCode
            // 
            this.txtCityCode.Location = new System.Drawing.Point(45, 106);
            this.txtCityCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Size = new System.Drawing.Size(132, 22);
            this.txtCityCode.TabIndex = 2;
            // 
            // btnMoveToList
            // 
            this.btnMoveToList.Location = new System.Drawing.Point(45, 219);
            this.btnMoveToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveToList.Name = "btnMoveToList";
            this.btnMoveToList.Size = new System.Drawing.Size(100, 28);
            this.btnMoveToList.TabIndex = 3;
            this.btnMoveToList.Text = "Listeye Taşı";
            this.btnMoveToList.UseVisualStyleBackColor = true;
            this.btnMoveToList.Click += new System.EventHandler(this.btnMoveToList_Click);
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.ItemHeight = 16;
            this.lstRecords.Location = new System.Drawing.Point(203, 16);
            this.lstRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(159, 212);
            this.lstRecords.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şehir Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plaka Kodu :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.btnMoveToList);
            this.Controls.Add(this.txtCityCode);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCityCode;
        private System.Windows.Forms.Button btnMoveToList;
        private System.Windows.Forms.ListBox lstRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

