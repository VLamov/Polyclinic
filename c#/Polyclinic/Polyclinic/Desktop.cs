using System;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            this.Userlogin = "Ламов Владимир";
            ///Password A = new Password();
            ///A.ShowDialog(this);
            InitializeComponent();
        }

        public string Userlogin;
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUserName.Text += "  " + Userlogin;
        }

        private void Desktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Individuals fl = new Individuals();
            ///fl.Owner = this;
            fl.MdiParent = this;
            fl.Show();

        }
    }
}
