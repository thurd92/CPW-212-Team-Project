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
    public partial class frmSearch : Form
    {
        string name = "";
        public frmSearch(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        public void frmSearch_Load(object sender, EventArgs e)
        {
            using (var db = new MediaDBEntities())
            {
                var grabAllMovies = from m in db.Movies
                                    select m;
                var grabAllTVShows = from t in db.TVShows
                                    select t; 
                if (name != "")
                {
                    grabAllMovies = from m in db.Movies
                                        where m.MovieName == name
                                        select m;
                    grabAllTVShows = from t in db.TVShows
                                         where t.TVName == name
                                         select t;
                }
               
                foreach (var movie in grabAllMovies)
                {
                    lstBoxMovieResults.Items.Add(movie.MovieName);   
                }

                foreach (var tv in grabAllTVShows)
                {
                    lstBoxTVResults.Items.Add(tv.TVName);
                }
            }
        }

        private void lstBoxMovieResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
