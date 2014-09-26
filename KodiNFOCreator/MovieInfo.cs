using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegeDoos.KodiNFOCreator
{
    public class MovieInfo
    {
        //used
        public string Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public string Runtime { get; set; }
        public string Storyline { get; set; }
        
        public string Type { get; set; }

        //general
        public string DisplayTitle
        {
            get
            {
                return string.Format("{0} ({1})", Title, Year);
            }
        }
        public string ImdbURL
        {
            get
            {
                return string.Format("http://www.imdb.com/title/{0}/", Id);
            }
        }
        public string ScraperUrl { get; set; }

        //not used
        public bool status { get; set; }
        public string OriginalTitle { get; set; }
        public string Rating { get; set; }
        public ArrayList Genres { get; set; }
        public ArrayList Directors { get; set; }
        public ArrayList Writers { get; set; }
        public ArrayList Cast { get; set; }
        public ArrayList Producers { get; set; }
        public ArrayList Musicians { get; set; }
        public ArrayList Cinematographers { get; set; }
        public ArrayList Editors { get; set; }
        public string MpaaRating { get; set; }
        public string ReleaseDate { get; set; }
        public ArrayList PlotKeywords { get; set; }
        public string Poster { get; set; }
        public string PosterLarge { get; set; }
        public string PosterFull { get; set; }
        public string Top250 { get; set; }
        public string Oscars { get; set; }
        public string Awards { get; set; }
        public string Nominations { get; set; }
        public string Tagline { get; set; }
        public string Votes { get; set; }
        public ArrayList Languages { get; set; }
        public ArrayList Countries { get; set; }
        public ArrayList ReleaseDates { get; set; }
        public ArrayList MediaImages { get; set; }
        public ArrayList RecommendedTitles { get; set; }

        #region.constructors

        public MovieInfo(string IMDbId)
        {
            Id = IMDbId;
        }

        #endregion
    }

}
