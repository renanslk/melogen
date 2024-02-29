namespace melogen
{
    partial class DialogAddCustomTag
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
            comboBoxAddCustomTag = new ComboBox();
            textBoxAddCustomTag = new TextBox();
            buttonAddCustomTag = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxAddCustomTag
            // 
            comboBoxAddCustomTag.FormattingEnabled = true;
            comboBoxAddCustomTag.Location = new Point(22, 36);
            comboBoxAddCustomTag.Name = "comboBoxAddCustomTag";
            comboBoxAddCustomTag.Size = new Size(157, 23);
            comboBoxAddCustomTag.TabIndex = 0;
            // 
            // textBoxAddCustomTag
            // 
            textBoxAddCustomTag.Location = new Point(185, 36);
            textBoxAddCustomTag.Name = "textBoxAddCustomTag";
            textBoxAddCustomTag.Size = new Size(181, 23);
            textBoxAddCustomTag.TabIndex = 1;
            // 
            // buttonAddCustomTag
            // 
            buttonAddCustomTag.Location = new Point(372, 36);
            buttonAddCustomTag.Name = "buttonAddCustomTag";
            buttonAddCustomTag.Size = new Size(70, 24);
            buttonAddCustomTag.TabIndex = 2;
            buttonAddCustomTag.Text = "Add";
            buttonAddCustomTag.UseVisualStyleBackColor = true;
            buttonAddCustomTag.Click += buttonAddCustomTag_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Add New Tag";
            // 
            // DialogAddCustomTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 82);
            Controls.Add(label1);
            Controls.Add(buttonAddCustomTag);
            Controls.Add(textBoxAddCustomTag);
            Controls.Add(comboBoxAddCustomTag);
            MaximizeBox = false;
            MaximumSize = new Size(490, 121);
            MinimizeBox = false;
            MinimumSize = new Size(490, 121);
            Name = "DialogAddCustomTag";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add new tag";
            Load += DialogAddCustomTag_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAddCustomTag;
        private TextBox textBoxAddCustomTag;
        private Button buttonAddCustomTag;
        private Label label1;
    }
}