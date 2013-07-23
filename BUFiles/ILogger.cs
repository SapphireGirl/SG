using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.Logging
{
    public interface ILogger
    {
        void Log(string txt);
        void LogFormat(string txt, params object[] pObjects);

    }
}
