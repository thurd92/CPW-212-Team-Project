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

        /// <summary>
        /// The Load event of the form. Automatically selects items from the database
        /// based on what is entered in the search Textbox on the Main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void frmSearch_Load(object sender, EventArgs e)
        {
            using (var db = new MediaDBEntities())
            {
                var grabAllMovies = from m in db.Movies
                                    select m;
                var grabAllTVShows = from t in db.TVShows
                                   select t; 
                //This condition is true when the user leaves the search Textbox on the Main form empty
                //There may be a better way to implement this behavior that does not use strings.
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

        /// <summary>
        /// Uses the HideDeleteButton method's return value to change the behavior of the 
        /// search form to act as a selection of items to be possibly deleted from the database.
        /// Calls RemoveMedia on the Main form to actually preform the delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Returns whether or not the delete button should be visible on the Search form.
        /// </summary>
        public void HideDeleteButton()
        {
            btnDelete.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit editForm = new frmEdit();
            editForm.ShowDialog();
        }
    }
}
