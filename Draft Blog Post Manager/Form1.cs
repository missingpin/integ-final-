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
    public partial class Form1 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db;";
        ToolTip toolTip = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            toolTip.SetToolTip(button1, "Create new Draft");
        }

        public void LoadData()
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    databaseConnection.Open();
                    string query = "SELECT id, title, author, category, created, " + "CASE WHEN updated IS NULL THEN '---- -- --' ELSE updated END AS updated FROM post";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, databaseConnection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    Dictionary<string, string> columnHeaders = new Dictionary<string, string>
            {
                { "id", "PostID" },
                { "title", "Blog Title" },
                { "author", "Author" },
                { "category", "Category"},
                { "created", "Date Created" },
                { "updated", "Date Updated" }
            };

                    foreach (var column in columnHeaders)
                    {
                        if (dataGridView1.Columns.Contains(column.Key))
                        {
                            dataGridView1.Columns[column.Key].HeaderText = column.Value;
                            dataGridView1.Columns[column.Key].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                    dataGridView1.Columns["id"].Width = 5;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                string postId = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this post?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string queryDelete = "DELETE FROM post WHERE id = @id";

                    using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            databaseConnection.Open();
                            MySqlCommand command = new MySqlCommand(queryDelete, databaseConnection);
                            command.Parameters.AddWithValue("@id", postId);
                            command.ExecuteNonQuery();

                            dataGridView1.Rows.RemoveAt(selectedRowIndex);

                            MessageBox.Show("Post deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string postId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

                this.Hide();
                Form3 form3 = new Form3(postId);
                form3.ShowDialog();
                this.Show();
                LoadData();
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string postId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

                this.Hide();
                Form4 form4 = new Form4(postId);
                form4.ShowDialog();
                this.Show();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a post to edit!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
    }
