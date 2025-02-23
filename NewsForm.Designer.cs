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
            lblTitle = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblBody = new Label();
            txtTitleField = new TextBox();
            txtDescriptionField = new TextBox();
            categoryList = new ComboBox();
            txtBodyField = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            nullFieldsWarnning = new Label();
            lblNullTitle = new Label();
            lblNullDescription = new Label();
            lblNullCategory = new Label();
            lblNullBody = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(40, 34);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 114);
            lblDescription.Margin = new Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(142, 35);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(40, 186);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(122, 35);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category ";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new Point(40, 273);
            lblBody.Margin = new Padding(5, 0, 5, 0);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(71, 35);
            lblBody.TabIndex = 3;
            lblBody.Text = "Body";
            // 
            // txtTitleField
            // 
            txtTitleField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Location = new Point(192, 47);
            txtTitleField.Margin = new Padding(5, 6, 5, 6);
            txtTitleField.MaxLength = 255;
            txtTitleField.MinimumSize = new Size(250, 0);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.Size = new Size(462, 41);
            txtTitleField.TabIndex = 4;
            // 
            // txtDescriptionField
            // 
            txtDescriptionField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescriptionField.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionField.Location = new Point(192, 126);
            txtDescriptionField.Margin = new Padding(5, 6, 5, 6);
            txtDescriptionField.MaxLength = 255;
            txtDescriptionField.MinimumSize = new Size(250, 0);
            txtDescriptionField.Name = "txtDescriptionField";
            txtDescriptionField.Size = new Size(462, 41);
            txtDescriptionField.TabIndex = 5;
            // 
            // categoryList
            // 
            categoryList.AllowDrop = true;
            categoryList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryList.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryList.FlatStyle = FlatStyle.System;
            categoryList.FormattingEnabled = true;
            categoryList.Items.AddRange(new object[] { "General", "Sports", "Health", "Politics" });
            categoryList.Location = new Point(192, 210);
            categoryList.Margin = new Padding(5, 6, 5, 6);
            categoryList.MinimumSize = new Size(250, 0);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(462, 43);
            categoryList.TabIndex = 6;
            // 
            // txtBodyField
            // 
            txtBodyField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBodyField.Location = new Point(193, 300);
            txtBodyField.Margin = new Padding(5, 6, 5, 6);
            txtBodyField.MaxLength = 10000;
            txtBodyField.MinimumSize = new Size(250, 0);
            txtBodyField.Name = "txtBodyField";
            txtBodyField.Size = new Size(462, 330);
            txtBodyField.TabIndex = 7;
            txtBodyField.Text = "";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(654, 652);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 47);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += saveButton_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(773, 652);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 47);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += cancleButton_Click;
            // 
            // nullFieldsWarnning
            // 
            nullFieldsWarnning.AutoSize = true;
            nullFieldsWarnning.Font = new Font("Segoe UI", 9F);
            nullFieldsWarnning.ForeColor = Color.Red;
            nullFieldsWarnning.Location = new Point(685, 147);
            nullFieldsWarnning.Name = "nullFieldsWarnning";
            nullFieldsWarnning.Size = new Size(196, 20);
            nullFieldsWarnning.TabIndex = 10;
            nullFieldsWarnning.Text = "All Fields Shoud Not Be Null";
            // 
            // lblNullTitle
            // 
            lblNullTitle.AutoSize = true;
            lblNullTitle.Font = new Font("Segoe UI", 15F);
            lblNullTitle.ForeColor = Color.Red;
            lblNullTitle.Location = new Point(185, 8);
            lblNullTitle.Name = "lblNullTitle";
            lblNullTitle.Size = new Size(186, 35);
            lblNullTitle.TabIndex = 11;
            lblNullTitle.Text = "Title is required";
            lblNullTitle.Visible = false;
            // 
            // lblNullDescription
            // 
            lblNullDescription.AutoSize = true;
            lblNullDescription.Font = new Font("Segoe UI", 15F);
            lblNullDescription.ForeColor = Color.Red;
            lblNullDescription.Location = new Point(188, 89);
            lblNullDescription.Name = "lblNullDescription";
            lblNullDescription.Size = new Size(267, 35);
            lblNullDescription.TabIndex = 12;
            lblNullDescription.Text = "Description is required";
            lblNullDescription.Visible = false;
            // 
            // lblNullCategory
            // 
            lblNullCategory.AutoSize = true;
            lblNullCategory.Font = new Font("Segoe UI", 15F);
            lblNullCategory.ForeColor = Color.Red;
            lblNullCategory.Location = new Point(189, 170);
            lblNullCategory.Name = "lblNullCategory";
            lblNullCategory.Size = new Size(240, 35);
            lblNullCategory.TabIndex = 13;
            lblNullCategory.Text = "Category is required";
            lblNullCategory.Visible = false;
            // 
            // lblNullBody
            // 
            lblNullBody.AutoSize = true;
            lblNullBody.Font = new Font("Segoe UI", 15F);
            lblNullBody.ForeColor = Color.Red;
            lblNullBody.Location = new Point(191, 259);
            lblNullBody.Name = "lblNullBody";
            lblNullBody.Size = new Size(196, 35);
            lblNullBody.TabIndex = 14;
            lblNullBody.Text = "Body is required";
            lblNullBody.Visible = false;
            // 
            // NewsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(943, 725);
            Controls.Add(lblNullBody);
            Controls.Add(lblNullCategory);
            Controls.Add(lblNullDescription);
            Controls.Add(lblNullTitle);
            Controls.Add(nullFieldsWarnning);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBodyField);
            Controls.Add(categoryList);
            Controls.Add(txtDescriptionField);
            Controls.Add(txtTitleField);
            Controls.Add(lblBody);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(550, 700);
            Name = "NewsForm";
            Text = "Add New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblBody;
        private TextBox txtTitleField;
        private TextBox txtDescriptionField;
        private ComboBox categoryList;
        private RichTextBox txtBodyField;
        private Button btnSave;
        private Button btnCancel;
        private Label nullFieldsWarnning;
        private Label lblNullTitle;
        private Label lblNullDescription;
        private Label lblNullCategory;
        private Label lblNullBody;
    }
}