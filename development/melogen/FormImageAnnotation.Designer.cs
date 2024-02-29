namespace melogen
{
    partial class FormImageAnnotation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageAnnotation));
            pictureBoxCurrentImage = new PictureBox();
            flowLayoutPanelTags = new FlowLayoutPanel();
            labelFiles = new Label();
            listBoxTagsSelected = new ListBox();
            buttonSetTags = new Button();
            buttonSkip = new Button();
            labelFilename = new Label();
            labelTagsApplied = new Label();
            buttonWrite = new Button();
            listBoxAuthor = new ListBox();
            panel1 = new Panel();
            labelTagHeader = new Label();
            labelAuthorHeader = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            listBoxAuthorsSelected = new ListBox();
            labelAuthorsAttached = new Label();
            labelTagsAttached = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            skipFileToolStripMenuItem = new ToolStripMenuItem();
            setTagsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            writeTaggedFilesToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            clearAllTagsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            addCustomTagToolStripMenuItem = new ToolStripMenuItem();
            addCustomAuthorToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCurrentImage
            // 
            pictureBoxCurrentImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxCurrentImage.BackColor = Color.Transparent;
            pictureBoxCurrentImage.Location = new Point(13, 51);
            pictureBoxCurrentImage.Name = "pictureBoxCurrentImage";
            pictureBoxCurrentImage.Size = new Size(623, 387);
            pictureBoxCurrentImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCurrentImage.TabIndex = 0;
            pictureBoxCurrentImage.TabStop = false;
            pictureBoxCurrentImage.WaitOnLoad = true;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.BackColor = Color.Transparent;
            flowLayoutPanelTags.Location = new Point(13, 38);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(203, 359);
            flowLayoutPanelTags.TabIndex = 1;
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.BackColor = Color.Transparent;
            labelFiles.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFiles.ForeColor = Color.Black;
            labelFiles.Location = new Point(23, 13);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(46, 23);
            labelFiles.TabIndex = 2;
            labelFiles.Text = "0 / 0";
            // 
            // listBoxTagsSelected
            // 
            listBoxTagsSelected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listBoxTagsSelected.BorderStyle = BorderStyle.None;
            listBoxTagsSelected.Enabled = false;
            listBoxTagsSelected.ForeColor = Color.Black;
            listBoxTagsSelected.FormattingEnabled = true;
            listBoxTagsSelected.ItemHeight = 15;
            listBoxTagsSelected.Location = new Point(19, 71);
            listBoxTagsSelected.MultiColumn = true;
            listBoxTagsSelected.Name = "listBoxTagsSelected";
            listBoxTagsSelected.SelectionMode = SelectionMode.None;
            listBoxTagsSelected.Size = new Size(113, 255);
            listBoxTagsSelected.TabIndex = 3;
            // 
            // buttonSetTags
            // 
            buttonSetTags.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSetTags.Location = new Point(331, 6);
            buttonSetTags.Name = "buttonSetTags";
            buttonSetTags.Size = new Size(268, 45);
            buttonSetTags.TabIndex = 4;
            buttonSetTags.Text = "Set Tags";
            buttonSetTags.UseVisualStyleBackColor = false;
            buttonSetTags.Click += buttonSetTags_Click;
            // 
            // buttonSkip
            // 
            buttonSkip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSkip.Location = new Point(50, 6);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(268, 45);
            buttonSkip.TabIndex = 5;
            buttonSkip.Text = "Skip";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // labelFilename
            // 
            labelFilename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFilename.BackColor = Color.Transparent;
            labelFilename.FlatStyle = FlatStyle.Popup;
            labelFilename.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilename.ForeColor = Color.Black;
            labelFilename.Location = new Point(132, 11);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new Size(504, 29);
            labelFilename.TabIndex = 6;
            labelFilename.Text = "Filename";
            labelFilename.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTagsApplied
            // 
            labelTagsApplied.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTagsApplied.AutoSize = true;
            labelTagsApplied.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTagsApplied.Location = new Point(6, 11);
            labelTagsApplied.Name = "labelTagsApplied";
            labelTagsApplied.Size = new Size(130, 23);
            labelTagsApplied.TabIndex = 7;
            labelTagsApplied.Text = "Applied data";
            // 
            // buttonWrite
            // 
            buttonWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonWrite.Location = new Point(19, 514);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(113, 47);
            buttonWrite.TabIndex = 8;
            buttonWrite.Text = "Write Output";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // listBoxAuthor
            // 
            listBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxAuthor.FormattingEnabled = true;
            listBoxAuthor.ItemHeight = 15;
            listBoxAuthor.Items.AddRange(new object[] { "unknown" });
            listBoxAuthor.Location = new Point(13, 36);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(195, 109);
            listBoxAuthor.TabIndex = 9;
            listBoxAuthor.MouseDoubleClick += listBoxAuthor_MouseDoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(pictureBoxCurrentImage);
            panel1.Location = new Point(220, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 454);
            panel1.TabIndex = 10;
            // 
            // labelTagHeader
            // 
            labelTagHeader.AutoSize = true;
            labelTagHeader.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTagHeader.Location = new Point(13, 11);
            labelTagHeader.Name = "labelTagHeader";
            labelTagHeader.Size = new Size(53, 23);
            labelTagHeader.TabIndex = 11;
            labelTagHeader.Text = "Tags";
            // 
            // labelAuthorHeader
            // 
            labelAuthorHeader.AutoSize = true;
            labelAuthorHeader.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAuthorHeader.Location = new Point(13, 10);
            labelAuthorHeader.Name = "labelAuthorHeader";
            labelAuthorHeader.Size = new Size(84, 23);
            labelAuthorHeader.TabIndex = 12;
            labelAuthorHeader.Text = "Authors";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            splitContainer1.BackColor = Color.SlateGray;
            splitContainer1.Location = new Point(0, 31);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel1.Controls.Add(labelTagHeader);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanelTags);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gainsboro;
            splitContainer1.Panel2.Controls.Add(labelAuthorHeader);
            splitContainer1.Panel2.Controls.Add(listBoxAuthor);
            splitContainer1.Panel2MinSize = 120;
            splitContainer1.Size = new Size(220, 577);
            splitContainer1.SplitterDistance = 409;
            splitContainer1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(labelFilename);
            panel2.Controls.Add(labelFiles);
            panel2.Location = new Point(220, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 50);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(buttonSkip);
            panel3.Controls.Add(buttonSetTags);
            panel3.Location = new Point(220, 550);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 58);
            panel3.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.LightBlue;
            panel4.Controls.Add(listBoxAuthorsSelected);
            panel4.Controls.Add(labelAuthorsAttached);
            panel4.Controls.Add(labelTagsAttached);
            panel4.Controls.Add(labelTagsApplied);
            panel4.Controls.Add(listBoxTagsSelected);
            panel4.Controls.Add(buttonWrite);
            panel4.Location = new Point(870, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 568);
            panel4.TabIndex = 17;
            // 
            // listBoxAuthorsSelected
            // 
            listBoxAuthorsSelected.Anchor = AnchorStyles.Bottom;
            listBoxAuthorsSelected.BorderStyle = BorderStyle.None;
            listBoxAuthorsSelected.Enabled = false;
            listBoxAuthorsSelected.ForeColor = Color.Black;
            listBoxAuthorsSelected.FormattingEnabled = true;
            listBoxAuthorsSelected.ItemHeight = 15;
            listBoxAuthorsSelected.Items.AddRange(new object[] { "unknown" });
            listBoxAuthorsSelected.Location = new Point(19, 375);
            listBoxAuthorsSelected.MultiColumn = true;
            listBoxAuthorsSelected.Name = "listBoxAuthorsSelected";
            listBoxAuthorsSelected.SelectionMode = SelectionMode.None;
            listBoxAuthorsSelected.Size = new Size(113, 120);
            listBoxAuthorsSelected.TabIndex = 11;
            // 
            // labelAuthorsAttached
            // 
            labelAuthorsAttached.Anchor = AnchorStyles.Bottom;
            labelAuthorsAttached.AutoSize = true;
            labelAuthorsAttached.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAuthorsAttached.Location = new Point(6, 354);
            labelAuthorsAttached.Name = "labelAuthorsAttached";
            labelAuthorsAttached.Size = new Size(71, 18);
            labelAuthorsAttached.TabIndex = 10;
            labelAuthorsAttached.Text = "Authors";
            // 
            // labelTagsAttached
            // 
            labelTagsAttached.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTagsAttached.AutoSize = true;
            labelTagsAttached.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTagsAttached.Location = new Point(6, 50);
            labelTagsAttached.Name = "labelTagsAttached";
            labelTagsAttached.Size = new Size(45, 18);
            labelTagsAttached.TabIndex = 9;
            labelTagsAttached.Text = "Tags";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { skipFileToolStripMenuItem, setTagsToolStripMenuItem, toolStripMenuItem1, writeTaggedFilesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // skipFileToolStripMenuItem
            // 
            skipFileToolStripMenuItem.Name = "skipFileToolStripMenuItem";
            skipFileToolStripMenuItem.Size = new Size(180, 22);
            skipFileToolStripMenuItem.Text = "&Skip File";
            skipFileToolStripMenuItem.Click += skipFileToolStripMenuItem_Click;
            // 
            // setTagsToolStripMenuItem
            // 
            setTagsToolStripMenuItem.Name = "setTagsToolStripMenuItem";
            setTagsToolStripMenuItem.Size = new Size(180, 22);
            setTagsToolStripMenuItem.Text = "Set &Tags";
            setTagsToolStripMenuItem.Click += setTagsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // writeTaggedFilesToolStripMenuItem
            // 
            writeTaggedFilesToolStripMenuItem.Name = "writeTaggedFilesToolStripMenuItem";
            writeTaggedFilesToolStripMenuItem.Size = new Size(180, 22);
            writeTaggedFilesToolStripMenuItem.Text = "&Write Log";
            writeTaggedFilesToolStripMenuItem.Click += writeTaggedFilesToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearAllTagsToolStripMenuItem, toolStripMenuItem2, addCustomTagToolStripMenuItem, addCustomAuthorToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // clearAllTagsToolStripMenuItem
            // 
            clearAllTagsToolStripMenuItem.Name = "clearAllTagsToolStripMenuItem";
            clearAllTagsToolStripMenuItem.Size = new Size(181, 22);
            clearAllTagsToolStripMenuItem.Text = "&Clear All Tags";
            clearAllTagsToolStripMenuItem.Click += clearAllTagsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(178, 6);
            // 
            // addCustomTagToolStripMenuItem
            // 
            addCustomTagToolStripMenuItem.Name = "addCustomTagToolStripMenuItem";
            addCustomTagToolStripMenuItem.Size = new Size(181, 22);
            addCustomTagToolStripMenuItem.Text = "Add Custom &Tag";
            addCustomTagToolStripMenuItem.Click += addCustomTagToolStripMenuItem_Click;
            // 
            // addCustomAuthorToolStripMenuItem
            // 
            addCustomAuthorToolStripMenuItem.Name = "addCustomAuthorToolStripMenuItem";
            addCustomAuthorToolStripMenuItem.Size = new Size(181, 22);
            addCustomAuthorToolStripMenuItem.Text = "Add Custom &Author";
            addCustomAuthorToolStripMenuItem.Click += addCustomAuthorToolStripMenuItem_Click;
            // 
            // FormImageAnnotation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 608);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1030, 647);
            Name = "FormImageAnnotation";
            Text = "Melogen - Annotate Media";
            FormClosing += FormImageAnnotation_FormClosing;
            Load += FormImageAnnotation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentImage).EndInit();
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCurrentImage;
        private FlowLayoutPanel flowLayoutPanelTags;
        private Label labelFiles;
        private ListBox listBoxTagsSelected;
        private Button buttonSetTags;
        private Button buttonSkip;
        private Label labelFilename;
        private Label labelTagsApplied;
        private Button buttonWrite;
        private ListBox listBoxAuthor;
        private Panel panel1;
        private Label labelTagHeader;
        private Label labelAuthorHeader;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ListBox listBoxAuthorsSelected;
        private Label labelAuthorsAttached;
        private Label labelTagsAttached;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem skipFileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem setTagsToolStripMenuItem;
        private ToolStripMenuItem writeTaggedFilesToolStripMenuItem;
        private ToolStripMenuItem clearAllTagsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem addCustomTagToolStripMenuItem;
        private ToolStripMenuItem addCustomAuthorToolStripMenuItem;
    }
}