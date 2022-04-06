namespace _18radiobox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBkorea = new System.Windows.Forms.RadioButton();
            this.RBchina = new System.Windows.Forms.RadioButton();
            this.RBjapan = new System.Windows.Forms.RadioButton();
            this.RBothers = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBmale = new System.Windows.Forms.RadioButton();
            this.RBfemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBothers);
            this.groupBox1.Controls.Add(this.RBjapan);
            this.groupBox1.Controls.Add(this.RBchina);
            this.groupBox1.Controls.Add(this.RBkorea);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // RBkorea
            // 
            this.RBkorea.AutoSize = true;
            this.RBkorea.Location = new System.Drawing.Point(19, 20);
            this.RBkorea.Name = "RBkorea";
            this.RBkorea.Size = new System.Drawing.Size(69, 17);
            this.RBkorea.TabIndex = 0;
            this.RBkorea.TabStop = true;
            this.RBkorea.Text = "대한민국";
            this.RBkorea.UseVisualStyleBackColor = true;
            // 
            // RBchina
            // 
            this.RBchina.AutoSize = true;
            this.RBchina.Location = new System.Drawing.Point(19, 50);
            this.RBchina.Name = "RBchina";
            this.RBchina.Size = new System.Drawing.Size(47, 17);
            this.RBchina.TabIndex = 1;
            this.RBchina.TabStop = true;
            this.RBchina.Text = "중국";
            this.RBchina.UseVisualStyleBackColor = true;
            // 
            // RBjapan
            // 
            this.RBjapan.AutoSize = true;
            this.RBjapan.Location = new System.Drawing.Point(19, 80);
            this.RBjapan.Name = "RBjapan";
            this.RBjapan.Size = new System.Drawing.Size(47, 17);
            this.RBjapan.TabIndex = 2;
            this.RBjapan.TabStop = true;
            this.RBjapan.Text = "일본";
            this.RBjapan.UseVisualStyleBackColor = true;
            // 
            // RBothers
            // 
            this.RBothers.AutoSize = true;
            this.RBothers.Location = new System.Drawing.Point(19, 110);
            this.RBothers.Name = "RBothers";
            this.RBothers.Size = new System.Drawing.Size(50, 17);
            this.RBothers.TabIndex = 3;
            this.RBothers.TabStop = true;
            this.RBothers.Text = "그 외";
            this.RBothers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBfemale);
            this.groupBox2.Controls.Add(this.RBmale);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // RBmale
            // 
            this.RBmale.AutoSize = true;
            this.RBmale.Location = new System.Drawing.Point(19, 19);
            this.RBmale.Name = "RBmale";
            this.RBmale.Size = new System.Drawing.Size(47, 17);
            this.RBmale.TabIndex = 0;
            this.RBmale.TabStop = true;
            this.RBmale.Text = "남성";
            this.RBmale.UseVisualStyleBackColor = true;
            //this.RBmale.CheckedChanged += new System.EventHandler(this.RBmale_CheckedChanged);
            // 
            // RBfemale
            // 
            this.RBfemale.AutoSize = true;
            this.RBfemale.Location = new System.Drawing.Point(72, 19);
            this.RBfemale.Name = "RBfemale";
            this.RBfemale.Size = new System.Drawing.Size(47, 17);
            this.RBfemale.TabIndex = 1;
            this.RBfemale.TabStop = true;
            this.RBfemale.Text = "여성";
            this.RBfemale.UseVisualStyleBackColor = true;
            //this.RBfemale.CheckedChanged += new System.EventHandler(this.RBfemale_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBothers;
        private System.Windows.Forms.RadioButton RBjapan;
        private System.Windows.Forms.RadioButton RBchina;
        private System.Windows.Forms.RadioButton RBkorea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBfemale;
        private System.Windows.Forms.RadioButton RBmale;
        private System.Windows.Forms.Button button1;
    }
}

