namespace PictureViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.show_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.bg_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 391);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(3, 400);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(57, 17);
            this.cb_1.TabIndex = 1;
            this.cb_1.Text = "Strech";
            this.cb_1.UseVisualStyleBackColor = true;
            this.cb_1.CheckedChanged += new System.EventHandler(this.cb_1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.show_btn);
            this.flowLayoutPanel1.Controls.Add(this.clear_btn);
            this.flowLayoutPanel1.Controls.Add(this.bg_btn);
            this.flowLayoutPanel1.Controls.Add(this.close_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(125, 400);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(687, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // show_btn
            // 
            this.show_btn.AutoSize = true;
            this.show_btn.Location = new System.Drawing.Point(561, 3);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(123, 23);
            this.show_btn.TabIndex = 0;
            this.show_btn.Text = "Show a picture";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.AutoSize = true;
            this.clear_btn.Location = new System.Drawing.Point(443, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(112, 23);
            this.clear_btn.TabIndex = 1;
            this.clear_btn.Text = "Clear the picture";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // bg_btn
            // 
            this.bg_btn.AutoSize = true;
            this.bg_btn.Location = new System.Drawing.Point(300, 3);
            this.bg_btn.Name = "bg_btn";
            this.bg_btn.Size = new System.Drawing.Size(137, 23);
            this.bg_btn.TabIndex = 2;
            this.bg_btn.Text = "Set the background color";
            this.bg_btn.UseVisualStyleBackColor = true;
            this.bg_btn.Click += new System.EventHandler(this.bg_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Location = new System.Drawing.Point(219, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button bg_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

