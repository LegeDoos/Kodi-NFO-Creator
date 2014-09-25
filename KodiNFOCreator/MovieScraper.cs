using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegeDoos.KodiNFOCreator
{
    public class IMDbItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }

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
        public string Plot { get; set; }
        public ArrayList PlotKeywords { get; set; }
        public string Poster { get; set; }
        public string PosterLarge { get; set; }
        public string PosterFull { get; set; }
        public string Runtime { get; set; }
        public string Top250 { get; set; }
        public string Oscars { get; set; }
        public string Awards { get; set; }
        public string Nominations { get; set; }
        public string Storyline { get; set; }
        public string Tagline { get; set; }
        public string Votes { get; set; }
        public ArrayList Languages { get; set; }
        public ArrayList Countries { get; set; }
        public ArrayList ReleaseDates { get; set; }
        public ArrayList MediaImages { get; set; }
        public ArrayList RecommendedTitles { get; set; }
        public string ImdbURL 
        {
            get 
            {
                return string.Format("http://www.imdb.com/title/{0}/", Id);
            } 
        }
        public string DisplayTitle
        {
            get
            {
                return string.Format("{0} ({1})", Title, Year);
            }
        }
 
        public IMDbItem(string IMDbId)
        {
            Id = IMDbId;
        }
    }

    abstract class MovieScraper
    {
        //helper members
        public enum LookupType { Simple, Normal, Extended }
        public Dictionary<string, IMDbItem> SearchResults { get; private set; } //display title, IMDbItem
        // AutoCompleteStringCollection SearchResultsAutoCompleteCollection { get; private set; }
        public string[] SearchResultsArray
        {
            get
            {
                return SearchResults.Keys.ToArray();
            }
        }
        

        #region.abstractMethods

        /// <summary>
        /// Search based on the part of the title and fill the SearchResult
        /// </summary>
        /// <param name="titlePart">Part of the title to search for</param>
        abstract public void SearchForTitlePart(string titlePart);
        
        #endregion

        #region.methods
        /// <summary>
        /// Clear the search results
        /// </summary>
        protected void InitSearchResults()
        {
            SearchResults = new Dictionary<string, IMDbItem>();
            //SearchResultsAutoCompleteCollection = new AutoCompleteStringCollection();

        }
        /// <summary>
        /// Add an item to the SearchResult
        /// </summary>
        /// <param name="displayTitle"></param>
        /// <param name="item"></param>
        protected void AddSearchResult(string displayTitle, IMDbItem item)
        {
            //todo: check of item al bestaat en meest recente item toevoegen (hoogste imdb id)
            //of opslaan imdbid / item
            SearchResults.Add(displayTitle, item);
            //SearchResultsAutoCompleteCollection.Add(displayTitle);
        }
        
        #endregion
    }

   }
