using System;
using DotNetNuke.Data;

namespace DNN.Scheduling
{
    public class SchedulingUtility
    {
        public static void WriteLog(DateTime currentTime)
        {
            DataProvider dbHandler = DataProvider.Instance();
            dbHandler.ExecuteNonQuery("Add_SchedulingLog", string.Format("some msg at {0}", currentTime), currentTime);
            // dbhandler must do these
            //var logOfSchedule =  new ScheduleLog() { ScheduleID = 1, Msg = "some log msg", OnDate = currentTime };
            // dbHandler.Save(logOfSchedule);
        }
    }
}