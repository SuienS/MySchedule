using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace MyShedule
{
    public class Clock
    {
        Timer t;
        static Clock clock = new Clock();
        public static string curDateTimeClock;
        public static DataTable futureEvents;


        public Clock()
        {
            t = new Timer();
        }


        public static async void TIME()
        {
            while (true)
            {
                clock.clockTick();
                checkReminders();
                await Task.Delay(1000);

            }
        }

        public static void checkReminders() 
        {
            futureEvents = DataPersistancy.getEvents(DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(-1));
            for (int i = 0; i < futureEvents.Rows.Count; i++)
            {
                DataRow eventDat = futureEvents.Rows[i];

                if (((DateTime)eventDat["Reminder"]).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)==
                    curDateTimeClock)
                {
                    MessageBox.Show("Reminder for the Event " + (string)eventDat["Name"] + " at " +
                        ((DateTime)eventDat["Start_time"]).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }

            }
        }



        //timer eventhandler for the clock
        private void clockTick()
        {
            //getting current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string dateToday = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            //time
            string time = "";

            //Building time string
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update date
            curDateTimeClock = (dateToday + " " + time);
        }

    }
}
