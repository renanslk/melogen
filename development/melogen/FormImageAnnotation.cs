using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace imanno
{
    public partial class FormImageAnnotation : Form
    {
        private string outputPath;
        private List<string> images;
        private Dictionary<string, List<string>> tags;
        private string leftTagPattern;
        private string rightTagPattern;
        private string separatorTagPattern;
        private string logPattern;
        private bool moveImagesConfig;

        private int imgIdx = -1;
        private List<string> imageLogs = new List<string>();

        public FormImageAnnotation(string outputPath, List<string> images, Dictionary<string, List<string>> tags, string leftTagPattern, string rightTagPattern, string separatorTagPattern, string logPattern, bool moveImagesConfig)
        {
            this.outputPath = outputPath;
            this.images = images;
            this.tags = tags;
            this.leftTagPattern = leftTagPattern;
            this.rightTagPattern = rightTagPattern;
            this.separatorTagPattern = separatorTagPattern;
            this.logPattern = logPattern;
            this.moveImagesConfig = moveImagesConfig;

            InitializeComponent();
        }

        private void disableControls()
        {
            buttonSetTags.Enabled = false;
            buttonSkip.Enabled = false;
            clearData();
        }

        private void clearData()
        {
            listBoxTagsSelected.Items.Clear();

            listBoxAuthorsSelected.Items.Clear();
            listBoxAuthorsSelected.Items.Add("unknown");

            foreach (Control control in flowLayoutPanelTags.Controls)
            {
                if (control.Tag != null)
                    control.BackColor = Color.WhiteSmoke;
            }
        }

        private void flushPicturebox()
        {
            pictureBoxCurrentImage.Image.Dispose();
        }

        private void updateFileInfo(string style, string filePath, int fileNumber)
        {
            labelFilename.Text = filePath;
            labelFiles.Text = (imgIdx + 1) + " / " + images.Count;

            if (style.Equals("error"))
            {
                labelFilename.ForeColor = Color.Red;
            }
            if (style.Equals("info"))
            {
                labelFilename.ForeColor = Color.Black;
            }
        }

        private void goToNextImage()
        {
            if (imgIdx < images.Count - 1)
            {
                imgIdx++;
                if (Utils.pathExists("file", images[imgIdx]))
                {
                    if (pictureBoxCurrentImage.Image != null)
                        flushPicturebox();
                    
                    pictureBoxCurrentImage.Image = Image.FromFile(images[imgIdx]);

                    updateFileInfo("info", images[imgIdx], imgIdx + 1);
                }
                else
                {
                    if (pictureBoxCurrentImage.Image != null)
                        pictureBoxCurrentImage.Image = null;

                    updateFileInfo("error", images[imgIdx], imgIdx + 1);

                    DialogResult result = MessageBox.Show("The file '" + images[imgIdx] + "' doesn't exists or has been moved. Continue?", "Image not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        clearData();
                        goToNextImage();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Writing intermediate log file to save your work.",
                            "Operation aborted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        writeLogFile();
                        disableControls();

                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            else
            {
                flushPicturebox();
                pictureBoxCurrentImage.Image = null;

                MessageBox.Show("End of list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                disableControls();
            }
        }

        private string moveFile(string pathFrom, string pathTo)
        {
            string finalFilename = pathTo.Split("\\").Last();

            if (!File.Exists(pathTo))
            {
                File.Move(pathFrom, pathTo);
            }
            else
            {
                string newName = renameFile(pathTo.Split("\\").Last());
                string newPathTo = outputPath + "\\" + newName;
                finalFilename = moveFile(pathFrom, newPathTo);
            }

            return finalFilename;
        }

        private string renameFile(string filename)
        {
            string text = filename;
            string pat = @"^(.*)\(([0-9]+)\)(\.[a-z]+)$"; // ...(n).ext
            string newName = "";

            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            Match m = r.Match(text);
            
            if (m.Success)
            {
                Group g = m.Groups[2];

                int newCopy = int.Parse(g.Value) + 1;
                string newFilename = Regex.Replace(text, pat, m.Groups[1] + "(" + newCopy + ")" + m.Groups[3]);

                newName = newFilename;
            }
            else
            {
                int extDotIdx = filename.LastIndexOf('.');
                string filenamePart = filename.Substring(0, extDotIdx);
                string ext = filename.Substring(extDotIdx + 1);
                newName = filenamePart + " (1)." + ext;
            }
            return newName;
        }

        private void buttonSetTags_Click(object sender, EventArgs e)
        {
            string logLine = "";
            string tagLine = "";
            string authorLine = "";

            foreach (string tag in listBoxTagsSelected.Items)
                tagLine += leftTagPattern + tag + rightTagPattern + separatorTagPattern;
            foreach (string author in listBoxAuthorsSelected.Items)
                authorLine += leftTagPattern + author + rightTagPattern + separatorTagPattern;

            // Remove extra separator
            if ((separatorTagPattern != "") && (tagLine != ""))
                tagLine = tagLine.Remove(tagLine.LastIndexOf(separatorTagPattern));
            if ((separatorTagPattern != "") && (authorLine != ""))
                authorLine = authorLine.Remove(authorLine.LastIndexOf(separatorTagPattern));

            string finalFilename = images[imgIdx].Split("\\").Last();

            if (moveImagesConfig)
            {
                flushPicturebox();
                string pathFrom = images[imgIdx];
                string pathTo = outputPath + "\\" + images[imgIdx].Split("\\").Last();

                finalFilename = moveFile(pathFrom, pathTo);
            }

            logLine = logPattern
                .Replace("<filename>", finalFilename)
                .Replace("<tags>", tagLine)
                .Replace("<authors>", authorLine);
            imageLogs.Add(logLine);

            clearData();
            goToNextImage();
        }

        private void fillTagsStructures()
        {
            foreach (var elem in tags)
            {
                if ((elem.Key.Equals("author")) || (elem.Key.Equals("authors")))
                {
                    elem.Value.Sort();
                    foreach (string tag in elem.Value)
                    {
                        if (!listBoxAuthor.Items.Contains(tag))
                        {
                            listBoxAuthor.Items.Add(tag);
                        }
                    }
                }
                else
                {
                    Label tagCategory = new Label
                    {
                        Text = elem.Key.ToUpperInvariant(),
                        Font = new System.Drawing.Font(Font.FontFamily, 11, FontStyle.Bold),
                        ForeColor = Color.Black,
                        AutoSize = true
                    };

                    flowLayoutPanelTags.Controls.Add(tagCategory);
                    flowLayoutPanelTags.SetFlowBreak(tagCategory, true);

                    elem.Value.Sort();
                    foreach (string tag in elem.Value)
                    {
                        Label tagLabel = new Label
                        {
                            Text = tag,
                            Tag = 0,
                            AutoSize = true,
                            BackColor = Color.White,
                            Margin = new Padding(3, 3, 3, 3),
                        };

                        tagLabel.Click += (s, e) =>
                        {
                            if (listBoxTagsSelected.Items.Contains(tag))
                            {
                                listBoxTagsSelected.Items.Remove(tag);
                                tagLabel.BackColor = Color.WhiteSmoke;
                            }
                            else
                            {
                                listBoxTagsSelected.Items.Add(tag);
                                tagLabel.BackColor = Color.MediumTurquoise;
                            }
                        };

                        flowLayoutPanelTags.Controls.Add(tagLabel);

                        if (tag == elem.Value.Last())
                        {
                            flowLayoutPanelTags.SetFlowBreak(tagLabel, true);
                        }
                    }
                }
            }
        }

        private void FormImageAnnotation_Load(object sender, EventArgs e)
        {
            goToNextImage();
            fillTagsStructures();
        }

        private void FormImageAnnotation_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            goToNextImage();
            clearData();
        }

        private void writeLogFile()
        {
            if (imageLogs.Count == 0)
            {
                MessageBox.Show("There's no data to write a log file.",
                    "No tagged images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime now = DateTime.Now;
                string nowFormatted = now.ToString("yyyyMMddHHmmss");

                string outputFilename = "imAnnoLog_" + nowFormatted + ".txt";
                string file = outputPath + "\\" + outputFilename;

                Utils.writeFile(file, imageLogs);

                MessageBox.Show("File '" + outputFilename + "' has been written!",
                    "File written sucessfully",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear current log buffer
                imageLogs.Clear();
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            writeLogFile();
        }

        private void listBoxAuthor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxAuthor.SelectedItem != null)
            {
                string elem = listBoxAuthor.SelectedItem.ToString();
                if (listBoxAuthorsSelected.Items.Contains(elem))
                {
                    listBoxAuthorsSelected.Items.Remove(elem);
                    if (listBoxAuthorsSelected.Items.Count == 0)
                    {
                        listBoxAuthorsSelected.Items.Add("unknown");
                    }
                }
                else
                {
                    listBoxAuthorsSelected.Items.Add(elem);
                    if (listBoxAuthorsSelected.Items.Contains ("unknown"))
                    {
                        listBoxAuthorsSelected.Items.Remove("unknown");
                    }
                }
            }
        }
    }
}