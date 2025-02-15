namespace FileworxsNews
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkUploadPhotoWarning = new Label();
            nullFieldsWarnning = new Label();
            cancleButton = new Button();
            saveButton = new Button();
            bodyField = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            descriptionField = new TextBox();
            titleField = new TextBox();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            filePath = new Label();
            browsePhoto = new Button();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 15F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1288, 799);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(checkUploadPhotoWarning);
            tabPage1.Controls.Add(nullFieldsWarnning);
            tabPage1.Controls.Add(cancleButton);
            tabPage1.Controls.Add(saveButton);
            tabPage1.Controls.Add(bodyField);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(descriptionField);
            tabPage1.Controls.Add(titleField);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1280, 751);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "File Description ";
            // 
            // checkUploadPhotoWarning
            // 
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
            // cancleButton
            // 
            cancleButton.BackColor = Color.Brown;
            cancleButton.Cursor = Cursors.Hand;
            cancleButton.FlatAppearance.BorderSize = 0;
            cancleButton.FlatStyle = FlatStyle.Flat;
            cancleButton.ForeColor = Color.White;
            cancleButton.Location = new Point(921, 581);
            cancleButton.Name = "cancleButton";
            cancleButton.Size = new Size(140, 76);
            cancleButton.TabIndex = 7;
            cancleButton.Text = "Cancle";
            cancleButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 130, 200);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(762, 581);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 76);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // bodyField
            // 
            bodyField.BorderStyle = BorderStyle.FixedSingle;
            bodyField.Location = new Point(243, 232);
            bodyField.Name = "bodyField";
            bodyField.Size = new Size(516, 308);
            bodyField.TabIndex = 5;
            bodyField.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 232);
            label3.Name = "label3";
            label3.Size = new Size(71, 35);
            label3.TabIndex = 4;
            label3.Text = "Body";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 150);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 3;
            label2.Text = "Description ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 67);
            label1.Name = "label1";
            label1.Size = new Size(61, 35);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // descriptionField
            // 
            descriptionField.BorderStyle = BorderStyle.FixedSingle;
            descriptionField.Location = new Point(243, 150);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(516, 41);
            descriptionField.TabIndex = 1;
            // 
            // titleField
            // 
            titleField.BorderStyle = BorderStyle.FixedSingle;
            titleField.Location = new Point(243, 67);
            titleField.Name = "titleField";
            titleField.Size = new Size(516, 41);
            titleField.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1280, 751);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(filePath);
            panel1.Controls.Add(browsePhoto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 108);
            panel1.TabIndex = 2;
            // 
            // filePath
            // 
            filePath.AutoSize = true;
            filePath.Location = new Point(314, 35);
            filePath.Name = "filePath";
            filePath.Size = new Size(243, 35);
            filePath.TabIndex = 1;
            filePath.Text = "Picture Location is :  ";
            // 
            // browsePhoto
            // 
            browsePhoto.BackColor = Color.FromArgb(0, 130, 200);
            browsePhoto.Cursor = Cursors.Hand;
            browsePhoto.FlatAppearance.BorderSize = 0;
            browsePhoto.FlatStyle = FlatStyle.Flat;
            browsePhoto.ForeColor = Color.White;
            browsePhoto.Location = new Point(49, 22);
            browsePhoto.Name = "browsePhoto";
            browsePhoto.Size = new Size(144, 66);
            browsePhoto.TabIndex = 0;
            browsePhoto.Text = "Browse";
            browsePhoto.UseVisualStyleBackColor = false;
            browsePhoto.Click += BrowsePhoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1274, 745);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PhotoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 799);
            Controls.Add(tabControl1);
            Name = "PhotoForm";
            Text = "New Photo";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button cancleButton;
        private Button saveButton;
        private RichTextBox bodyField;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox descriptionField;
        private TextBox titleField;
        private Panel panel1;
        private Button browsePhoto;
        private PictureBox pictureBox1;
        private Label filePath;
        private Label nullFieldsWarnning;
        private Label checkUploadPhotoWarning;
    }
}