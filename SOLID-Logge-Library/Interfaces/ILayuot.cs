namespace SOLID_Logge_Library.Interfaces
{
    using System;
    using SOLID_Logge_Library.Enums;

    public interface ILayuot
    {
        string Formated(string msg , ReportLevel report , DateTime date);
    }
}
