using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    internal class DBConnection
    {
        public static string ConnectionString = "Data Source=DESKTOP-AAKBJPP;Initial Catalog=PMS;Integrated Security=True";
        public static bool InsertDataIntoMedicineTable(string medicineName, DateTime expiryDate, DateTime manufDate, int quantity, double unitPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlGetMaxID = "SELECT ISNULL(MAX(Medicine_ID), 0) FROM [dbo].[Medicine]";
                    using (SqlCommand cmdGetMaxID = new SqlCommand(sqlGetMaxID, connection))
                    {
                        int highestMedicineID = int.Parse(cmdGetMaxID.ExecuteScalar().ToString());
                        int newMedicineID = highestMedicineID + 1;

                        string sqlInsert = @"INSERT INTO [dbo].[Medicine]
                             ([Medicine_ID]
                             ,[Medicine_name]
                             ,[Medicine_expirydate]
                             ,[Medicince_manufdate]
                             ,[Quantity]
                             ,[Unit_price])
                             VALUES
                             (@MedicineID, @MedicineName, @ExpiryDate, @ManufDate, @Quantity, @UnitPrice)";

                        using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                        {
                            cmd.Parameters.AddWithValue("@MedicineID", newMedicineID);
                            cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                            cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@ManufDate", manufDate.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void UpdateRowInDatabase(int medicineID, int rowIndex, double newPrice, int newQuantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlUpdate = @"UPDATE [dbo].[Medicine]
                                 SET [Unit_price] = @NewPrice,
                                     [Quantity] = @NewQuantity
                                 WHERE [Medicine_ID] = @MedicineID";

                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, connection))
                    {
                        cmd.Parameters.AddWithValue("@NewPrice", newPrice);
                        cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@MedicineID", medicineID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating row in the database: " + ex.Message);
            }


        }
        public static bool VerifyPharmacistCredentials(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlVerify = "SELECT COUNT(*) FROM [dbo].[Pharmacist] WHERE [ph_username] = @Username AND [ph_password] = @Password";
                    using (SqlCommand cmdVerify = new SqlCommand(sqlVerify, connection))
                    {
                        cmdVerify.Parameters.AddWithValue("@Username", username);
                        cmdVerify.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmdVerify.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying pharmacist credentials: " + ex.Message);
                return false;
            }
        }

        public static bool InsertDataIntoPharmacistTable
            (string firstName, string lastName, 
            DateTime dob, string gender, 
            string contact, decimal salary, 
            string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlGetMaxID = "SELECT ISNULL(MAX(Ph_id), 0) FROM [dbo].[Pharmacist]";
                    using (SqlCommand cmdGetMaxID = new SqlCommand(sqlGetMaxID, connection))
                    {
                        int highestPharmacistID = int.Parse(cmdGetMaxID.ExecuteScalar().ToString());
                        int newPharmacistID = highestPharmacistID + 1;
                        string sqlInsert = @"INSERT INTO [dbo].[Pharmacist]
                                            ([Ph_id]
                                            ,[ph_firstname]
                                            ,[ph_lastname]
                                            ,[ph_dob]
                                            ,[ph_gender]
                                            ,[ph_contact]
                                            ,[ph_salary]
                                            ,[ph_username]
                                            ,[ph_password])
                                            VALUES
                                            (@PhID, @FirstName, @LastName, @DOB, @Gender, @Contact, @Salary, @Username, @Password)";

                        using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, connection))
                        {
                            cmdInsert.Parameters.AddWithValue("@PhID", newPharmacistID);
                            cmdInsert.Parameters.AddWithValue("@FirstName", firstName);
                            cmdInsert.Parameters.AddWithValue("@LastName", lastName);
                            cmdInsert.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmdInsert.Parameters.AddWithValue("@Gender", gender);
                            cmdInsert.Parameters.AddWithValue("@Contact", contact);
                            cmdInsert.Parameters.AddWithValue("@Salary", salary);
                            cmdInsert.Parameters.AddWithValue("@Username", username);
                            cmdInsert.Parameters.AddWithValue("@Password", password);

                            cmdInsert.ExecuteNonQuery();
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data into Pharmacist table: " + ex.Message);
                return false;
            }
        }
        public static void DeleteRowFromPharmacistTable(string pharmacistId)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Pharmacist WHERE Ph_Id = @Ph_Id";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Ph_Id", pharmacistId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static PharmacistsClass GetPharmacistByUsername(string username)
        {
            PharmacistsClass pharmacist = null;
            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Ph_id, ph_firstname, ph_lastname, ph_dob, ph_gender, " +
                    "ph_contact, ph_salary, ph_username, ph_password " +
                    "FROM Pharmacist WHERE ph_username = @Username";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pharmacist = new PharmacistsClass
                            (Convert.ToInt32(reader["Ph_id"]),
                                reader["ph_firstname"].ToString(),
                                reader["ph_lastname"].ToString(),
                                Convert.ToDateTime(reader["ph_dob"]),
                                reader["ph_gender"].ToString(),
                                reader["ph_contact"].ToString(),
                                Convert.ToDouble(reader["ph_salary"]),
                                reader["ph_username"].ToString(),
                                reader["ph_password"].ToString());
                        }
                    }
                }
            }
            return pharmacist;
        }
    }
}
