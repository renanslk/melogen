using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace imanno
{
    public partial class FormImageAnnotation : Form
    {
        private string outputPath;
        private List<string> images;
        private List<List<string>> tagsList;
        private string leftTagPattern;
        private string rightTagPattern;
        private string separatorTagPattern;
        private string logPattern;

        private int imgIdx = 0;
        private List<string> imageLogs = new List<string>();

        public FormImageAnnotation(string outputPath, List<string> images, List<List<string>> tagsList, string leftTagPattern, string rightTagPattern, string separatorTagPattern, string logPattern)
        {
            this.outputPath = outputPath;
            this.images = images;
            this.tagsList = tagsList;
            this.leftTagPattern = leftTagPattern;
            this.rightTagPattern = rightTagPattern;
            this.separatorTagPattern = separatorTagPattern;
            this.logPattern = logPattern;

            InitializeComponent();
        }

        private void goToNextImage()
        {
            if (imgIdx < images.Count - 1)
            {
                imgIdx++;
                pictureBoxCurrentImage.Image = Image.FromFile(images[imgIdx]);
                labelFilename.Text = images[imgIdx].ToString();
                labelFiles.Text = (imgIdx + 1) + " / " + images.Count;
            }
            else
            {
                MessageBox.Show("End of list", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSetTags_Click(object sender, EventArgs e)
        {
            string logLine = "";
            string tagLine = "";

            // Set tags for image
            foreach (var tag in listBoxTagsSelected.Items)
            {
                tagLine += leftTagPattern + tag + rightTagPattern + separatorTagPattern;
            }
            // Remove extra separator
            if ((separatorTagPattern != "") && (tagLine != ""))
                tagLine = tagLine.Remove(tagLine.LastIndexOf(separatorTagPattern));

            // Replace elements in pattern
            logLine = logPattern.Replace("<filename>", images[imgIdx].Split("\\").Last())
                .Replace("<tags>", tagLine);

            imageLogs.Add(logLine);

            goToNextImage();
            clearData();
        }

        private void clearData()
        {
            listBoxTagsSelected.Items.Clear();
            foreach (Control control in flowLayoutPanelTags.Controls)
            {
                if (control.Tag != null)
                    control.BackColor = Color.WhiteSmoke;
            }
        }

        private void FormImageAnnotation_Load(object sender, EventArgs e)
        {
            // Set first image from list
            if (images.Count > 0)
            {
                pictureBoxCurrentImage.Image = Image.FromFile(images[imgIdx]);
                labelFilename.Text = images[imgIdx].ToString();

                // Set label count text
                labelFiles.Text = (imgIdx + 1) + " / " + images.Count;
            }

            // Set tags
            for (int i = 0; i < tagsList.Count; i++)
            {
                Label tagCategory = new Label();

                tagCategory.Text = tagsList[i][0].ToString();
                tagCategory.Width = flowLayoutPanelTags.Width;
                tagCategory.Font = new System.Drawing.Font(tagCategory.Font.FontFamily, 11, FontStyle.Bold);
                tagCategory.ForeColor = Color.White;
                flowLayoutPanelTags.Controls.Add(tagCategory);

                // Split tags
                string[] groupTags = tagsList[i][1].Split(",");
                foreach (string tag in groupTags)
                {
                    Label tagLabel = new Label();
                    tagLabel.Text = tag;
                    tagLabel.Tag = i;
                    tagLabel.AutoSize = true;
                    tagLabel.BackColor = Color.White;
                    tagLabel.Margin = new Padding(3, 3, 3, 3);
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
                }
            }
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

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (imageLogs.Count == 0)
            {
                MessageBox.Show("Empty image buffer. Tag at least one image before trying to write a file.",
                    "No tagged images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                // Get current Date-Time
                DateTime now = DateTime.Now;
                string nowFormatted = now.ToString("yyyyMMddHHmmss");

                string outputFilename = "imAnnoLog_" + nowFormatted + ".txt";
                string file = outputPath + "\\" + outputFilename;

                // Create file
                if (!File.Exists(file))
                {
                    File.Create(file).Close();
                }

                // Writes to file
                var fs = new FileStream(file, FileMode.Open);
                var stream = new StreamWriter(fs);

                foreach (string log in imageLogs)
                {
                    // write each line to the stream
                    stream.WriteLine(log);
                }
                stream.Close();

                MessageBox.Show("File '" + outputFilename + "' has been written!", 
                    "File written sucessfully",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear images already tagged
                imageLogs.Clear();
            }
        }
    }
}
