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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            using (var db = new MediaDBEntities())
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //MediaDBEntities db = new MediaDBEntities();

            //if (chkMovie.Checked)
            //{
            //    Movies movie = db.Movies.Find(MovieID);
            //    db.Movies.Add(movie);
            //    db.SaveChanges();
            //}
            //else if (chkTV.Checked)
            //{
            //    TVShows show = db.TVShows.Find(TVID);
            //    db.TVShows.Add(show);
            //    db.SaveChanges();
            //}
            //this.Close();

            using (var db = new MediaDBEntities())
            {

            }
        }
    }
}