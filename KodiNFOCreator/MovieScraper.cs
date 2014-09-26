using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegeDoos.KodiNFOCreator
{

  
    abstract class MovieScraper
    {
        //helper members
        public enum LookupType { Simple, Normal, Extended }
        public Dictionary<string, MovieInfo> SearchResults { get; private set; } //display title, IMDbItem
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
            SearchResults = new Dictionary<string, MovieInfo>();
            //SearchResultsAutoCompleteCollection = new AutoCompleteStringCollection();

        }
        /// <summary>
        /// Add an item to the SearchResult
        /// </summary>
        /// <param name="displayTitle"></param>
        /// <param name="item"></param>
        protected void AddSearchResult(string displayTitle, MovieInfo item)
        {
            //todo: check of item al bestaat en meest recente item toevoegen (hoogste imdb id)
            //of opslaan imdbid / item
            SearchResults.Add(displayTitle, item);
            //SearchResultsAutoCompleteCollection.Add(displayTitle);
        }
        
        #endregion
    }

   }
