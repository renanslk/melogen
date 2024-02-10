using System.Collections.Generic;
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

        private void getTagsFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader(tagsPath);
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (line != null)
                    {
                        // Gather category and tags
                        string[] data = line.Split(":");
                        string category = data[0];
                        string tags = data[1];

                        // Construct category/tags list
                        List<string> tagsBundle = new List<string> { };
                        tagsBundle.Add(category);
                        tagsBundle.Add(tags);

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
    }
}
