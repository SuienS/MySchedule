using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace MyShedule
{
    public partial class DayEventsDisplay : MaterialForm
    {
        private FlowLayoutPanel dayEvents;
        private DateTime date;
        public static DayEventsDisplay dayEventsDisplayForm;
        public DayEventsDisplay(FlowLayoutPanel dayEvents, DateTime date)
        {
            InitializeComponent();

            this.dayEvents = dayEvents;
            this.date = date;

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

        public static void dayEventsDisplay(FlowLayoutPanel dayEvents, DateTime date)
        {
            dayEventsDisplayForm = new DayEventsDisplay(dayEvents,date);
            dayEventsDisplayForm.ShowDialog();
        }

        public void loadEventDat() 
        {
            flpDayEvents.MaximumSize = new Size(460, 475);
            flpDayEvents.AutoScroll = true;
            flpDayEvents.WrapContents = true;
            addEventsBtns();
        }


        private void DayEventsDisplay_Load(object sender, EventArgs e)
        {
            loadEventDat();
        }

        private void addEventsBtns() 
        {
            lblDate.Text = date.ToString("dd MMMM, yyyy");
            if (dayEvents.Controls.Count == 1)
            {
                lblNoEvents.Visible = true;
            }
            else 
            {
                foreach (Control cntrl in dayEvents.Controls)
                {
                    if (cntrl is Label)
                    {
                        continue;
                    }
                    DataRow singleEventData = DataPersistancy.getSingleEvent(Int32.Parse(cntrl.Name.Split('_')[1])).Rows[0];


                    DateTime evntDayStart = (DateTime)singleEventData[5];
                    DateTime evntDayEnd = (DateTime)singleEventData[6];
                    flpDayEvents.Controls.Add(createSingleEventButton((int)singleEventData[0], (string)singleEventData[2], (string)singleEventData[3], ((DateTime)singleEventData[5]).ToString("dd/MM/yyyy  HH:mm:ss")));

                }
            }
        }

        private MaterialRaisedButton createSingleEventButton(int id, string eventName, string eventDescription, string eventTime) 
        {
            string eventDat = "{0} - {1}    on {2}";
            string eventDatButtonText = string.Format(eventDat, eventName, eventDescription, eventTime);
            MaterialRaisedButton btnEvent = new MaterialRaisedButton();
            btnEvent.Text = eventDatButtonText;
            btnEvent.AutoSize = false;
            btnEvent.Size = new Size(445, 36);
            btnEvent.Click += (sender, EventArgs) => { btnEvent_Click(sender, EventArgs, id); };
            return btnEvent;
        }

        private void btnEvent_Click(object sender, EventArgs e, int id)
        {
            AddEventView.singleEventDisplay(id);
        }

        private void btnAddEventsSingleView_Click(object sender, EventArgs e)
        {
            AddEventView addEvent = new AddEventView(null);
            addEvent.ShowDialog();
        }
    }
}
