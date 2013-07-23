

namespace SG.Logging
{
    public class LogAdapter : ILogger
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof (LogAdapter));

        public void Log(string txt)
        {
            log.Info(txt);
        }

        public void LogFormat(string txt, params object[] pObjects)
        {
            log.InfoFormat(txt, pObjects);
        }
    }
}
