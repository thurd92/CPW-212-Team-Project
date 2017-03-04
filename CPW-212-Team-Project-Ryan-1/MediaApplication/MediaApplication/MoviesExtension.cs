using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApplication
{
    //We created this class to get around an issue with EF where our constructor
    //for Movies was changed due to an update we made in our database.
    partial class Movies
    {
        public Movies()
        {

        }
        public Movies(string name, string genre)
        {
            MovieName = name;
            MovieGenre = genre;
        }
    }
}
