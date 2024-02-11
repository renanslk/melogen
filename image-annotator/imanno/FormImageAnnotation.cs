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
                control.BackColor = Color.Transparent;
            }
        }

        private void FormImageAnnotation_Load(object sender, EventArgs e)
        {
            // Set first image from list
            if (images.Count > 0)
            {
                pictureBoxCurrentImage.Image = Image.FromFile(images[imgIdx]);
            
                // Set label count text
                labelFiles.Text = (imgIdx + 1) + " / " + images.Count;
            }

            // Set tags
            for (int i = 0; i < tagsList.Count; i++)
            {
                Label tagCategory = new Label();
               
                tagCategory.Text = tagsList[i][0].ToString();
                flowLayoutPanelTags.Controls.Add(tagCategory);

                // Split tags
                string[] groupTags = tagsList[i][1].Split(',');
                foreach (string tag in groupTags)
                {
                    LinkLabel linkTag = new LinkLabel();
                    linkTag.Text = tag;
                    linkTag.Tag = i;
                    linkTag.Click += (s, e) => {
                        if (listBoxTagsSelected.Items.Contains(tag))
                        {
                            listBoxTagsSelected.Items.Remove(tag);
                            linkTag.BackColor = Color.Transparent;
                        }
                        else
                        {
                            listBoxTagsSelected.Items.Add(tag);
                            linkTag.BackColor = Color.Orange;
                        }
                    };
                    flowLayoutPanelTags.Controls.Add(linkTag);
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
