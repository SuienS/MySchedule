using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace MyShedule
{
    public partial class MainMenu : MaterialForm
    {
        string Username;
        public MainMenu(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            Clock.TIME();
            Console.ReadLine();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblWelcomeUser.Text = "Hi, " + Username;
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            CalendarView.showCalendar();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AddEventView addEventView = new AddEventView(null);
            addEventView.ShowDialog();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            PredictionView prediction = new PredictionView();
            prediction.ShowDialog();
        }

        private void lblWelcomeUser_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
