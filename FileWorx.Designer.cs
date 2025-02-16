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
            tabPage1 = new TabPage();
            pnlPreviewContent = new RichTextBox();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            pnlContentDetail = new Panel();
            button1 = new Button();
            btnAddNew = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            categoryField = new TextBox();
            creationDateField = new TextBox();
            titleField = new TextBox();
            label4 = new Label();
            contentList = new ListView();
            titleColumn = new ColumnHeader();
            creationDateColumn = new ColumnHeader();
            descriptionColumn = new ColumnHeader();
            mainSplitContainer = new SplitContainer();
            pnltabPreview.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnltabPreview
            // 
            pnltabPreview.Controls.Add(tabPage1);
            pnltabPreview.Controls.Add(tabPage2);
            pnltabPreview.Dock = DockStyle.Fill;
            pnltabPreview.Font = new Font("Segoe UI", 15F);
            pnltabPreview.Location = new Point(8, 192);
            pnltabPreview.Margin = new Padding(0);
            pnltabPreview.Name = "pnltabPreview";
            pnltabPreview.Padding = new Point(0, 0);
            pnltabPreview.SelectedIndex = 0;
            pnltabPreview.Size = new Size(1539, 368);
            pnltabPreview.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(pnlPreviewContent);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1531, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Preview";
            // 
            // pnlPreviewContent
            // 
            pnlPreviewContent.BorderStyle = BorderStyle.None;
            pnlPreviewContent.Dock = DockStyle.Fill;
            pnlPreviewContent.Location = new Point(2, 2);
            pnlPreviewContent.Margin = new Padding(2);
            pnlPreviewContent.Name = "pnlPreviewContent";
            pnlPreviewContent.ReadOnly = true;
            pnlPreviewContent.Size = new Size(1527, 323);
            pnlPreviewContent.TabIndex = 0;
            pnlPreviewContent.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1531, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "image";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1527, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pnlContentDetail
            // 
            pnlContentDetail.BackColor = Color.White;
            pnlContentDetail.Controls.Add(button1);
            pnlContentDetail.Controls.Add(btnAddNew);
            pnlContentDetail.Controls.Add(label3);
            pnlContentDetail.Controls.Add(label2);
            pnlContentDetail.Controls.Add(label1);
            pnlContentDetail.Controls.Add(categoryField);
            pnlContentDetail.Controls.Add(creationDateField);
            pnlContentDetail.Controls.Add(titleField);
            pnlContentDetail.Dock = DockStyle.Top;
            pnlContentDetail.Font = new Font("Segoe UI", 15F);
            pnlContentDetail.ForeColor = SystemColors.ControlDark;
            pnlContentDetail.Location = new Point(8, 8);
            pnlContentDetail.Margin = new Padding(5);
            pnlContentDetail.Name = "pnlContentDetail";
            pnlContentDetail.Padding = new Padding(5);
            pnlContentDetail.Size = new Size(1539, 184);
            pnlContentDetail.TabIndex = 2;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1198, 43);
            button1.Name = "button1";
            button1.Size = new Size(133, 50);
            button1.TabIndex = 7;
            button1.Text = "Add Photo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Location = new Point(1337, 43);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 50);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 124);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 4;
            label2.Text = "Creation Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // categoryField
            // 
            categoryField.BorderStyle = BorderStyle.FixedSingle;
            categoryField.Font = new Font("Segoe UI", 12F);
            categoryField.Location = new Point(177, 123);
            categoryField.Margin = new Padding(2);
            categoryField.Name = "categoryField";
            categoryField.ReadOnly = true;
            categoryField.Size = new Size(346, 29);
            categoryField.TabIndex = 2;
            // 
            // creationDateField
            // 
            creationDateField.BorderStyle = BorderStyle.FixedSingle;
            creationDateField.Font = new Font("Segoe UI", 12F);
            creationDateField.Location = new Point(177, 79);
            creationDateField.Margin = new Padding(2);
            creationDateField.Name = "creationDateField";
            creationDateField.ReadOnly = true;
            creationDateField.Size = new Size(346, 29);
            creationDateField.TabIndex = 1;
            // 
            // titleField
            // 
            titleField.BorderStyle = BorderStyle.FixedSingle;
            titleField.Font = new Font("Segoe UI", 11F);
            titleField.Location = new Point(177, 37);
            titleField.Margin = new Padding(2);
            titleField.Name = "titleField";
            titleField.ReadOnly = true;
            titleField.Size = new Size(346, 27);
            titleField.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 130, 200);
            label4.Location = new Point(738, 7);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 3;
            label4.Text = "Fileworx News";
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
            contentList.Margin = new Padding(2);
            contentList.MaximumSize = new Size(0, 900);
            contentList.MinimumSize = new Size(600, 250);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1555, 250);
            contentList.TabIndex = 0;
            contentList.TileSize = new Size(100, 100);
            contentList.UseCompatibleStateImageBehavior = false;
            contentList.View = View.Details;
            contentList.MouseClick += ContentList_MouseClick;
            contentList.MouseDoubleClick += ContentList_MouseDoubleClick;
            // 
            // titleColumn
            // 
            titleColumn.Text = "Title";
            // 
            // creationDateColumn
            // 
            creationDateColumn.Text = "Creation Date";
            creationDateColumn.Width = 121;
            // 
            // descriptionColumn
            // 
            descriptionColumn.Text = "Description";
            descriptionColumn.Width = 121;
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.BorderStyle = BorderStyle.FixedSingle;
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(25, 50);
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
            mainSplitContainer.Size = new Size(1557, 783);
            mainSplitContainer.SplitterDistance = 209;
            mainSplitContainer.TabIndex = 4;
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1607, 853);
            Controls.Add(mainSplitContainer);
            Controls.Add(label4);
            Margin = new Padding(2);
            Name = "FileWorx";
            Padding = new Padding(25, 50, 25, 20);
            Text = "FileWorx News";
            Load += FileWorx_Load;
            Resize += FileWorx_Resize;
            pnltabPreview.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContentDetail.ResumeLayout(false);
            pnlContentDetail.PerformLayout();
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl pnltabPreview;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Panel pnlContentDetail;
        private Button addNewsButton;
        private Label label3;
        private Button addPhotoButton;
        private Label label2;
        private Label label1;
        private TextBox categoryField;
        private TextBox creationDateField;
        private TextBox titleField;
        private Label label4;
        private TabPage tabPage1;
        private RichTextBox pnlPreviewContent;
        private Label label5;
        private ListView contentList;
        internal ColumnHeader titleColumn;
        private ColumnHeader creationDateColumn;
        private ColumnHeader descriptionColumn;
        private SplitContainer mainSplitContainer;
        private Button button1;
        private Button btnAddNew;
    }
}