namespace FileworxsNews
{
    partial class FileWorx
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
            pnltabPreview = new TabControl();
            previewTabPage1 = new TabPage();
            pnlPreviewContent = new RichTextBox();
            imageTabPage2 = new TabPage();
            imagePreview = new PictureBox();
            pnlContentDetail = new Panel();
            lblCategory = new Label();
            lblCreationDate = new Label();
            lblTitle = new Label();
            txtCategoryField = new TextBox();
            txtCreationDateField = new TextBox();
            txtTitleField = new TextBox();
            btnAddPhoto = new Button();
            btnAddNew = new Button();
            titleLabel = new Label();
            contentList = new ListView();
            titleColumn = new ColumnHeader();
            creationDateColumn = new ColumnHeader();
            descriptionColumn = new ColumnHeader();
            mainSplitContainer = new SplitContainer();
            pnlHead = new Panel();
            pnlBody = new Panel();
            pnltabPreview.SuspendLayout();
            previewTabPage1.SuspendLayout();
            imageTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePreview).BeginInit();
            pnlContentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            pnlHead.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnltabPreview
            // 
            pnltabPreview.Controls.Add(previewTabPage1);
            pnltabPreview.Controls.Add(imageTabPage2);
            pnltabPreview.Dock = DockStyle.Fill;
            pnltabPreview.Font = new Font("Segoe UI", 15F);
            pnltabPreview.Location = new Point(8, 148);
            pnltabPreview.Margin = new Padding(0);
            pnltabPreview.Name = "pnltabPreview";
            pnltabPreview.Padding = new Point(0, 0);
            pnltabPreview.SelectedIndex = 0;
            pnltabPreview.Size = new Size(1430, 204);
            pnltabPreview.TabIndex = 0;
            // 
            // previewTabPage1
            // 
            previewTabPage1.BackColor = Color.Gray;
            previewTabPage1.Controls.Add(pnlPreviewContent);
            previewTabPage1.Location = new Point(4, 37);
            previewTabPage1.Margin = new Padding(2);
            previewTabPage1.Name = "previewTabPage1";
            previewTabPage1.Padding = new Padding(2);
            previewTabPage1.Size = new Size(1422, 163);
            previewTabPage1.TabIndex = 0;
            previewTabPage1.Text = "Preview";
            // 
            // pnlPreviewContent
            // 
            pnlPreviewContent.BackColor = Color.White;
            pnlPreviewContent.BorderStyle = BorderStyle.None;
            pnlPreviewContent.Dock = DockStyle.Fill;
            pnlPreviewContent.Location = new Point(2, 2);
            pnlPreviewContent.Margin = new Padding(2);
            pnlPreviewContent.Name = "pnlPreviewContent";
            pnlPreviewContent.ReadOnly = true;
            pnlPreviewContent.Size = new Size(1418, 159);
            pnlPreviewContent.TabIndex = 0;
            pnlPreviewContent.Text = "";
            // 
            // imageTabPage2
            // 
            imageTabPage2.BackColor = Color.Black;
            imageTabPage2.Controls.Add(imagePreview);
            imageTabPage2.Location = new Point(4, 37);
            imageTabPage2.Margin = new Padding(2);
            imageTabPage2.Name = "imageTabPage2";
            imageTabPage2.Padding = new Padding(2);
            imageTabPage2.Size = new Size(1420, 161);
            imageTabPage2.TabIndex = 1;
            imageTabPage2.Text = "image";
            // 
            // imagePreview
            // 
            imagePreview.BackColor = Color.White;
            imagePreview.Dock = DockStyle.Fill;
            imagePreview.ErrorImage = null;
            imagePreview.InitialImage = null;
            imagePreview.Location = new Point(2, 2);
            imagePreview.Margin = new Padding(2);
            imagePreview.Name = "imagePreview";
            imagePreview.Size = new Size(1416, 157);
            imagePreview.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePreview.TabIndex = 4;
            imagePreview.TabStop = false;
            // 
            // pnlContentDetail
            // 
            pnlContentDetail.BackColor = Color.White;
            pnlContentDetail.Controls.Add(lblCategory);
            pnlContentDetail.Controls.Add(lblCreationDate);
            pnlContentDetail.Controls.Add(lblTitle);
            pnlContentDetail.Controls.Add(txtCategoryField);
            pnlContentDetail.Controls.Add(txtCreationDateField);
            pnlContentDetail.Controls.Add(txtTitleField);
            pnlContentDetail.Dock = DockStyle.Top;
            pnlContentDetail.Font = new Font("Segoe UI", 15F);
            pnlContentDetail.ForeColor = SystemColors.ControlDark;
            pnlContentDetail.Location = new Point(8, 8);
            pnlContentDetail.Margin = new Padding(5);
            pnlContentDetail.Name = "pnlContentDetail";
            pnlContentDetail.Padding = new Padding(5);
            pnlContentDetail.Size = new Size(1430, 140);
            pnlContentDetail.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(3, 96);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.ForeColor = Color.Black;
            lblCreationDate.Location = new Point(3, 51);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(132, 28);
            lblCreationDate.TabIndex = 4;
            lblCreationDate.Text = "Creation Date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(3, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 28);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // txtCategoryField
            // 
            txtCategoryField.BackColor = Color.White;
            txtCategoryField.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryField.Font = new Font("Segoe UI", 12F);
            txtCategoryField.Location = new Point(140, 95);
            txtCategoryField.Margin = new Padding(2);
            txtCategoryField.Name = "txtCategoryField";
            txtCategoryField.ReadOnly = true;
            txtCategoryField.Size = new Size(346, 29);
            txtCategoryField.TabIndex = 2;
            // 
            // txtCreationDateField
            // 
            txtCreationDateField.BackColor = Color.White;
            txtCreationDateField.BorderStyle = BorderStyle.FixedSingle;
            txtCreationDateField.Font = new Font("Segoe UI", 12F);
            txtCreationDateField.Location = new Point(140, 51);
            txtCreationDateField.Margin = new Padding(2);
            txtCreationDateField.Name = "txtCreationDateField";
            txtCreationDateField.ReadOnly = true;
            txtCreationDateField.Size = new Size(346, 29);
            txtCreationDateField.TabIndex = 1;
            // 
            // txtTitleField
            // 
            txtTitleField.BackColor = Color.White;
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Font = new Font("Segoe UI", 11F);
            txtTitleField.Location = new Point(140, 9);
            txtTitleField.Margin = new Padding(2);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.ReadOnly = true;
            txtTitleField.Size = new Size(346, 27);
            txtTitleField.TabIndex = 0;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Anchor = AnchorStyles.Left;
            btnAddPhoto.BackColor = Color.FromArgb(0, 130, 200);
            btnAddPhoto.Cursor = Cursors.Hand;
            btnAddPhoto.ForeColor = Color.White;
            btnAddPhoto.Location = new Point(138, 4);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(132, 38);
            btnAddPhoto.TabIndex = 7;
            btnAddPhoto.Text = "Add Photo";
            btnAddPhoto.UseVisualStyleBackColor = false;
            btnAddPhoto.Click += OnAddPhotoButtonClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Left;
            btnAddNew.BackColor = Color.FromArgb(224, 224, 224);
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Location = new Point(1, 3);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 38);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += OnAddNewButtonClick;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.White;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 130, 200);
            titleLabel.Location = new Point(603, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(180, 32);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Fileworx News";
            // 
            // contentList
            // 
            contentList.Alignment = ListViewAlignment.SnapToGrid;
            contentList.BackColor = Color.White;
            contentList.BorderStyle = BorderStyle.FixedSingle;
            contentList.Columns.AddRange(new ColumnHeader[] { titleColumn, creationDateColumn, descriptionColumn });
            contentList.Cursor = Cursors.Hand;
            contentList.Dock = DockStyle.Fill;
            contentList.Font = new Font("Segoe UI", 15F);
            contentList.ForeColor = Color.Black;
            contentList.FullRowSelect = true;
            contentList.GridLines = true;
            contentList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            contentList.LabelEdit = true;
            contentList.Location = new Point(0, 0);
            contentList.Margin = new Padding(2);
            contentList.MaximumSize = new Size(0, 900);
            contentList.MinimumSize = new Size(100, 100);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1446, 277);
            contentList.TabIndex = 0;
            contentList.TileSize = new Size(100, 100);
            contentList.UseCompatibleStateImageBehavior = false;
            contentList.View = View.Details;
            contentList.MouseClick += ContentListMouseClick;
            contentList.MouseDoubleClick += ContentListMouseDoubleClick;
            // 
            // titleColumn
            // 
            titleColumn.Text = "Title";
            titleColumn.Width = 400;
            // 
            // creationDateColumn
            // 
            creationDateColumn.Text = "Creation Date";
            creationDateColumn.Width = 400;
            // 
            // descriptionColumn
            // 
            descriptionColumn.Text = "Description";
            descriptionColumn.Width = 600;
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 20);
            mainSplitContainer.Name = "mainSplitContainer";
            mainSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(contentList);
            mainSplitContainer.Panel1MinSize = 100;
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(pnltabPreview);
            mainSplitContainer.Panel2.Controls.Add(pnlContentDetail);
            mainSplitContainer.Panel2.Padding = new Padding(8);
            mainSplitContainer.Size = new Size(1446, 641);
            mainSplitContainer.SplitterDistance = 277;
            mainSplitContainer.TabIndex = 4;
            // 
            // pnlHead
            // 
            pnlHead.Controls.Add(titleLabel);
            pnlHead.Controls.Add(btnAddPhoto);
            pnlHead.Controls.Add(btnAddNew);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(25, 20);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(1446, 53);
            pnlHead.TabIndex = 8;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(mainSplitContainer);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(25, 73);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(0, 20, 0, 0);
            pnlBody.Size = new Size(1446, 661);
            pnlBody.TabIndex = 9;
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1496, 754);
            Controls.Add(pnlBody);
            Controls.Add(pnlHead);
            Margin = new Padding(2);
            Name = "FileWorx";
            Padding = new Padding(25, 20, 25, 20);
            Text = "FileWorx News";
            WindowState = FormWindowState.Maximized;
            Load += FileWorxLoad;
            pnltabPreview.ResumeLayout(false);
            previewTabPage1.ResumeLayout(false);
            imageTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagePreview).EndInit();
            pnlContentDetail.ResumeLayout(false);
            pnlContentDetail.PerformLayout();
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            pnlBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl pnltabPreview;
        private TabPage imageTabPage2;
        private PictureBox imagePreview;
        private Panel pnlContentDetail;
        private Button addNewsButton;
        private Label lblCategory;
        private Button addPhotoButton;
        private Label lblCreationDate;
        private Label lblTitle;
        private TextBox txtCategoryField;
        private TextBox txtCreationDateField;
        private TextBox txtTitleField;
        private Label titleLabel;
        private TabPage previewTabPage1;
        private RichTextBox pnlPreviewContent;
        private Label label5;
        private ListView contentList;
        internal ColumnHeader titleColumn;
        private ColumnHeader creationDateColumn;
        private ColumnHeader descriptionColumn;
        private SplitContainer mainSplitContainer;
        private Button btnAddPhoto;
        private Button btnAddNew;
        private Panel pnlHead;
        private Panel pnlBody;
    }
}