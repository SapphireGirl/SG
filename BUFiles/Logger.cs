using System.IO;

namespace SG.Logging
{
    public class Logger : ILogger
    {
        private StreamWriter logFile;
        public void Log(string txt)
        {
            WriteLog(txt);
        }

        public void LogFormat(string txt, params object[] pObjects)
        {
            string logMessage = string.Format(txt, pObjects);
            WriteLog(logMessage);
        }

        private void WriteLog(string txt)
        {
            if (logFile == null)
            {
                logFile = new StreamWriter("SGLog.log");
            }

            logFile.WriteLine(txt);
            logFile.Flush();
        }
    }
}
