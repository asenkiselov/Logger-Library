namespace SOLID_Logge_Library.Layuots
{
    using System;
    using System.Text;
    using SOLID_Logge_Library.Enums;
    using SOLID_Logge_Library.Interfaces;

    public class XmlLayuot:ILayuot
    {
         public string Formated(string msg, ReportLevel report, DateTime date)
         {
            var output = new StringBuilder();
            output.AppendLine("<log>");
            output.AppendLine("<message>" + msg + "</message>");
            output.AppendLine("<level>" + report + "</level>");
            output.AppendLine("<date>" + date + "</date>");
            output.AppendLine("</log>");

            return output.ToString();
        }
    }
    
}
