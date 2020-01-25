using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;
using Net.Code.ADONet;

namespace MyShedule
{
    public partial class AddEventView : MaterialForm
    {
        private bool editable = true;
        private bool update = false;
        private bool reminder = false;
        private DataTable eventData = null;
        public AddEventView(DataTable eventData)
        {
            InitializeComponent();
            this.eventData = eventData;
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey700, Primary.BlueGrey500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );


        }

        //Enabling and disabling edit form contents
        private void enableContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (enabled && ctrl.Name == "dtpReminder" && btnAddReminder.Text == "+") 
                {
                    continue;
                }
                ctrl.Enabled = enabled;
            }
        }

        private void AddEventView_Load(object sender, EventArgs e)
        {
            //determinding whether it is an existing record show or adding new event
            btnAddReminder.AutoSize = false;
            btnAddReminder.Size = new Size(29, 20);
            if (eventData != null)
            {
                loadData();
                enableContents(this.panelInputs, false);
                btnAddEvent.Text = "Edit";
                editable = false;
                btnDelete.Visible = true;
            }
            else 
            {
                cBCC.SelectedIndex = 0;
                dtpEventEnd.Value = DateTime.Now.AddHours(2);
                dtpReminder.Visible = false;
                btnDelete.Visible = false;
            }

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            addEvent();
        }

        private void txtEventName_Click(object sender, EventArgs e)
        {

        }

        private void dtpEventEnd_Enter(object sender, EventArgs e)
        {
            this.dtpEventEnd.MinDate = dtpEventStart.Value;
        }

        private void dtpEventStart_ValueChanged(object sender, EventArgs e)
        {
            this.dtpEventEnd.MinDate = dtpEventStart.Value;
            this.dtpReminder.MaxDate = dtpEventStart.Value;
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {

            if (reminder)
            {
                reminderButtonEnabled(false);
            }
            else 
            {
                reminderButtonEnabled(true);
            }
        }

        //Reminder button enabling disabling
        private void reminderButtonEnabled(bool enabled) 
        {
            if (!enabled)
            {
                btnAddReminder.Text = "+";
                reminder = false;
                dtpReminder.Enabled = false;
                dtpReminder.Visible = false;
            }
            else
            {
                btnAddReminder.Text = "-"; 
                dtpReminder.Visible = true;
                dtpReminder.Enabled = true;
                reminder = true;
                if(eventData!=null && (DateTime.Now < (DateTime)eventData.Rows[0]["Start_time"]))
                {
                    dtpReminder.MinDate = DateTime.Now.AddHours(1); ;
                    dtpReminder.MaxDate = (DateTime)eventData.Rows[0]["Start_time"];
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool stat = DataPersistancy.deleteEvent((int)eventData.Rows[0]["id"]);
            if (stat)
            {
                MessageBox.Show("Event Deleted successfully", "Event Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                CalendarView.calender.displayCurrentDate();
                if (DayEventsDisplay.dayEventsDisplayForm!=null && DayEventsDisplay.dayEventsDisplayForm.Visible) 
                {
                    DayEventsDisplay.dayEventsDisplayForm.Dispose(); 
                }
            }

        }

        private void dtpReminder_Enter(object sender, EventArgs e)
        {
            this.dtpReminder.MaxDate = dtpEventStart.Value;
            this.dtpReminder.MinDate = DateTime.Today.AddHours(1);
            if ((this.dtpReminder.MaxDate- this.dtpReminder.MinDate).Hours<1) 
            {
                reminderButtonEnabled(false);
                btnAddReminder.Enabled = false;
                btnAddReminder.Visible = false;
            }
        }
    }
}
