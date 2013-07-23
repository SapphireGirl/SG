using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Logging;

namespace SG.Util
{
    public interface ISGLogger
    {
       
            void WriteToLog(string msg);
            //void WriteObjectToConsoleLog(string msg);

            //void WriteMsgToEventLog(string msg);
            //void WriteObjectToEventLog(string msg);

            //void WriteMsgToTraceLog(string msg, params object[] pObjects);
            //void WriteObjectToTraceLog(string msg, params object[] pObjects);


    }
}
