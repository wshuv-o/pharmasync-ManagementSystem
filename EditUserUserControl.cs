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

namespace PharmacyManagementSystem.Resources
{
    public partial class EditUserUserControl : UserControl
    {
        public EditUserUserControl()
        {
            InitializeComponent();
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
                        dGVEditUser.DataSource = dataTable;
                        dGVEditUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dGVEditUser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGVEditUser.SelectedRows[0];
                string pharmacistId = selectedRow.Cells[0].Value.ToString();
                dGVEditUser.Rows.Remove(selectedRow);
                DBConnection.DeleteRowFromPharmacistTable(pharmacistId);
                MessageBox.Show("User Deleted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dGVEditUser.DataSource;
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                foreach (DataRow row in dt.Rows)
                {
                    string pharmacistId = row["Ph_id"].ToString();
                    string firstName = row["ph_firstname"].ToString();
                    string lastName = row["ph_lastname"].ToString();
                    string dob = row["ph_dob"].ToString();
                    string gender = row["ph_gender"].ToString();
                    string contact = row["ph_contact"].ToString();
                    string salary = row["ph_salary"].ToString();
                    string username = row["ph_username"].ToString();
                    string password = row["ph_password"].ToString();

                    string updateQuery = "UPDATE Pharmacist SET " +
                        "ph_firstname = @FirstName, " +
                        "ph_lastname = @LastName, " +
                        "ph_dob = @DOB, " +
                        "ph_gender = @Gender, " +
                        "ph_contact = @Contact, " +
                        "ph_salary = @Salary, " +
                        "ph_username = @Username, " +
                        "ph_password = @Password " +
                        "WHERE Ph_id = @PharmacistId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@PharmacistId", pharmacistId);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Updated");
            }
        }
    }
}
