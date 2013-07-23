using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.Unity;
using SG.Util;


namespace SG.Logging
{
   // public class SGLogger<TLog> : BaseLog where TLog : LogCategory
    public class SGLogger : BaseLogger, ISGLogger
    {
        private LogWriter _logWriter;
        private IUnityContainer _container;


        public SGLogger(IUnityContainer container)
        {
            _container = container;
            _logWriter = _container.Resolve<LogWriter>();
        }
        
        public override void WriteToLog(string msg)
        {
            // TODO: implement categories
            //LogEntry logEntry = new LogEntry();
            //logEntry.Message = string.Format("WriteMsgToConsoleLog: ");
            //// Categories are used to route the log entry to one or more trace listeners
            //logEntry.Categories.Add(LogCategory.Info);

            _logWriter.Write(msg, "Info");
        }

        // TODO: Implement additional logging to accomodate n-tier systems.
        public override void WriteObjectToConsoleLog(string msg)
        {
            throw new System.NotImplementedException();
        }

        public override void WriteMsgToEventLog(string msg)
        {
            throw new System.NotImplementedException();
        }

        public override void WriteObjectToEventLog(string msg)
        {
            throw new System.NotImplementedException();
        }

        public override void WriteMsgToTraceLog(string msg, params object[] pObjects)
        {
            throw new System.NotImplementedException();
        }

        public override void WriteObjectToTraceLog(string msg, params object[] pObjects)
        {
            throw new System.NotImplementedException();
        }
    }
}
