﻿namespace melogen
{
    partial class FormConfig
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            folderBrowserDialog1 = new FolderBrowserDialog();
            richTextOutputPattern = new RichTextBox();
            buttonInputPath = new Button();
            textBoxInputFolder = new TextBox();
            textBoxTagsFile = new TextBox();
            buttonTagsFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBoxTagLeft = new TextBox();
            textBoxTagRight = new TextBox();
            textBoxTagSeparator = new TextBox();
            labelTag = new Label();
            textBoxOutputFolder = new TextBox();
            buttonOutputPath = new Button();
            checkBoxMoveImages = new CheckBox();
            groupBoxPathConfiguration = new GroupBox();
            groupBoxLogConfiguration = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            labelPredefinedLogs = new Label();
            radioButtonCommon = new RadioButton();
            labelTagSeparator = new Label();
            labelLog = new Label();
            labelTagDecoration = new Label();
            panelGeneralConfig = new Panel();
            buttonOpenAnnotator = new Button();
            checkBoxSearchSub = new CheckBox();
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            groupBoxPathConfiguration.SuspendLayout();
            groupBoxLogConfiguration.SuspendLayout();
            panelGeneralConfig.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextOutputPattern
            // 
            richTextOutputPattern.DetectUrls = false;
            richTextOutputPattern.Location = new Point(18, 93);
            richTextOutputPattern.Name = "richTextOutputPattern";
            richTextOutputPattern.Size = new Size(378, 72);
            richTextOutputPattern.TabIndex = 0;
            richTextOutputPattern.Text = "Processed: <filename>; Tags: <tags>; Authors: <authors>";
            // 
            // buttonInputPath
            // 
            buttonInputPath.Location = new Point(18, 21);
            buttonInputPath.Name = "buttonInputPath";
            buttonInputPath.Size = new Size(104, 23);
            buttonInputPath.TabIndex = 1;
            buttonInputPath.Text = "Input Folder";
            buttonInputPath.UseVisualStyleBackColor = true;
            buttonInputPath.Click += buttonInputPath_Click;
            // 
            // textBoxInputFolder
            // 
            textBoxInputFolder.Location = new Point(128, 22);
            textBoxInputFolder.Name = "textBoxInputFolder";
            textBoxInputFolder.ReadOnly = true;
            textBoxInputFolder.Size = new Size(268, 23);
            textBoxInputFolder.TabIndex = 2;
            // 
            // textBoxTagsFile
            // 
            textBoxTagsFile.Location = new Point(128, 80);
            textBoxTagsFile.Name = "textBoxTagsFile";
            textBoxTagsFile.ReadOnly = true;
            textBoxTagsFile.Size = new Size(268, 23);
            textBoxTagsFile.TabIndex = 6;
            // 
            // buttonTagsFile
            // 
            buttonTagsFile.Location = new Point(18, 80);
            buttonTagsFile.Name = "buttonTagsFile";
            buttonTagsFile.Size = new Size(104, 23);
            buttonTagsFile.TabIndex = 7;
            buttonTagsFile.Text = "Tags File";
            buttonTagsFile.UseVisualStyleBackColor = true;
            buttonTagsFile.Click += buttonTagsFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxTagLeft
            // 
            textBoxTagLeft.Location = new Point(18, 37);
            textBoxTagLeft.Name = "textBoxTagLeft";
            textBoxTagLeft.Size = new Size(42, 23);
            textBoxTagLeft.TabIndex = 9;
            textBoxTagLeft.Text = "\"";
            textBoxTagLeft.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxTagRight
            // 
            textBoxTagRight.Location = new Point(96, 37);
            textBoxTagRight.Name = "textBoxTagRight";
            textBoxTagRight.Size = new Size(42, 23);
            textBoxTagRight.TabIndex = 10;
            textBoxTagRight.Text = "\"";
            // 
            // textBoxTagSeparator
            // 
            textBoxTagSeparator.Location = new Point(155, 37);
            textBoxTagSeparator.Name = "textBoxTagSeparator";
            textBoxTagSeparator.Size = new Size(42, 23);
            textBoxTagSeparator.TabIndex = 11;
            textBoxTagSeparator.Text = ",";
            // 
            // labelTag
            // 
            labelTag.AutoSize = true;
            labelTag.Location = new Point(66, 40);
            labelTag.Name = "labelTag";
            labelTag.Size = new Size(24, 15);
            labelTag.TabIndex = 12;
            labelTag.Text = "tag";
            // 
            // textBoxOutputFolder
            // 
            textBoxOutputFolder.Location = new Point(128, 51);
            textBoxOutputFolder.Name = "textBoxOutputFolder";
            textBoxOutputFolder.ReadOnly = true;
            textBoxOutputFolder.Size = new Size(268, 23);
            textBoxOutputFolder.TabIndex = 14;
            // 
            // buttonOutputPath
            // 
            buttonOutputPath.Location = new Point(18, 50);
            buttonOutputPath.Name = "buttonOutputPath";
            buttonOutputPath.Size = new Size(104, 23);
            buttonOutputPath.TabIndex = 13;
            buttonOutputPath.Text = "Output Folder";
            buttonOutputPath.UseVisualStyleBackColor = true;
            buttonOutputPath.Click += buttonOutputPath_Click;
            // 
            // checkBoxMoveImages
            // 
            checkBoxMoveImages.AutoSize = true;
            checkBoxMoveImages.Location = new Point(12, 10);
            checkBoxMoveImages.Name = "checkBoxMoveImages";
            checkBoxMoveImages.Size = new Size(282, 19);
            checkBoxMoveImages.TabIndex = 15;
            checkBoxMoveImages.Text = "Move images to output folder after classification";
            checkBoxMoveImages.UseVisualStyleBackColor = true;
            // 
            // groupBoxPathConfiguration
            // 
            groupBoxPathConfiguration.Controls.Add(buttonTagsFile);
            groupBoxPathConfiguration.Controls.Add(textBoxOutputFolder);
            groupBoxPathConfiguration.Controls.Add(textBoxTagsFile);
            groupBoxPathConfiguration.Controls.Add(buttonOutputPath);
            groupBoxPathConfiguration.Controls.Add(textBoxInputFolder);
            groupBoxPathConfiguration.Controls.Add(buttonInputPath);
            groupBoxPathConfiguration.Location = new Point(12, 29);
            groupBoxPathConfiguration.Name = "groupBoxPathConfiguration";
            groupBoxPathConfiguration.Size = new Size(414, 125);
            groupBoxPathConfiguration.TabIndex = 19;
            groupBoxPathConfiguration.TabStop = false;
            groupBoxPathConfiguration.Text = "Source Path";
            // 
            // groupBoxLogConfiguration
            // 
            groupBoxLogConfiguration.Controls.Add(radioButton3);
            groupBoxLogConfiguration.Controls.Add(radioButton2);
            groupBoxLogConfiguration.Controls.Add(radioButton1);
            groupBoxLogConfiguration.Controls.Add(labelPredefinedLogs);
            groupBoxLogConfiguration.Controls.Add(radioButtonCommon);
            groupBoxLogConfiguration.Controls.Add(labelTagSeparator);
            groupBoxLogConfiguration.Controls.Add(labelLog);
            groupBoxLogConfiguration.Controls.Add(labelTagDecoration);
            groupBoxLogConfiguration.Controls.Add(textBoxTagSeparator);
            groupBoxLogConfiguration.Controls.Add(labelTag);
            groupBoxLogConfiguration.Controls.Add(richTextOutputPattern);
            groupBoxLogConfiguration.Controls.Add(textBoxTagRight);
            groupBoxLogConfiguration.Controls.Add(textBoxTagLeft);
            groupBoxLogConfiguration.Location = new Point(12, 161);
            groupBoxLogConfiguration.Name = "groupBoxLogConfiguration";
            groupBoxLogConfiguration.Size = new Size(414, 184);
            groupBoxLogConfiguration.TabIndex = 20;
            groupBoxLogConfiguration.TabStop = false;
            groupBoxLogConfiguration.Text = "Output File Configuration";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(320, 55);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 19);
            radioButton3.TabIndex = 19;
            radioButton3.Text = "Styled";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(320, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 19);
            radioButton2.TabIndex = 18;
            radioButton2.Text = "Array";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.MouseClick += radioButton2_MouseClick;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(243, 55);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 17;
            radioButton1.Text = "HTML";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.MouseClick += radioButton1_MouseClick;
            // 
            // labelPredefinedLogs
            // 
            labelPredefinedLogs.AutoSize = true;
            labelPredefinedLogs.Location = new Point(243, 18);
            labelPredefinedLogs.Name = "labelPredefinedLogs";
            labelPredefinedLogs.Size = new Size(133, 15);
            labelPredefinedLogs.TabIndex = 16;
            labelPredefinedLogs.Text = "Predefined Log Patterns";
            // 
            // radioButtonCommon
            // 
            radioButtonCommon.AutoSize = true;
            radioButtonCommon.Checked = true;
            radioButtonCommon.Location = new Point(243, 36);
            radioButtonCommon.Name = "radioButtonCommon";
            radioButtonCommon.Size = new Size(63, 19);
            radioButtonCommon.TabIndex = 15;
            radioButtonCommon.TabStop = true;
            radioButtonCommon.Text = "Default";
            radioButtonCommon.UseVisualStyleBackColor = true;
            radioButtonCommon.MouseClick += radioButtonCommon_MouseClick;
            // 
            // labelTagSeparator
            // 
            labelTagSeparator.AutoSize = true;
            labelTagSeparator.Location = new Point(152, 19);
            labelTagSeparator.Name = "labelTagSeparator";
            labelTagSeparator.Size = new Size(57, 15);
            labelTagSeparator.TabIndex = 14;
            labelTagSeparator.Text = "Separator";
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Location = new Point(18, 75);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(80, 15);
            labelLog.TabIndex = 13;
            labelLog.Text = "Log formatter";
            // 
            // labelTagDecoration
            // 
            labelTagDecoration.AutoSize = true;
            labelTagDecoration.Location = new Point(18, 19);
            labelTagDecoration.Name = "labelTagDecoration";
            labelTagDecoration.Size = new Size(128, 15);
            labelTagDecoration.TabIndex = 0;
            labelTagDecoration.Text = "Tags/authors formatter";
            // 
            // panelGeneralConfig
            // 
            panelGeneralConfig.BackColor = Color.LightBlue;
            panelGeneralConfig.Controls.Add(buttonOpenAnnotator);
            panelGeneralConfig.Controls.Add(checkBoxSearchSub);
            panelGeneralConfig.Controls.Add(checkBoxMoveImages);
            panelGeneralConfig.Location = new Point(0, 352);
            panelGeneralConfig.Name = "panelGeneralConfig";
            panelGeneralConfig.Size = new Size(439, 67);
            panelGeneralConfig.TabIndex = 21;
            // 
            // buttonOpenAnnotator
            // 
            buttonOpenAnnotator.Location = new Point(350, 10);
            buttonOpenAnnotator.Name = "buttonOpenAnnotator";
            buttonOpenAnnotator.Size = new Size(75, 45);
            buttonOpenAnnotator.TabIndex = 17;
            buttonOpenAnnotator.Text = "Start";
            buttonOpenAnnotator.UseVisualStyleBackColor = true;
            buttonOpenAnnotator.Click += buttonOpenAnnotator_Click;
            // 
            // checkBoxSearchSub
            // 
            checkBoxSearchSub.AutoSize = true;
            checkBoxSearchSub.Location = new Point(12, 35);
            checkBoxSearchSub.Name = "checkBoxSearchSub";
            checkBoxSearchSub.Size = new Size(197, 19);
            checkBoxSearchSub.TabIndex = 16;
            checkBoxSearchSub.Text = "Also get images from subfolders";
            checkBoxSearchSub.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(437, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(44, 20);
            aToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(107, 22);
            aboutToolStripMenuItem1.Text = "&About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click_1;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(437, 418);
            Controls.Add(panelGeneralConfig);
            Controls.Add(groupBoxPathConfiguration);
            Controls.Add(groupBoxLogConfiguration);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(453, 457);
            MinimumSize = new Size(453, 457);
            Name = "FormConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Melogen - Configuration";
            groupBoxPathConfiguration.ResumeLayout(false);
            groupBoxPathConfiguration.PerformLayout();
            groupBoxLogConfiguration.ResumeLayout(false);
            groupBoxLogConfiguration.PerformLayout();
            panelGeneralConfig.ResumeLayout(false);
            panelGeneralConfig.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private RichTextBox richTextOutputPattern;
        private Button buttonInputPath;
        private TextBox textBoxInputFolder;
        private TextBox textBoxTagsFile;
        private Button buttonTagsFile;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxTagLeft;
        private TextBox textBoxTagRight;
        private TextBox textBoxTagSeparator;
        private Label labelTag;
        private TextBox textBoxOutputFolder;
        private Button buttonOutputPath;
        private CheckBox checkBoxMoveImages;
        private GroupBox groupBoxPathConfiguration;
        private GroupBox groupBoxLogConfiguration;
        private Label labelLog;
        private Label labelTagDecoration;
        private Label labelTagSeparator;
        private Panel panelGeneralConfig;
        private CheckBox checkBoxSearchSub;
        private Button buttonOpenAnnotator;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private RadioButton radioButton1;
        private Label labelPredefinedLogs;
        private RadioButton radioButtonCommon;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
    }
}
