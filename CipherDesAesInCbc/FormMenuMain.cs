using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherDesAesInCbc
{
    public partial class FormMenuMain : Form
    {
        public FormMenuMain()
        {
            InitializeComponent();
        }

        private void aESCBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAesCbc form = new FormAesCbc();
            form.MdiParent = this;
            form.Show();
        }

        private void dESCBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesCbc form = new FormDesCbc();
            form.MdiParent = this;
            form.Show();
        }
    }
}
