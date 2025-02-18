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
            nullFieldsWarning  = new Label();
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
            lblFilePathText = new Label();
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
            tabsPreview.Margin = new Padding(2);
            tabsPreview.Name = "tabsPreview";
            tabsPreview.SelectedIndex = 0;
            tabsPreview.Size = new Size(1002, 571);
            tabsPreview.TabIndex = 0;
            // 
            // FileDescriptionTab
            // 
            FileDescriptionTab.BackColor = Color.White;
            FileDescriptionTab.Controls.Add(checkUploadPhotoWarning);
            FileDescriptionTab.Controls.Add(nullFieldsWarning );
            FileDescriptionTab.Controls.Add(btnCancel);
            FileDescriptionTab.Controls.Add(btnSave);
            FileDescriptionTab.Controls.Add(txtBodyField);
            FileDescriptionTab.Controls.Add(lblBodyField);
            FileDescriptionTab.Controls.Add(lblDescriptionField);
            FileDescriptionTab.Controls.Add(lblTitleField);
            FileDescriptionTab.Controls.Add(txtDescriptionField);
            FileDescriptionTab.Controls.Add(txtTitleField);
            FileDescriptionTab.Location = new Point(4, 37);
            FileDescriptionTab.Margin = new Padding(2);
            FileDescriptionTab.Name = "FileDescriptionTab";
            FileDescriptionTab.Padding = new Padding(2);
            FileDescriptionTab.Size = new Size(994, 530);
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
            checkUploadPhotoWarning.Location = new Point(633, 344);
            checkUploadPhotoWarning.Name = "checkUploadPhotoWarning";
            checkUploadPhotoWarning.Size = new Size(149, 15);
            checkUploadPhotoWarning.TabIndex = 9;
            checkUploadPhotoWarning.Text = "A photo must be uploaded";
            // 
            // nullFieldsWarning 
            // 
            nullFieldsWarning .Anchor = AnchorStyles.None;
            nullFieldsWarning .AutoSize = true;
            nullFieldsWarning .Font = new Font("Segoe UI", 9F);
            nullFieldsWarning .ForeColor = Color.Red;
            nullFieldsWarning .Location = new Point(633, 372);
            nullFieldsWarning .Name = "nullFieldsWarning ";
            nullFieldsWarning .Size = new Size(155, 15);
            nullFieldsWarning .TabIndex = 8;
            nullFieldsWarning .Text = "All Fields Shoud Not Be Null";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(707, 415);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 38);
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
            btnSave.Location = new Point(593, 415);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 38);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.MouseClick += OnSaveButtonClick;
            // 
            // txtBodyField
            // 
            txtBodyField.Anchor = AnchorStyles.None;
            txtBodyField.BorderStyle = BorderStyle.FixedSingle;
            txtBodyField.Location = new Point(189, 166);
            txtBodyField.Margin = new Padding(2);
            txtBodyField.MaxLength = 10000;
            txtBodyField.Name = "txtBodyField";
            txtBodyField.Size = new Size(402, 221);
            txtBodyField.TabIndex = 5;
            txtBodyField.Text = "";
            // 
            // lblBodyField
            // 
            lblBodyField.Anchor = AnchorStyles.None;
            lblBodyField.AutoSize = true;
            lblBodyField.Location = new Point(59, 166);
            lblBodyField.Margin = new Padding(2, 0, 2, 0);
            lblBodyField.Name = "lblBodyField";
            lblBodyField.Size = new Size(57, 28);
            lblBodyField.TabIndex = 4;
            lblBodyField.Text = "Body";
            // 
            // lblDescriptionField
            // 
            lblDescriptionField.Anchor = AnchorStyles.None;
            lblDescriptionField.AutoSize = true;
            lblDescriptionField.Location = new Point(59, 107);
            lblDescriptionField.Margin = new Padding(2, 0, 2, 0);
            lblDescriptionField.Name = "lblDescriptionField";
            lblDescriptionField.Size = new Size(117, 28);
            lblDescriptionField.TabIndex = 3;
            lblDescriptionField.Text = "Description ";
            // 
            // lblTitleField
            // 
            lblTitleField.Anchor = AnchorStyles.None;
            lblTitleField.AutoSize = true;
            lblTitleField.Location = new Point(59, 48);
            lblTitleField.Margin = new Padding(2, 0, 2, 0);
            lblTitleField.Name = "lblTitleField";
            lblTitleField.Size = new Size(49, 28);
            lblTitleField.TabIndex = 2;
            lblTitleField.Text = "Title";
            // 
            // txtDescriptionField
            // 
            txtDescriptionField.Anchor = AnchorStyles.None;
            txtDescriptionField.BorderStyle = BorderStyle.FixedSingle;
            txtDescriptionField.Location = new Point(189, 107);
            txtDescriptionField.Margin = new Padding(2);
            txtDescriptionField.MaxLength = 255;
            txtDescriptionField.Name = "txtDescriptionField";
            txtDescriptionField.Size = new Size(402, 34);
            txtDescriptionField.TabIndex = 1;
            // 
            // txtTitleField
            // 
            txtTitleField.Anchor = AnchorStyles.None;
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Location = new Point(189, 48);
            txtTitleField.Margin = new Padding(2);
            txtTitleField.MaxLength = 255;
            txtTitleField.Name = "txtTitleField";
            txtTitleField.Size = new Size(402, 34);
            txtTitleField.TabIndex = 0;
            // 
            // imageTabPage
            // 
            imageTabPage.Controls.Add(pnlMainContent);
            imageTabPage.Controls.Add(pictureView);
            imageTabPage.Location = new Point(4, 37);
            imageTabPage.Margin = new Padding(2);
            imageTabPage.Name = "imageTabPage";
            imageTabPage.Padding = new Padding(2);
            imageTabPage.Size = new Size(994, 530);
            imageTabPage.TabIndex = 1;
            imageTabPage.Text = "Image";
            imageTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(lblFilePath);
            pnlMainContent.Controls.Add(lblFilePathText);
            pnlMainContent.Controls.Add(btnBrowsePhoto);
            pnlMainContent.Dock = DockStyle.Top;
            pnlMainContent.Location = new Point(2, 2);
            pnlMainContent.Margin = new Padding(2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(990, 77);
            pnlMainContent.TabIndex = 2;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(400, 25);
            lblFilePath.Margin = new Padding(2, 0, 2, 0);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(17, 28);
            lblFilePath.TabIndex = 2;
            lblFilePath.Text = " ";
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
            btnBrowsePhoto.Margin = new Padding(2);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(112, 47);
            btnBrowsePhoto.TabIndex = 0;
            btnBrowsePhoto.Text = "Browse";
            btnBrowsePhoto.UseVisualStyleBackColor = false;
            btnBrowsePhoto.Click += OnBrowsePhotoClick;
            // 
            // pictureView
            // 
            pictureView.Dock = DockStyle.Fill;
            pictureView.Location = new Point(2, 2);
            pictureView.Margin = new Padding(2);
            pictureView.Name = "pictureView";
            pictureView.Size = new Size(990, 526);
            pictureView.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureView.TabIndex = 1;
            pictureView.TabStop = false;
            // 
            // PhotoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 571);
            Controls.Add(tabsPreview);
            Margin = new Padding(2);
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
        private Label nullFieldsWarning ;
        private Label checkUploadPhotoWarning;
        private Label lblFilePath;
    }
}