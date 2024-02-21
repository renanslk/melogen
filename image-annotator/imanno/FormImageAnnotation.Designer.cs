namespace imanno
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCurrentImage
            // 
            pictureBoxCurrentImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxCurrentImage.BackColor = Color.WhiteSmoke;
            pictureBoxCurrentImage.Image = Properties.Resources.end;
            pictureBoxCurrentImage.Location = new Point(179, 41);
            pictureBoxCurrentImage.Name = "pictureBoxCurrentImage";
            pictureBoxCurrentImage.Size = new Size(534, 364);
            pictureBoxCurrentImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCurrentImage.TabIndex = 0;
            pictureBoxCurrentImage.TabStop = false;
            pictureBoxCurrentImage.WaitOnLoad = true;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanelTags.BackColor = Color.MediumSpringGreen;
            flowLayoutPanelTags.Location = new Point(0, 0);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanelTags.Size = new Size(179, 451);
            flowLayoutPanelTags.TabIndex = 1;
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.BackColor = Color.Transparent;
            labelFiles.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFiles.ForeColor = Color.Black;
            labelFiles.Location = new Point(185, 9);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(46, 23);
            labelFiles.TabIndex = 2;
            labelFiles.Text = "0 / 0";
            // 
            // listBoxTagsSelected
            // 
            listBoxTagsSelected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxTagsSelected.BorderStyle = BorderStyle.None;
            listBoxTagsSelected.Enabled = false;
            listBoxTagsSelected.ForeColor = Color.Black;
            listBoxTagsSelected.FormattingEnabled = true;
            listBoxTagsSelected.ItemHeight = 15;
            listBoxTagsSelected.Location = new Point(732, 32);
            listBoxTagsSelected.MultiColumn = true;
            listBoxTagsSelected.Name = "listBoxTagsSelected";
            listBoxTagsSelected.SelectionMode = SelectionMode.None;
            listBoxTagsSelected.Size = new Size(64, 360);
            listBoxTagsSelected.TabIndex = 3;
            // 
            // buttonSetTags
            // 
            buttonSetTags.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSetTags.Location = new Point(446, 405);
            buttonSetTags.Name = "buttonSetTags";
            buttonSetTags.Size = new Size(268, 45);
            buttonSetTags.TabIndex = 4;
            buttonSetTags.Text = "Set Tags";
            buttonSetTags.UseVisualStyleBackColor = true;
            buttonSetTags.Click += buttonSetTags_Click;
            // 
            // buttonSkip
            // 
            buttonSkip.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSkip.Location = new Point(179, 405);
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
            labelFilename.BackColor = Color.White;
            labelFilename.FlatStyle = FlatStyle.Popup;
            labelFilename.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilename.ForeColor = Color.Black;
            labelFilename.Location = new Point(277, 7);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new Size(426, 29);
            labelFilename.TabIndex = 6;
            labelFilename.Text = "Filename";
            labelFilename.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTagsApplied
            // 
            labelTagsApplied.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTagsApplied.AutoSize = true;
            labelTagsApplied.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTagsApplied.Location = new Point(719, 9);
            labelTagsApplied.Name = "labelTagsApplied";
            labelTagsApplied.Size = new Size(44, 23);
            labelTagsApplied.TabIndex = 7;
            labelTagsApplied.Text = "Tags";
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(724, 403);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(75, 47);
            buttonWrite.TabIndex = 8;
            buttonWrite.Text = "Write Output";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // FormImageAnnotation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(808, 450);
            Controls.Add(buttonWrite);
            Controls.Add(labelTagsApplied);
            Controls.Add(labelFilename);
            Controls.Add(buttonSkip);
            Controls.Add(buttonSetTags);
            Controls.Add(listBoxTagsSelected);
            Controls.Add(labelFiles);
            Controls.Add(flowLayoutPanelTags);
            Controls.Add(pictureBoxCurrentImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormImageAnnotation";
            Text = "ImAnno - Annotate Image";
            FormClosing += FormImageAnnotation_FormClosing;
            Load += FormImageAnnotation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentImage).EndInit();
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
    }
}