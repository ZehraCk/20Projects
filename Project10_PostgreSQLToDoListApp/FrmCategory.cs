using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDoListApp
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localHost;port=5432;Database=project10;user ID=postgres;Password=staj2026";
        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataSet = new DataTable();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet;
            connection.Close();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            CategoryList();

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryName", txtName.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Eklendi");
                CategoryList();
            }
            connection.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(txtId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarıyla Silindi");
                CategoryList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryName", txtName.Text);
                command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(txtId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarıyla Güncellendi");
                CategoryList();
            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(txtId.Text));
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["CategoryName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Kategori bulunamadı.");
                        }
                    }
                }
            }
        }
    }
}
