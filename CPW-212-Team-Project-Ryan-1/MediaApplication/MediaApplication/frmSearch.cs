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
        //by default, the name variable expects the user to leave the name textbox on the main form blank.
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
                //A general LINQ query that grabs all movies and tv shows.
                var grabAllMovies = from m in db.Movies
                                    select m;
                var grabAllTVShows = from t in db.TVShows
                                    select t; 
                if (name != "")
                {
                    //A specialized LINQ query that grabs tv shows and movies matching the contents of the name field.
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
    }
}
