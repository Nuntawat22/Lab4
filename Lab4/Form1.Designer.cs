namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthyear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbContacts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbGpa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNameLow = new System.Windows.Forms.TextBox();
            this.tbNameHigh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(68, 39);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(111, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbBirthyear
            // 
            this.tbBirthyear.Location = new System.Drawing.Point(68, 69);
            this.tbBirthyear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBirthyear.Multiline = true;
            this.tbBirthyear.Name = "tbBirthyear";
            this.tbBirthyear.Size = new System.Drawing.Size(111, 27);
            this.tbBirthyear.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(68, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbContacts
            // 
            this.tbContacts.Location = new System.Drawing.Point(119, 200);
            this.tbContacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContacts.Multiline = true;
            this.tbContacts.Name = "tbContacts";
            this.tbContacts.Size = new System.Drawing.Size(136, 96);
            this.tbContacts.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "รายชื่อ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "อายุรวม :";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(119, 156);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(136, 31);
            this.tbTotal.TabIndex = 8;
            this.tbTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "GPA Max :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "GPA Min :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "GPA";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(119, 71);
            this.tbMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMin.Multiline = true;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(136, 29);
            this.tbMin.TabIndex = 13;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(119, 34);
            this.tbMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMax.Multiline = true;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(136, 29);
            this.tbMax.TabIndex = 12;
            // 
            // tbGpa
            // 
            this.tbGpa.Location = new System.Drawing.Point(68, 100);
            this.tbGpa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGpa.Multiline = true;
            this.tbGpa.Name = "tbGpa";
            this.tbGpa.Size = new System.Drawing.Size(111, 29);
            this.tbGpa.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(44, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "GPA Avg :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(314, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 14);
            this.label9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(287, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "ชื่อคนที่GPAมากที่สุด =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(287, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "ชื่อคนที่GPAน้อยที่สุด =";
            // 
            // tbAvg
            // 
            this.tbAvg.Location = new System.Drawing.Point(119, 114);
            this.tbAvg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAvg.Multiline = true;
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.Size = new System.Drawing.Size(137, 29);
            this.tbAvg.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(318, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 14);
            this.label12.TabIndex = 21;
            // 
            // tbNameLow
            // 
            this.tbNameLow.Location = new System.Drawing.Point(429, 71);
            this.tbNameLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameLow.Multiline = true;
            this.tbNameLow.Name = "tbNameLow";
            this.tbNameLow.Size = new System.Drawing.Size(128, 27);
            this.tbNameLow.TabIndex = 23;
            // 
            // tbNameHigh
            // 
            this.tbNameHigh.Location = new System.Drawing.Point(429, 37);
            this.tbNameHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameHigh.Multiline = true;
            this.tbNameHigh.Name = "tbNameHigh";
            this.tbNameHigh.Size = new System.Drawing.Size(128, 27);
            this.tbNameHigh.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNameLow);
            this.groupBox1.Controls.Add(this.tbContacts);
            this.groupBox1.Controls.Add(this.tbNameHigh);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbAvg);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(206, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 396);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 486);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbGpa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBirthyear);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbName;
        private TextBox tbBirthyear;
        private Button button1;
        private TextBox tbContacts;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTotal;
        private TextBox Nmax;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbMin;
        private TextBox tbMax;
        private TextBox tbGpa;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbAvg;
        private Label label12;
        private TextBox tbNameLow;
        private TextBox tbNameHigh;
        private GroupBox groupBox1;
    }
}