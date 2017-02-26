using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MediaApplication
{
    public partial class MediaApp : Form
    {
        public MediaApp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchbox = new frmSearch(txtName.Text);
            searchbox.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd addForm = new frmAdd();
            addForm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmSearch searchbox = new frmSearch(txtName.Text);
            searchbox.ShowDialog();

            if(searchbox.lstBoxMovieResults.SelectedItem != null) // if (searchbox.lstBoxMovieResults.SelectedIndex >= 0) means they have chosen an index
            {
                string selected = searchbox.lstBoxMovieResults.SelectedItem.ToString();
                //create method to Remove movie from database
                //searchbox.lstBoxMovieResults.Items.Remove(selected); //this is does not remove the item from the database'
                RemoveMedia(selected);
            }
            else if (searchbox.lstBoxTVResults.SelectedIndex >= 0)
            {
                string selected = searchbox.lstBoxTVResults.SelectedItem.ToString(); //when the method is static we use the class to reference, but when is nonstatic and object of the class is needed
                RemoveMedia(selected);
            }

        }
        public void RemoveMedia(string selected)
        {
            using (var db = new MediaDBEntities())
            {
                var DeleteMovies = from Movies in db.Movies
                                   where Movies.MovieName == selected
                                   select Movies;

                var DeleteShows = from TVShows in db.TVShows
                                  where TVShows.TVName == selected
                                  select TVShows;

                foreach (var item in DeleteMovies)
                {
                    db.Movies.Remove(item);
                    
                }
                foreach (var item in DeleteShows)
                {
                    db.TVShows.Remove(item);
                }
                MessageBox.Show("Are you sure you want to delete this item?");
            }
        }
    }
}
