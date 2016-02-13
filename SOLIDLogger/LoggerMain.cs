using SOLID_Logge_Library.Enums;

namespace SOLIDLogger
{
    using SOLID_Logge_Library.Appenders;
    using SOLID_Logge_Library.Interfaces;
    using SOLID_Logge_Library.Layuots;
    using SOLID_Logge_Library.Loggers;

    public class LoggerMain
    {
        static void Main()
        {
            TestInterfaces();

            TestFileAppender();

            TestXmlLayuot();

            TestTreshold();
        }

        private static void TestTreshold()
        {
            var simpleLayout = new SimpleLayuot();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.Treshold = ReportLevel.Error;

            var logger = new Logger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");
        }

        private static void TestXmlLayuot()
        {
            var xmlLayout = new XmlLayuot();
            var consoleAppender = new ConsoleAppender(xmlLayout);
            var logger = new Logger(consoleAppender);

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");
        }

        private static void TestInterfaces()
        {
            ILayuot simpleLayout = new SimpleLayuot();
            IAppender consoleAppender =
                new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info($"User {"Pesho"} successfully registered.");
        }

        private static void TestFileAppender()
        {
            var simpleLayout = new SimpleLayuot();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "log.txt";

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info($"User {"Pesho"} successfully registered.");
            logger.Warn("Warning - missing files.");
        }
    }
}
