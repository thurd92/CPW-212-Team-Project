using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApplication
{
    class MediaDBHelper
    {
        public static void GetAllAwards()
        {
            MediaCatalogEntities db = new MediaCatalogEntities();
            var awardList = (from a in db.Awards
                                     select a );
        }
        public static void GetAllCast()
        {
            MediaCatalogEntities db = new MediaCatalogEntities();
            var castList = (from c in db.Casts
                             select c);
        }
        public static void GetAllTvShows()
        {
            MediaCatalogEntities db = new MediaCatalogEntities();
            var showsList = (from t in db.TvShows
                             select t);
        }
        public static void GetAllMovieInfo()
        {
            MediaCatalogEntities db = new MediaCatalogEntities();
            var info = (from i in db.MovieInfoes
                             select i);
        }
    }
}
