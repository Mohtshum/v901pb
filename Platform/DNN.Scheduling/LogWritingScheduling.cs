using DotNetNuke.Services.Scheduling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNN.Scheduling
{
    public class LogWritingScheduling : SchedulerClient
    {
        private ScheduleHistoryItem shItem;

        public LogWritingScheduling(ScheduleHistoryItem shItem) : base()
        {
            this.shItem = shItem;
        }

        public override void DoWork()
        {
            bool schedulingDone = true;

            try
            {
                SchedulingUtility.WriteLog(DateTime.Now);
                //To log note                
                InsertLogNote(" logging done by scheduling");
                //Show success
                this.ScheduleHistoryItem.Succeeded = schedulingDone;
            }
            catch (Exception ex)
            {
                this.ScheduleHistoryItem.Succeeded = !schedulingDone;
                InsertLogNote("Exception= " + ex.ToString());
                this.Errored(ref ex);
                DotNetNuke.Services.Exceptions.Exceptions.LogException(ex);
            }
        }

        private void InsertLogNote(string logMessage)
        {
            this.ScheduleHistoryItem.AddLogNote(logMessage);
        }
    }
}
