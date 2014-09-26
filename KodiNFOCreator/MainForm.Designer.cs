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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
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
            this.comboBoxScraper = new System.Windows.Forms.ComboBox();
            this.labelFindOnline = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelCustom = new System.Windows.Forms.Label();
            this.autoCompleteTextBox = new LegeDoos.KodiNFOCreator.AutoCompleteTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFileName.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.labelCustom);
            this.panelMain.Controls.Add(this.comboBoxScraper);
            this.panelMain.Controls.Add(this.linkLabel1);
            this.panelMain.Controls.Add(this.autoCompleteTextBox);
            this.panelMain.Controls.Add(this.labelFindOnline);
            this.panelMain.Controls.Add(this.labelUrl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 73);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(437, 444);
            this.panelMain.TabIndex = 2;
            // 
            // panelFileName
            // 
            this.panelFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFileName.Controls.Add(this.labelSourceFile);
            this.panelFileName.Controls.Add(this.labelMediaFile);
            this.panelFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileName.Location = new System.Drawing.Point(3, 38);
            this.panelFileName.Name = "panelFileName";
            this.panelFileName.Size = new System.Drawing.Size(437, 29);
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
            this.menuStrip1.Size = new System.Drawing.Size(443, 35);
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
            // 
            // makeFindableForCouchPotatoToolStripMenuItem
            // 
            this.makeFindableForCouchPotatoToolStripMenuItem.Name = "makeFindableForCouchPotatoToolStripMenuItem";
            this.makeFindableForCouchPotatoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.makeFindableForCouchPotatoToolStripMenuItem.Text = "Make findable for &CouchPotato";
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
            // comboBoxScraper
            // 
            this.comboBoxScraper.FormattingEnabled = true;
            this.comboBoxScraper.Location = new System.Drawing.Point(11, 27);
            this.comboBoxScraper.Name = "comboBoxScraper";
            this.comboBoxScraper.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScraper.TabIndex = 4;
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
            // labelCustom
            // 
            this.labelCustom.AutoSize = true;
            this.labelCustom.Location = new System.Drawing.Point(8, 85);
            this.labelCustom.Name = "labelCustom";
            this.labelCustom.Size = new System.Drawing.Size(91, 13);
            this.labelCustom.TabIndex = 8;
            this.labelCustom.Text = "Custom properties";
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
            this.ClientSize = new System.Drawing.Size(443, 520);
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
    }
}