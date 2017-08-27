using System;
using DotNetNuke.Data;

namespace DNN.Scheduling
{
    internal class SchedulingUtility
    {
        internal static void WriteLog(DateTime currentTime)
        {
            DataProvider dbHandler = DataProvider.Instance();
            dbHandler.ExecuteReader("DotSee_Scheduling", null);

            // dbhandler must do these
            var logOfSchedule =  new ScheduleLog() { ScheduleID = 1, Msg = "some log msg", OnDate = currentTime };
            // dbHandler.Save(logOfSchedule);
        }
    }
}