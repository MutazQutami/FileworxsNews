namespace FileworxsNewsUI
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
            pnltabPreview.Location = new Point(10, 248);
            pnltabPreview.Margin = new Padding(0);
            pnltabPreview.Name = "pnltabPreview";
            pnltabPreview.Padding = new Point(0, 0);
            pnltabPreview.SelectedIndex = 0;
            pnltabPreview.Size = new Size(1837, 243);
            pnltabPreview.TabIndex = 0;
            // 
            // previewTabPage1
            // 
            previewTabPage1.BackColor = Color.Gray;
            previewTabPage1.Controls.Add(pnlPreviewContent);
            previewTabPage1.Location = new Point(4, 44);
            previewTabPage1.Name = "previewTabPage1";
            previewTabPage1.Padding = new Padding(3, 3, 3, 3);
            previewTabPage1.Size = new Size(1829, 195);
            previewTabPage1.TabIndex = 0;
            previewTabPage1.Text = "Preview";
            // 
            // pnlPreviewContent
            // 
            pnlPreviewContent.BorderStyle = BorderStyle.None;
            pnlPreviewContent.Dock = DockStyle.Fill;
            pnlPreviewContent.Location = new Point(3, 3);
            pnlPreviewContent.Name = "pnlPreviewContent";
            pnlPreviewContent.ReadOnly = true;
            pnlPreviewContent.Size = new Size(1823, 189);
            pnlPreviewContent.TabIndex = 0;
            pnlPreviewContent.Text = "";
            // 
            // imageTabPage2
            // 
            imageTabPage2.BackColor = Color.Black;
            imageTabPage2.Controls.Add(imagePreview);
            imageTabPage2.Location = new Point(4, 44);
            imageTabPage2.Name = "imageTabPage2";
            imageTabPage2.Padding = new Padding(3, 3, 3, 3);
            imageTabPage2.Size = new Size(1829, 195);
            imageTabPage2.TabIndex = 1;
            imageTabPage2.Text = "image";
            // 
            // imagePreview
            // 
            imagePreview.BackColor = Color.White;
            imagePreview.Dock = DockStyle.Fill;
            imagePreview.ErrorImage = null;
            imagePreview.InitialImage = null;
            imagePreview.Location = new Point(3, 3);
            imagePreview.Name = "imagePreview";
            imagePreview.Size = new Size(1823, 189);
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
            pnlContentDetail.Location = new Point(10, 11);
            pnlContentDetail.Margin = new Padding(6, 7, 6, 7);
            pnlContentDetail.Name = "pnlContentDetail";
            pnlContentDetail.Padding = new Padding(6, 7, 6, 7);
            pnlContentDetail.Size = new Size(1837, 237);
            pnlContentDetail.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(51, 174);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(115, 35);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.ForeColor = Color.Black;
            lblCreationDate.Location = new Point(51, 112);
            lblCreationDate.Margin = new Padding(4, 0, 4, 0);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(167, 35);
            lblCreationDate.TabIndex = 4;
            lblCreationDate.Text = "Creation Date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(51, 52);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 35);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // txtCategoryField
            // 
            txtCategoryField.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryField.Font = new Font("Segoe UI", 12F);
            txtCategoryField.Location = new Point(228, 172);
            txtCategoryField.Name = "txtCategoryField";
            txtCategoryField.ReadOnly = true;
            txtCategoryField.Size = new Size(444, 34);
            txtCategoryField.TabIndex = 2;
            // 
            // txtCreationDateField
            // 
            txtCreationDateField.BorderStyle = BorderStyle.FixedSingle;
            txtCreationDateField.Font = new Font("Segoe UI", 12F);
            txtCreationDateField.Location = new Point(228, 111);
            txtCreationDateField.Name = "txtCreationDateField";
            txtCreationDateField.ReadOnly = true;
            txtCreationDateField.Size = new Size(444, 34);
            txtCreationDateField.TabIndex = 1;
            // 
            // txtTitleField
            // 
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Font = new Font("Segoe UI", 11F);
            txtTitleField.Location = new Point(228, 52);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.ReadOnly = true;
            txtTitleField.Size = new Size(444, 32);
            txtTitleField.TabIndex = 0;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Anchor = AnchorStyles.Left;
            btnAddPhoto.BackColor = Color.FromArgb(0, 130, 200);
            btnAddPhoto.Cursor = Cursors.Hand;
            btnAddPhoto.ForeColor = Color.White;
            btnAddPhoto.Location = new Point(177, 6);
            btnAddPhoto.Margin = new Padding(4, 4, 4, 4);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(170, 53);
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
            btnAddNew.Location = new Point(1, 4);
            btnAddNew.Margin = new Padding(4, 4, 4, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(168, 53);
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
            titleLabel.Location = new Point(775, 3);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(225, 41);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Fileworx News";
            // 
            // contentList
            // 
            contentList.Alignment = ListViewAlignment.SnapToGrid;
            contentList.BackColor = SystemColors.ControlLight;
            contentList.BorderStyle = BorderStyle.None;
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
            contentList.MaximumSize = new Size(0, 1260);
            contentList.MinimumSize = new Size(129, 140);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1857, 385);
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
            mainSplitContainer.BorderStyle = BorderStyle.FixedSingle;
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 28);
            mainSplitContainer.Margin = new Padding(4, 4, 4, 4);
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
            mainSplitContainer.Panel2.Padding = new Padding(10, 11, 10, 11);
            mainSplitContainer.Size = new Size(1859, 897);
            mainSplitContainer.SplitterDistance = 387;
            mainSplitContainer.SplitterWidth = 6;
            mainSplitContainer.TabIndex = 4;
            // 
            // pnlHead
            // 
            pnlHead.Controls.Add(titleLabel);
            pnlHead.Controls.Add(btnAddPhoto);
            pnlHead.Controls.Add(btnAddNew);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(32, 28);
            pnlHead.Margin = new Padding(4, 4, 4, 4);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(1859, 74);
            pnlHead.TabIndex = 8;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(mainSplitContainer);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(32, 102);
            pnlBody.Margin = new Padding(4, 4, 4, 4);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(0, 28, 0, 0);
            pnlBody.Size = new Size(1859, 925);
            pnlBody.TabIndex = 9;
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1923, 1055);
            Controls.Add(pnlBody);
            Controls.Add(pnlHead);
            Name = "FileWorx";
            Padding = new Padding(32, 28, 32, 28);
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