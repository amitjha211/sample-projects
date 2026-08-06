
using apk;
using apk.db;
using apk.win;
using g.progress;
using tcore2.env;
using static g.progress.progress_f;

namespace sample_winforms
{
    public partial class frmProgress_Test2 : frmAPK_Base
    {
        public frmProgress_Test2()
        {
            InitializeComponent();
        }


        Task taskProcess = null;
        Task taskDisplay = null;

        progress_model _p = null;


        private void process_func(progress_model p)
        {

            int iCount = 244;
            progress_start(p, "Upload", "Upload");
            Thread.Sleep(1000);

            for (int i = 0; i < iCount; i++)
            {
                Thread.Sleep(200);
                progress_working(p, iCount, i);
            }

            progress_end(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _p = progress_create(_apk);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            taskProcess = new Task(() =>
            {
                process_func(_p);
            });


            _p.onAction = (object sender, string sAction) =>
            {
                progress_model p = (progress_model)sender;


                switch (sAction)
                {
                    case "start":
                        this.Invoke(() =>
                        {
                            groupBox1.Text = $"{p.progressTitle}   ---- [Started]";
                            progressBar1.Value = 0;
                            btnStart.Enabled = false;
                        });

                        break;
                    case "working":
                        this.Invoke(() =>
                        {
                            groupBox1.Text = $"{p.progressTitle}   ---- [Working]";
                            progressBar1.Value = Convert.ToInt32(p.per);
                        });

                        break;
                    case "end":
                        this.Invoke(() =>
                        {
                            groupBox1.Text = $"{p.progressTitle}   ---- [Done]";
                            progressBar1.Value = Convert.ToInt32(p.per);
                            btnStart.Enabled = true;
                        });

                        break;
                }

            };

            taskProcess.Start();
        }
    }
}