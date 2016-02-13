
using System;
using System.Data;
using SOLID_Logge_Library.Enums;

namespace SOLID_Logge_Library.Loggers
{
    using System.Collections.Generic;
    using SOLID_Logge_Library.Interfaces;

    public class Logger:ILogger

    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public IList<IAppender> Appenders { get; }

        public void Info(string msg)
        {
            this.Log(msg,ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg,ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg,ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg,ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
            this.Log(msg,ReportLevel.Fatal);
        }

        private void Log(string msg,ReportLevel report)
        {
            var data = DateTime.Now;
            foreach (var appender in Appenders)
            {
                appender.Append(msg,report,data);
            }
        }
    }
}
