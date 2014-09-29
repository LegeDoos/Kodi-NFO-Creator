namespace LegeDoos.KodiNFOCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonFindableCouchPotato = new System.Windows.Forms.Button();
            this.buttonCreateNFO = new System.Windows.Forms.Button();
            this.textBoxRuntime = new System.Windows.Forms.TextBox();
            this.labelCustomRuntime = new System.Windows.Forms.Label();
            this.textBoxPlot = new System.Windows.Forms.TextBox();
            this.labelCustomPlot = new System.Windows.Forms.Label();
            this.textBoxOutline = new System.Windows.Forms.TextBox();
            this.labelCustomOutline = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelCustomYear = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelCustomTitle = new System.Windows.Forms.Label();
            this.labelCustom = new System.Windows.Forms.Label();
            this.comboBoxScraper = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelFindOnline = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.panelFileName = new System.Windows.Forms.Panel();
            this.labelSourceFile = new System.Windows.Forms.Label();
            this.labelMediaFile = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeFindableForCouchPotatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kodiNFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoCompleteTextBox = new LegeDoos.KodiNFOCreator.AutoCompleteTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFileName.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kodiNFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelMain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelFileName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.buttonFindableCouchPotato);
            this.panelMain.Controls.Add(this.buttonCreateNFO);
            this.panelMain.Controls.Add(this.textBoxRuntime);
            this.panelMain.Controls.Add(this.labelCustomRuntime);
            this.panelMain.Controls.Add(this.textBoxPlot);
            this.panelMain.Controls.Add(this.labelCustomPlot);
            this.panelMain.Controls.Add(this.textBoxOutline);
            this.panelMain.Controls.Add(this.labelCustomOutline);
            this.panelMain.Controls.Add(this.textBoxYear);
            this.panelMain.Controls.Add(this.labelCustomYear);
            this.panelMain.Controls.Add(this.textBoxTitle);
            this.panelMain.Controls.Add(this.labelCustomTitle);
            this.panelMain.Controls.Add(this.labelCustom);
            this.panelMain.Controls.Add(this.comboBoxScraper);
            this.panelMain.Controls.Add(this.linkLabel1);
            this.panelMain.Controls.Add(this.autoCompleteTextBox);
            this.panelMain.Controls.Add(this.labelFindOnline);
            this.panelMain.Controls.Add(this.labelUrl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 83);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(431, 354);
            this.panelMain.TabIndex = 2;
            // 
            // buttonFindableCouchPotato
            // 
            this.buttonFindableCouchPotato.Location = new System.Drawing.Point(249, 321);
            this.buttonFindableCouchPotato.Name = "buttonFindableCouchPotato";
            this.buttonFindableCouchPotato.Size = new System.Drawing.Size(85, 23);
            this.buttonFindableCouchPotato.TabIndex = 20;
            this.buttonFindableCouchPotato.Text = "Make findable";
            this.buttonFindableCouchPotato.UseVisualStyleBackColor = true;
            this.buttonFindableCouchPotato.Click += new System.EventHandler(this.buttonFindableCouchPotato_Click);
            // 
            // buttonCreateNFO
            // 
            this.buttonCreateNFO.Location = new System.Drawing.Point(340, 321);
            this.buttonCreateNFO.Name = "buttonCreateNFO";
            this.buttonCreateNFO.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateNFO.TabIndex = 19;
            this.buttonCreateNFO.Text = "Create NFO";
            this.buttonCreateNFO.UseVisualStyleBackColor = true;
            this.buttonCreateNFO.Click += new System.EventHandler(this.buttonCreateNFO_Click);
            // 
            // textBoxRuntime
            // 
            this.textBoxRuntime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodiNFOBindingSource, "runtime", true));
            this.textBoxRuntime.Location = new System.Drawing.Point(262, 144);
            this.textBoxRuntime.Name = "textBoxRuntime";
            this.textBoxRuntime.Size = new System.Drawing.Size(88, 20);
            this.textBoxRuntime.TabIndex = 18;
            // 
            // labelCustomRuntime
            // 
            this.labelCustomRuntime.AutoSize = true;
            this.labelCustomRuntime.Location = new System.Drawing.Point(165, 147);
            this.labelCustomRuntime.Name = "labelCustomRuntime";
            this.labelCustomRuntime.Size = new System.Drawing.Size(91, 13);
            this.labelCustomRuntime.TabIndex = 17;
            this.labelCustomRuntime.Text = "Runtime (minutes)";
            // 
            // textBoxPlot
            // 
            this.textBoxPlot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodiNFOBindingSource, "plot", true));
            this.textBoxPlot.Location = new System.Drawing.Point(77, 170);
            this.textBoxPlot.Multiline = true;
            this.textBoxPlot.Name = "textBoxPlot";
            this.textBoxPlot.Size = new System.Drawing.Size(338, 66);
            this.textBoxPlot.TabIndex = 16;
            // 
            // labelCustomPlot
            // 
            this.labelCustomPlot.AutoSize = true;
            this.labelCustomPlot.Location = new System.Drawing.Point(8, 173);
            this.labelCustomPlot.Name = "labelCustomPlot";
            this.labelCustomPlot.Size = new System.Drawing.Size(25, 13);
            this.labelCustomPlot.TabIndex = 15;
            this.labelCustomPlot.Text = "Plot";
            // 
            // textBoxOutline
            // 
            this.textBoxOutline.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodiNFOBindingSource, "outline", true));
            this.textBoxOutline.Location = new System.Drawing.Point(77, 242);
            this.textBoxOutline.Multiline = true;
            this.textBoxOutline.Name = "textBoxOutline";
            this.textBoxOutline.Size = new System.Drawing.Size(338, 62);
            this.textBoxOutline.TabIndex = 14;
            // 
            // labelCustomOutline
            // 
            this.labelCustomOutline.AutoSize = true;
            this.labelCustomOutline.Location = new System.Drawing.Point(8, 245);
            this.labelCustomOutline.Name = "labelCustomOutline";
            this.labelCustomOutline.Size = new System.Drawing.Size(40, 13);
            this.labelCustomOutline.TabIndex = 13;
            this.labelCustomOutline.Text = "Outline";
            // 
            // textBoxYear
            // 
            this.textBoxYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodiNFOBindingSource, "year", true));
            this.textBoxYear.Location = new System.Drawing.Point(77, 144);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(75, 20);
            this.textBoxYear.TabIndex = 12;
            // 
            // labelCustomYear
            // 
            this.labelCustomYear.AutoSize = true;
            this.labelCustomYear.Location = new System.Drawing.Point(8, 147);
            this.labelCustomYear.Name = "labelCustomYear";
            this.labelCustomYear.Size = new System.Drawing.Size(29, 13);
            this.labelCustomYear.TabIndex = 11;
            this.labelCustomYear.Text = "Year";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodiNFOBindingSource, "title", true));
            this.textBoxTitle.Location = new System.Drawing.Point(77, 108);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(338, 20);
            this.textBoxTitle.TabIndex = 10;
            // 
            // labelCustomTitle
            // 
            this.labelCustomTitle.AutoSize = true;
            this.labelCustomTitle.Location = new System.Drawing.Point(8, 111);
            this.labelCustomTitle.Name = "labelCustomTitle";
            this.labelCustomTitle.Size = new System.Drawing.Size(27, 13);
            this.labelCustomTitle.TabIndex = 9;
            this.labelCustomTitle.Text = "Title";
            // 
            // labelCustom
            // 
            this.labelCustom.AutoSize = true;
            this.labelCustom.Location = new System.Drawing.Point(8, 85);
            this.labelCustom.Name = "labelCustom";
            this.labelCustom.Size = new System.Drawing.Size(91, 13);
            this.labelCustom.TabIndex = 8;
            this.labelCustom.Text = "Custom properties";
            // 
            // comboBoxScraper
            // 
            this.comboBoxScraper.FormattingEnabled = true;
            this.comboBoxScraper.Location = new System.Drawing.Point(11, 27);
            this.comboBoxScraper.Name = "comboBoxScraper";
            this.comboBoxScraper.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScraper.TabIndex = 4;
            this.comboBoxScraper.SelectedValueChanged += new System.EventHandler(this.comboBoxScraper_SelectedValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(180, 49);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.google.com";
            // 
            // labelFindOnline
            // 
            this.labelFindOnline.AutoSize = true;
            this.labelFindOnline.Location = new System.Drawing.Point(8, 11);
            this.labelFindOnline.Name = "labelFindOnline";
            this.labelFindOnline.Size = new System.Drawing.Size(89, 13);
            this.labelFindOnline.TabIndex = 5;
            this.labelFindOnline.Text = "Find movie online";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(139, 49);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(32, 13);
            this.labelUrl.TabIndex = 6;
            this.labelUrl.Text = "URL:";
            // 
            // panelFileName
            // 
            this.panelFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFileName.Controls.Add(this.labelSourceFile);
            this.panelFileName.Controls.Add(this.labelMediaFile);
            this.panelFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileName.Location = new System.Drawing.Point(3, 38);
            this.panelFileName.Name = "panelFileName";
            this.panelFileName.Size = new System.Drawing.Size(431, 39);
            this.panelFileName.TabIndex = 0;
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(70, 10);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(0, 13);
            this.labelSourceFile.TabIndex = 1;
            // 
            // labelMediaFile
            // 
            this.labelMediaFile.AutoSize = true;
            this.labelMediaFile.Location = new System.Drawing.Point(8, 10);
            this.labelMediaFile.Name = "labelMediaFile";
            this.labelMediaFile.Size = new System.Drawing.Size(58, 13);
            this.labelMediaFile.TabIndex = 0;
            this.labelMediaFile.Text = "Media file: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.actionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 31);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openFileToolStripMenuItem.Text = "&Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNFOToolStripMenuItem,
            this.makeFindableForCouchPotatoToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 31);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // createNFOToolStripMenuItem
            // 
            this.createNFOToolStripMenuItem.Name = "createNFOToolStripMenuItem";
            this.createNFOToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.createNFOToolStripMenuItem.Text = "Create &NFO";
            this.createNFOToolStripMenuItem.Click += new System.EventHandler(this.createNFOToolStripMenuItem_Click);
            // 
            // makeFindableForCouchPotatoToolStripMenuItem
            // 
            this.makeFindableForCouchPotatoToolStripMenuItem.Name = "makeFindableForCouchPotatoToolStripMenuItem";
            this.makeFindableForCouchPotatoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.makeFindableForCouchPotatoToolStripMenuItem.Text = "Make findable for &CouchPotato";
            this.makeFindableForCouchPotatoToolStripMenuItem.Click += new System.EventHandler(this.makeFindableForCouchPotatoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 31);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for &Updates";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // kodiNFOBindingSource
            // 
            this.kodiNFOBindingSource.DataSource = typeof(LegeDoos.KodiNFOCreator.Movie);
            // 
            // handlerBindingSource
            // 
            this.handlerBindingSource.DataSource = typeof(LegeDoos.KodiNFOCreator.Handler);
            // 
            // autoCompleteTextBox
            // 
            this.autoCompleteTextBox.AcceptsReturn = true;
            this.autoCompleteTextBox.AcceptsTab = true;
            this.autoCompleteTextBox.Location = new System.Drawing.Point(139, 27);
            this.autoCompleteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.autoCompleteTextBox.MinimumSize = new System.Drawing.Size(4, 21);
            this.autoCompleteTextBox.Name = "autoCompleteTextBox";
            this.autoCompleteTextBox.Size = new System.Drawing.Size(276, 20);
            this.autoCompleteTextBox.TabIndex = 3;
            this.autoCompleteTextBox.Text = "Enter search title";
            this.autoCompleteTextBox.Values = null;
            this.autoCompleteTextBox.StoppedTypingTextChanged += new System.EventHandler(this.autoCompleteTextBox_StoppedTypingTextChanged);
            this.autoCompleteTextBox.TextChanged += new System.EventHandler(this.autoCompleteTextBox_TextChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Kodi NFO Creator by LegeDoos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFileName.ResumeLayout(false);
            this.panelFileName.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kodiNFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFileName;
        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.Label labelMediaFile;
        private System.Windows.Forms.Panel panelMain;
        private AutoCompleteTextBox autoCompleteTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeFindableForCouchPotatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelFindOnline;
        private System.Windows.Forms.ComboBox comboBoxScraper;
        private System.Windows.Forms.Label labelCustom;
        private System.Windows.Forms.TextBox textBoxPlot;
        private System.Windows.Forms.Label labelCustomPlot;
        private System.Windows.Forms.TextBox textBoxOutline;
        private System.Windows.Forms.Label labelCustomOutline;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelCustomYear;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelCustomTitle;
        private System.Windows.Forms.BindingSource kodiNFOBindingSource;
        private System.Windows.Forms.TextBox textBoxRuntime;
        private System.Windows.Forms.Label labelCustomRuntime;
        private System.Windows.Forms.Button buttonCreateNFO;
        private System.Windows.Forms.Button buttonFindableCouchPotato;
        private System.Windows.Forms.BindingSource handlerBindingSource;
    }
}