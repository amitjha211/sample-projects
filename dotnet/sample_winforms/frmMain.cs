
namespace sample_winforms
{


    public partial class frmMain : frmAPK_Base
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void progress1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgress_Test1 _frm = new frmProgress_Test1();
            _frm.MdiParent = this;
            _frm._apk = this._apk;
            _frm.Show();
        }

        private void progress2WithObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgress_Test2 _frm = new frmProgress_Test2();
            _frm.MdiParent = this;
            _frm._apk = this._apk;
            _frm.Show();
        }
    }




}
