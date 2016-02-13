namespace SOLID_Logge_Library.Interfaces
{
    using System;
    using System.Data;
    using SOLID_Logge_Library.Enums;

    public interface IAppender
    {
        ReportLevel Treshold { get; set; }

        ILayuot Layuot { get; set; }

        void Append(string msg , ReportLevel report ,DateTime  date);
    }
}
