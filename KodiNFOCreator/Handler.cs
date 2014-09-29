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
        Movie NFO;
        MovieScraper MovieScraper;
        AutoCompleteTextBox formAutoCompleteTextBox;
        ComboBox formScraperSelectComboBox;
        Label sourceFileLabel;
        BindingSource theBindingSource;
        
        public enum ScraperTypes
        {
            OMDB,
            Searchengine
        }

        //public ScraperTypes SraperType { get; set; }

        private Boolean SearchingExecuting;

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
        private string targetFilenameNFO
        {
            get
            {
                return string.Format("{0}\\{1}.nfo", sourcePath, Path.GetFileNameWithoutExtension(sourceFull));
            }
        }

        #region.constructors
        
        public Handler(AutoCompleteTextBox AutoCompleteTextBox, Label SourceFileLabel, BindingSource BindingSourceNFO, ComboBox ScraperSelectCombo)
        {
            formAutoCompleteTextBox = AutoCompleteTextBox;
            sourceFileLabel = SourceFileLabel;
            theBindingSource = BindingSourceNFO;
            formScraperSelectComboBox = ScraperSelectCombo;
            formScraperSelectComboBox.DataSource = Enum.GetValues(typeof(ScraperTypes)).Cast<ScraperTypes>();
            formScraperSelectComboBox.SelectedItem = ScraperTypes.OMDB;
            InitMovieScraper();
        }

        #endregion

        #region.ui

        private void Initialize(string FileName)
        {
            NFO = new Movie(FileName);
            sourceFull = FileName;
            sourceFileLabel.Text = sourceFile;
            theBindingSource.DataSource = NFO;
        }

        public void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != null)
            {
                Initialize(dlg.FileName);
            }
        }

        internal void CreateNFO()
        {
            Boolean exportNFO;
            Boolean exportURL;
            Boolean success = true;

            string filename = "";

            if (sourceFile == null || sourceFile.Length == 0)
            {
                MessageBox.Show("No media file selected!");
                return;
            }

            exportNFO = NFO != null && NFO.title != null && NFO.title.Length > 0;
            exportURL = false;

            if (!exportNFO && !exportURL)
            {
                MessageBox.Show("You have to select a online title or enter a custom title to use the create NFO function.");
                return;
            }

            if (exportNFO)
            {
                //export nfo
                success = NFO.SaveNFO(targetFilenameNFO);
            }
            if (exportURL)
            {
                //add url
                success = success && AddURLToFile();
            }
            MessageBox.Show("NFO saved!");
        }

        private bool AddURLToFile()
        {
            Boolean retVal = false;
            Boolean fileExists = File.Exists(targetFilenameNFO);

            //append url
            File.AppendAllText(targetFilenameNFO, fileExists ? Environment.NewLine : "" + "http://www.google.com");
            retVal = true;
            return retVal;

        }

        internal void MakeFindableForCouchPotato()
        {
            throw new NotImplementedException();
        }

        internal void SraperChanged()
        {
            InitMovieScraper();
        }
        private void InitMovieScraper()
        {
            ScraperTypes type = (ScraperTypes)Enum.Parse(typeof(ScraperTypes), formScraperSelectComboBox.Text);

            switch (type)
            {
                case ScraperTypes.OMDB:
                    MovieScraper = new MovieScraperOMdb();
                    break;
                case ScraperTypes.Searchengine:
                    MovieScraper = new MovieScraperSearchEngine();
                    break;
                default:
                    //default to omdb
                    MovieScraper = new MovieScraperOMdb();
                    break;
            }

        }
        
        #endregion

        #region.search

        internal void DoSearch(string p)
        {
            if (!SearchingExecuting && MovieScraper != null && formAutoCompleteTextBox.IsSearching)
            {
                SearchingExecuting = true;
                if (p.ToLower() != formAutoCompleteTextBox.Text.ToLower())
                {
                    MovieScraper.SearchForTitlePart(p);
                    formAutoCompleteTextBox.Values = MovieScraper.SearchResultsArray;
                }
                SearchingExecuting = false;
            }   
        }

        internal void ExecuteSearch(bool force)
        {
            string searchString = formAutoCompleteTextBox.Text.Trim();

            if (searchString.Length > MinimumStringSize)
            {
                DoSearch(searchString);
            }
            else
            {
                formAutoCompleteTextBox.Values = null;
            }
        }

        internal void StartSearch()
        {
            formAutoCompleteTextBox.IsSearching = true;
        }

        internal void StopSearch()
        {
            formAutoCompleteTextBox.IsSearching = false;
        }

        #endregion




    }
}
