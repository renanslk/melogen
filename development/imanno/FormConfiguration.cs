using System.Diagnostics;
using System.Text.RegularExpressions;

namespace imanno
{
    public partial class FormConfig : Form
    {
        private string inputPath;
        private string tagsPath;
        private string outputPath;

        private List<string> images;

        Dictionary<string, List<String>> annotatorInfo;

        public FormConfig()
        {
            InitializeComponent();
        }

        private void populateImagesList(Boolean searchSubfolders)
        {
            images = new List<string>();

            if (inputPath != null)
            {
                var ext = new List<string> { "jpg", "jpeg", "gif", "png" };

                var searchType = SearchOption.TopDirectoryOnly;
                if (searchSubfolders == true)
                    searchType = SearchOption.AllDirectories;

                var selectedFiles = Directory
                    .EnumerateFiles(inputPath, "*.*", searchType)
                    .Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant()));

                foreach (string file in selectedFiles)
                {
                    // Avoid files already in output folder (!)
                    int pathLimiter = file.LastIndexOf("\\");
                    string curPath = file.Substring(0, pathLimiter);

                    Debug.WriteLine("curpath: " + curPath);
                    Debug.WriteLine("outputpath: " + outputPath);

                    if (curPath != outputPath)
                        images.Add(file);
                }
            }
        }

        private bool validateAndGetTags()
        {
            bool ret = true;

            annotatorInfo = new Dictionary<string, List<string>>();

            StreamReader sr = new StreamReader(tagsPath);
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();

                if (line != null)
                {
                    string pattern = @"^([^\s][\w\s]+[^\s]):([\w]+[\w\s]*)(,[\w\s]+)*$"; // cat:tag,tag...
                    string input = line;
                    Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                    if (m.Success)
                    {
                        string[] data = line.Split(":");

                        string[] rawItems = data[1].Split(",");
                        string category = data[0].ToLowerInvariant();

                        List<string> items = new List<string>();
                        foreach (string item in rawItems)
                            items.Add(item.Trim().ToLowerInvariant());

                        annotatorInfo.Add(category, items);
                    }
                    else
                    {
                        MessageBox.Show("Tag file has invalid data.", "Invalid file format",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        annotatorInfo.Clear();
                        ret = false;
                        break;
                    }
                }
            }
            sr.Close();

            // Return if invalid formatting
            if (ret == false)
            {
                return ret;
            }

            // Avoid empty files
            if (annotatorInfo.Count == 0)
            {
                MessageBox.Show("The tags file selected is empty.", "Empty file",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }

            return ret;
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

        private void flowManager()
        {
            if ((Utils.pathExists("dir", inputPath)) &&
                (Utils.pathExists("dir", outputPath)) &&
                (Utils.pathExists("file", tagsPath)))
            {
                if (validateAndGetTags())
                {
                    populateImagesList(checkBoxSearchSub.Checked);

                    // Avoid null data
                    if (images.Count == 0)
                    {
                        if (inputPath == outputPath)
                        {
                            MessageBox.Show("Output path images are ignored by default.\n" +
                            "Please avoid using the same path for input and output or mark to search in subfolders (if available).",
                            "No images found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("There's no images at the selected path.\n" +
                            "Accepted files are [*.jpg][*.jpeg][*.png][*.gif]", "No images found",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        FormImageAnnotation formImageAnnotation = new FormImageAnnotation(
                            outputPath,
                            images,
                            annotatorInfo,
                            textBoxTagLeft.Text,
                            textBoxTagRight.Text,
                            textBoxTagSeparator.Text,
                            richTextOutputPattern.Text,
                            checkBoxMoveImages.Checked);
                        formImageAnnotation.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("One or more selected paths doesn't exists!",
                    "Invalid paths",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonOpenAnnotator_Click(object sender, EventArgs e)
        {
            flowManager();
        }

        private void buttonOutputPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                outputPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void aboutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Image Annotator (ImAnno)\n" +
                "Version 0.1.0\n\n" +
                "Creator: Renan Pelogia\n" +
                "All rights reserved.",
                "About ImAnno");
        }
    }
}
