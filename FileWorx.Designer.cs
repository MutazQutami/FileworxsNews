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
            panel3 = new Panel();
            tabPreviewContainer = new SplitContainer();
            tabPreview = new TabControl();
            tabPage1 = new TabPage();
            previewContent = new RichTextBox();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            addNewsButton = new Button();
            label5 = new Label();
            addPhotoButton = new Button();
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
            panel3.SuspendLayout();
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
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tabPreviewContainer);
            panel3.Controls.Add(addNewsButton);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(addPhotoButton);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(21, 296);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1720, 699);
            panel3.TabIndex = 1;
            // 
            // tabPreviewContainer
            // 
            tabPreviewContainer.Location = new Point(43, 219);
            tabPreviewContainer.Name = "tabPreviewContainer";
            tabPreviewContainer.Orientation = Orientation.Horizontal;
            // 
            // tabPreviewContainer.Panel1
            // 
            tabPreviewContainer.Panel1.Controls.Add(tabPreview);
            tabPreviewContainer.Size = new Size(927, 451);
            tabPreviewContainer.SplitterDistance = 162;
            tabPreviewContainer.TabIndex = 4;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(tabPage1);
            tabPreview.Controls.Add(tabPage2);
            tabPreview.Dock = DockStyle.Fill;
            tabPreview.Font = new Font("Segoe UI", 15F);
            tabPreview.Location = new Point(0, 0);
            tabPreview.Margin = new Padding(2);
            tabPreview.Name = "tabPreview";
            tabPreview.SelectedIndex = 0;
            tabPreview.Size = new Size(927, 162);
            tabPreview.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(previewContent);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(919, 121);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Preview";
            // 
            // previewContent
            // 
            previewContent.BorderStyle = BorderStyle.None;
            previewContent.Dock = DockStyle.Fill;
            previewContent.Location = new Point(2, 2);
            previewContent.Margin = new Padding(2);
            previewContent.Name = "previewContent";
            previewContent.ReadOnly = true;
            previewContent.Size = new Size(915, 117);
            previewContent.TabIndex = 0;
            previewContent.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(919, 121);
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
            pictureBox1.Size = new Size(915, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // addNewsButton
            // 
            addNewsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNewsButton.BackColor = Color.DimGray;
            addNewsButton.Cursor = Cursors.Hand;
            addNewsButton.FlatAppearance.BorderSize = 0;
            addNewsButton.FlatStyle = FlatStyle.Flat;
            addNewsButton.Font = new Font("Segoe UI", 15F);
            addNewsButton.ForeColor = Color.White;
            addNewsButton.Location = new Point(1566, 12);
            addNewsButton.Name = "addNewsButton";
            addNewsButton.Size = new Size(126, 51);
            addNewsButton.TabIndex = 2;
            addNewsButton.Text = "Add New";
            addNewsButton.UseVisualStyleBackColor = false;
            addNewsButton.Click += addNews_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 130, 200);
            label5.Location = new Point(789, 12);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 4;
            label5.Text = "Details";
            // 
            // addPhotoButton
            // 
            addPhotoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addPhotoButton.BackColor = Color.FromArgb(0, 130, 200);
            addPhotoButton.Cursor = Cursors.Hand;
            addPhotoButton.FlatAppearance.BorderSize = 0;
            addPhotoButton.FlatStyle = FlatStyle.Flat;
            addPhotoButton.Font = new Font("Segoe UI", 15F);
            addPhotoButton.ForeColor = Color.White;
            addPhotoButton.Location = new Point(1434, 12);
            addPhotoButton.Name = "addPhotoButton";
            addPhotoButton.Size = new Size(126, 51);
            addPhotoButton.TabIndex = 1;
            addPhotoButton.Text = "Add Photo";
            addPhotoButton.UseVisualStyleBackColor = false;
            addPhotoButton.Click += addPhoto_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(categoryField);
            panel4.Controls.Add(creationDateField);
            panel4.Controls.Add(titleField);
            panel4.Font = new Font("Segoe UI", 15F);
            panel4.ForeColor = SystemColors.ControlDark;
            panel4.Location = new Point(5, 46);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(1717, 165);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 111);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 70);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 4;
            label2.Text = "Creation Date";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // categoryField
            // 
            categoryField.Anchor = AnchorStyles.Left;
            categoryField.BorderStyle = BorderStyle.FixedSingle;
            categoryField.Location = new Point(179, 111);
            categoryField.Margin = new Padding(2);
            categoryField.Name = "categoryField";
            categoryField.ReadOnly = true;
            categoryField.Size = new Size(307, 34);
            categoryField.TabIndex = 2;
            // 
            // creationDateField
            // 
            creationDateField.Anchor = AnchorStyles.Left;
            creationDateField.BorderStyle = BorderStyle.FixedSingle;
            creationDateField.Location = new Point(179, 70);
            creationDateField.Margin = new Padding(2);
            creationDateField.Name = "creationDateField";
            creationDateField.ReadOnly = true;
            creationDateField.Size = new Size(307, 34);
            creationDateField.TabIndex = 1;
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.Left;
            titleField.BorderStyle = BorderStyle.FixedSingle;
            titleField.Location = new Point(179, 29);
            titleField.Margin = new Padding(2);
            titleField.Name = "titleField";
            titleField.ReadOnly = true;
            titleField.Size = new Size(307, 34);
            titleField.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1781, 1006);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 130, 200);
            label4.Location = new Point(774, 12);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 3;
            label4.Text = "Fileworx News";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(contentList);
            panel2.Location = new Point(20, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1720, 232);
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
            contentList.Margin = new Padding(2);
            contentList.Name = "contentList";
            contentList.RightToLeft = RightToLeft.No;
            contentList.Size = new Size(1718, 230);
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
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1781, 1006);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FileWorx";
            Text = "FileWorx News";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
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
        private Label label5;
        private SplitContainer tabPreviewContainer;
        private TabPage tabPage1;
        private RichTextBox previewContent;
    }
}