namespace process_communication
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
            ApplicationConfiguration.Initialize();
            Form1 frm = new Form1();

            //frm.create_process("jdb.exe", "D:/sample-projects/dotnet-process-communication/py/p.py");
            frm.create_process("D:/git2/cli_bin/rnd/process.bat");
            Application.Run(frm);
        }
    }
}