namespace Draft_Blog_Post_Manager
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(88, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(784, 35);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(16, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 20);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 115);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 3;
            label2.Text = "Author";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(16, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 20);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(216, 383);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(523, 371);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 162, 184);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(776, 8);
            button1.Name = "button1";
            button1.Size = new Size(98, 32);
            button1.TabIndex = 6;
            button1.Text = "Create Draft";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fasion", "Technology", "Sports", "Politics" });
            comboBox1.Location = new Point(88, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 168);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 10;
            label4.Text = "Date of Creation";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(216, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 216);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 96);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 0;
            label5.Text = "Insert Image";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 104);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
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
            // 
            // panel3
            // 
            panel3.Location = new Point(192, 736);
            panel3.Name = "panel3";
            panel3.Size = new Size(588, 18);
            panel3.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(664, 8);
            button2.Name = "button2";
            button2.Size = new Size(98, 32);
            button2.TabIndex = 10;
            button2.Text = "Discard Draft";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(896, 667);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Label label3;
        private Panel panel3;
        private Button button2;
    }
}