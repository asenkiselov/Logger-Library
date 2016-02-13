namespace SOLID_Logge_Library.Appenders
{
    using System;
    using SOLID_Logge_Library.Enums;
    using SOLID_Logge_Library.Interfaces;

    public abstract class Appender:IAppender
    {
        public ReportLevel Treshold { get; set; }

        public ILayuot Layuot { get; set; }

        protected Appender(ILayuot layuot)
        {
            this.Layuot = layuot;
        }

        public abstract void Append(string msg, ReportLevel report, DateTime date);

    }
}
