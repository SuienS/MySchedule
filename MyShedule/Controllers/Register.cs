using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MyShedule
{
    public partial class Register
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand com = new SqlCommand();
        private String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ravidu\source\repos\MyShedule\MyShedule\Database1.mdf;Integrated Security = True";
        private string query = "INSERT INTO UserAccounts (Username, Password, Birthday, SleepHours ) VALUES (@Username, @Password,  @Birthday, @SleepHours)";
        private string queryUserCheck = "SELECT * FROM UserAccounts WHERE Username = @Username";

        public void register(String Username, String Password, DateTime Birthday, int SleepHours)
        {
            try
            {
                SqlConnection dbConnection = default(SqlConnection);
                dbConnection = new SqlConnection(dbString);

                SqlCommand dbCommand = default(SqlCommand);

                dbCommand = new SqlCommand(queryUserCheck, dbConnection);
                dbCommand.Parameters.AddWithValue("@Username", Username);
                dbCommand.Connection.Open();

                SqlDataReader rdr = dbCommand.ExecuteReader();

                if (rdr.Read() == true) 
                {
                    MessageBox.Show("Username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "" ;
                    return;
                }

                rdr.Close();


                dbCommand = new SqlCommand(query, dbConnection);

                dbCommand.Parameters.AddWithValue("@Username", Username);
                dbCommand.Parameters.AddWithValue("@Password", Password);
                dbCommand.Parameters.AddWithValue("@Birthday", Birthday);
                dbCommand.Parameters.AddWithValue("@SleepHours", SleepHours);

                int result = dbCommand.ExecuteNonQuery();

                // Check Error
                if (result < 0) 
                {
                    Console.WriteLine("Error inserting data into Database!");
                }
                else 
                {
                    MessageBox.Show("User registered successfully... Login to use the App","Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }


                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
