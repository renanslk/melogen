namespace melogen
{
    public partial class DialogAddCustomTag : Form
    {
        public string tagName;
        public string catName;
        private Dictionary<string, List<string>> tags;
        private FlowLayoutPanel flowLayoutPanelTags;

        public DialogAddCustomTag(Dictionary<string, List<string>> tags, FlowLayoutPanel flowLayoutPanelTags)
        {
            this.tags = tags;
            this.flowLayoutPanelTags = flowLayoutPanelTags;
            InitializeComponent();
        }

        private void buttonAddCustomTag_Click(object sender, EventArgs e)
        {
            if ((comboBoxAddCustomTag.Items.Count > 0) && 
                (comboBoxAddCustomTag.SelectedItem != null) &&
                (textBoxAddCustomTag.Text.Trim() != "")) {

                this.tagName = textBoxAddCustomTag.Text.Trim();
                this.catName = comboBoxAddCustomTag.Text;

                Control[] categories = flowLayoutPanelTags.Controls.Find(catName, false);

                foreach (Control category in categories)
                {
                    if (category.Controls.Find("dinamicLabel" + tagName, false).Count() == 0)
                        this.DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show("Tag already exists!", "Invalid tag", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please fill the data!", "Empty fields", MessageBoxButtons.OK);
            }
        }

        private void DialogAddCustomTag_Load(object sender, EventArgs e)
        {
            foreach (string tag in tags.Keys)
            {
                if ((tag.Equals("author")) || (tag.Equals("author")))
                {
                    // continue
                }
                else
                {
                    comboBoxAddCustomTag.Items.Add(tag);
                }
            }
        }
    }
}
