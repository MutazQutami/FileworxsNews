namespace FileworxsNews
{
    partial class NewsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            titleField = new TextBox();
            descriptionField = new TextBox();
            categoryList = new ComboBox();
            bodyField = new RichTextBox();
            saveButton = new Button();
            cancleButton = new Button();
            nullFieldsWarnning = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(49, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(49, 110);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(49, 167);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Category ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(49, 223);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 3;
            label4.Text = "Body";
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.None;
            titleField.BorderStyle = BorderStyle.FixedSingle;
            titleField.Location = new Point(194, 50);
            titleField.Margin = new Padding(5, 6, 5, 6);
            titleField.MaxLength = 255;
            titleField.Name = "titleField";
            titleField.Size = new Size(467, 34);
            titleField.TabIndex = 4;
            // 
            // descriptionField
            // 
            descriptionField.Anchor = AnchorStyles.None;
            descriptionField.BorderStyle = BorderStyle.FixedSingle;
            descriptionField.Location = new Point(194, 110);
            descriptionField.Margin = new Padding(5, 6, 5, 6);
            descriptionField.MaxLength = 255;
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(467, 34);
            descriptionField.TabIndex = 5;
            // 
            // categoryList
            // 
            categoryList.AllowDrop = true;
            categoryList.Anchor = AnchorStyles.None;
            categoryList.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryList.FlatStyle = FlatStyle.System;
            categoryList.FormattingEnabled = true;
            categoryList.Items.AddRange(new object[] { "General", "Sports", "Health", "Politics" });
            categoryList.Location = new Point(194, 167);
            categoryList.Margin = new Padding(5, 6, 5, 6);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(467, 36);
            categoryList.TabIndex = 6;
            // 
            // bodyField
            // 
            bodyField.Anchor = AnchorStyles.None;
            bodyField.BorderStyle = BorderStyle.FixedSingle;
            bodyField.Location = new Point(194, 236);
            bodyField.Margin = new Padding(5, 6, 5, 6);
            bodyField.MaxLength = 10000;
            bodyField.Name = "bodyField";
            bodyField.Size = new Size(467, 294);
            bodyField.TabIndex = 7;
            bodyField.Text = "";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = Color.FromArgb(0, 130, 200);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(754, 551);
            saveButton.Margin = new Padding(5, 6, 5, 6);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(109, 47);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancleButton
            // 
            cancleButton.Anchor = AnchorStyles.None;
            cancleButton.BackColor = Color.Brown;
            cancleButton.Cursor = Cursors.Hand;
            cancleButton.FlatAppearance.BorderSize = 0;
            cancleButton.FlatStyle = FlatStyle.Flat;
            cancleButton.ForeColor = Color.White;
            cancleButton.Location = new Point(888, 551);
            cancleButton.Margin = new Padding(5, 6, 5, 6);
            cancleButton.Name = "cancleButton";
            cancleButton.Size = new Size(118, 47);
            cancleButton.TabIndex = 9;
            cancleButton.Text = "Cancel";
            cancleButton.UseVisualStyleBackColor = false;
            cancleButton.Click += cancleButton_Click;
            // 
            // nullFieldsWarnning
            // 
            nullFieldsWarnning.AutoSize = true;
            nullFieldsWarnning.Font = new Font("Segoe UI", 9F);
            nullFieldsWarnning.ForeColor = Color.Red;
            nullFieldsWarnning.Location = new Point(690, 515);
            nullFieldsWarnning.Name = "nullFieldsWarnning";
            nullFieldsWarnning.Size = new Size(155, 15);
            nullFieldsWarnning.TabIndex = 10;
            nullFieldsWarnning.Text = "All Fields Shoud Not Be Null";
            // 
            // NewsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1211, 649);
            Controls.Add(nullFieldsWarnning);
            Controls.Add(cancleButton);
            Controls.Add(saveButton);
            Controls.Add(bodyField);
            Controls.Add(categoryList);
            Controls.Add(descriptionField);
            Controls.Add(titleField);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "NewsForm";
            Text = "Add New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox titleField;
        private TextBox descriptionField;
        private ComboBox categoryList;
        private RichTextBox bodyField;
        private Button saveButton;
        private Button cancleButton;
        private Label nullFieldsWarnning;
    }
}