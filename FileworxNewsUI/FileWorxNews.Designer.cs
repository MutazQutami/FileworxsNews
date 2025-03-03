﻿namespace FileworxsNewsUI
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
            descriptionColumn = new ColumnHeader();
            creatorNameColumn = new ColumnHeader();
            creationDateColumn = new ColumnHeader();
            lastModifierNameColumn = new ColumnHeader();
            lastModificationDateColumn = new ColumnHeader();
            mainSplitContainer = new SplitContainer();
            pnlContentList = new Panel();
            pnlTopSpliter = new Panel();
            pnlFilters = new Panel();
            lblToLMDate = new Label();
            lblLMDate = new Label();
            lblCToDateText = new Label();
            lblCDateText = new Label();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnApply = new Button();
            lblLMDateText = new Label();
            lblCreationDateText = new Label();
            lblCreatorText = new Label();
            lbllasModText = new Label();
            lblDescriptionText = new Label();
            lblTitleText = new Label();
            comboxLastMod = new ComboBox();
            comboxCreator = new ComboBox();
            comBoxDescription = new ComboBox();
            comBoxTitle = new ComboBox();
            comBoxDate = new ComboBox();
            comBoxLastModDate = new ComboBox();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            btnClearFilters = new Button();
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
            addFiltersToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            pnlBodyContent = new Panel();
            pnlContentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            pnlContentList.SuspendLayout();
            pnlTopSpliter.SuspendLayout();
            pnlFilters.SuspendLayout();
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
            pnlContentDetail.BackColor = Color.White;
            pnlContentDetail.Controls.Add(lblCategory);
            pnlContentDetail.Controls.Add(lblCreationDate);
            pnlContentDetail.Controls.Add(lblTitle);
            pnlContentDetail.Controls.Add(txtCategoryField);
            pnlContentDetail.Controls.Add(txtCreationDateField);
            pnlContentDetail.Controls.Add(txtTitleField);
            pnlContentDetail.Font = new Font("Segoe UI", 15F);
            pnlContentDetail.ForeColor = SystemColors.ControlDark;
            pnlContentDetail.Location = new Point(10, 11);
            pnlContentDetail.Margin = new Padding(6, 7, 6, 7);
            pnlContentDetail.MinimumSize = new Size(836, 0);
            pnlContentDetail.Name = "pnlContentDetail";
            pnlContentDetail.Padding = new Padding(6, 7, 6, 7);
            pnlContentDetail.Size = new Size(2254, 214);
            pnlContentDetail.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(6, 144);
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
            lblCreationDate.Location = new Point(6, 83);
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
            lblTitle.Location = new Point(6, 22);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 35);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // txtCategoryField
            // 
            txtCategoryField.BackColor = Color.White;
            txtCategoryField.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryField.Font = new Font("Segoe UI", 12F);
            txtCategoryField.Location = new Point(184, 141);
            txtCategoryField.Name = "txtCategoryField";
            txtCategoryField.ReadOnly = true;
            txtCategoryField.Size = new Size(444, 34);
            txtCategoryField.TabIndex = 2;
            // 
            // txtCreationDateField
            // 
            txtCreationDateField.BackColor = Color.White;
            txtCreationDateField.BorderStyle = BorderStyle.FixedSingle;
            txtCreationDateField.Font = new Font("Segoe UI", 12F);
            txtCreationDateField.Location = new Point(184, 81);
            txtCreationDateField.Name = "txtCreationDateField";
            txtCreationDateField.ReadOnly = true;
            txtCreationDateField.Size = new Size(444, 34);
            txtCreationDateField.TabIndex = 1;
            // 
            // txtTitleField
            // 
            txtTitleField.BackColor = Color.White;
            txtTitleField.BorderStyle = BorderStyle.FixedSingle;
            txtTitleField.Font = new Font("Segoe UI", 11F);
            txtTitleField.Location = new Point(184, 22);
            txtTitleField.Name = "txtTitleField";
            txtTitleField.ReadOnly = true;
            txtTitleField.Size = new Size(444, 32);
            txtTitleField.TabIndex = 0;
            // 
            // contentList
            // 
            contentList.Alignment = ListViewAlignment.SnapToGrid;
            contentList.BackColor = Color.White;
            contentList.Columns.AddRange(new ColumnHeader[] { titleColumn, descriptionColumn, creatorNameColumn, creationDateColumn, lastModifierNameColumn, lastModificationDateColumn });
            contentList.Cursor = Cursors.Hand;
            contentList.Dock = DockStyle.Fill;
            contentList.Font = new Font("Segoe UI", 15F);
            contentList.ForeColor = Color.Black;
            contentList.FullRowSelect = true;
            contentList.GridLines = true;
            contentList.LabelEdit = true;
            contentList.Location = new Point(0, 0);
            contentList.MinimumSize = new Size(129, 4);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1898, 254);
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
            titleColumn.Width = 230;
            // 
            // descriptionColumn
            // 
            descriptionColumn.Text = "Description";
            descriptionColumn.Width = 250;
            // 
            // creatorNameColumn
            // 
            creatorNameColumn.Text = "Creator ";
            creatorNameColumn.Width = 220;
            // 
            // creationDateColumn
            // 
            creationDateColumn.Text = "Creation Date";
            creationDateColumn.Width = 230;
            // 
            // lastModifierNameColumn
            // 
            lastModifierNameColumn.Text = "Last Modifier";
            lastModifierNameColumn.Width = 230;
            // 
            // lastModificationDateColumn
            // 
            lastModificationDateColumn.Text = "Last Modification Date";
            lastModificationDateColumn.Width = 220;
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(13, 14);
            mainSplitContainer.Margin = new Padding(4);
            mainSplitContainer.Name = "mainSplitContainer";
            mainSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.AutoScroll = true;
            mainSplitContainer.Panel1.Controls.Add(pnlContentList);
            mainSplitContainer.Panel1.Controls.Add(pnlTopSpliter);
            mainSplitContainer.Panel1MinSize = 350;
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.AutoScroll = true;
            mainSplitContainer.Panel2.AutoScrollMargin = new Size(2, 2);
            mainSplitContainer.Panel2.Controls.Add(pnltabPreview);
            mainSplitContainer.Panel2.Controls.Add(pnlContentDetail);
            mainSplitContainer.Panel2.Padding = new Padding(10, 11, 10, 11);
            mainSplitContainer.Panel2MinSize = 100;
            mainSplitContainer.Size = new Size(1898, 936);
            mainSplitContainer.SplitterDistance = 489;
            mainSplitContainer.SplitterWidth = 6;
            mainSplitContainer.TabIndex = 4;
            // 
            // pnlContentList
            // 
            pnlContentList.Controls.Add(contentList);
            pnlContentList.Dock = DockStyle.Fill;
            pnlContentList.Location = new Point(0, 235);
            pnlContentList.Margin = new Padding(4);
            pnlContentList.Name = "pnlContentList";
            pnlContentList.Size = new Size(1898, 254);
            pnlContentList.TabIndex = 16;
            // 
            // pnlTopSpliter
            // 
            pnlTopSpliter.Controls.Add(pnlFilters);
            pnlTopSpliter.Dock = DockStyle.Top;
            pnlTopSpliter.Location = new Point(0, 0);
            pnlTopSpliter.Margin = new Padding(4);
            pnlTopSpliter.Name = "pnlTopSpliter";
            pnlTopSpliter.Size = new Size(1898, 235);
            pnlTopSpliter.TabIndex = 15;
            // 
            // pnlFilters
            // 
            pnlFilters.AutoScroll = true;
            pnlFilters.Controls.Add(lblToLMDate);
            pnlFilters.Controls.Add(lblLMDate);
            pnlFilters.Controls.Add(lblCToDateText);
            pnlFilters.Controls.Add(lblCDateText);
            pnlFilters.Controls.Add(dateTimePicker5);
            pnlFilters.Controls.Add(dateTimePicker4);
            pnlFilters.Controls.Add(dateTimePicker3);
            pnlFilters.Controls.Add(dateTimePicker2);
            pnlFilters.Controls.Add(btnApply);
            pnlFilters.Controls.Add(lblLMDateText);
            pnlFilters.Controls.Add(lblCreationDateText);
            pnlFilters.Controls.Add(lblCreatorText);
            pnlFilters.Controls.Add(lbllasModText);
            pnlFilters.Controls.Add(lblDescriptionText);
            pnlFilters.Controls.Add(lblTitleText);
            pnlFilters.Controls.Add(comboxLastMod);
            pnlFilters.Controls.Add(comboxCreator);
            pnlFilters.Controls.Add(comBoxDescription);
            pnlFilters.Controls.Add(comBoxTitle);
            pnlFilters.Controls.Add(comBoxDate);
            pnlFilters.Controls.Add(comBoxLastModDate);
            pnlFilters.Controls.Add(txtDescription);
            pnlFilters.Controls.Add(txtTitle);
            pnlFilters.Controls.Add(btnClearFilters);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(0, 0);
            pnlFilters.Margin = new Padding(4);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1898, 235);
            pnlFilters.TabIndex = 14;
            // 
            // lblToLMDate
            // 
            lblToLMDate.AutoSize = true;
            lblToLMDate.Font = new Font("Segoe UI", 13F);
            lblToLMDate.ForeColor = Color.Black;
            lblToLMDate.Location = new Point(1755, 189);
            lblToLMDate.Margin = new Padding(4, 0, 4, 0);
            lblToLMDate.Name = "lblToLMDate";
            lblToLMDate.Size = new Size(36, 30);
            lblToLMDate.TabIndex = 47;
            lblToLMDate.Text = "To";
            lblToLMDate.Visible = false;
            // 
            // lblLMDate
            // 
            lblLMDate.AutoSize = true;
            lblLMDate.Font = new Font("Segoe UI", 13F);
            lblLMDate.ForeColor = Color.Black;
            lblLMDate.Location = new Point(1755, 147);
            lblLMDate.Margin = new Padding(4, 0, 4, 0);
            lblLMDate.Name = "lblLMDate";
            lblLMDate.Size = new Size(58, 30);
            lblLMDate.TabIndex = 46;
            lblLMDate.Text = "Date";
            lblLMDate.Visible = false;
            // 
            // lblCToDateText
            // 
            lblCToDateText.AutoSize = true;
            lblCToDateText.Font = new Font("Segoe UI", 13F);
            lblCToDateText.ForeColor = Color.Black;
            lblCToDateText.Location = new Point(549, 189);
            lblCToDateText.Margin = new Padding(4, 0, 4, 0);
            lblCToDateText.Name = "lblCToDateText";
            lblCToDateText.Size = new Size(36, 30);
            lblCToDateText.TabIndex = 45;
            lblCToDateText.Text = "To";
            lblCToDateText.Visible = false;
            // 
            // lblCDateText
            // 
            lblCDateText.AutoSize = true;
            lblCDateText.Font = new Font("Segoe UI", 13F);
            lblCDateText.ForeColor = Color.Black;
            lblCDateText.Location = new Point(549, 148);
            lblCDateText.Margin = new Padding(4, 0, 4, 0);
            lblCDateText.Name = "lblCDateText";
            lblCDateText.Size = new Size(58, 30);
            lblCDateText.TabIndex = 44;
            lblCDateText.Text = "Date";
            lblCDateText.Visible = false;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(1849, 192);
            dateTimePicker5.Margin = new Padding(4);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(256, 29);
            dateTimePicker5.TabIndex = 43;
            dateTimePicker5.Visible = false;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(629, 147);
            dateTimePicker4.Margin = new Padding(4);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(313, 29);
            dateTimePicker4.TabIndex = 42;
            dateTimePicker4.Visible = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(1849, 150);
            dateTimePicker3.Margin = new Padding(4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(256, 29);
            dateTimePicker3.TabIndex = 41;
            dateTimePicker3.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(629, 189);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(313, 29);
            dateTimePicker2.TabIndex = 40;
            dateTimePicker2.Visible = false;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Top;
            btnApply.Cursor = Cursors.Hand;
            btnApply.Font = new Font("Segoe UI", 12F);
            btnApply.ForeColor = Color.Black;
            btnApply.Location = new Point(2133, 112);
            btnApply.Margin = new Padding(4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(168, 67);
            btnApply.TabIndex = 39;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += OnApplyButtonClick;
            // 
            // lblLMDateText
            // 
            lblLMDateText.AutoSize = true;
            lblLMDateText.Font = new Font("Segoe UI", 13F);
            lblLMDateText.ForeColor = Color.Black;
            lblLMDateText.Location = new Point(1162, 144);
            lblLMDateText.Margin = new Padding(4, 0, 4, 0);
            lblLMDateText.Name = "lblLMDateText";
            lblLMDateText.Size = new Size(228, 30);
            lblLMDateText.TabIndex = 38;
            lblLMDateText.Text = "Last Modification Date";
            // 
            // lblCreationDateText
            // 
            lblCreationDateText.AutoSize = true;
            lblCreationDateText.Font = new Font("Segoe UI", 13F);
            lblCreationDateText.ForeColor = Color.Black;
            lblCreationDateText.Location = new Point(24, 147);
            lblCreationDateText.Margin = new Padding(4, 0, 4, 0);
            lblCreationDateText.Name = "lblCreationDateText";
            lblCreationDateText.Size = new Size(146, 30);
            lblCreationDateText.TabIndex = 37;
            lblCreationDateText.Text = "Creation Date";
            // 
            // lblCreatorText
            // 
            lblCreatorText.AutoSize = true;
            lblCreatorText.Font = new Font("Segoe UI", 13F);
            lblCreatorText.ForeColor = Color.Black;
            lblCreatorText.Location = new Point(1162, 81);
            lblCreatorText.Margin = new Padding(4, 0, 4, 0);
            lblCreatorText.Name = "lblCreatorText";
            lblCreatorText.Size = new Size(150, 30);
            lblCreatorText.TabIndex = 36;
            lblCreatorText.Text = "Creator Name";
            // 
            // lbllasModText
            // 
            lbllasModText.AutoSize = true;
            lbllasModText.Font = new Font("Segoe UI", 13F);
            lbllasModText.ForeColor = Color.Black;
            lbllasModText.Location = new Point(1162, 18);
            lbllasModText.Margin = new Padding(4, 0, 4, 0);
            lbllasModText.Name = "lbllasModText";
            lbllasModText.Size = new Size(139, 30);
            lbllasModText.TabIndex = 35;
            lbllasModText.Text = "Last Modifier";
            // 
            // lblDescriptionText
            // 
            lblDescriptionText.AutoSize = true;
            lblDescriptionText.Font = new Font("Segoe UI", 13F);
            lblDescriptionText.ForeColor = Color.Black;
            lblDescriptionText.Location = new Point(24, 83);
            lblDescriptionText.Margin = new Padding(4, 0, 4, 0);
            lblDescriptionText.Name = "lblDescriptionText";
            lblDescriptionText.Size = new Size(122, 30);
            lblDescriptionText.TabIndex = 34;
            lblDescriptionText.Text = "Description";
            // 
            // lblTitleText
            // 
            lblTitleText.AutoSize = true;
            lblTitleText.Font = new Font("Segoe UI", 13F);
            lblTitleText.ForeColor = Color.Black;
            lblTitleText.Location = new Point(24, 18);
            lblTitleText.Margin = new Padding(4, 0, 4, 0);
            lblTitleText.Name = "lblTitleText";
            lblTitleText.Size = new Size(54, 30);
            lblTitleText.TabIndex = 33;
            lblTitleText.Text = "Title";
            // 
            // comboxLastMod
            // 
            comboxLastMod.Font = new Font("Segoe UI", 12F);
            comboxLastMod.FormattingEnabled = true;
            comboxLastMod.Location = new Point(1414, 18);
            comboxLastMod.Margin = new Padding(4);
            comboxLastMod.Name = "comboxLastMod";
            comboxLastMod.Size = new Size(301, 36);
            comboxLastMod.TabIndex = 32;
            comboxLastMod.Text = " --Select--";
            // 
            // comboxCreator
            // 
            comboxCreator.Font = new Font("Segoe UI", 12F);
            comboxCreator.FormattingEnabled = true;
            comboxCreator.Location = new Point(1414, 81);
            comboxCreator.Margin = new Padding(4);
            comboxCreator.Name = "comboxCreator";
            comboxCreator.Size = new Size(301, 36);
            comboxCreator.TabIndex = 31;
            comboxCreator.Text = " --Select--";
            // 
            // comBoxDescription
            // 
            comBoxDescription.Font = new Font("Segoe UI", 12F);
            comBoxDescription.FormattingEnabled = true;
            comBoxDescription.Location = new Point(210, 81);
            comBoxDescription.Margin = new Padding(4);
            comBoxDescription.Name = "comBoxDescription";
            comBoxDescription.Size = new Size(301, 36);
            comBoxDescription.TabIndex = 30;
            comBoxDescription.Text = " --Select--";
            // 
            // comBoxTitle
            // 
            comBoxTitle.Font = new Font("Segoe UI", 12F);
            comBoxTitle.FormattingEnabled = true;
            comBoxTitle.Location = new Point(210, 17);
            comBoxTitle.Margin = new Padding(4);
            comBoxTitle.Name = "comBoxTitle";
            comBoxTitle.Size = new Size(301, 36);
            comBoxTitle.TabIndex = 29;
            comBoxTitle.Text = " --Select--";
            // 
            // comBoxDate
            // 
            comBoxDate.Font = new Font("Segoe UI", 12F);
            comBoxDate.FormattingEnabled = true;
            comBoxDate.Location = new Point(210, 147);
            comBoxDate.Margin = new Padding(4);
            comBoxDate.Name = "comBoxDate";
            comBoxDate.Size = new Size(301, 36);
            comBoxDate.TabIndex = 28;
            comBoxDate.Text = " --Select--";
            // 
            // comBoxLastModDate
            // 
            comBoxLastModDate.Font = new Font("Segoe UI", 12F);
            comBoxLastModDate.FormattingEnabled = true;
            comBoxLastModDate.Location = new Point(1414, 148);
            comBoxLastModDate.Margin = new Padding(4);
            comBoxLastModDate.Name = "comBoxLastModDate";
            comBoxLastModDate.Size = new Size(301, 36);
            comBoxLastModDate.TabIndex = 26;
            comBoxLastModDate.Text = " --Select--";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(585, 83);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(357, 34);
            txtDescription.TabIndex = 25;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(585, 18);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(357, 34);
            txtTitle.TabIndex = 24;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Anchor = AnchorStyles.Top;
            btnClearFilters.BackColor = Color.FromArgb(0, 130, 200);
            btnClearFilters.Cursor = Cursors.Hand;
            btnClearFilters.Font = new Font("Segoe UI", 12F);
            btnClearFilters.ForeColor = Color.White;
            btnClearFilters.Location = new Point(2133, 34);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(168, 71);
            btnClearFilters.TabIndex = 13;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += OnClearFiltersButtonClick;
            // 
            // pnltabPreview
            // 
            pnltabPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnltabPreview.Controls.Add(previewTabPage1);
            pnltabPreview.Controls.Add(imageTabPage2);
            pnltabPreview.Font = new Font("Segoe UI", 15F);
            pnltabPreview.Location = new Point(10, 232);
            pnltabPreview.Margin = new Padding(0);
            pnltabPreview.MinimumSize = new Size(836, 0);
            pnltabPreview.Name = "pnltabPreview";
            pnltabPreview.Padding = new Point(0, 0);
            pnltabPreview.SelectedIndex = 0;
            pnltabPreview.Size = new Size(2273, 630);
            pnltabPreview.TabIndex = 0;
            // 
            // previewTabPage1
            // 
            previewTabPage1.AutoScroll = true;
            previewTabPage1.BackColor = Color.Gray;
            previewTabPage1.Controls.Add(pnlPreviewContent);
            previewTabPage1.Location = new Point(4, 44);
            previewTabPage1.Name = "previewTabPage1";
            previewTabPage1.Padding = new Padding(3);
            previewTabPage1.Size = new Size(2265, 582);
            previewTabPage1.TabIndex = 0;
            previewTabPage1.Text = "Preview";
            // 
            // pnlPreviewContent
            // 
            pnlPreviewContent.BackColor = Color.White;
            pnlPreviewContent.BorderStyle = BorderStyle.None;
            pnlPreviewContent.Dock = DockStyle.Fill;
            pnlPreviewContent.Location = new Point(3, 3);
            pnlPreviewContent.Name = "pnlPreviewContent";
            pnlPreviewContent.ReadOnly = true;
            pnlPreviewContent.Size = new Size(2259, 576);
            pnlPreviewContent.TabIndex = 0;
            pnlPreviewContent.Text = "";
            // 
            // imageTabPage2
            // 
            imageTabPage2.BackColor = Color.Black;
            imageTabPage2.Controls.Add(imagePreview);
            imageTabPage2.Location = new Point(4, 44);
            imageTabPage2.Name = "imageTabPage2";
            imageTabPage2.Padding = new Padding(3);
            imageTabPage2.Size = new Size(2265, 582);
            imageTabPage2.TabIndex = 1;
            imageTabPage2.Text = "Image";
            // 
            // imagePreview
            // 
            imagePreview.BackColor = Color.White;
            imagePreview.Dock = DockStyle.Fill;
            imagePreview.ErrorImage = null;
            imagePreview.InitialImage = null;
            imagePreview.Location = new Point(3, 3);
            imagePreview.Name = "imagePreview";
            imagePreview.Size = new Size(2259, 576);
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
            menuStripActions.Items.AddRange(new ToolStripItem[] { addPhotoToolStripMenuItem, addNewsToolStripMenuItem, usersListToolStripMenuItem, addFiltersToolStripMenuItem });
            menuStripActions.Location = new Point(0, 0);
            menuStripActions.MinimumSize = new Size(0, 64);
            menuStripActions.Name = "menuStripActions";
            menuStripActions.Padding = new Padding(6, 1, 0, 1);
            menuStripActions.Size = new Size(1924, 64);
            menuStripActions.TabIndex = 10;
            menuStripActions.Text = "menuStrip1";
            // 
            // addPhotoToolStripMenuItem
            // 
            addPhotoToolStripMenuItem.ForeColor = Color.Black;
            addPhotoToolStripMenuItem.Name = "addPhotoToolStripMenuItem";
            addPhotoToolStripMenuItem.Size = new Size(148, 62);
            addPhotoToolStripMenuItem.Text = "Add Photo";
            addPhotoToolStripMenuItem.Click += OnAddPhotoButtonClick;
            // 
            // addNewsToolStripMenuItem
            // 
            addNewsToolStripMenuItem.ForeColor = Color.Black;
            addNewsToolStripMenuItem.Name = "addNewsToolStripMenuItem";
            addNewsToolStripMenuItem.Size = new Size(143, 62);
            addNewsToolStripMenuItem.Text = "Add News";
            addNewsToolStripMenuItem.Click += OnAddNewsButtonClick;
            // 
            // usersListToolStripMenuItem
            // 
            usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            usersListToolStripMenuItem.Size = new Size(134, 62);
            usersListToolStripMenuItem.Text = "Users List";
            usersListToolStripMenuItem.Visible = false;
            usersListToolStripMenuItem.Click += OnUsersListMouseClick;
            // 
            // addFiltersToolStripMenuItem
            // 
            addFiltersToolStripMenuItem.ForeColor = Color.Black;
            addFiltersToolStripMenuItem.Name = "addFiltersToolStripMenuItem";
            addFiltersToolStripMenuItem.Size = new Size(147, 62);
            addFiltersToolStripMenuItem.Text = "Add Filters";
            addFiltersToolStripMenuItem.Click += OnAddFiltersButtonClick;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(menuStripActions);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.MinimumSize = new Size(771, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1924, 63);
            pnlTop.TabIndex = 11;
            // 
            // pnlBodyContent
            // 
            pnlBodyContent.AutoScroll = true;
            pnlBodyContent.AutoScrollMargin = new Size(20, 0);
            pnlBodyContent.Controls.Add(mainSplitContainer);
            pnlBodyContent.Dock = DockStyle.Fill;
            pnlBodyContent.Location = new Point(0, 63);
            pnlBodyContent.Name = "pnlBodyContent";
            pnlBodyContent.Padding = new Padding(13, 14, 13, 14);
            pnlBodyContent.Size = new Size(1924, 964);
            pnlBodyContent.TabIndex = 12;
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlBodyContent);
            Controls.Add(pnlTop);
            ForeColor = Color.Black;
            MainMenuStrip = menuStripActions;
            Name = "FileWorx";
            Padding = new Padding(0, 0, 0, 28);
            Text = "FileWorx News";
            WindowState = FormWindowState.Maximized;
            Load += FileWorxLoad;
            pnlContentDetail.ResumeLayout(false);
            pnlContentDetail.PerformLayout();
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            pnlContentList.ResumeLayout(false);
            pnlTopSpliter.ResumeLayout(false);
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
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
        private ColumnHeader creatorNameColumn;
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
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem addFiltersToolStripMenuItem;
        private ColumnHeader lastModificationDateColumn;
        private ColumnHeader creationDateColumn;
        private ColumnHeader lastModifierNameColumn;
        private Panel pnlTopSpliter;
        private Panel pnlFilters;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private Button btnApply;
        private Label lblLMDateText;
        private Label lblCreationDateText;
        private Label lblCreatorText;
        private Label lbllasModText;
        private Label lblDescriptionText;
        private Label lblTitleText;
        private ComboBox comboxLastMod;
        private ComboBox comboxCreator;
        private ComboBox comBoxDescription;
        private ComboBox comBoxTitle;
        private ComboBox comBoxDate;
        private ComboBox comBoxLastModDate;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Button btnClearFilters;
        private Panel pnlContentList;
        private Label lblToLMDate;
        private Label lblLMDate;
        private Label lblCToDateText;
        private Label lblCDateText;
    }
}