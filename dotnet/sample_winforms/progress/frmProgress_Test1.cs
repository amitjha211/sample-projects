
using apk;
using apk.db;
using apk.win;
using g.progress;
using tcore2.env;
using static g.progress.progress_f;

namespace sample_winforms
{
    public partial class frmProgress_Test1 : frmAPK_Base
    {
        public frmProgress_Test1()
        {
            InitializeComponent();
        }

        int iProcessCount = 244;

        int iProgress = 0;
        int iTimerCount = 0;

        Task t1 = null;
        Task t2 = null;

        private void Form1_Load(object sender, EventArgs e)
        {

            t1 = new Task(() =>
            {
                for (int i = 0; i <= iProcessCount; i++)
                {
                    Thread.Sleep(200);
                    iProgress = i;
                }
            });

            t2 = new Task(() =>
            {
                while (true)
                {
                    

                    Thread.Sleep(150);


                    if (this.Disposing) return;

                     this.Invoke(() =>
                    {
                        if (this.Disposing) return;
                        this.Text = $"Process : {iProgress} || Timer Count : {iTimerCount} ||";
                    });

                    iTimerCount++;
                    if (iProgress >= iProcessCount)
                    {

                        this.Invoke(() =>
                        {
                            alert("Done");
                        });
                        return;
                    }

                }
            });
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            t1.Start();
            t2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = iProgress.ToString();
        }

    }
}