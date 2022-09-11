using System.Runtime.InteropServices;

namespace SBFC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region TitleBar_Drag_Form
        //Drag Form
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Form Shadow Effect
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams сp = base.CreateParams;
                сp.ClassStyle |= 0x00020000;
                return сp;
            }
        }
        #endregion



        private void txtSourcesPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSourcesPath.Text = fbd.SelectedPath;
                }
            }
        }
        private void txtDestinationPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtDestinationPath.Text = fbd.SelectedPath;
                }
            }
        }
        private void btnPng2Jpeg_Click(object sender, EventArgs e)
        {

        }

       
    }
}