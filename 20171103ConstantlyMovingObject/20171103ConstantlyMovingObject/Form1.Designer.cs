namespace _20171103ConstantlyMovingObject
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
            this.btnMovingObject = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnNorthWest = new System.Windows.Forms.Button();
            this.btnNorthEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouthWest = new System.Windows.Forms.Button();
            this.btnSouthEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMovingObject
            // 
            this.btnMovingObject.Location = new System.Drawing.Point(33, 317);
            this.btnMovingObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMovingObject.Name = "btnMovingObject";
            this.btnMovingObject.Size = new System.Drawing.Size(100, 28);
            this.btnMovingObject.TabIndex = 0;
            this.btnMovingObject.Text = "button1";
            this.btnMovingObject.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(587, 271);
            this.btnNorth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(84, 68);
            this.btnNorth.TabIndex = 1;
            this.btnNorth.Text = "Kuzey";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnNorthWest
            // 
            this.btnNorthWest.Location = new System.Drawing.Point(495, 273);
            this.btnNorthWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNorthWest.Name = "btnNorthWest";
            this.btnNorthWest.Size = new System.Drawing.Size(84, 66);
            this.btnNorthWest.TabIndex = 2;
            this.btnNorthWest.Text = "Kuzey Batı";
            this.btnNorthWest.UseVisualStyleBackColor = true;
            this.btnNorthWest.Click += new System.EventHandler(this.btnNorthWest_Click);
            // 
            // btnNorthEast
            // 
            this.btnNorthEast.Location = new System.Drawing.Point(680, 273);
            this.btnNorthEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNorthEast.Name = "btnNorthEast";
            this.btnNorthEast.Size = new System.Drawing.Size(84, 66);
            this.btnNorthEast.TabIndex = 3;
            this.btnNorthEast.Text = "Kuzey Doğu";
            this.btnNorthEast.UseVisualStyleBackColor = true;
            this.btnNorthEast.Click += new System.EventHandler(this.btnNorthEast_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(495, 347);
            this.btnWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(84, 66);
            this.btnWest.TabIndex = 4;
            this.btnWest.Text = "Batı";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouthWest
            // 
            this.btnSouthWest.Location = new System.Drawing.Point(495, 421);
            this.btnSouthWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSouthWest.Name = "btnSouthWest";
            this.btnSouthWest.Size = new System.Drawing.Size(84, 66);
            this.btnSouthWest.TabIndex = 5;
            this.btnSouthWest.Text = "Güney Batı";
            this.btnSouthWest.UseVisualStyleBackColor = true;
            this.btnSouthWest.Click += new System.EventHandler(this.btnSouthWest_Click);
            // 
            // btnSouthEast
            // 
            this.btnSouthEast.Location = new System.Drawing.Point(679, 423);
            this.btnSouthEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSouthEast.Name = "btnSouthEast";
            this.btnSouthEast.Size = new System.Drawing.Size(85, 66);
            this.btnSouthEast.TabIndex = 7;
            this.btnSouthEast.Text = "Güney Doğu";
            this.btnSouthEast.UseVisualStyleBackColor = true;
            this.btnSouthEast.Click += new System.EventHandler(this.btnSouthEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(587, 422);
            this.btnSouth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(84, 68);
            this.btnSouth.TabIndex = 6;
            this.btnSouth.Text = "Güney";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(679, 349);
            this.btnEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(85, 66);
            this.btnEast.TabIndex = 8;
            this.btnEast.Text = "Doğu";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMovingObject);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 364);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnSouthEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnSouthWest);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorthEast);
            this.Controls.Add(this.btnNorthWest);
            this.Controls.Add(this.btnNorth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovingObject;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnNorthWest;
        private System.Windows.Forms.Button btnNorthEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouthWest;
        private System.Windows.Forms.Button btnSouthEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

