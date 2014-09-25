using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LegeDoos.KodiNFOCreator
{
    class Handler
    {
        Movie movie;
        MovieScraper MovieScraper;
        AutoCompleteTextBox theAutoCompleteTextBox;
        
        private Boolean Searching;

        private const int MinimumStringSize = 3;

        string sourceFull { get; set; }
        public string sourcePath
        {
            get 
            {
                return Path.GetDirectoryName(sourceFull);
            }
        }
        public string sourceFile
        {
            get
            {
                return Path.GetFileName(sourceFull);
            }
        }
        public string sourceExtension
        {
            get
            {
                return Path.GetExtension(sourceFull);
            }
        }

        public Handler(string _fileName)
        {
            movie = new Movie(_fileName);
            sourceFull = _fileName;
            MovieScraper = new MovieScraperOMdb();
        }

        internal void InitSearchTextBox(AutoCompleteTextBox textBox)
        {
            theAutoCompleteTextBox = textBox;
            //todo: delete
            //MovieScraper.SearchForTitlePart("green");
            //theAutoCompleteTextBox.Values = MovieScraper.SearchResultsArray;
            
        }

        internal void DoSearch(string p)
        {
            if (!Searching)
            {
                Searching = true;
                if (p.ToLower() != theAutoCompleteTextBox.Text.ToLower())
                {
                    MovieScraper.SearchForTitlePart(p);
                    theAutoCompleteTextBox.Values = MovieScraper.SearchResultsArray;
                }
                Searching = false;
            }   
        }

        internal void ExecuteSearch(bool force)
        {
            string searchString = theAutoCompleteTextBox.Text.Trim();

            if (searchString.Length > MinimumStringSize)
            {
                DoSearch(searchString);
            }
            else
            {
                theAutoCompleteTextBox.Values = null;
            }
        }
    }
}
