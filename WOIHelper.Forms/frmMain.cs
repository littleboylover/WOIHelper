using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOIHelper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuStardustCalculator_Click(object sender, EventArgs e)
        {
            var form = new frmStardusts();
            form.MdiParent = this;

            form.Show();
        }

        private void mnuGemCalculator_Click(object sender, EventArgs e)
        {
            var form = new frmGem();
            form.MdiParent = this;

            form.Show();
        }

        private void packDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmPacks();
            form.MdiParent = this;

            form.Show();
        }
    }
}
