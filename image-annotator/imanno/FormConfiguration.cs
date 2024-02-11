using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.Arm;

namespace imanno
{
    public partial class FormConfig : Form
    {
        // Source paths
        string inputPath;
        string tagsPath;
        string outputPath;

        // Image control variables
        List<string> images = new List<string>();

        // Tags
        public List<List<string>> tagsList = new List<List<string>>();

        public FormConfig()
        {
            InitializeComponent();
        }

        private void populateImagesList(Boolean searchSubfolders)
        {
            // Clear previous list
            images.Clear();

            if (inputPath != null)
            {
                // Filter files by extension
                var ext = new List<string> { "jpg", "jpeg", "gif", "png" };

                // Check search option
                var searchType = SearchOption.TopDirectoryOnly;
                if (searchSubfolders == true)
                    searchType = SearchOption.AllDirectories;

                var selectedFiles = Directory
                    .EnumerateFiles(inputPath, "*.*", searchType)
                    .Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLower()));

                foreach (string file in selectedFiles)
                {
                    images.Add(file);
                    // richTextOutputPattern.AppendText("\r\n" + file);
                    // richTextOutputPattern.ScrollToCaret();
                }
            }
        }

        private void getTagsFromFile()
        {
            try
            {
                tagsList.Clear();

                StreamReader sr = new StreamReader(tagsPath);
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (line != null && line.Contains(":"))
                    {
                        string[] data;
                        string category;
                        string tags;

                        // Gather category and tags
                        data = line.Split(":");
                        category = data[0];
                        tags = data[1];

                        if (tags == null)
                        {
                            throw new Exception("Invalid tag selection!");
                        }
                    

                        // Construct category/tags list
                        List<string> tagsBundle = new List<string> { };
                        tagsBundle.Add(category);
                        tagsBundle.Add(tags.Replace(" ", ""));

                        tagsList.Add(tagsBundle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInputPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInputFolder.Text = folderBrowserDialog1.SelectedPath;
                inputPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonTagsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog tagsFilePicker = new OpenFileDialog();
            tagsFilePicker.Filter = "All Files (*.*)|*.*";
            tagsFilePicker.FilterIndex = 1;
            tagsFilePicker.Multiselect = false;

            if (tagsFilePicker.ShowDialog() == DialogResult.OK)
            {
                textBoxTagsFile.Text = tagsFilePicker.FileName;
                tagsPath = tagsFilePicker.FileName;
            }
        }

        private void buttonOpenAnnotator_Click(object sender, EventArgs e)
        {
            populateImagesList(false);
            getTagsFromFile();

            // Avoid null data
            if (images.Count == 0)
            {
                MessageBox.Show("There's no images at the selected path.\n" +
                    "Accepted files are [*.jpg][*.jpeg][*.png][*.gif]", "Images not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tagsList.Count == 0)
            {
                MessageBox.Show("No tags detected.\n" +
                    "Select a valid tag file.", "Invalid tags file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                FormImageAnnotation formImageAnnotation = new FormImageAnnotation(outputPath, images, tagsList);
                formImageAnnotation.Show();
                this.Hide();
            }
        }

        private void buttonOutputPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                outputPath = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
