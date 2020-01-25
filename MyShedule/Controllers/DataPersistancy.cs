using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyShedule
{
    class DataPersistancy
    {
        // define INSERT query with parameters
        public static int user_id = 1;
        public static string user_Name = "none";
        public static double sleep_time = 6.0;
        public static char Separator = ((char)007);
        private static string DBconnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ravidu\source\repos\MyShedule\MyShedule\Database1.mdf;Integrated Security=True";

        public static void getUserID(string Username, string Password) 
        {
            try
            {
                // create connection and command
                using (SqlConnection cn = new SqlConnection(DBconnectionString))
                using (SqlCommand cmd = new SqlCommand("user_Login", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // defining parameters and their values
                    cmd.Parameters.Add(new SqlParameter("@Username", Username));
                    cmd.Parameters.Add(new SqlParameter("@Password", Password));

                    // open connection, execute INSERT, close connection
                    cn.Open();

                    // executing the command
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        user_id = (int)rdr["Id"];
                        user_Name = (string)rdr["Username"];
                        sleep_time = (int)rdr["SleepHours"];
                        Console.WriteLine(user_id);
                        Console.WriteLine(user_Name);

                    }
                    rdr.Close();
                    cn.Close();
                    Console.WriteLine("Logged IN: " + user_id + " - " + Username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErrorDBUser", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static DataTable getSingleEvent(int id) 
        {
            DataTable eventDataTable = null;

            try
            {
                // create connection and command
                using (SqlConnection cn = new SqlConnection(DBconnectionString))
                using (SqlCommand cmd = new SqlCommand("singleEvent_get", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // defining parameters and their values
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    // open connection, execute INSERT, close connection
                    cn.Open();


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    eventDataTable = new DataTable();
                    // querying database and return the result to the datatable
                    da.Fill(eventDataTable);
                    da.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErrorDBEvent", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return eventDataTable;
        }

        public static bool deleteEvent(int id) 
        {
            bool success = false;
            try
            {
                // creating connection and command
                using (SqlConnection cn = new SqlConnection(DBconnectionString))
                using (SqlCommand cmd = new SqlCommand("event_Delete", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // defining parameters and their values
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@user_id", user_id));

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErrorDBEvent", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return success;
        }

        public static DataTable getEvents(DateTime date) 
        {
            return getEvents(date, date.AddSeconds(86399.9));
        }

        public static DataTable getEvents(DateTime startDate, DateTime endDate) 
        {
            DataTable eventsDataTable = null;
            string sp = "events_get";

            try
            {
                if (endDate.CompareTo(startDate)==0) 
                {
                    sp = "events_ReminderGet";
                    endDate = startDate.AddMinutes(2);
                }
                // creating connection and command
                using (SqlConnection cn = new SqlConnection(DBconnectionString))
                using (SqlCommand cmd = new SqlCommand(sp, cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // define parameters and their values
                    cmd.Parameters.Add(new SqlParameter("@StartDate", startDate));
                    cmd.Parameters.Add(new SqlParameter("@EndDate", endDate));
                    cmd.Parameters.Add(new SqlParameter("@user_id", user_id));

                    // open connection, execute INSERT, close connection
                    cn.Open();

                    // execute the command
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    eventsDataTable = new DataTable();
                    // querying database and return the result to datatable
                    da.Fill(eventsDataTable);
                    da.Dispose();
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErrorDBEvent", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            return eventsDataTable;
        }

        public static void AddRecurring(string type, string eventName, string eventDescription, string eventType, string eventStart, string eventEnd, string location, string eventCC, string contact, string reminderDateTime)
        {
            if (type == "Monthly")
            {
                for (int i=1;i<24;i++) 
                {
                    DateTime recStart = DateTime.Parse(eventStart, CultureInfo.InvariantCulture).AddMonths(i);
                    DateTime recEnd = DateTime.Parse(eventEnd, CultureInfo.InvariantCulture).AddMonths(i);
                    AddDBNewEvent(eventName, eventDescription, eventType,
                        recStart.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        recEnd.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        location, eventCC, 
                        contact, "NULL","Not"
                        );
                }
            }
            else 
            {
                for (int i = 1; i < 10; i++)
                {
                    DateTime recStart = DateTime.Parse(eventStart, CultureInfo.InvariantCulture).AddYears(i);
                    DateTime recEnd = DateTime.Parse(eventEnd, CultureInfo.InvariantCulture).AddYears(i);
                    AddDBNewEvent(eventName, eventDescription, eventType,
                        recStart.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        recEnd.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        location, eventCC,
                        contact, "NULL","Not"
                        );
                }
            }
        }
        
        public static bool AddDBNewEvent(string eventName, string eventDescription, string eventType, string eventStart, string eventEnd, string location, string eventCC, string contact, string reminderDateTime, string status)
        {
            bool success = false;
            bool recurringT = false;
            try 
            {
                // creating connection and command
                using (SqlConnection cn = new SqlConnection(DBconnectionString))
                using (SqlCommand cmd = new SqlCommand("events_Insert", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // defining parameters and their values
                    cmd.Parameters.Add(new SqlParameter("@User_id", user_id));
                    cmd.Parameters.Add(new SqlParameter("@Name", eventName));
                    cmd.Parameters.Add(new SqlParameter("@Description", eventDescription));
                    cmd.Parameters.Add(new SqlParameter("@Start_time", eventStart));
                    cmd.Parameters.Add(new SqlParameter("@End_time", eventEnd)); ;
                    cmd.Parameters.Add(new SqlParameter("@Contacts", contact));
                    cmd.Parameters.Add(new SqlParameter("@Location", location));
                    cmd.Parameters.Add(new SqlParameter("@Color_code", eventCC));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    if (reminderDateTime == "NULL")
                    {
                        cmd.Parameters.Add(new SqlParameter("@Reminder", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Reminder", reminderDateTime));
                    }
                    if (eventType.Split('|')[0] != "One-off" && 
                        !(eventType.Split('|')[0]=="RecurringM" || eventType.Split('|')[0] == "RecurringY"))
                    {
                        recurringT = true;
                        cmd.Parameters.Add(new SqlParameter("@Type", eventType));
                    }
                    else 
                    {
                        cmd.Parameters.Add(new SqlParameter("@Type", eventType));
                    }
                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    if (recurringT) 
                    {
                        string recType = eventType.Split('|')[0].Split('-')[1];
                        recurringT = false;
                        string eventNewType = "RecurringY|";
                        if (recType == "Monthly") 
                        {
                            eventNewType = "RecurringM|";
                        }
                        eventNewType += eventType.Split('|')[1];
                        AddRecurring(recType, eventName, eventDescription, eventNewType,
                            eventStart, eventEnd, location, eventCC,
                            contact, reminderDateTime);
                    }
                    success = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            return success;

        }

        public static bool UpdateDBNewEvent(int id, string eventName, string eventDescription, string eventType, string eventStart, string eventEnd, string location, string eventCC, string contact, string reminderDateTime, string status)
        {
            bool success = false;

            try
            {
                // creating connection and command
                using (SqlConnection cn = new SqlConnection(DBconnectionString))
                using (SqlCommand cmd = new SqlCommand("singleEvent_update", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // defining parameters and their values
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@Name", eventName));
                    cmd.Parameters.Add(new SqlParameter("@Description", eventDescription));
                    cmd.Parameters.Add(new SqlParameter("@Type", eventType));
                    cmd.Parameters.Add(new SqlParameter("@Start_time", eventStart));
                    cmd.Parameters.Add(new SqlParameter("@End_time", eventEnd)); ;
                    cmd.Parameters.Add(new SqlParameter("@Contacts", contact));
                    cmd.Parameters.Add(new SqlParameter("@Location", location));
                    cmd.Parameters.Add(new SqlParameter("@Color_code", eventCC));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    if (reminderDateTime == "NULL")
                    {
                        cmd.Parameters.Add(new SqlParameter("@Reminder", DBNull.Value));
                    }
                    else 
                    {
                        cmd.Parameters.Add(new SqlParameter("@Reminder", reminderDateTime));
                    }

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return success;

        }
    }
}
