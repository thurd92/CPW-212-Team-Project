using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApplication
{
    public partial class MediaApp : Form
    {
        public MediaApp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchbox = new frmSearch(txtName.Text);
            searchbox.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd addForm = new frmAdd();
            addForm.ShowDialog();
        }
    }
}
