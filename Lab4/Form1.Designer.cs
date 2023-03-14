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
            this.m1 = new System.Windows.Forms.TextBox();
            this.m2 = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.Button();
            this.m4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.gpa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(137, 82);
            this.m1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m1.Multiline = true;
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(131, 44);
            this.m1.TabIndex = 0;
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(137, 138);
            this.m2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m2.Multiline = true;
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(131, 44);
            this.m2.TabIndex = 1;
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.n.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n.Location = new System.Drawing.Point(137, 252);
            this.n.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(133, 68);
            this.n.TabIndex = 2;
            this.n.Text = "Add";
            this.n.UseVisualStyleBackColor = false;
            this.n.Click += new System.EventHandler(this.n_Click);
            // 
            // m4
            // 
            this.m4.Location = new System.Drawing.Point(181, 325);
            this.m4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m4.Multiline = true;
            this.m4.Name = "m4";
            this.m4.Size = new System.Drawing.Size(240, 237);
            this.m4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "รายชื่อ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "อายุรวม :";
            // 
            // Nmax
            // 
            this.Nmax.Location = new System.Drawing.Point(181, 252);
            this.Nmax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nmax.Multiline = true;
            this.Nmax.Name = "Nmax";
            this.Nmax.Size = new System.Drawing.Size(240, 42);
            this.Nmax.TabIndex = 8;
            this.Nmax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "GPA Max :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "GPA Min :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(79, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "GPA";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(480, 138);
            this.min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.min.Multiline = true;
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(240, 44);
            this.min.TabIndex = 13;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(480, 77);
            this.max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.max.Multiline = true;
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(240, 44);
            this.max.TabIndex = 12;
            // 
            // gpa
            // 
            this.gpa.Location = new System.Drawing.Point(137, 195);
            this.gpa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpa.Multiline = true;
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(131, 44);
            this.gpa.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "GPA Avg :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(449, 377);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(431, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "ชื่อคนที่GPAมากที่สุด =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(431, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "ชื่อคนที่GPAน้อยที่สุด =";
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(181, 182);
            this.avg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avg.Multiline = true;
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(240, 44);
            this.avg.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(454, 373);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 22);
            this.label12.TabIndex = 21;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(623, 118);
            this.name2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name2.Multiline = true;
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(108, 44);
            this.name2.TabIndex = 23;
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(623, 53);
            this.name1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name1.Multiline = true;
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(108, 44);
            this.name1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name2);
            this.groupBox1.Controls.Add(this.m4);
            this.groupBox1.Controls.Add(this.name1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.avg);
            this.groupBox1.Controls.Add(this.Nmax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(299, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(793, 595);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gpa);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox m1;
        private TextBox m2;
        private Button n;
        private TextBox m4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nmax;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox min;
        private TextBox max;
        private TextBox gpa;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox avg;
        private Label label12;
        private TextBox name2;
        private TextBox name1;
        private GroupBox groupBox1;
    }
}