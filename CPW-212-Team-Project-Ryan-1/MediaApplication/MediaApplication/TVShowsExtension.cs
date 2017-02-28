using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApplication
{
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
