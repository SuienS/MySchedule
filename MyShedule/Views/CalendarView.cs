using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace MyShedule
{
    public partial class CalendarView : MaterialForm
    {
        private List<FlowLayoutPanel> formDaysList = new List<FlowLayoutPanel>();
        private DateTime currentDateTime = DateTime.Today;
        public static CalendarView calender = new CalendarView();
        
        public CalendarView()
        {
            InitializeComponent();
            // Create a material theme
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configuring color theme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple900, Primary.DeepPurple700,
                Primary.DeepPurple400, Accent.Purple400,
                TextShade.WHITE
            );
        }

        public static void showCalendar() 
        {
            calender.ShowDialog();
        }

        //adding calander day boxes(FlowLayoutPanels)
        private void generateCalDays(int totalDays) 
        {
            formDays.Controls.Clear();
            formDaysList.Clear();
            for (int i = 1; i < totalDays; i++) 
            {
                FlowLayoutPanel formDay = new FlowLayoutPanel();
                formDay.Name = "f1Day" + i;
                formDay.MaximumSize = new Size(150, 100);
                formDay.AutoScroll = true;
                formDay.WrapContents = true;
                formDay.BackColor = Color.Gray;
                formDay.Margin = new Padding(4, 4, 4, 4);
                formDays.Controls.Add(formDay);
                formDaysList.Add(formDay);
            }

        }

        //adding the day number to the relavant day box
        private void addLabelDayToFormDay(int startDayFormNum, int totDaysInMonth) 
        {
            clearDayLabels();

            for (int i = 1; i <= totDaysInMonth; i++)
            {
                Label lblDay = new Label();
                lblDay.Name = "lblDay" + i;
                lblDay.AutoSize = false;
                lblDay.TextAlign = ContentAlignment.MiddleRight;
                lblDay.Size = new Size(125, 25);
                lblDay.Text = i.ToString();
                lblDay.Font = new Font("Malgun Gothic", 14);
                lblDay.ForeColor = System.Drawing.Color.White;
                DateTime date = new DateTime(currentDateTime.Year, currentDateTime.Month, i, 0, 0, 0);
                int index = (i - 1 + (startDayFormNum - 1));
                lblDay.Click += (sender, EventArgs) => { lblDay_Click(sender, EventArgs, index, date); };
                formDaysList[i - 1 + (startDayFormNum - 1)].Controls.Add(lblDay);
            }

        }

        //DayView
        private void lblDay_Click(object sender, EventArgs e, int lblDayIndex, DateTime date)
        {
            dayEventsDisplay(formDaysList[lblDayIndex], date);
        }


        public void dayEventsDisplay(FlowLayoutPanel dayEvents, DateTime date)
        {
            DayEventsDisplay.dayEventsDisplay(dayEvents, date);
        }

        //Creating buttuns for each event in a day
        private MaterialRaisedButton createEventButton(string eventData,int id) 
        {
            MaterialRaisedButton btnEvent = new MaterialRaisedButton();
            btnEvent.Name = "btnEvent_" + id;
            btnEvent.AutoSize = false;
            //resizing the size of the button to fit the event data
            int btnHeight = 25;
            if (eventData.Length >= 13) 
            {
                btnHeight += ( ((int)Math.Ceiling((double)(eventData.Length / 12))) * 25 );
            }
            btnEvent.Size = new Size(120, btnHeight);
            btnEvent.Text = eventData;
            btnEvent.Click += (sender, EventArgs) => { btnEvent_Click(sender, EventArgs, id); };
            return btnEvent;
        }

        //adding event buttons to the day boxes(FLPs)
        private void addEventBtnDayToFormDay(int startDayNumber) 
        {
            DateTime startDate = new DateTime(currentDateTime.Year,currentDateTime.Month,1, 0,0,0);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            DataTable events = DataPersistancy.getEvents(startDate,endDate);

            foreach(DataRow singleEventData in events.Rows)
            {
                DateTime evntDayStart = (DateTime)singleEventData[5];
                DateTime evntDayEnd = (DateTime)singleEventData[6];
                string eventNameDat = (string)singleEventData[2];
                if (((string)singleEventData[11]) == "Done") { eventNameDat += " ✓"; }
                formDaysList[(evntDayStart.Day-1) + (startDayNumber - 1)].Controls.Add( createEventButton(eventNameDat, (int)singleEventData[0]) );
                if (evntDayStart.Date != evntDayEnd.Date) 
                {
                    int durationDays = (int)Math.Ceiling((evntDayEnd.Date - evntDayStart.Date).TotalDays);
                    MaterialRaisedButton[] btnEventList = new MaterialRaisedButton[durationDays];
                    for (int day = 1; day <= durationDays; day++) 
                    {
                        btnEventList[day - 1] = createEventButton(eventNameDat, (int)singleEventData[0]);
                        formDaysList[(evntDayStart.Day - 1) + (startDayNumber - 1) + day].Controls.Add(btnEventList[day-1]);
                    }
                }

            }

        }

        private void clearDayLabels() 
        {
            foreach (FlowLayoutPanel flp in formDaysList)
            {
                flp.Controls.Clear();
            }
        }

        //Geting the current choosed month and generating the calendar
        public void displayCurrentDate() 
        {
            lblDate.Text = currentDateTime.ToString("MMMM, yyyy");
            int firstDayNumber = getFirstDay();
            int totDays = getTotalDaysOfCurDate();
            addLabelDayToFormDay(firstDayNumber, totDays);
            addEventBtnDayToFormDay(firstDayNumber);
        }

        private void preMonth() 
        {
            currentDateTime = currentDateTime.AddMonths(-1);
            displayCurrentDate();
        }

        private void nextMonth() 
        {
            currentDateTime = currentDateTime.AddMonths(1);
            displayCurrentDate();
        }

        private void today()
        {
            currentDateTime = DateTime.Today;
            displayCurrentDate();
        }

        private int getFirstDay() 
        {
            DateTime firstDayOfMonth = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
            return (int)firstDayOfMonth.DayOfWeek + 1;

        }


        private int getTotalDaysOfCurDate() 
        {
            DateTime firstDayOfCurDate = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
            return firstDayOfCurDate.AddMonths(1).AddDays(-1).Day;
        }

        private void CalendarView_Load(object sender, EventArgs e)
        {
            generateCalDays(42);
            displayCurrentDate();
        }


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void materialRaisedButton1_ClickAsync(object sender, EventArgs e)
        {
            timer.Interval = 800;
            timer.Tick += timer_Tick;
            timer.Start();
            materialRaisedButton1.Enabled = false;
            nextMonth();
        }
        void timer_Tick(object sender, System.EventArgs e)
        {
            materialRaisedButton1.Enabled = true;
            materialRaisedButton2.Enabled = true;
            timer.Stop();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            timer.Interval = 800;
            timer.Tick += timer_Tick;
            timer.Start();
            materialRaisedButton2.Enabled = false;
            preMonth();
        }

        private void btnEvent_Click(object sender, EventArgs e, int id)
        {
            AddEventView.singleEventDisplay(id);
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            today();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayCurrentDate();
        }
    }
}
