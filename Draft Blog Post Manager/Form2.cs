using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Draft_Blog_Post_Manager
{
    public partial class Form2 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db;";
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(richTextBox1.Text) ||
        comboBox1.SelectedItem == null)
            {
                MessageBox.Show("All fields (Title, Author, Paragraph, and Category) must be filled!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();

                string title = textBox1.Text;
                string author = textBox2.Text;
                string created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string paragraph = richTextBox1.Text;
                string category = comboBox1.SelectedItem?.ToString() ?? "Uncategorized";
                byte[] imageData = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                }

                string queryAdd = "INSERT INTO post (title, author, paragraph, created, updated, category, image) VALUES (@title, @author, @paragraph, @created, NULL, @category, @image)";

                using (MySqlCommand commandDatabase = new MySqlCommand(queryAdd, databaseConnection))
                {
                    commandDatabase.Parameters.AddWithValue("@title", title);
                    commandDatabase.Parameters.AddWithValue("@author", author);
                    commandDatabase.Parameters.AddWithValue("@paragraph", paragraph);
                    commandDatabase.Parameters.AddWithValue("@created", created);
                    commandDatabase.Parameters.AddWithValue("@category", comboBox1.SelectedItem.ToString());
                    commandDatabase.Parameters.AddWithValue("@image", imageData);

                    commandDatabase.ExecuteNonQuery();
                }

                MessageBox.Show("Data saved successfully!");

                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.LoadData();
                    this.Close();
                }
                else
                {
                    mainForm = new Form1();
                    mainForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                databaseConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discard this draft post?","Discard Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.Show();
                }
                else
                {
                    mainForm = new Form1();
                    mainForm.Show();
                }

                this.Close();
            }
        }
    }
}
