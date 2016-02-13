namespace SOLID_Logge_Library.Appenders
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using SOLID_Logge_Library.Enums;
    using SOLID_Logge_Library.Interfaces;

    public class FileAppender:Appender
    {
        public FileAppender(ILayuot layuot) 
            : base(layuot)
        {
        }

        public override void Append(string msg, ReportLevel report, DateTime date)
        {
            if (this.Treshold <= report)
            {
                var formatedMessege = Layuot.Formated(msg, report, date);
                this.WriteMessageToFile(formatedMessege);
            }
          
        }

        public string File { get; set; }

        private void WriteMessageToFile(string logMessage)
        {
            string path = this.File;
            string message = logMessage + Environment.NewLine;

            System.IO.File.AppendAllText(path, message);
        }
    }
}

