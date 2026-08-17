using System;
using System.Diagnostics;

namespace process_communication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Process py = null;
        Task task_read = null;

        public void create_process(string sAppNamePath, params string[] args)
        {
            py = new Process();

            //py.StartInfo.FileName = "python.exe";
            //py.StartInfo.ArgumentList.Add("D:/sample-projects/dotnet-process-communication/py/p.py");

            py.StartInfo.FileName = sAppNamePath;
            foreach (string arg in args) 
            {
                py.StartInfo.ArgumentList.Add(arg);
            }

            py.StartInfo.CreateNoWindow= true;

            py.StartInfo.UseShellExecute = false;
            py.StartInfo.RedirectStandardOutput = true;
            py.StartInfo.RedirectStandardError = true;
            py.StartInfo.RedirectStandardInput = true;
            //* Set your output and error (asynchronous) handlers
            py.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            py.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            //* Start process and handlers
        }
 
        void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {

            this.Invoke(() => {

                txtOut.AppendText("\n\r");
                txtOut.AppendText(outLine.Data);
                //txtOut.AppendText("\n");
            });
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            py.StandardInput.WriteLine(txtIn.Text);
            py.StandardInput.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            py.Start();
            py.BeginOutputReadLine();
            py.BeginErrorReadLine();
            //py.WaitForExit();
        }
    }
}
