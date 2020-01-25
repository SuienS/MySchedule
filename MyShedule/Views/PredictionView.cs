using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
namespace MyShedule
{
    public partial class PredictionView : MaterialForm
    {
        double[] chart0, chart1, chart2, chart3;
        public PredictionView()
        {
            InitializeComponent();

        }


        private async void generatePredictionReportBtn_ClickAsync(object sender, EventArgs e)
        {
            SaveFileDialog locationFile = new SaveFileDialog();

            locationFile.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            locationFile.FilterIndex = 2;
            locationFile.RestoreDirectory = true;

            if (locationFile.ShowDialog() == DialogResult.OK) 
            {
                var time = await Task.Run(() => this.writeFile(locationFile.FileName));
                MessageBox.Show("Prediction Report saved Successfully");
            }
        }

        private int writeFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8);
            try
            {

                sw.WriteLine("--------------PREDICTION RESULT-------------");
                sw.WriteLine("\n");
                sw.WriteLine("Week 1");
                sw.WriteLine("==================================================");
                sw.WriteLine("Predicted Appointments Hours : " + weeklyWeightedTotalDurations(0)[0]);
                sw.WriteLine("Predicted Tasks Hours : " + weeklyWeightedTotalDurations(0)[1]);
                sw.WriteLine("Predicted Sleep Time Hours : " + weeklyWeightedTotalDurations(0)[2]);
                sw.WriteLine("Predicted Vacant Time Hours : " + weeklyWeightedTotalDurations(0)[3]);
                sw.WriteLine("Week 2");
                sw.WriteLine("==================================================");
                sw.WriteLine("Predicted Appointments Hours : " + weeklyWeightedTotalDurations(1)[0]);
                sw.WriteLine("Predicted Tasks Hours : " + weeklyWeightedTotalDurations(1)[1]);
                sw.WriteLine("Predicted Sleep Time Hours : " + weeklyWeightedTotalDurations(1)[2]);
                sw.WriteLine("Predicted Vacant Time Hours : " + weeklyWeightedTotalDurations(1)[3]);
                sw.WriteLine("Week 3");
                sw.WriteLine("==================================================");
                sw.WriteLine("Predicted Appointments Hours : " + weeklyWeightedTotalDurations(2)[0]);
                sw.WriteLine("Predicted Tasks Hours : " + weeklyWeightedTotalDurations(2)[1]);
                sw.WriteLine("Predicted Sleep Time Hours : " + weeklyWeightedTotalDurations(2)[2]);
                sw.WriteLine("Predicted Vacant Time Hours : " + weeklyWeightedTotalDurations(2)[3]);
                sw.WriteLine("Week 4");
                sw.WriteLine("==================================================");
                sw.WriteLine("Predicted Appointments Hours : " + weeklyWeightedTotalDurations(3)[0]);
                sw.WriteLine("Predicted Tasks Hours : " + weeklyWeightedTotalDurations(3)[1]);
                sw.WriteLine("Predicted Sleep Time Hours : " + weeklyWeightedTotalDurations(3)[2]);
                sw.WriteLine("Predicted Vacant Time Hours : " + weeklyWeightedTotalDurations(3)[3]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("File Write Error");
            }
            finally { sw.Close(); }
            return 1;
        }



        private void generateChart(double[] week1,double[] week2,double[] week3,double[] week4) 
        {
            generateWeekStackedBar("Week 04", week4[0], week4[1], week4[2], week4[3]);
            generateWeekStackedBar("Week 03", week3[0], week3[1], week3[2], week3[3]);
            generateWeekStackedBar("Week 02", week2[0], week2[1], week2[2], week2[3]);
            generateWeekStackedBar("Week 01", week1[0], week1[1], week1[2], week1[3]);
        }

        private void generateWeekStackedBar(string week,double appointments, double tasks, double sleep,double vacant) 
        {
            chartPrediction.Series["Appointments"].Points.AddXY(week, appointments);
            chartPrediction.Series["Tasks"].Points.AddXY(week, tasks);
            chartPrediction.Series["Vacant Time"].Points.AddXY(week, vacant);
            chartPrediction.Series["Sleep Time"].Points.AddXY(week, sleep);
        }

        private void PredictionView_Load(object sender, EventArgs e)
        {
            loadAllEvents();
            chart0 = weeklyWeightedTotalDurations(0);
            chart1 = weeklyWeightedTotalDurations(1);
            chart2 = weeklyWeightedTotalDurations(2);
            chart3 = weeklyWeightedTotalDurations(3);

            generateChart(chart0, chart1, chart2, chart3);

            Console.WriteLine(chart3[0]);
        }
    }

}
