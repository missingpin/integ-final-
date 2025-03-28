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

namespace Draft_Blog_Post_Manager
{
    public partial class Form4 : Form
    {
        string postId;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db;";
        byte[] newImageData = null;
        public Form4(string id)
        {
            InitializeComponent();
            postId = id;
            LoadPostData();
        }
        private void LoadPostData()
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open();
                    string query = "SELECT title, author, created, paragraph, category, image FROM post WHERE id = @id";

                    MySqlCommand command = new MySqlCommand(query, databaseConnection);
                    command.Parameters.AddWithValue("@id", postId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox1.Text = reader["title"].ToString();
                        textBox2.Text = reader["author"].ToString();
                        richTextBox1.Text = reader["paragraph"].ToString();
                        comboBox1.Text = reader["category"].ToString();

                        if (reader["image"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["image"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No post found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(richTextBox1.Text) ||
        comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("All fields (Title, Author, Category, and Paragraph) must be filled!",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open();
                    string queryUpdate = "UPDATE post SET title=@title, author=@author, paragraph=@paragraph, category=@category, image=@image, updated=CURDATE() WHERE id=@id";

                    using (MySqlCommand command = new MySqlCommand(queryUpdate, databaseConnection))
                    {
                        command.Parameters.AddWithValue("@id", postId);
                        command.Parameters.AddWithValue("@title", textBox1.Text);
                        command.Parameters.AddWithValue("@author", textBox2.Text);
                        command.Parameters.AddWithValue("@paragraph", richTextBox1.Text);
                        command.Parameters.AddWithValue("@category", comboBox1.Text);
                        if (newImageData != null)
                        {
                            command.Parameters.AddWithValue("@image", newImageData);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@image", DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Draft Updated successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    newImageData = ms.ToArray();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel changes?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
