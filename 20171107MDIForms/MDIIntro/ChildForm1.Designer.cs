namespace MDIIntro
{
    partial class ChildForm1
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
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtRecord
            // 
            this.txtRecord.Location = new System.Drawing.Point(13, 13);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(100, 20);
            this.txtRecord.TabIndex = 0;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(13, 39);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(100, 23);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Kayıt Ekle";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.Location = new System.Drawing.Point(152, 13);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(120, 186);
            this.lstRecords.TabIndex = 2;
            // 
            // ChildForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtRecord);
            this.Name = "ChildForm1";
            this.Text = "ChildForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ListBox lstRecords;
    }
}