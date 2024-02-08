using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class ViewUserUserControl : UserControl
    {
        public ViewUserUserControl()
        {
            InitializeComponent();
            LoadPharmacistData();
        }

        private void LoadPharmacistData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM [dbo].[Pharmacist]";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dGVViweUsers.DataSource = dataTable;
                        dGVViweUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchPharmacist(txtSearch.Text);
        }
        private void SearchPharmacist(string searchName = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM [dbo].[Pharmacist]";
                    if (!string.IsNullOrWhiteSpace(searchName))
                    {
                        sqlSelect += $" WHERE ph_firstname LIKE '%{searchName}%'";
                    }
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dGVViweUsers.DataSource = dataTable;
                        dGVViweUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }
    }
}
