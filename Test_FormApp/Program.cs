using OfficeOpenXml;

namespace Test_FormApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ApplicationConfiguration.Initialize();
            Application.Run(new Upload());
            //Application.Run(new USB());
            //Application.Run(new WebCam());
            //Application.Run(new ExcelNew());
        }
    }
}