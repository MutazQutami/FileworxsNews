namespace FileworxsNewsUI
{
    partial class PhotoForm
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
            tabsPreview = new TabControl();
            FileDescriptionTab = new TabPage();
            lblNullBody = new Label();
            lblNullDescription = new Label();
            lblNullTitle = new Label();
            txtBodyField = new RichTextBox();
            lblBodyField = new Label();
            lblDescriptionField = new Label();
            lblTitleField = new Label();
            txtDescriptionField = new TextBox();
            txtTitleField = new TextBox();
            imageTabPage = new TabPage();
            pnlMainContent = new Panel();
            lblNullPhoto = new Label();
            lblFilePath = new Label();
            lblFilePathText = new Label();
            btnBrowsePhoto = new Button();
            pictureView = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            tabsPreview.SuspendLayout();
            FileDescriptionTab.SuspendLayout();
            imageTabPage.SuspendLayout();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureView).BeginInit();
            SuspendLayout();
            // 
            // tabsPreview
            // 
            tabsPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabsPreview.Controls.Add(FileDescriptionTab);
            tabsPreview.Controls.Add(imageTabPage);
            tabsPreview.Font = new Font("Segoe UI", 15F);
            tabsPreview.Location = new Point(2, 2);
            tabsPreview.Margin = new Padding(2, 2, 2, 2);
            tabsPreview.Name = "tabsPreview";
            tabsPreview.SelectedIndex = 0;
            tabsPreview.Size = new Size(680, 535);
            tabsPreview.TabIndex = 0;
            // 
            // FileDescriptionTab
            // 
            FileDescriptionTab.BackColor = Color.White;
            FileDescriptionTab.Controls.Add(lblNullBody);
            FileDescriptionTab.Controls.Add(lblNullDescription);
            FileDescriptionTab.Controls.Add(lblNullTitle);
            FileDescriptionTab.Controls.Add(txtBodyField);
            FileDescriptionTab.Controls.Add(lblBodyField);
            FileDescriptionTab.Controls.Add(lblDescriptionField);
            FileDescriptionTab.Controls.Add(lblTitleField);
            FileDescriptionTab.Controls.Add(txtDescriptionField);
            FileDescriptionTab.Controls.Add(txtTitleField);
            FileDescriptionTab.Location = new Point(4, 37);
            FileDescriptionTab.Margin = new Padding(2, 2, 2, 2);
            FileDescriptionTab.Name = "FileDescriptionTab";
            FileDescriptionTab.Padding = new Padding(2, 2, 2, 2);
            FileDescriptionTab.Size = new Size(672, 494);
            FileDescriptionTab.TabIndex = 0;
            FileDescriptionTab.Text = "File Description ";
            // 
            // lblNullBody
            // 
            lblNullBody.AutoSize = true;
            lblNullBody.BackColor = Color.White;
            lblNullBody.Font = new Font("Segoe UI", 15F);
            lblNullBody.ForeColor = Color.Red;
            lblNullBody.Location = new Point(148, 133);
            lblNullBody.Name = "lblNullBody";
            lblNullBody.Size = new Size(154, 28);
            lblNullBody.TabIndex = 12;
            lblNullBody.Text = "Body is required";
            lblNullBody.Visible = false;
            // 
            // lblNullDescription
            // 
            lblNullDescription.AutoSize = true;
            lblNullDescription.BackColor = Color.White;
            lblNullDescription.Font = new Font("Segoe UI", 15F);
            lblNullDescription.ForeColor = Color.Red;
            lblNullDescription.Location = new Point(148, 68);
            lblNullDescription.Name = "lblNullDescription";
            lblNullDescription.Size = new Size(209, 28);
            lblNullDescription.TabIndex = 11;
            lblNullDescription.Text = "Description is required";
            lblNullDescription.Visible = false;
            // 
            // lblNullTitle
            // 
            lblNullTitle.AutoSize = true;
            lblNullTitle.BackColor = Color.White;
            lblNullTitle.Font = new Font("Segoe UI", 15F);
            lblNullTitle.ForeColor = Color.Red;
            lblNullTitle.Location = new Point(148, 4);
            lblNullTitle.Name = "lblNullTitle";
            lblNullTitle.Size = new Size(146, 28);
            lblNullTitle.TabIndex = 10;
            lblNullTitle.Text = "Title is required";
            lblNullTitle.Visible = false;
            // 
            // txtBodyField
            // 
            txtBodyField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBodyField.BackColor = Color.White;
            txtBodyField.BorderStyle = BorderStyle.FixedSingle;
            txtBodyField.Location = new Point(148, 164);
            txtBodyField.Margin = new Padding(2, 2, 2, 2);
            txtBodyField.MaxLength = 10000;
            txtBodyField.MinimumSize = new Size(195, 4);
            txtBodyField.Name = "txtBodyField";
            txtBodyField.Size = new Size(255, 241);
            txtBodyField.TabIndex = 5;
            txtBodyField.Text = "";
            // 
            // lblBodyField
            // 
            lblBodyField.AutoSize = true;
            lblBodyField.Location = new Point(24, 154);
            lblBodyField.Margin = new Padding(2, 0, 2, 0);
            lblBodyField.Name = "lblBodyField";
            lblBodyField.Size = new Size(57, 28);
            lblBodyField.TabIndex = 4;
            lblBodyField.Text = "Body";
            // 
            // lblDescriptionField
            // 
            lblDescriptionField.AutoSize = true;
            lblDescriptionField.Location = new Point(24, 95);
            lblDescriptionField.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionField.Name = "lblDescriptionField";
            lblDescriptionField.Size = new Size(117, 28);
            lblDescriptionField.TabIndex = 3;
            lblDescriptionField.Text = "Description ";
            // 
            // lblTitleField
            // 
            lblTitleField.AutoSize = true;
            lblTitleField.Location = new Point(24, 36);
            lblTitleField.Margin = new Padding(2, 0, 2, 0);
            lblTitleField.Name = "lblTitleField";
            lblTitleField.Size = new Size(49, 28);
            lblTitleField.TabIndex = 2;
            lblTitleField.Text = "Title";
            // 
            // txtDescriptionField
            // 
            txtDescriptionField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescriptionField.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionField.Location = new Point(148, 98);
            txtDescriptionField.Margin = new Padding(2, 2, 2, 2);
            txtDescriptionField.MaxLength = 255;
            txtDescriptionField.MinimumSize = new Size(195, 2);
            txtDescriptionField.Name = "txtDescriptionField";
            txtDescriptionField.Size = new Size(255, 34);
            txtDescriptionField.TabIndex = 1;
            // 
            // txtTitleField
            // 
            txtTitleField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Location = new Point(148, 34);
            txtTitleField.Margin = new Padding(2, 2, 2, 2);
            txtTitleField.MaxLength = 255;
            txtTitleField.MinimumSize = new Size(195, 2);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.Size = new Size(255, 34);
            txtTitleField.TabIndex = 0;
            // 
            // imageTabPage
            // 
            imageTabPage.BackColor = Color.White;
            imageTabPage.Controls.Add(pnlMainContent);
            imageTabPage.Controls.Add(pictureView);
            imageTabPage.Location = new Point(4, 37);
            imageTabPage.Margin = new Padding(2, 2, 2, 2);
            imageTabPage.Name = "imageTabPage";
            imageTabPage.Padding = new Padding(2, 2, 2, 2);
            imageTabPage.Size = new Size(672, 494);
            imageTabPage.TabIndex = 1;
            imageTabPage.Text = "Image";
            // 
            // pnlMainContent
            // 
            pnlMainContent.AutoScroll = true;
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Controls.Add(lblNullPhoto);
            pnlMainContent.Controls.Add(lblFilePath);
            pnlMainContent.Controls.Add(lblFilePathText);
            pnlMainContent.Controls.Add(btnBrowsePhoto);
            pnlMainContent.Dock = DockStyle.Top;
            pnlMainContent.Location = new Point(2, 2);
            pnlMainContent.Margin = new Padding(2, 2, 2, 2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(668, 77);
            pnlMainContent.TabIndex = 2;
            // 
            // lblNullPhoto
            // 
            lblNullPhoto.AutoSize = true;
            lblNullPhoto.BackColor = Color.White;
            lblNullPhoto.Font = new Font("Segoe UI", 15F);
            lblNullPhoto.ForeColor = Color.Red;
            lblNullPhoto.Location = new Point(222, 27);
            lblNullPhoto.Name = "lblNullPhoto";
            lblNullPhoto.Size = new Size(248, 28);
            lblNullPhoto.TabIndex = 11;
            lblNullPhoto.Text = "A photo must be uploaded";
            lblNullPhoto.Visible = false;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(400, 25);
            lblFilePath.Margin = new Padding(2, 0, 2, 0);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(0, 28);
            lblFilePath.TabIndex = 2;
            // 
            // lblFilePathText
            // 
            lblFilePathText.AutoSize = true;
            lblFilePathText.Location = new Point(222, 25);
            lblFilePathText.Margin = new Padding(2, 0, 2, 0);
            lblFilePathText.Name = "lblFilePathText";
            lblFilePathText.Size = new Size(189, 28);
            lblFilePathText.TabIndex = 1;
            lblFilePathText.Text = "Picture Location is :  ";
            lblFilePathText.Visible = false;
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.BackColor = Color.FromArgb(0, 130, 200);
            btnBrowsePhoto.Cursor = Cursors.Hand;
            btnBrowsePhoto.FlatAppearance.BorderSize = 0;
            btnBrowsePhoto.FlatStyle = FlatStyle.Flat;
            btnBrowsePhoto.ForeColor = Color.White;
            btnBrowsePhoto.Location = new Point(38, 16);
            btnBrowsePhoto.Margin = new Padding(2, 2, 2, 2);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(112, 47);
            btnBrowsePhoto.TabIndex = 0;
            btnBrowsePhoto.Text = "Browse";
            btnBrowsePhoto.UseVisualStyleBackColor = false;
            btnBrowsePhoto.Click += OnBrowsePhotoClick;
            // 
            // pictureView
            // 
            pictureView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureView.BackColor = Color.White;
            pictureView.Location = new Point(2, 84);
            pictureView.Margin = new Padding(2, 2, 2, 2);
            pictureView.Name = "pictureView";
            pictureView.Size = new Size(669, 310);
            pictureView.SizeMode = PictureBoxSizeMode.Zoom;
            pictureView.TabIndex = 1;
            pictureView.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(528, 469);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(408, 469);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 38);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.MouseClick += OnSaveButtonClick;
            // 
            // PhotoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(683, 521);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(tabsPreview);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(431, 404);
            Name = "PhotoForm";
            Text = "New Photo";
            tabsPreview.ResumeLayout(false);
            FileDescriptionTab.ResumeLayout(false);
            FileDescriptionTab.PerformLayout();
            imageTabPage.ResumeLayout(false);
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabsPreview;
        private TabPage FileDescriptionTab;
        private TabPage imageTabPage;
        private Button btnCancel;
        private Button btnSave;
        private RichTextBox txtBodyField;
        private Label lblBodyField;
        private Label lblDescriptionField;
        private Label lblTitleField;
        private TextBox txtDescriptionField;
        private TextBox txtTitleField;
        private Panel pnlMainContent;
        private Button btnBrowsePhoto;
        private PictureBox pictureView;
        private Label lblFilePathText;
        private Label lblFilePath;
        private Label lblNullBody;
        private Label lblNullDescription;
        private Label lblNullTitle;
        private Label lblNullPhoto;
    }
}