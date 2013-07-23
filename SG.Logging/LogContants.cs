using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.Logging
{
    public struct Priority
    {
        public const int Lowest = 0;
        public const int Low = 1;
        public const int Normal = 2;
        public const int High = 3;
        public const int Highest = 4;
     
    }
    // A Category a Log Level/Log Type combo
    // 
    public struct LogCategory
    {
        // Critical:  System is down or in jeopardy of going down: e.g Memory Issues
        //                Critical Level Errors are written to the Event Log, Trace Log (Flat file),
        //                 and the Console
        // Error: Operation did not succeed
        //            Error Level Errors are written to the Event Log and the Trace Log
        // Warning: Error occurred with possible work around: e.g. Some input errors
        //                 Warning Level Errors are written to the Trace Log
        // Trace: Used for Debug purposes
        //             Trace Level Errors are written to the Trace Log
        // Info: Used to log info about the application/process
        //           Info Level Errors are written to the Trace Log

        public const string Critical = "Critical";
        public const string Error = "Error";
        public const string Warning = "Warning";
        public const string Trace = "Trace";
        public const string Info = "Info";



    }
}
