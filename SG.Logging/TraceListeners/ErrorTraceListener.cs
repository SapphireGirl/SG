using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace SG.Logging.TraceListeners
{
    // This class will write to the Trace.log file in the bin dir of the executable program
    // As well as the Event Log : 
    // TODO: Test Trace logging in Event Viewer

    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class ErrorTraceListener : CustomTraceListener
    {
        public override void TraceData(TraceEventCache eventCache, string source,
           TraceEventType eventType, int id, object data)
        {
            if (data is LogEntry && this.Formatter != null)
            {
                this.WriteLine(this.Formatter.Format(data as LogEntry));
            }
            else
            {
                this.WriteLine(data.ToString());
            }
        }
        public override void Write(string message)
        {
            throw new NotImplementedException();
        }

        public override void WriteLine(string message)
        {
            throw new NotImplementedException();
        }
    }
}
