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
            upperPart = new Panel();
            contentList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lowerPart = new Panel();
            secondHalfContainer = new SplitContainer();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabPreviewContainer).BeginInit();
            tabPreviewContainer.Panel1.SuspendLayout();
            tabPreviewContainer.SuspendLayout();
            tabPreview.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            upperPart.SuspendLayout();
            lowerPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondHalfContainer).BeginInit();
            secondHalfContainer.Panel1.SuspendLayout();
            secondHalfContainer.Panel2.SuspendLayout();
            secondHalfContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tabPreviewContainer
            // 
            tabPreviewContainer.Dock = DockStyle.Fill;
            tabPreviewContainer.Location = new Point(0, 0);
            tabPreviewContainer.Margin = new Padding(0);
            tabPreviewContainer.Name = "tabPreviewContainer";
            tabPreviewContainer.Orientation = Orientation.Horizontal;
            // 
            // tabPreviewContainer.Panel1
            // 
            tabPreviewContainer.Panel1.Controls.Add(tabPreview);
            tabPreviewContainer.Size = new Size(860, 449);
            tabPreviewContainer.SplitterDistance = 320;
            tabPreviewContainer.TabIndex = 4;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(tabPage1);
            tabPreview.Controls.Add(tabPage2);
            tabPreview.Dock = DockStyle.Fill;
            tabPreview.Font = new Font("Segoe UI", 15F);
            tabPreview.Location = new Point(0, 0);
            tabPreview.Margin = new Padding(0);
            tabPreview.Name = "tabPreview";
            tabPreview.Padding = new Point(0, 0);
            tabPreview.SelectedIndex = 0;
            tabPreview.Size = new Size(860, 320);
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
            tabPage1.Size = new Size(852, 279);
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
            previewContent.Size = new Size(848, 275);
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
            tabPage2.Size = new Size(852, 279);
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
            pictureBox1.Size = new Size(848, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(601, 449);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 238);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 164);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 4;
            label2.Text = "Creation Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 102);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // categoryField
            // 
            categoryField.BorderStyle = BorderStyle.FixedSingle;
            categoryField.Location = new Point(180, 238);
            categoryField.Margin = new Padding(2);
            categoryField.Name = "categoryField";
            categoryField.ReadOnly = true;
            categoryField.Size = new Size(307, 34);
            categoryField.TabIndex = 2;
            // 
            // creationDateField
            // 
            creationDateField.BorderStyle = BorderStyle.FixedSingle;
            creationDateField.Location = new Point(178, 164);
            creationDateField.Margin = new Padding(2);
            creationDateField.Name = "creationDateField";
            creationDateField.ReadOnly = true;
            creationDateField.Size = new Size(307, 34);
            creationDateField.TabIndex = 1;
            // 
            // titleField
            // 
            titleField.BorderStyle = BorderStyle.FixedSingle;
            titleField.Location = new Point(180, 102);
            titleField.Margin = new Padding(2);
            titleField.Name = "titleField";
            titleField.ReadOnly = true;
            titleField.Size = new Size(307, 34);
            titleField.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(upperPart);
            panel1.Controls.Add(lowerPart);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(25, 50);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1557, 803);
            panel1.TabIndex = 1;
            // 
            // upperPart
            // 
            upperPart.BorderStyle = BorderStyle.FixedSingle;
            upperPart.Controls.Add(contentList);
            upperPart.Dock = DockStyle.Top;
            upperPart.Location = new Point(0, 0);
            upperPart.Name = "upperPart";
            upperPart.Size = new Size(1557, 256);
            upperPart.TabIndex = 2;
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
            contentList.Size = new Size(1555, 254);
            contentList.Sorting = SortOrder.Descending;
            contentList.TabIndex = 0;
            contentList.TileSize = new Size(100, 100);
            contentList.UseCompatibleStateImageBehavior = false;
            contentList.View = View.Details;
            contentList.MouseClick += ContentList_MouseClick;
            contentList.MouseDoubleClick += ContentList_MouseDoubleClick;
            contentList.Resize += ContentList_Resize;
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
            // lowerPart
            // 
            lowerPart.BorderStyle = BorderStyle.FixedSingle;
            lowerPart.Controls.Add(secondHalfContainer);
            lowerPart.Location = new Point(1, 295);
            lowerPart.Margin = new Padding(0);
            lowerPart.Name = "lowerPart";
            lowerPart.Padding = new Padding(0, 21, 10, 0);
            lowerPart.Size = new Size(1476, 472);
            lowerPart.TabIndex = 7;
            // 
            // secondHalfContainer
            // 
            secondHalfContainer.Dock = DockStyle.Fill;
            secondHalfContainer.Location = new Point(0, 21);
            secondHalfContainer.Margin = new Padding(0);
            secondHalfContainer.Name = "secondHalfContainer";
            // 
            // secondHalfContainer.Panel1
            // 
            secondHalfContainer.Panel1.Controls.Add(panel4);
            // 
            // secondHalfContainer.Panel2
            // 
            secondHalfContainer.Panel2.Controls.Add(tabPreviewContainer);
            secondHalfContainer.Size = new Size(1464, 449);
            secondHalfContainer.SplitterDistance = 601;
            secondHalfContainer.SplitterWidth = 3;
            secondHalfContainer.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 130, 200);
            label4.Location = new Point(674, 6);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 3;
            label4.Text = "Fileworx News";
            // 
            // FileWorx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1607, 853);
            Controls.Add(label4);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FileWorx";
            Padding = new Padding(25, 50, 25, 0);
            Text = "FileWorx News";
            tabPreviewContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabPreviewContainer).EndInit();
            tabPreviewContainer.ResumeLayout(false);
            tabPreview.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            upperPart.ResumeLayout(false);
            lowerPart.ResumeLayout(false);
            secondHalfContainer.Panel1.ResumeLayout(false);
            secondHalfContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)secondHalfContainer).EndInit();
            secondHalfContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Panel upperPart;
        private ListView contentList;
        internal ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label4;
        private SplitContainer tabPreviewContainer;
        private TabPage tabPage1;
        private RichTextBox previewContent;
        private SplitContainer secondHalfContainer;
        private Panel lowerPart;
        private Label label5;
    }
}