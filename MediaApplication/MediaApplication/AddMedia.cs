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
    public partial class AddMedia : Form
    {
        public AddMedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCast addCast = new AddCast();
            addCast.Show();
        }
    }
}
