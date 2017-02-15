using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
       
       
        private void chbxMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMovie.Checked)
            {

            }
        }

       
        public static List<Movies> GetAllMovies()
        {
            MediaDBEntities db = new MediaDBEntities();
            List<Movies> movies = (from mov in db.Movies
                                   select mov).ToList();
            return movies;
        }
        public static List<TVShows> GetAllTVShows()
        {
            MediaDBEntities db = new MediaDBEntities();
            List<TVShows> shows = (from sho in db.TVShows
                                   select sho).ToList();
            return shows;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MediaDBEntities db = new MediaDBEntities();

            if (chbxMovie.Checked)
            {
                Movies movie = new Movies(txtName.Text, txtGenre.Text);
                db.Movies.Add(movie);
                db.SaveChanges();             
            }
            else if (chbxTVShow.Checked)
            {
                TVShows show = new TVShows(txtName.Text, txtGenre.Text);
                db.TVShows.Add(show);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
