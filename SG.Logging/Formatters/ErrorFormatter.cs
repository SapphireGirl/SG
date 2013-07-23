using System.IO;
using System.Text;
using System.Collections.Specialized;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;

namespace SG.Logging.Formatters
{
    [ConfigurationElementType(typeof(CustomFormatterData))]
    public class ErrorFormatter : LogFormatter
    {
        private NameValueCollection Attributes = null;

        public ErrorFormatter(NameValueCollection attributes)
        {
            this.Attributes = attributes;
        }
        public override string Format(LogEntry log)
        {
            string prefix = this.Attributes["prefix"];
            string ns = this.Attributes["namespace"];
            StringBuilder sb = new StringBuilder();
            using (StringWriter s = new StringWriter(sb))
            {

                s.Write("ERROR: ");
                s.Write("IIII");
                s.WriteLine(prefix);
                s.WriteLine("Timestamp:");
                s.Write(log.TimeStampString);
                s.WriteLine("Message: ");
                s.Write(log.Message);
                s.WriteLine("Machine: ");
                s.Write(log.MachineName);
                s.WriteLine("Win32ThreadId: ");
                s.Write(log.Win32ThreadId);
                s.WriteLine("ThreadName: ");
                s.Write(log.ManagedThreadName);

                return sb.ToString();

            }
        }
    }
}
