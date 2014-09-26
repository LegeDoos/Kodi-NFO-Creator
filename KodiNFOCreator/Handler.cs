using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LegeDoos.KodiNFOCreator
{
    class Handler
    {
        KodiNFO movie;
        MovieScraper MovieScraper;
        AutoCompleteTextBox theAutoCompleteTextBox;
        Label sourceFileLabel;

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

        #region.constructors
        
        public Handler(AutoCompleteTextBox AutoCompleteTextBox, Label SourceFileLabel)
        {
            theAutoCompleteTextBox = AutoCompleteTextBox;
            sourceFileLabel = SourceFileLabel;
            MovieScraper = new MovieScraperOMdb();
        }

        #endregion

        #region.ui

        public void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != null)
            {
                Initialize(dlg.FileName);
            }
        }

        private void Initialize(string FileName)
        {
            movie = new KodiNFO(FileName);
            sourceFull = FileName;
            sourceFileLabel.Text = sourceFile;
        }

        #endregion


        internal void DoSearch(string p)
        {
            if (!Searching && MovieScraper != null)
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
