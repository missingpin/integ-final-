namespace Draft_Blog_Post_Manager
{
    partial class Form4
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Trebuchet MS", 8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fasion", "Technology", "Sports", "Politics" });
            comboBox1.Location = new Point(88, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 24);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 162, 184);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(776, 8);
            button1.Name = "button1";
            button1.Size = new Size(88, 32);
            button1.TabIndex = 15;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(216, 408);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(440, 336);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            textBox1.Location = new Point(88, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 35);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 104);
            panel2.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(680, 8);
            button2.Name = "button2";
            button2.Size = new Size(88, 32);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 64);
            label6.Name = "label6";
            label6.Size = new Size(68, 27);
            label6.TabIndex = 0;
            label6.Text = "TITLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 16);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 9;
            label3.Text = "Category";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 112);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 19;
            label2.Text = "Author";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(208, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 264);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(896, 667);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Label label6;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
    }
}