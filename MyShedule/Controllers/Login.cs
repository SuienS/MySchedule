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
    partial class Login
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand com = new SqlCommand();
        private String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ravidu\source\repos\MyShedule\MyShedule\Database1.mdf;Integrated Security = True";

        public void login(String Username, String Password)
        {
            try
            {
                SqlConnection dbConnection = default(SqlConnection);
                dbConnection = new SqlConnection(dbString);

                SqlCommand dbCommand = default(SqlCommand);

                dbCommand = new SqlCommand("SELECT Username,Password FROM UserAccounts WHERE Username = @Username AND Password = @Password", dbConnection);

                SqlParameter userName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter userPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                userName.Value = txtUserName.Text;
                userPassword.Value = txtPassword.Text;

                dbCommand.Parameters.Add(userName);
                dbCommand.Parameters.Add(userPassword);

                dbCommand.Connection.Open();

                SqlDataReader dbReader = dbCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (dbReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully " + txtUserName.Text);
                    //Hide the login form
                    this.Hide();
                    DataPersistancy.getUserID(txtUserName.Text, txtPassword.Text);
                    MainMenu menu = new MainMenu(txtUserName.Text);
                    menu.ShowDialog();
                }


                else
                {
                    MessageBox.Show("Login Failed!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

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
