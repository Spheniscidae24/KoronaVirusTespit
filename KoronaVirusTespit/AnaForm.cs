namespace KoronaVirusTespit
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yardýmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimForm form = new YardimForm();
            form.Show();
        }

        private void belirtiTespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BelirtiTespitForm form = new BelirtiTespitForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}