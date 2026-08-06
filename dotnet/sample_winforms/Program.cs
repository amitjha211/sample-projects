
using apk;
using static apk.admin.apk_admin;

namespace sample_winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            clsAPK _apk = apk_create("sample", "sample", "dev");
            
            ApplicationConfiguration.Initialize();
            frmMain _frmMain = new frmMain();
            _frmMain._apk = _apk;   

            Application.Run(_frmMain);
        }
    }
}