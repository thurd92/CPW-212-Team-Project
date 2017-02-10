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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        private Movies movie = null;
        private TVShows show = null;
        private void chbxMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMovie.Checked)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chbxMovie.Checked)
            {
                movie = new Movies(txtName.Text, txtGenre.Text);
            }
            else if (chbxTVShow.Checked)
            {
                show = new TVShows(txtName.Text, txtGenre.Text);
            }
            this.Close();
        }
    }
}
