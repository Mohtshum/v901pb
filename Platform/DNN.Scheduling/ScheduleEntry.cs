using System;

namespace DNN.Scheduling
{
    internal class ScheduleEntry
    {
        public ScheduleEntry()
        {
        }

        public string Msg { get; set; }
        public DateTime OnDate { get; set; }
        public int ScheduleID { get; set; }
    }
}