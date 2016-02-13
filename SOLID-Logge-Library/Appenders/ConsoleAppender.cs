namespace SOLID_Logge_Library.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public class ConsoleAppender:Appender
    {
        public ConsoleAppender(ILayuot layuot) 
            : base(layuot)
        {
        }

        public override void Append(string msg, ReportLevel report, DateTime date)
        {
            if (this.Treshold <= report)
            {
                var formatedMessege = Layuot.Formated(msg, report, date);
                Console.WriteLine(formatedMessege);
            }
         
        }
    }
}
