using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApplication
{
    //We created this class to get around an issue with EF where our constructor
    //for TVShows was changed due to an update we made in our database.
    partial class TVShows
    {
        public TVShows()
        {

        }
        public TVShows(string name, string genre)
        {
            TVName = name;
            TVGenre = genre;
        }
    }
}
