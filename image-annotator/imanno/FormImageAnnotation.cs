using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imanno
{
    public partial class FormImageAnnotation : Form
    {
        private string outputPath;
        private List<string> images;
        private List<List<string>> tagsList;
        private int imgIdx = 0;

        public FormImageAnnotation(string outputPath, List<string> images, List<List<string>> tagsList)
        {
            this.outputPath = outputPath;
            this.images = images;
            this.tagsList = tagsList;

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
            goToNextImage();
            clearData();
        }

        private void addOrRemoveTag()
        {
            goToNextImage();
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
                tagCategory.Font = new Font(tagCategory.Font.FontFamily, 11, FontStyle.Bold);
                tagCategory.ForeColor = Color.White;
                flowLayoutPanelTags.Controls.Add(tagCategory);

                // Split tags
                string[] groupTags = tagsList[i][1].Split(',');
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
            Application.Exit();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            goToNextImage();
            clearData();
        }
    }
}
