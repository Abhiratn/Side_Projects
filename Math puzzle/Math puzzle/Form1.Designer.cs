namespace Math_puzzle
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
            this.time_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plus_left_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plus_right_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.sub_left_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub_right_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.NumericUpDown();
            this.mul_left_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mul_right_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mul = new System.Windows.Forms.NumericUpDown();
            this.div_left_lbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.div_right_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.NumericUpDown();
            this.strt_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.SuspendLayout();
            // 
            // time_lbl
            // 
            this.time_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(182, 9);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(295, 30);
            this.time_lbl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plus_left_lbl
            // 
            this.plus_left_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_left_lbl.Location = new System.Drawing.Point(50, 75);
            this.plus_left_lbl.Name = "plus_left_lbl";
            this.plus_left_lbl.Size = new System.Drawing.Size(60, 50);
            this.plus_left_lbl.TabIndex = 2;
            this.plus_left_lbl.Text = "?";
            this.plus_left_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plus_right_lbl
            // 
            this.plus_right_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_right_lbl.Location = new System.Drawing.Point(182, 75);
            this.plus_right_lbl.Name = "plus_right_lbl";
            this.plus_right_lbl.Size = new System.Drawing.Size(60, 50);
            this.plus_right_lbl.TabIndex = 4;
            this.plus_right_lbl.Text = "?";
            this.plus_right_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(303, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            // 
            // sub_left_lbl
            // 
            this.sub_left_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_left_lbl.Location = new System.Drawing.Point(50, 133);
            this.sub_left_lbl.Name = "sub_left_lbl";
            this.sub_left_lbl.Size = new System.Drawing.Size(60, 50);
            this.sub_left_lbl.TabIndex = 2;
            this.sub_left_lbl.Text = "?";
            this.sub_left_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub_right_lbl
            // 
            this.sub_right_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_right_lbl.Location = new System.Drawing.Point(182, 133);
            this.sub_right_lbl.Name = "sub_right_lbl";
            this.sub_right_lbl.Size = new System.Drawing.Size(60, 50);
            this.sub_right_lbl.TabIndex = 4;
            this.sub_right_lbl.Text = "?";
            this.sub_right_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(303, 142);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 35);
            this.sub.TabIndex = 2;
            // 
            // mul_left_lbl
            // 
            this.mul_left_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul_left_lbl.Location = new System.Drawing.Point(50, 194);
            this.mul_left_lbl.Name = "mul_left_lbl";
            this.mul_left_lbl.Size = new System.Drawing.Size(60, 50);
            this.mul_left_lbl.TabIndex = 2;
            this.mul_left_lbl.Text = "?";
            this.mul_left_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 3;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mul_right_lbl
            // 
            this.mul_right_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul_right_lbl.Location = new System.Drawing.Point(182, 194);
            this.mul_right_lbl.Name = "mul_right_lbl";
            this.mul_right_lbl.Size = new System.Drawing.Size(60, 50);
            this.mul_right_lbl.TabIndex = 4;
            this.mul_right_lbl.Text = "?";
            this.mul_right_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 5;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(303, 203);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(100, 35);
            this.mul.TabIndex = 3;
            // 
            // div_left_lbl
            // 
            this.div_left_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_left_lbl.Location = new System.Drawing.Point(50, 249);
            this.div_left_lbl.Name = "div_left_lbl";
            this.div_left_lbl.Size = new System.Drawing.Size(60, 50);
            this.div_left_lbl.TabIndex = 2;
            this.div_left_lbl.Text = "?";
            this.div_left_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 3;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // div_right_lbl
            // 
            this.div_right_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_right_lbl.Location = new System.Drawing.Point(182, 249);
            this.div_right_lbl.Name = "div_right_lbl";
            this.div_right_lbl.Size = new System.Drawing.Size(60, 50);
            this.div_right_lbl.TabIndex = 4;
            this.div_right_lbl.Text = "?";
            this.div_right_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 5;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(303, 258);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(100, 35);
            this.div.TabIndex = 4;
            // 
            // strt_btn
            // 
            this.strt_btn.AutoSize = true;
            this.strt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strt_btn.Location = new System.Drawing.Point(143, 311);
            this.strt_btn.Name = "strt_btn";
            this.strt_btn.Size = new System.Drawing.Size(139, 34);
            this.strt_btn.TabIndex = 0;
            this.strt_btn.Text = "Start The Quiz";
            this.strt_btn.UseVisualStyleBackColor = true;
            this.strt_btn.Click += new System.EventHandler(this.strt_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.strt_btn);
            this.Controls.Add(this.div);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.div_right_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mul_right_lbl);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sub_right_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.div_left_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mul_left_lbl);
            this.Controls.Add(this.plus_right_lbl);
            this.Controls.Add(this.sub_left_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plus_left_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Puzzle";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plus_left_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plus_right_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label sub_left_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sub_right_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sub;
        private System.Windows.Forms.Label mul_left_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mul_right_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown mul;
        private System.Windows.Forms.Label div_left_lbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label div_right_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown div;
        private System.Windows.Forms.Button strt_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

