using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShedule
{
    partial class PredictionView
    {
        private const int predictionWeekNum = 4;
        private const int predictionMonths = 8;
        private const double totalWeekHours = 168.0;
        private static double sleepTime = 40.0;
        private DataTable[,] week_events = new DataTable[predictionWeekNum, predictionMonths];
        private double[] weightage = {1, 0.42, 0.26, 0.18, 0.08, 0.04, 0.01, 0.01 };
        
        //Retrieving all the event data of last 7 months with the future 1 month from database
        private void loadAllEvents() 
        {
            sleepTime = DataPersistancy.sleep_time * 7;
            int weeks = -4;
            for (int month = 0; month < predictionMonths; month++)
            {
                for (int week = 0; week < predictionWeekNum; week++)
                {
                    week_events[week,month] = DataPersistancy.getEvents(
                        DateTime.Now.AddDays(-(weeks*7)-7).AddSeconds(1), 
                        DateTime.Now.AddDays(-(weeks*7))
                    );
                    weeks++;
                }
            }
        }

        //Calculating the total unweighted weekly amount of time usages
        private double[] weeklyAmount(string type,int weekNum) 
        {
            int weekNumber = 3 - weekNum;
            double[] unWeightedTotalHours = new double[predictionMonths];
            //getting the total duration of all the events in all months in the passed(in parameter) week number
            for (int month=0; month< predictionMonths; month++) 
            {
                double totalHours = 0.0;
                foreach (DataRow eventDataRow in week_events[weekNumber, month].Rows) 
                {
                    if ( ((string)eventDataRow["Type"]).Split('|')[1] == type) 
                    {
                        double totalEventDuration = (
                        (DateTime)eventDataRow["End_time"] - (DateTime)eventDataRow["Start_time"]
                        ).TotalHours;
                        totalHours += totalEventDuration;
                    }
                }
                unWeightedTotalHours[month] = totalHours;
            }

            return unWeightedTotalHours;
        }

        //weighing the total usage hours
        private double weeklyWeightedAmount(string type, int weekNumber) 
        {
            double[] unWeighted = weeklyAmount(type, weekNumber);
            double weightedWeeklyPredictedDuration = (
                unWeighted[0] * weightage[0] +
                unWeighted[1] * weightage[1] +
                unWeighted[2] * weightage[2] +
                unWeighted[3] * weightage[3] +
                unWeighted[4] * weightage[4] +
                unWeighted[5] * weightage[5] +
                unWeighted[6] * weightage[6] +
                unWeighted[7] * weightage[7]
                );

            return weightedWeeklyPredictedDuration;
        }

        //getting the sum of all the event types' usages week by week ang returns the final data array
        private double[] weeklyWeightedTotalDurations(int weekNumber) 
        {
            double[] weeklyPredictedAmounts = new double[4];
            weeklyPredictedAmounts[0] = Math.Round(weeklyWeightedAmount("Appointment", weekNumber),2);
            weeklyPredictedAmounts[1] = Math.Round(weeklyWeightedAmount("Task", weekNumber),2);
            weeklyPredictedAmounts[2] = sleepTime;
            weeklyPredictedAmounts[3] = Math.Round((totalWeekHours - (weeklyPredictedAmounts[0]+ weeklyPredictedAmounts[1] + weeklyPredictedAmounts[2])),2);
            if (weeklyPredictedAmounts[3]<0.0) 
            {
                weeklyPredictedAmounts[2] += weeklyPredictedAmounts[3];
                weeklyPredictedAmounts[3] = 0.0;
            }

            return weeklyPredictedAmounts;
        }

    }
}
