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
            this.panelFileName = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.labelSourceFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelProperties = new System.Windows.Forms.Panel();
            this.autoCompleteTextBox = new LegeDoos.KodiNFOCreator.AutoCompleteTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFileName.SuspendLayout();
            this.panelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelFileName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelProperties, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelFileName
            // 
            this.panelFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFileName.Controls.Add(this.btnOpenFile);
            this.panelFileName.Controls.Add(this.labelSourceFile);
            this.panelFileName.Controls.Add(this.label1);
            this.panelFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileName.Location = new System.Drawing.Point(3, 3);
            this.panelFileName.Name = "panelFileName";
            this.panelFileName.Size = new System.Drawing.Size(437, 46);
            this.panelFileName.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(336, 10);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(75, 15);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(62, 13);
            this.labelSourceFile.TabIndex = 1;
            this.labelSourceFile.Text = "placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media file: ";
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.panelButtons.Location = new System.Drawing.Point(3, 471);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(437, 46);
            this.panelButtons.TabIndex = 1;
            // 
            // panelProperties
            // 
            this.panelProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProperties.Controls.Add(this.autoCompleteTextBox);
            this.panelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperties.Location = new System.Drawing.Point(3, 55);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.Size = new System.Drawing.Size(437, 410);
            this.panelProperties.TabIndex = 2;
            // 
            // autoCompleteTextBox
            // 
            this.autoCompleteTextBox.Location = new System.Drawing.Point(13, 316);
            this.autoCompleteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.autoCompleteTextBox.Name = "autoCompleteTextBox";
            this.autoCompleteTextBox.Size = new System.Drawing.Size(278, 20);
            this.autoCompleteTextBox.TabIndex = 3;
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
            this.panelFileName.ResumeLayout(false);
            this.panelFileName.PerformLayout();
            this.panelProperties.ResumeLayout(false);
            this.panelProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelProperties;
        private AutoCompleteTextBox autoCompleteTextBox;
    }
}