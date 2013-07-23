using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace SG.Logging.TraceListeners
{
    // This class will write to the Critical.log file in the bin dir of the executable program

    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class CriticalTraceListener : CustomTraceListener
    {
       
        public CriticalTraceListener() : base()
        {
            
        }
        // TraceData override

        public override void TraceData(TraceEventCache eventCache, string source,
            TraceEventType eventType, 
            int id, 
            object data)
        {
           // base.TraceData(eventCache, source, eventType, id, data);
            //if (data is LogEntry && this.Formatter != null)
            //{
            //    this.WriteLine(this.Formatter.Format(data as LogEntry));
            //}
            //else
            //{
            //    this.WriteLine(data.ToString());
            //}

        }
        // CustomTraceListener Methods
        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine((string)this.Attributes["delimiter"]);

            Console.WriteLine(message);

        }

        // In EL example: overriding TraceData
    }
}
