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
            pictureBoxCurrentImage = new PictureBox();
            flowLayoutPanelTags = new FlowLayoutPanel();
            labelFiles = new Label();
            listBoxTagsSelected = new ListBox();
            buttonSetTags = new Button();
            buttonSkip = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCurrentImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCurrentImage
            // 
            pictureBoxCurrentImage.Location = new Point(206, 46);
            pictureBoxCurrentImage.Name = "pictureBoxCurrentImage";
            pictureBoxCurrentImage.Size = new Size(448, 323);
            pictureBoxCurrentImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCurrentImage.TabIndex = 0;
            pictureBoxCurrentImage.TabStop = false;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTags.Location = new Point(3, 3);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(179, 412);
            flowLayoutPanelTags.TabIndex = 1;
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.Location = new Point(206, 22);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(89, 15);
            labelFiles.TabIndex = 2;
            labelFiles.Text = "0 / 0 - Filename";
            // 
            // listBoxTagsSelected
            // 
            listBoxTagsSelected.FormattingEnabled = true;
            listBoxTagsSelected.ItemHeight = 15;
            listBoxTagsSelected.Location = new Point(660, 46);
            listBoxTagsSelected.Name = "listBoxTagsSelected";
            listBoxTagsSelected.Size = new Size(116, 259);
            listBoxTagsSelected.TabIndex = 3;
            // 
            // buttonSetTags
            // 
            buttonSetTags.Location = new Point(487, 375);
            buttonSetTags.Name = "buttonSetTags";
            buttonSetTags.Size = new Size(75, 23);
            buttonSetTags.TabIndex = 4;
            buttonSetTags.Text = "Set Tags";
            buttonSetTags.UseVisualStyleBackColor = true;
            buttonSetTags.Click += buttonSetTags_Click;
            // 
            // buttonSkip
            // 
            buttonSkip.Location = new Point(331, 375);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(75, 23);
            buttonSkip.TabIndex = 5;
            buttonSkip.Text = "Skip";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // FormImageAnnotation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSkip);
            Controls.Add(buttonSetTags);
            Controls.Add(listBoxTagsSelected);
            Controls.Add(labelFiles);
            Controls.Add(flowLayoutPanelTags);
            Controls.Add(pictureBoxCurrentImage);
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
    }
}