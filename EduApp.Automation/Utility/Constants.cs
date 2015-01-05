namespace EduApp.Automation.Utility
{
    public static class Constants
    {
        public static int ApplicationTimeOut = 10;
        public static string FrameworkProject = "EduApp.Automation";
        public static string SpecFlowProject = "EduApp.UITest";
        public static string DebugFolder = @"bin\Debug";
        public static string ReleaseFolder = @"bin\Release";
        public static string DriverFolder = @"Drivers";
        public static string DevUrl = @"http://localhost:82/";

        public enum Browsers
        {
            GoogleChrome = 1,
            InternetExplorer = 2
        }

        public enum Environments
        {
            DEV = 1,
            QA = 2,
            PROD = 3
        }

    }
}
