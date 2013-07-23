using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace SG.Logging.Loggers
{
    public class CriticalLogger : BaseLogger
    {

       

       
        public override void WriteToLog(string msg, LogCategory category, Priority priority)
        {
            LogEntry log = new LogEntry();

            log.Categories.Add(category.ToString());
            //  log.Priority = int.TryParse( priority);
            //writer.Write(msg, category, priority);
        }
        //void WriteObjectToConsoleLog(string msg);

        //void WriteMsgToEventLog(string msg);
        //void WriteObjectToEventLog(string msg);

        //void WriteMsgToTraceLog(string msg, params object[] pObjects);
        //void WriteObjectToTraceLog(string msg, params object[] pObjects);
    }
}
