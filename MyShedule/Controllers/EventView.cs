using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShedule
{
    public partial class AddEventView
    {
        public static void singleEventDisplay(int id)
        {
            DataTable eventData = DataPersistancy.getSingleEvent(id);
            AddEventView singleEventView = new AddEventView(eventData);
            singleEventView.ShowDialog();
            Console.WriteLine(eventData.Rows[0]["id"]);
        }



        private void loadData()
        {
            try
            {
                if ((((string)eventData.Rows[0]["Type"]).Split('|')[0] == "RecurringM") ||
                (((string)eventData.Rows[0]["Type"]).Split('|')[0] == "Recurring-Monthly")
                )
                {
                    rbRecurringMonthly.Checked = true;
                }
                else if ((((string)eventData.Rows[0]["Type"]).Split('|')[0] == "RecurringY") ||
                    (((string)eventData.Rows[0]["Type"]).Split('|')[0] == "Recurring-Yearly")
                    )
                {
                    rbRecurringYearly.Checked = true;
                }
                if (((string)eventData.Rows[0]["Type"]).Split('|')[1] == "Appointment")
                {
                    rbAppointment.Checked = true;
                }
                if (!DBNull.Value.Equals(eventData.Rows[0]["Reminder"]))
                {
                    reminderButtonEnabled(true);
                    try
                    {
                        dtpReminder.Value = (DateTime)eventData.Rows[0]["Reminder"];
                    }
                    catch (Exception ex)
                    {
                        reminderButtonEnabled(false);
                    }
                }
                bool status = false;
                if (((string)eventData.Rows[0]["Status"]) == "Done")
                {
                    status = true;
                }
                cbStatus.Checked = status;
                txtEventName.Text = (string)eventData.Rows[0]["Name"];
                txtDescription.Text = (string)eventData.Rows[0]["Description"];
                dtpEventStart.Value = (DateTime)eventData.Rows[0]["Start_time"];
                dtpEventEnd.Value = (DateTime)eventData.Rows[0]["End_time"];
                txtLocation.Text = (string)eventData.Rows[0]["Location"];
                cBCC.SelectedItem = (string)eventData.Rows[0]["Color_code"];
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
