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
            tabPreviewContainer = new SplitContainer();
            tabPreview = new TabControl();
            tabPage1 = new TabPage();
            previewContent = new RichTextBox();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            categoryField = new TextBox();
            creationDateField = new TextBox();
            titleField = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            contentList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel3 = new Panel();
            secondHalfContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)tabPreviewContainer).BeginInit();
            tabPreviewContainer.Panel1.SuspendLayout();
            tabPreviewContainer.SuspendLayout();
            tabPreview.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondHalfContainer).BeginInit();
            secondHalfContainer.Panel1.SuspendLayout();
            secondHalfContainer.Panel2.SuspendLayout();
            secondHalfContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tabPreviewContainer
            // 
            tabPreviewContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tabPreviewContainer.Location = new Point(0, 0);
            tabPreviewContainer.Margin = new Padding(4);
            tabPreviewContainer.Name = "tabPreviewContainer";
            tabPreviewContainer.Orientation = Orientation.Horizontal;
            // 
            // tabPreviewContainer.Panel1
            // 
            tabPreviewContainer.Panel1.Controls.Add(tabPreview);
            tabPreviewContainer.Size = new Size(1002, 450);
            tabPreviewContainer.SplitterDistance = 320;
            tabPreviewContainer.SplitterWidth = 6;
            tabPreviewContainer.TabIndex = 4;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(tabPage1);
            tabPreview.Controls.Add(tabPage2);
            tabPreview.Dock = DockStyle.Fill;
            tabPreview.Font = new Font("Segoe UI", 15F);
            tabPreview.Location = new Point(0, 0);
            tabPreview.Name = "tabPreview";
            tabPreview.SelectedIndex = 0;
            tabPreview.Size = new Size(1002, 320);
            tabPreview.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(previewContent);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(994, 272);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Preview";
            // 
            // previewContent
            // 
            previewContent.BorderStyle = BorderStyle.None;
            previewContent.Dock = DockStyle.Fill;
            previewContent.Location = new Point(3, 3);
            previewContent.Name = "previewContent";
            previewContent.ReadOnly = true;
            previewContent.Size = new Size(988, 266);
            previewContent.TabIndex = 0;
            previewContent.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(994, 272);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "image";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(988, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(categoryField);
            panel4.Controls.Add(creationDateField);
            panel4.Controls.Add(titleField);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 15F);
            panel4.ForeColor = SystemColors.ControlDark;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(6, 7, 6, 7);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(6, 7, 6, 7);
            panel4.Size = new Size(707, 450);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 35);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(51, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 35);
            label2.TabIndex = 4;
            label2.Text = "Creation Date";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 35);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // categoryField
            // 
            categoryField.Anchor = AnchorStyles.Left;
            categoryField.BorderStyle = BorderStyle.FixedSingle;
            categoryField.Location = new Point(231, 214);
            categoryField.Name = "categoryField";
            categoryField.ReadOnly = true;
            categoryField.Size = new Size(394, 41);
            categoryField.TabIndex = 2;
            // 
            // creationDateField
            // 
            creationDateField.Anchor = AnchorStyles.Left;
            creationDateField.BorderStyle = BorderStyle.FixedSingle;
            creationDateField.Location = new Point(231, 146);
            creationDateField.Name = "creationDateField";
            creationDateField.ReadOnly = true;
            creationDateField.Size = new Size(394, 41);
            creationDateField.TabIndex = 1;
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.Left;
            titleField.BorderStyle = BorderStyle.FixedSingle;
            titleField.Location = new Point(231, 81);
            titleField.Name = "titleField";
            titleField.ReadOnly = true;
            titleField.Size = new Size(394, 41);
            titleField.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1805, 1055);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 130, 200);
            label4.Location = new Point(752, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 41);
            label4.TabIndex = 3;
            label4.Text = "Fileworx News";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(contentList);
            panel2.Location = new Point(26, 83);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1726, 357);
            panel2.TabIndex = 2;
            // 
            // contentList
            // 
            contentList.Alignment = ListViewAlignment.SnapToGrid;
            contentList.BackColor = SystemColors.ControlLight;
            contentList.BorderStyle = BorderStyle.None;
            contentList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            contentList.Cursor = Cursors.Hand;
            contentList.Dock = DockStyle.Fill;
            contentList.Font = new Font("Segoe UI", 15F);
            contentList.ForeColor = Color.Black;
            contentList.FullRowSelect = true;
            contentList.GridLines = true;
            contentList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            contentList.Location = new Point(0, 0);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1724, 355);
            contentList.Sorting = SortOrder.Descending;
            contentList.TabIndex = 0;
            contentList.TileSize = new Size(100, 100);
            contentList.UseCompatibleStateImageBehavior = false;
            contentList.View = View.Details;
            contentList.MouseClick += contentList_MouseClick;
            contentList.MouseDoubleClick += contentList_MouseDoubleClick;
            contentList.Resize += contentList_Resize;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Creation Date";
            columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 121;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(secondHalfContainer);
            panel3.Location = new Point(27, 496);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 30, 10, 0);
            panel3.Size = new Size(1735, 482);
            panel3.TabIndex = 7;
            // 
            // secondHalfContainer
            // 
            secondHalfContainer.Dock = DockStyle.Fill;
            secondHalfContainer.Location = new Point(10, 30);
            secondHalfContainer.Name = "secondHalfContainer";
            // 
            // secondHalfContainer.Panel1
            // 
            secondHalfContainer.Panel1.Controls.Add(panel4);
            // 
            // secondHalfContainer.Panel2
            // 
            secondHalfContainer.Panel2.Controls.Add(tabPreviewContainer);
            secondHalfContainer.Size = new Size(1713, 450);
            secondHalfContainer.SplitterDistance = 707;
            secondHalfContainer.TabIndex = 6;
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1805, 1055);
            Controls.Add(panel1);
            Name = "FileWorx";
            Text = "FileWorx News";
            tabPreviewContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabPreviewContainer).EndInit();
            tabPreviewContainer.ResumeLayout(false);
            tabPreview.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            secondHalfContainer.Panel1.ResumeLayout(false);
            secondHalfContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)secondHalfContainer).EndInit();
            secondHalfContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabPreview;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button addNewsButton;
        private Label label3;
        private Button addPhotoButton;
        private Label label2;
        private Label label1;
        private TextBox categoryField;
        private TextBox creationDateField;
        private TextBox titleField;
        private Panel panel1;
        private Panel panel2;
        private ListView contentList;
        internal ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label4;
        private SplitContainer tabPreviewContainer;
        private TabPage tabPage1;
        private RichTextBox previewContent;
        private SplitContainer secondHalfContainer;
        private Panel panel3;
        private Label label5;
    }
}