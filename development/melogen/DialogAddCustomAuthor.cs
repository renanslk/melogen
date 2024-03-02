using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melogen
{
    public partial class DialogAddCustomAuthor : Form
    {
        public List<string> availableAuthors = new List<string>();
        public string customAuthor;
        public DialogAddCustomAuthor(List<string> availableAuthors)
        {
            this.availableAuthors = availableAuthors;
            InitializeComponent();
        }

        private void buttonAddCustomAuthor_Click(object sender, EventArgs e)
        {
            if (textBoxAddCustomAuthor.Text.Trim() != "")
            {
                if (!availableAuthors.Contains(textBoxAddCustomAuthor.Text.Trim().ToLowerInvariant()))
                {
                    availableAuthors.Add(textBoxAddCustomAuthor.Text);
                    this.customAuthor = textBoxAddCustomAuthor.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Author name already exists!", "Invalid author", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please fill the data!", "Empty fields", MessageBoxButtons.OK);
            }
        }
    }
}
