using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApplication
{
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
