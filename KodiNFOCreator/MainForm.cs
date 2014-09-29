using LegeDoos.KodiNFOCreator.IMDb_Scraper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegeDoos.KodiNFOCreator
{
    public partial class MainForm : Form
    {
        Handler handler {get; set;}

        
        public MainForm()
        {
            InitializeComponent();
            handler = new Handler(autoCompleteTextBox, labelSourceFile, kodiNFOBindingSource, comboBoxScraper);
        }

        private void autoCompleteTextBox_StoppedTypingTextChanged(object sender, EventArgs e)
        {
            //do search with force
            handler.ExecuteSearch(true);
        }

        private void autoCompleteTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //do search on space
            handler.StartSearch();
            if (autoCompleteTextBox.Text.EndsWith(" "))
            {
                handler.ExecuteSearch(false);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.OpenFile();
        }

        private void createNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.CreateNFO();
        }

        private void buttonCreateNFO_Click(object sender, EventArgs e)
        {
            handler.CreateNFO();
        }

        private void buttonFindableCouchPotato_Click(object sender, EventArgs e)
        {
            handler.MakeFindableForCouchPotato();
        }

        private void makeFindableForCouchPotatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.MakeFindableForCouchPotato();
        }

        private void comboBoxScraper_SelectedValueChanged(object sender, EventArgs e)
        {
            if (handler != null)
                handler.SraperChanged();
        }

        private void autoCompleteTextBox_Enter(object sender, EventArgs e)
        {
            handler.StartSearch();
        }

        private void autoCompleteTextBox_Leave(object sender, EventArgs e)
        {
            handler.StopSearch();
        }
    }
}
