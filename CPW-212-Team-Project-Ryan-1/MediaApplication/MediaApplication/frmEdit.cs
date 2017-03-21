using MediaApplication;
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
        private string genre;
        private CastList cast;
        private Awards award;

        public frmEdit()
        {
            InitializeComponent();
        }

        public frmEdit(string name, string genre, CastList cast, Awards award)
        {
            chkMovie.Checked.Equals(true);
            txtEditName.Text = name;
            txtEditGenre.Text = genre;
            this.cast = cast;
            this.award = award;
        }

        public frmEdit(string name, string genre)
        {
            chkTV.Checked.Equals(true);
            txtEditName.Text = name;
            txtEditGenre.Text = genre;
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
            //    Movies movie = db.Movies.Find();
            //    db.Movies.Add(movie);
            //    db.SaveChanges();
            //}
            //else if (chkTV.Checked)
            //{
            //    TVShows show = db.TVShows.Find();
            //    db.TVShows.Add(show);
            //    db.SaveChanges();
            //}
            //this.Close();

            //if (chkMovie.Checked)
            //{
            //    using (var db = new MediaDBEntities())
            //    {
            //        var grabName = from m in db.Movies select m.MovieName;
            //    }
            //}
            //else if (chkTV.Checked)
            //{
            //    using (var db = new MediaDBEntities())
            //    {
            //        var grabName = from t in db.TVShows select t.TVName;
            //    }
            //}
        }
    }
}