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
       
        /// <summary>
        /// Queries the database for a list of all movies.
        /// </summary>
        /// <returns>A List of movies to be used in other operations</returns>
        public static List<Movies> GetAllMovies()
        {
            MediaDBEntities db = new MediaDBEntities();
            List<Movies> movies = (from mov in db.Movies
                                   select mov).ToList();
            return movies;
        }
        
        /// <summary>
        /// Queries the database for a list of all TV shows.
        /// </summary>
        /// <returns>A List of all TV shows to be used in other operations</returns>
        public static List<TVShows> GetAllTVShows()
        {
            MediaDBEntities db = new MediaDBEntities();
            List<TVShows> shows = (from sho in db.TVShows
                                   select sho).ToList();
            return shows;
        }

        /// <summary>
        /// Adds media to the database depending on which checkbox is checked on the
        /// Add form and closes the connection after.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSave_Click(object sender, EventArgs e)
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
