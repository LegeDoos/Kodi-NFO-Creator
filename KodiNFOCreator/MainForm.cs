﻿using LegeDoos.KodiNFOCreator.IMDb_Scraper;
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
            handler = new Handler(autoCompleteTextBox, labelSourceFile);
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

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handler.OpenFile();
        }


    }
}
