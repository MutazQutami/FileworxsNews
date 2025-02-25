namespace FileworxsNewsUI
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
            lblNullTitle = new Label();
            lblNullDescription = new Label();
            lblNullCategory = new Label();
            lblNullBody = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = SystemColors.AppWorkspace;
            lblTitle.Location = new Point(59, 40);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.AppWorkspace;
            lblDescription.Location = new Point(49, 104);
            lblDescription.Margin = new Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(142, 35);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = SystemColors.AppWorkspace;
            lblCategory.Location = new Point(49, 167);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(122, 35);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category ";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.ForeColor = SystemColors.AppWorkspace;
            lblBody.Location = new Point(49, 249);
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
            txtTitleField.Location = new Point(233, 50);
            txtTitleField.Margin = new Padding(5, 6, 5, 6);
            txtTitleField.MaxLength = 255;
            txtTitleField.MinimumSize = new Size(250, 0);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.Size = new Size(393, 41);
            txtTitleField.TabIndex = 4;
            // 
            // txtDescriptionField
            // 
            txtDescriptionField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescriptionField.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionField.Location = new Point(233, 132);
            txtDescriptionField.Margin = new Padding(5, 6, 5, 6);
            txtDescriptionField.MaxLength = 255;
            txtDescriptionField.MinimumSize = new Size(250, 0);
            txtDescriptionField.Name = "txtDescriptionField";
            txtDescriptionField.Size = new Size(393, 41);
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
            categoryList.Location = new Point(233, 222);
            categoryList.Margin = new Padding(5, 6, 5, 6);
            categoryList.MinimumSize = new Size(250, 0);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(393, 43);
            categoryList.TabIndex = 6;
            // 
            // txtBodyField
            // 
            txtBodyField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBodyField.BorderStyle = BorderStyle.FixedSingle;
            txtBodyField.Location = new Point(233, 312);
            txtBodyField.Margin = new Padding(5, 6, 5, 6);
            txtBodyField.MaxLength = 10000;
            txtBodyField.MinimumSize = new Size(250, 0);
            txtBodyField.Name = "txtBodyField";
            txtBodyField.Size = new Size(393, 249);
            txtBodyField.TabIndex = 7;
            txtBodyField.Text = "";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(621, 573);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 47);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnSaveButtonClick;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(750, 573);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 47);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // lblNullTitle
            // 
            lblNullTitle.AutoSize = true;
            lblNullTitle.Font = new Font("Segoe UI", 15F);
            lblNullTitle.ForeColor = Color.Red;
            lblNullTitle.Location = new Point(230, 9);
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
            lblNullDescription.Location = new Point(230, 97);
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
            lblNullCategory.Location = new Point(230, 179);
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
            lblNullBody.Location = new Point(236, 271);
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
            ClientSize = new Size(914, 682);
            Controls.Add(lblNullBody);
            Controls.Add(lblNullCategory);
            Controls.Add(lblNullDescription);
            Controls.Add(lblNullTitle);
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
            MinimumSize = new Size(550, 670);
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
        private Label lblNullTitle;
        private Label lblNullDescription;
        private Label lblNullCategory;
        private Label lblNullBody;
    }
}