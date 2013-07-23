using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace SG.Logging.TraceListeners
{
    // This class will write to the Warning.log file in the bin dir of the executable program

    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class WarningTraceListener : CustomTraceListener
    {
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
