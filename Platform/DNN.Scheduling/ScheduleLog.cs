using System;

namespace DNN.Scheduling
{
    internal class ScheduleLog
    {
        public ScheduleLog()
        {
        }

        public string Msg { get; set; }
        public DateTime OnDate { get; set; }
        public int ScheduleID { get; set; }
    }
}