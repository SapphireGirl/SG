using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using SG.Util;

namespace SG.Logging
{
    // TODO: This needs to be of type T to accomodate different Logging files
    // TODO:  Need to have Debug/Trace, Info, Warning, and Error
    
    public abstract class BaseLogger : ISGLogger
    {

        private LogWriter writer = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
        private TraceManager traceMgr = EnterpriseLibraryContainer.Current.GetInstance<TraceManager>();

        public BaseLogger()
        {
           
        }

        public virtual void WriteToLog(string msg)
        {
            writer.Write(msg);
        }
        public virtual void WriteToLog(string msg, LogCategory category, Priority priority)
        {
         
        }

        public virtual void WriteObjectToConsoleLog(string msg){}

        public virtual void WriteMsgToEventLog(string msg){}

        public virtual void WriteObjectToEventLog(string msg){}

        public virtual void WriteMsgToTraceLog(string msg, params object[] pObjects){}

        public virtual void WriteObjectToTraceLog(string msg, params object[] pObjects){}

    }
}
