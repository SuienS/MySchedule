using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShedule
{
    public partial class AddEventView
    {
        private void addEvent() 
        {
            if (editable)
            {
                string eventName = txtEventName.Text;
                string eventDescription = txtDescription.Text;
                string eventType = "One-off|";
                if (rbRecurringMonthly.Checked)
                {
                    eventType = "Recurring-Monthly|";
                }
                else if (rbRecurringYearly.Checked)
                {
                    eventType = "Recurring-Yearly|";
                }
                if (rbAppointment.Checked)
                {
                    eventType += "Appointment";
                }
                else
                {
                    eventType += "Task";
                }

                string eventStart = dtpEventStart.Value.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                string eventEnd = dtpEventEnd.Value.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                string location = txtLocation.Text;
                string eventCC = cBCC.SelectedItem.ToString();
                string contact = "NULL";
                if (txtContact.Text != null)
                {
                    contact = txtContact.Text;
                }
                string reminderDateTime = "NULL";
                if (dtpReminder.Enabled)
                {
                    reminderDateTime = dtpReminder.Value.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                }
                string status = "Not";
                if (cbStatus.Checked) 
                {
                    status = "Done";
                }
                if (update)
                {
                    bool success = DataPersistancy.UpdateDBNewEvent((int)eventData.Rows[0]["id"], eventName, eventDescription, eventType, eventStart, eventEnd, location, eventCC, contact, reminderDateTime, status);
                    if (success)
                    {
                        MessageBox.Show("Event Updated successfully", "Event Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    { return; }
                }
                else
                {
                    bool success = DataPersistancy.AddDBNewEvent(eventName, eventDescription, eventType, eventStart, eventEnd, location, eventCC, contact, reminderDateTime, status);
                    if (success)
                    {
                        MessageBox.Show("Event Added successfully", "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    { return; }
                }
                if (CalendarView.calender != null && CalendarView.calender.Visible)
                {
                    CalendarView.calender.displayCurrentDate();
                }

                if (DayEventsDisplay.dayEventsDisplayForm != null && DayEventsDisplay.dayEventsDisplayForm.Visible)
                {
                    DayEventsDisplay.dayEventsDisplayForm.Dispose();
                }

                this.Close();
            }
            else
            {
                btnAddEvent.Text = "Confirm";
                enableContents(this.panelInputs, true);
                editable = true;
                update = true;
                if (DateTime.Now > (DateTime)eventData.Rows[0]["Start_time"])
                {
                    btnAddReminder.Enabled = false;
                    dtpReminder.Enabled = false;
                }
            }

        }
    }
}
