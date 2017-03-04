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
                if (name != "")//comment
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
            //remove if possible
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check to see if movie or show was selected and deletes appropriately
            if (lstBoxMovieResults.SelectedIndex >= 0)
            {
                string selected = lstBoxMovieResults.SelectedItem.ToString();
                MediaApp r = new MediaApp(); //created an object of MediaApp in order to call the RemoveMedia() function            
                r.RemoveMedia(selected);
            }
            else if (lstBoxTVResults.SelectedIndex >= 0)
            {
                string selected = lstBoxTVResults.SelectedItem.ToString();
                MediaApp r = new MediaApp(); //created an object of MediaApp in order to call the RemoveMedia() function            
                r.RemoveMedia(selected);
            }


            //clears the lists
            lstBoxMovieResults.Items.Clear();
            lstBoxTVResults.Items.Clear();
            //reloads the list in the boxes to reflect the changes
            frmSearch_Load(sender, e);
        }
        public void HideDeleteButton()
        {
            btnDelete.Visible = false;
        }
    }
}
