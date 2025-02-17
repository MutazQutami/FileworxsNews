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
            checkUploadPhotoWarning = new Label();
            nullFieldsWarnning = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtBodyField = new RichTextBox();
            lblBodyField = new Label();
            lblDescriptionField = new Label();
            lblTitleField = new Label();
            txtDescriptionField = new TextBox();
            txtTitleField = new TextBox();
            imageTabPage = new TabPage();
            pnlMainContent = new Panel();
            lblFilePath = new Label();
            btnBrowsePhoto = new Button();
            pictureView = new PictureBox();
            tabsPreview.SuspendLayout();
            FileDescriptionTab.SuspendLayout();
            imageTabPage.SuspendLayout();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureView).BeginInit();
            SuspendLayout();
            // 
            // tabsPreview
            // 
            tabsPreview.Controls.Add(FileDescriptionTab);
            tabsPreview.Controls.Add(imageTabPage);
            tabsPreview.Dock = DockStyle.Fill;
            tabsPreview.Font = new Font("Segoe UI", 15F);
            tabsPreview.Location = new Point(0, 0);
            tabsPreview.Name = "tabsPreview";
            tabsPreview.SelectedIndex = 0;
            tabsPreview.Size = new Size(1288, 799);
            tabsPreview.TabIndex = 0;
            // 
            // FileDescriptionTab
            // 
            FileDescriptionTab.BackColor = Color.White;
            FileDescriptionTab.Controls.Add(checkUploadPhotoWarning);
            FileDescriptionTab.Controls.Add(nullFieldsWarnning);
            FileDescriptionTab.Controls.Add(btnCancel);
            FileDescriptionTab.Controls.Add(btnSave);
            FileDescriptionTab.Controls.Add(txtBodyField);
            FileDescriptionTab.Controls.Add(lblBodyField);
            FileDescriptionTab.Controls.Add(lblDescriptionField);
            FileDescriptionTab.Controls.Add(lblTitleField);
            FileDescriptionTab.Controls.Add(txtDescriptionField);
            FileDescriptionTab.Controls.Add(txtTitleField);
            FileDescriptionTab.Location = new Point(4, 44);
            FileDescriptionTab.Name = "FileDescriptionTab";
            FileDescriptionTab.Padding = new Padding(3);
            FileDescriptionTab.Size = new Size(1280, 751);
            FileDescriptionTab.TabIndex = 0;
            FileDescriptionTab.Text = "File Description ";
            // 
            // checkUploadPhotoWarning
            // 
            checkUploadPhotoWarning.Anchor = AnchorStyles.None;
            checkUploadPhotoWarning.AutoSize = true;
            checkUploadPhotoWarning.BackColor = Color.White;
            checkUploadPhotoWarning.Font = new Font("Segoe UI", 9F);
            checkUploadPhotoWarning.ForeColor = Color.Red;
            checkUploadPhotoWarning.Location = new Point(814, 482);
            checkUploadPhotoWarning.Margin = new Padding(4, 0, 4, 0);
            checkUploadPhotoWarning.Name = "checkUploadPhotoWarning";
            checkUploadPhotoWarning.Size = new Size(188, 20);
            checkUploadPhotoWarning.TabIndex = 9;
            checkUploadPhotoWarning.Text = "A photo must be uploaded";
            // 
            // nullFieldsWarnning
            // 
            nullFieldsWarnning.Anchor = AnchorStyles.None;
            nullFieldsWarnning.AutoSize = true;
            nullFieldsWarnning.Font = new Font("Segoe UI", 9F);
            nullFieldsWarnning.ForeColor = Color.Red;
            nullFieldsWarnning.Location = new Point(814, 521);
            nullFieldsWarnning.Margin = new Padding(4, 0, 4, 0);
            nullFieldsWarnning.Name = "nullFieldsWarnning";
            nullFieldsWarnning.Size = new Size(196, 20);
            nullFieldsWarnning.TabIndex = 8;
            nullFieldsWarnning.Text = "All Fields Shoud Not Be Null";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(909, 581);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 53);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(762, 581);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 53);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.MouseClick += OnSaveButtonClick;
            // 
            // txtBodyField
            // 
            txtBodyField.Anchor = AnchorStyles.None;
            txtBodyField.BorderStyle = BorderStyle.FixedSingle;
            txtBodyField.Location = new Point(243, 232);
            txtBodyField.MaxLength = 10000;
            txtBodyField.Name = "txtBodyField";
            txtBodyField.Size = new Size(516, 308);
            txtBodyField.TabIndex = 5;
            txtBodyField.Text = "";
            // 
            // lblBodyField
            // 
            lblBodyField.Anchor = AnchorStyles.None;
            lblBodyField.AutoSize = true;
            lblBodyField.Location = new Point(76, 232);
            lblBodyField.Name = "lblBodyField";
            lblBodyField.Size = new Size(71, 35);
            lblBodyField.TabIndex = 4;
            lblBodyField.Text = "Body";
            // 
            // lblDescriptionField
            // 
            lblDescriptionField.Anchor = AnchorStyles.None;
            lblDescriptionField.AutoSize = true;
            lblDescriptionField.Location = new Point(76, 150);
            lblDescriptionField.Name = "lblDescriptionField";
            lblDescriptionField.Size = new Size(149, 35);
            lblDescriptionField.TabIndex = 3;
            lblDescriptionField.Text = "Description ";
            // 
            // lblTitleField
            // 
            lblTitleField.Anchor = AnchorStyles.None;
            lblTitleField.AutoSize = true;
            lblTitleField.Location = new Point(76, 67);
            lblTitleField.Name = "lblTitleField";
            lblTitleField.Size = new Size(61, 35);
            lblTitleField.TabIndex = 2;
            lblTitleField.Text = "Title";
            // 
            // txtDescriptionField
            // 
            txtDescriptionField.Anchor = AnchorStyles.None;
            txtDescriptionField.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionField.Location = new Point(243, 150);
            txtDescriptionField.MaxLength = 255;
            txtDescriptionField.Name = "txtDescriptionField";
            txtDescriptionField.Size = new Size(516, 41);
            txtDescriptionField.TabIndex = 1;
            // 
            // txtTitleField
            // 
            txtTitleField.Anchor = AnchorStyles.None;
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Location = new Point(243, 67);
            txtTitleField.MaxLength = 255;
            txtTitleField.Name = "txtTitleField";
            txtTitleField.Size = new Size(516, 41);
            txtTitleField.TabIndex = 0;
            // 
            // imageTabPage
            // 
            imageTabPage.Controls.Add(pnlMainContent);
            imageTabPage.Controls.Add(pictureView);
            imageTabPage.Location = new Point(4, 44);
            imageTabPage.Name = "imageTabPage";
            imageTabPage.Padding = new Padding(3);
            imageTabPage.Size = new Size(1280, 751);
            imageTabPage.TabIndex = 1;
            imageTabPage.Text = "Image";
            imageTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(lblFilePath);
            pnlMainContent.Controls.Add(btnBrowsePhoto);
            pnlMainContent.Dock = DockStyle.Top;
            pnlMainContent.Location = new Point(3, 3);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1274, 108);
            pnlMainContent.TabIndex = 2;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(314, 35);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(243, 35);
            lblFilePath.TabIndex = 1;
            lblFilePath.Text = "Picture Location is :  ";
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.BackColor = Color.FromArgb(0, 130, 200);
            btnBrowsePhoto.Cursor = Cursors.Hand;
            btnBrowsePhoto.FlatAppearance.BorderSize = 0;
            btnBrowsePhoto.FlatStyle = FlatStyle.Flat;
            btnBrowsePhoto.ForeColor = Color.White;
            btnBrowsePhoto.Location = new Point(49, 22);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(144, 66);
            btnBrowsePhoto.TabIndex = 0;
            btnBrowsePhoto.Text = "Browse";
            btnBrowsePhoto.UseVisualStyleBackColor = false;
            btnBrowsePhoto.Click += OnBrowsePhotoClick;
            // 
            // pictureView
            // 
            pictureView.Dock = DockStyle.Fill;
            pictureView.Location = new Point(3, 3);
            pictureView.Name = "pictureView";
            pictureView.Size = new Size(1274, 745);
            pictureView.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureView.TabIndex = 1;
            pictureView.TabStop = false;
            // 
            // PhotoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 799);
            Controls.Add(tabsPreview);
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
        private Label lblFilePath;
        private Label nullFieldsWarnning;
        private Label checkUploadPhotoWarning;
    }
}