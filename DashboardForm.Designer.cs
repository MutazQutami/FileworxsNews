namespace FileworxsNews
{
    partial class Dashboard
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ContentPanel = new Button();
            label4 = new Label();
            label5 = new Label();
            AddNew = new Button();
            AddPhoto = new Button();
            AddUser = new Button();
            UsersList = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 130, 200);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 494);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 241);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 2;
            label2.Text = "To Fileworx NEWS ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 195);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // ContentPanel
            // 
            ContentPanel.Anchor = AnchorStyles.None;
            ContentPanel.BackColor = Color.Silver;
            ContentPanel.Cursor = Cursors.Hand;
            ContentPanel.FlatAppearance.BorderSize = 0;
            ContentPanel.FlatStyle = FlatStyle.Flat;
            ContentPanel.Font = new Font("Segoe UI Emoji", 20F);
            ContentPanel.ForeColor = Color.Black;
            ContentPanel.Location = new Point(419, 174);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(144, 168);
            ContentPanel.TabIndex = 3;
            ContentPanel.Text = "Content Panel";
            ContentPanel.UseVisualStyleBackColor = false;
            ContentPanel.Click += ContentPanel_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.FromArgb(0, 130, 200);
            label4.Location = new Point(403, 53);
            label4.Name = "label4";
            label4.Size = new Size(451, 54);
            label4.TabIndex = 6;
            label4.Text = "FILEWORX DASHBOARD";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(495, 118);
            label5.Name = "label5";
            label5.Size = new Size(238, 30);
            label5.TabIndex = 7;
            label5.Text = "Select an Option Below";
            // 
            // AddNew
            // 
            AddNew.Anchor = AnchorStyles.None;
            AddNew.BackColor = Color.FromArgb(0, 130, 200);
            AddNew.Cursor = Cursors.Hand;
            AddNew.FlatAppearance.BorderSize = 0;
            AddNew.FlatStyle = FlatStyle.Flat;
            AddNew.Font = new Font("Segoe UI Emoji", 20F);
            AddNew.ForeColor = Color.White;
            AddNew.Location = new Point(569, 174);
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(256, 52);
            AddNew.TabIndex = 8;
            AddNew.Text = "Add New";
            AddNew.UseVisualStyleBackColor = false;
            AddNew.Click += AddNew_Click;
            // 
            // AddPhoto
            // 
            AddPhoto.Anchor = AnchorStyles.None;
            AddPhoto.BackColor = Color.FromArgb(0, 130, 200);
            AddPhoto.Cursor = Cursors.Hand;
            AddPhoto.FlatAppearance.BorderSize = 0;
            AddPhoto.FlatStyle = FlatStyle.Flat;
            AddPhoto.Font = new Font("Segoe UI Emoji", 20F);
            AddPhoto.ForeColor = Color.White;
            AddPhoto.Location = new Point(569, 232);
            AddPhoto.Name = "AddPhoto";
            AddPhoto.Size = new Size(256, 52);
            AddPhoto.TabIndex = 9;
            AddPhoto.Text = "Add Photo";
            AddPhoto.UseVisualStyleBackColor = false;
            AddPhoto.Click += AddPhoto_Click;
            // 
            // AddUser
            // 
            AddUser.Anchor = AnchorStyles.None;
            AddUser.BackColor = Color.FromArgb(0, 130, 200);
            AddUser.Cursor = Cursors.Hand;
            AddUser.FlatAppearance.BorderSize = 0;
            AddUser.FlatStyle = FlatStyle.Flat;
            AddUser.Font = new Font("Segoe UI Emoji", 20F);
            AddUser.ForeColor = Color.White;
            AddUser.Location = new Point(569, 290);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(256, 52);
            AddUser.TabIndex = 10;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = false;
            AddUser.Click += AddUser_Click;
            // 
            // UsersList
            // 
            UsersList.Anchor = AnchorStyles.None;
            UsersList.BackColor = Color.FromArgb(224, 224, 224);
            UsersList.Cursor = Cursors.Hand;
            UsersList.FlatAppearance.BorderSize = 0;
            UsersList.FlatStyle = FlatStyle.Flat;
            UsersList.Font = new Font("Segoe UI Emoji", 20F);
            UsersList.ForeColor = Color.Black;
            UsersList.Location = new Point(419, 348);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(406, 52);
            UsersList.TabIndex = 11;
            UsersList.Text = "Users List";
            UsersList.UseVisualStyleBackColor = false;
            UsersList.Click += UsersList_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1072, 494);
            Controls.Add(UsersList);
            Controls.Add(AddUser);
            Controls.Add(AddPhoto);
            Controls.Add(AddNew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ContentPanel);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox userNameField;
        private TextBox passwordField;
        private Button ContentPanel;
        private Label userNameLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddNew;
        private Button AddPhoto;
        private Button AddUser;
        private Button UsersList;
        private Label label6;
        private LinkLabel signUpLable;
        private Label nullFieldWarning;
        private Label wrongCredentials;
    }
}