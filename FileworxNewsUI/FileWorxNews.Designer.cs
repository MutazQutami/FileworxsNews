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
            components = new System.ComponentModel.Container();
            pnlContentDetail = new Panel();
            lblCategory = new Label();
            lblCreationDate = new Label();
            lblTitle = new Label();
            txtCategoryField = new TextBox();
            txtCreationDateField = new TextBox();
            txtTitleField = new TextBox();
            contentList = new ListView();
            titleColumn = new ColumnHeader();
            creationDateColumn = new ColumnHeader();
            descriptionColumn = new ColumnHeader();
            mainSplitContainer = new SplitContainer();
            pnltabPreview = new TabControl();
            previewTabPage1 = new TabPage();
            pnlPreviewContent = new RichTextBox();
            imageTabPage2 = new TabPage();
            imagePreview = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStripActions = new MenuStrip();
            addPhotoToolStripMenuItem = new ToolStripMenuItem();
            addNewsToolStripMenuItem = new ToolStripMenuItem();
            usersListToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            pnlBodyContent = new Panel();
            pnlContentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            pnltabPreview.SuspendLayout();
            previewTabPage1.SuspendLayout();
            imageTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePreview).BeginInit();
            menuStripActions.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlBodyContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentDetail
            // 
            pnlContentDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentDetail.BackColor = Color.White;
            pnlContentDetail.Controls.Add(lblCategory);
            pnlContentDetail.Controls.Add(lblCreationDate);
            pnlContentDetail.Controls.Add(lblTitle);
            pnlContentDetail.Controls.Add(txtCategoryField);
            pnlContentDetail.Controls.Add(txtCreationDateField);
            pnlContentDetail.Controls.Add(txtTitleField);
            pnlContentDetail.Font = new Font("Segoe UI", 15F);
            pnlContentDetail.ForeColor = SystemColors.ControlDark;
            pnlContentDetail.Location = new Point(10, 13);
            pnlContentDetail.Margin = new Padding(5);
            pnlContentDetail.Name = "pnlContentDetail";
            pnlContentDetail.Padding = new Padding(5);
            pnlContentDetail.Size = new Size(867, 136);
            pnlContentDetail.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(5, 103);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.ForeColor = Color.Black;
            lblCreationDate.Location = new Point(5, 59);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(132, 28);
            lblCreationDate.TabIndex = 4;
            lblCreationDate.Text = "Creation Date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(5, 16);
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
            txtCategoryField.Location = new Point(143, 101);
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
            txtCreationDateField.Location = new Point(143, 58);
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
            txtTitleField.Location = new Point(143, 16);
            txtTitleField.Margin = new Padding(2);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.ReadOnly = true;
            txtTitleField.Size = new Size(346, 27);
            txtTitleField.TabIndex = 0;
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
            contentList.MinimumSize = new Size(101, 101);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1472, 319);
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
            mainSplitContainer.Location = new Point(12, 4);
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
            mainSplitContainer.Panel2.AutoScroll = true;
            mainSplitContainer.Panel2.Controls.Add(pnltabPreview);
            mainSplitContainer.Panel2.Controls.Add(pnlContentDetail);
            mainSplitContainer.Panel2.Padding = new Padding(8);
            mainSplitContainer.Size = new Size(1472, 681);
            mainSplitContainer.SplitterDistance = 319;
            mainSplitContainer.TabIndex = 4;
            // 
            // pnltabPreview
            // 
            pnltabPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnltabPreview.Controls.Add(previewTabPage1);
            pnltabPreview.Controls.Add(imageTabPage2);
            pnltabPreview.Font = new Font("Segoe UI", 15F);
            pnltabPreview.Location = new Point(10, 154);
            pnltabPreview.Margin = new Padding(0);
            pnltabPreview.MinimumSize = new Size(0, 286);
            pnltabPreview.Name = "pnltabPreview";
            pnltabPreview.Padding = new Point(0, 0);
            pnltabPreview.SelectedIndex = 0;
            pnltabPreview.Size = new Size(871, 286);
            pnltabPreview.TabIndex = 0;
            // 
            // previewTabPage1
            // 
            previewTabPage1.AutoScroll = true;
            previewTabPage1.BackColor = Color.Gray;
            previewTabPage1.Controls.Add(pnlPreviewContent);
            previewTabPage1.Location = new Point(4, 37);
            previewTabPage1.Margin = new Padding(2);
            previewTabPage1.Name = "previewTabPage1";
            previewTabPage1.Padding = new Padding(2);
            previewTabPage1.Size = new Size(863, 245);
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
            pnlPreviewContent.Size = new Size(859, 241);
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
            imageTabPage2.Size = new Size(863, 245);
            imageTabPage2.TabIndex = 1;
            imageTabPage2.Text = "Image";
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
            imagePreview.Size = new Size(859, 241);
            imagePreview.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePreview.TabIndex = 4;
            imagePreview.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStripActions
            // 
            menuStripActions.Dock = DockStyle.Fill;
            menuStripActions.Font = new Font("Segoe UI", 15F);
            menuStripActions.ImageScalingSize = new Size(20, 20);
            menuStripActions.Items.AddRange(new ToolStripItem[] { addPhotoToolStripMenuItem, addNewsToolStripMenuItem, usersListToolStripMenuItem });
            menuStripActions.Location = new Point(0, 0);
            menuStripActions.MinimumSize = new Size(0, 46);
            menuStripActions.Name = "menuStripActions";
            menuStripActions.Padding = new Padding(5, 1, 0, 1);
            menuStripActions.Size = new Size(1496, 46);
            menuStripActions.TabIndex = 10;
            menuStripActions.Text = "menuStrip1";
            // 
            // addPhotoToolStripMenuItem
            // 
            addPhotoToolStripMenuItem.Name = "addPhotoToolStripMenuItem";
            addPhotoToolStripMenuItem.Size = new Size(119, 44);
            addPhotoToolStripMenuItem.Text = "Add Photo";
            addPhotoToolStripMenuItem.Click += OnAddPhotoButtonClick;
            // 
            // addNewsToolStripMenuItem
            // 
            addNewsToolStripMenuItem.Name = "addNewsToolStripMenuItem";
            addNewsToolStripMenuItem.Size = new Size(113, 44);
            addNewsToolStripMenuItem.Text = "Add News";
            addNewsToolStripMenuItem.Click += OnAddNewsButtonClick;
            // 
            // usersListToolStripMenuItem
            // 
            usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            usersListToolStripMenuItem.Size = new Size(105, 44);
            usersListToolStripMenuItem.Text = "Users List";
            usersListToolStripMenuItem.Visible = false;
            usersListToolStripMenuItem.Click += OnUsersListMouseClick;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(menuStripActions);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1496, 45);
            pnlTop.TabIndex = 11;
            // 
            // pnlBodyContent
            // 
            pnlBodyContent.AutoScroll = true;
            pnlBodyContent.Controls.Add(mainSplitContainer);
            pnlBodyContent.Dock = DockStyle.Fill;
            pnlBodyContent.Location = new Point(0, 45);
            pnlBodyContent.Margin = new Padding(2);
            pnlBodyContent.Name = "pnlBodyContent";
            pnlBodyContent.Padding = new Padding(12, 4, 12, 4);
            pnlBodyContent.Size = new Size(1496, 689);
            pnlBodyContent.TabIndex = 12;
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1496, 754);
            Controls.Add(pnlBodyContent);
            Controls.Add(pnlTop);
            MainMenuStrip = menuStripActions;
            Margin = new Padding(2);
            Name = "FileWorx";
            Padding = new Padding(0, 0, 0, 20);
            Text = "FileWorx News";
            WindowState = FormWindowState.Maximized;
            Load += FileWorxLoad;
            pnlContentDetail.ResumeLayout(false);
            pnlContentDetail.PerformLayout();
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            pnltabPreview.ResumeLayout(false);
            previewTabPage1.ResumeLayout(false);
            imageTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagePreview).EndInit();
            menuStripActions.ResumeLayout(false);
            menuStripActions.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBodyContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContentDetail;
        private Button addNewsButton;
        private Label lblCategory;
        private Button addPhotoButton;
        private Label lblCreationDate;
        private Label lblTitle;
        private TextBox txtCategoryField;
        private TextBox txtCreationDateField;
        private TextBox txtTitleField;
        private Label label5;
        private ListView contentList;
        internal ColumnHeader titleColumn;
        private ColumnHeader creationDateColumn;
        private ColumnHeader descriptionColumn;
        private SplitContainer mainSplitContainer;
        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlTop;
        private MenuStrip menuStripActions;
        private ToolStripMenuItem addPhotoToolStripMenuItem;
        private ToolStripMenuItem addNewsToolStripMenuItem;
        private ToolStripMenuItem usersListToolStripMenuItem;
        private Panel pnlBodyContent;
        private TabControl pnltabPreview;
        private TabPage previewTabPage1;
        private RichTextBox pnlPreviewContent;
        private TabPage imageTabPage2;
        private PictureBox imagePreview;
        private Panel panel1;
    }
}