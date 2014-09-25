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
        Handler handler;
        
        public MainForm()
        {
            InitializeComponent();
        }


        private void SourceDocsLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSrcDlg_Click(object sender, EventArgs e)
        {

        }

        private void SourceDocsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;

            //FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                handler = new Handler(dlg.FileName);
                handler.InitSearchTextBox(this.autoCompleteTextBox);
                labelSourceFile.Text = handler.sourceFile;
                
                //tmp
                
            }
        }

        
        private void autoCompleteTextBox_StoppedTypingTextChanged(object sender, EventArgs e)
        {
            //do search with force
            handler.ExecuteSearch(true);
        }

        private void autoCompleteTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //do search on space
            if (autoCompleteTextBox.Text.EndsWith(" "))
            {
                handler.ExecuteSearch(false);
            }
        }


    }
}
