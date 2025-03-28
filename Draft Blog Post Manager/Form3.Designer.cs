namespace Draft_Blog_Post_Manager
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 80);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 0;
            label1.Text = "TITLE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 144);
            label2.Name = "label2";
            label2.Size = new Size(40, 18);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 168);
            label3.Name = "label3";
            label3.Size = new Size(44, 18);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(96, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 48);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.ForeColor = Color.Cornsilk;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 128);
            panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightGray;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(16, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "< Return";
            linkLabel1.MouseClick += linkLabel1_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 496);
            label4.MaximumSize = new Size(0, 327);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 20);
            label4.Size = new Size(40, 38);
            label4.TabIndex = 3;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.ForeColor = Color.Cornsilk;
            panel2.Location = new Point(832, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 392);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.ForeColor = Color.Cornsilk;
            panel3.Location = new Point(96, 480);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 4);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.ForeColor = Color.Cornsilk;
            panel4.Location = new Point(432, 184);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 4);
            panel4.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(913, 684);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel1;
        private Label label4;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}