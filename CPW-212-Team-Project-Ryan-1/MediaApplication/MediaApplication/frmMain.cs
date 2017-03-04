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

        /// <summary>
        /// Displays another form that allows the user to add their own media
        /// into the underlying database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd addForm = new frmAdd();
            addForm.ShowDialog();
         
        }

        /// <summary>
        /// Brings up an altered version of the search form that allows the user to 
        /// delete a selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmSearch searchbox = new frmSearch(txtName.Text);
            searchbox.Text = "Select Item to Remove"; //used the form from frmSearch and just renamed it 
            searchbox.ShowDialog(); //displays the list with movies and tv shows

        }

        /// <summary>
        /// Performs the delete operation once it has confirmation from the generated Messagebox
        /// on the selected member.
        /// </summary>
        /// <param name="selected">A string representation of the selected member on the previous search form</param>
        public void RemoveMedia(string selected)
        {

            //This uses an overload of MessageBox.Show that places Yes/No buttons on the box and returns a DialogResult which we use to
            //determine whether or not to preform the delete operation.
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

        /// <summary>
        /// Exits out of the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
