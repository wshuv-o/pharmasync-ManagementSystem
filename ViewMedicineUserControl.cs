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
    public partial class ViewMedicineUserControl : UserControl
    {
        public ViewMedicineUserControl()
        {
            InitializeComponent();
            string sqlSelect = "SELECT * FROM [dbo].[Medicine]";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, DBConnection.ConnectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGVViweMedicine.DataSource = dataTable;
            dGVViweMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchbox()
        {
            try
            {
                string s = "";

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    s = $" SELECT * FROM [dbo].[Medicine] WHERE Medicine_name LIKE '%{txtSearch.Text}%'";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(s, DBConnection.ConnectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dGVViweMedicine.DataSource = dataTable;
                dGVViweMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchbox();
        }

        private void LoadMedicineData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect;
                    if (cmbCheck.SelectedItem.ToString() == "All Medicine")
                    {
                        sqlSelect = "SELECT * FROM [dbo].[Medicine]";
                    }
                    else if (cmbCheck.SelectedItem.ToString() == "Expired Medicine")
                    {
                        sqlSelect = "SELECT * FROM [dbo].[Medicine] WHERE Medicine_expirydate < GETDATE()";
                    }
                    else if (cmbCheck.SelectedItem.ToString() == "Valid Medicine ")
                    {
                        sqlSelect = "SELECT * FROM [dbo].[Medicine] WHERE Medicine_expirydate >= GETDATE()";
                    }
                    else
                    {
                        return;
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dGVViweMedicine.DataSource = dataTable;
                    dGVViweMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }
        private void RefreshMedicineData()
        {
            LoadMedicineData();
        }
        private void validComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMedicineData();
        }
    }
}
