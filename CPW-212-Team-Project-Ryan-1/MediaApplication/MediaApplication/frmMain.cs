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

        /// <summary>
        /// Displays the box with the list of all the movies and tv shows in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchbox = new frmSearch(txtName.Text);
            searchbox.HideDeleteButton(); //hides the button
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
            searchbox.Text = "Select Item to Remove"; //used the form from frmSearch and just renamed it 
            searchbox.ShowDialog(); //displays the list with movies and tv shows


            ///////MOVE THIS CODE TO THE btnDelete_Click in frmSearch.cs/////
            //if(searchbox.lstBoxMovieResults.SelectedItem != null) // if (searchbox.lstBoxMovieResults.SelectedIndex >= 0) means they have chosen an index
            //{
            //    string selected = searchbox.lstBoxMovieResults.SelectedItem.ToString();
            //    //create method to Remove movie from database
            //    //searchbox.lstBoxMovieResults.Items.Remove(selected); //this is does not remove the item from the database'
            //    RemoveMedia(selected);
            //}
            //else if (searchbox.lstBoxTVResults.SelectedIndex >= 0)
            //{
            //    string selected = searchbox.lstBoxTVResults.SelectedItem.ToString(); //when the method is static we use the class to reference, but when is nonstatic and object of the class is needed
            //    RemoveMedia(selected);
            //}

        }
        public void RemoveMedia(string selected)
        {
            
            DialogResult selection = MessageBox.Show("Are you sure you want to delete this item?", "Warning!", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);//asks user if they are sure they want to remove an item

            if (selection == DialogResult.Yes)
            {
                using (var db = new MediaDBEntities())
                {
                    var DeleteMovies = (from Movies in db.Movies
                                        where Movies.MovieName == selected
                                        select Movies).ToList();

                    var DeleteShows = (from TVShows in db.TVShows
                                       where TVShows.TVName == selected
                                       select TVShows).ToList();

                    foreach (Movies item in DeleteMovies)
                    {
                        db.Movies.Remove(item);//perhaps will delete duplicates movies of different years

                    }
                    foreach (TVShows item in DeleteShows)
                    {
                        db.TVShows.Remove(item);
                    }

                    db.SaveChanges();
                }
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
