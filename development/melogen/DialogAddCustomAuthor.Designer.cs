namespace melogen
{
    partial class DialogAddCustomAuthor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddCustomAuthor = new Button();
            labelAddCustomAuthor = new Label();
            textBoxAddCustomAuthor = new TextBox();
            SuspendLayout();
            // 
            // buttonAddCustomAuthor
            // 
            buttonAddCustomAuthor.Location = new Point(170, 33);
            buttonAddCustomAuthor.Name = "buttonAddCustomAuthor";
            buttonAddCustomAuthor.Size = new Size(78, 28);
            buttonAddCustomAuthor.TabIndex = 0;
            buttonAddCustomAuthor.Text = "Add";
            buttonAddCustomAuthor.UseVisualStyleBackColor = true;
            buttonAddCustomAuthor.Click += buttonAddCustomAuthor_Click;
            // 
            // labelAddCustomAuthor
            // 
            labelAddCustomAuthor.AutoSize = true;
            labelAddCustomAuthor.Location = new Point(38, 19);
            labelAddCustomAuthor.Name = "labelAddCustomAuthor";
            labelAddCustomAuthor.Size = new Size(96, 15);
            labelAddCustomAuthor.TabIndex = 1;
            labelAddCustomAuthor.Text = "Add New Author";
            // 
            // textBoxAddCustomAuthor
            // 
            textBoxAddCustomAuthor.Location = new Point(38, 37);
            textBoxAddCustomAuthor.Name = "textBoxAddCustomAuthor";
            textBoxAddCustomAuthor.Size = new Size(126, 23);
            textBoxAddCustomAuthor.TabIndex = 2;
            // 
            // DialogAddCustomAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 85);
            Controls.Add(textBoxAddCustomAuthor);
            Controls.Add(labelAddCustomAuthor);
            Controls.Add(buttonAddCustomAuthor);
            MaximizeBox = false;
            MaximumSize = new Size(318, 124);
            MinimizeBox = false;
            MinimumSize = new Size(318, 124);
            Name = "DialogAddCustomAuthor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DialogAddCustomAuthor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddCustomAuthor;
        private Label labelAddCustomAuthor;
        private TextBox textBoxAddCustomAuthor;
    }
}