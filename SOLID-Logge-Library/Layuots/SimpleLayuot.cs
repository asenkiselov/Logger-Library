namespace SOLID_Logge_Library.Layuots
{
    using System;
    using SOLID_Logge_Library.Enums;
    using SOLID_Logge_Library.Interfaces;

    public class SimpleLayuot:ILayuot
    {
        private const string FormatedString = " {0} - {1} - {2} ";

        public string Formated(string msg, ReportLevel report, DateTime date)
        {
            return string.Format(FormatedString, date, report, msg);
        }
    }
}
