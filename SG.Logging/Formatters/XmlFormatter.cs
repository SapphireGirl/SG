using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Xml;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;


namespace SG.Logging.Formatters
{
    [ConfigurationElementType(typeof(CustomFormatterData))]
    public class XmlFormatter : LogFormatter
    {
        private NameValueCollection Attributes = null;

        public XmlFormatter(NameValueCollection attributes)
        {
            this.Attributes = attributes;
        }


        public override string Format(LogEntry log)
        {
            string prefix = this.Attributes["prefix"];
            string ns = this.Attributes["namespace"];

            using (StringWriter s = new StringWriter())
            {
                XmlTextWriter w = new XmlTextWriter(s);
                w.Formatting = Formatting.Indented;
                w.Indentation = 2;
                w.WriteStartDocument(true);
                w.WriteStartElement(prefix, "logentry", ns);
                w.WriteAttributeString("Priority", ns,
                    log.Priority.ToString(CultureInfo.InvariantCulture));
                w.WriteElementString("Timestamp", ns, log.TimeStampString);
                w.WriteElementString("Message", ns, log.Message);
                w.WriteElementString("EventId", ns,
                    log.EventId.ToString(CultureInfo.InvariantCulture));
                w.WriteElementString("Severity", ns, log.Severity.ToString());
                w.WriteElementString("Title", ns, log.Title);
                w.WriteElementString("Machine", ns, log.MachineName);
                w.WriteElementString("AppDomain", ns, log.AppDomainName);
                w.WriteElementString("ProcessId", ns, log.ProcessId);
                w.WriteElementString("ProcessName", ns, log.ProcessName);
                w.WriteElementString("Win32ThreadId", ns, log.Win32ThreadId);
                w.WriteElementString("ThreadName", ns, log.ManagedThreadName);
                w.WriteEndElement();
                w.WriteEndDocument();

                return s.ToString();


            }
        }
    }
}