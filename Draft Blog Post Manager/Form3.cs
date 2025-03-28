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
    public partial class Form3 : Form
    {
        string postId;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db;";
        public Form3(string id)
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
                        label1.Text = reader["title"].ToString().ToUpper();
                        label2.Text = reader["author"].ToString();
                        label3.Text = reader["created"].ToString();
                        label4.Text = reader["paragraph"].ToString();
                        label5.Text = reader["category"].ToString();
                    }
                    if (!(reader["image"] is DBNull))
                    {
                        byte[] imageData = (byte[])reader["image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
