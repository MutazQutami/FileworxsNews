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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 692);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(15, 338);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 35);
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
            label1.Location = new Point(22, 273);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 57);
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
            ContentPanel.Location = new Point(539, 244);
            ContentPanel.Margin = new Padding(4);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(185, 235);
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
            label4.Location = new Point(518, 74);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(566, 67);
            label4.TabIndex = 6;
            label4.Text = "FILEWORX DASHBOARD";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(636, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(292, 37);
            label5.TabIndex = 7;
            label5.Text = "Select an Option Below";
            // 
            // AddNew
            // 
            AddNew.Anchor = AnchorStyles.None;
            AddNew.BackColor = Color.FromArgb(0, 130, 160);
            AddNew.Cursor = Cursors.Hand;
            AddNew.FlatAppearance.BorderSize = 0;
            AddNew.FlatStyle = FlatStyle.Flat;
            AddNew.Font = new Font("Segoe UI Emoji", 20F);
            AddNew.ForeColor = Color.White;
            AddNew.Location = new Point(732, 244);
            AddNew.Margin = new Padding(4);
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(329, 73);
            AddNew.TabIndex = 8;
            AddNew.Text = "Add New";
            AddNew.UseVisualStyleBackColor = false;
            AddNew.Click += AddNew_Click;
            // 
            // AddPhoto
            // 
            AddPhoto.Anchor = AnchorStyles.None;
            AddPhoto.BackColor = Color.FromArgb(0, 130, 160);
            AddPhoto.Cursor = Cursors.Hand;
            AddPhoto.FlatAppearance.BorderSize = 0;
            AddPhoto.FlatStyle = FlatStyle.Flat;
            AddPhoto.Font = new Font("Segoe UI Emoji", 20F);
            AddPhoto.ForeColor = Color.White;
            AddPhoto.Location = new Point(732, 325);
            AddPhoto.Margin = new Padding(4);
            AddPhoto.Name = "AddPhoto";
            AddPhoto.Size = new Size(329, 73);
            AddPhoto.TabIndex = 9;
            AddPhoto.Text = "Add Photo";
            AddPhoto.UseVisualStyleBackColor = false;
            AddPhoto.Click += AddPhoto_Click;
            // 
            // AddUser
            // 
            AddUser.Anchor = AnchorStyles.None;
            AddUser.BackColor = Color.FromArgb(0, 130, 160);
            AddUser.Cursor = Cursors.Hand;
            AddUser.FlatAppearance.BorderSize = 0;
            AddUser.FlatStyle = FlatStyle.Flat;
            AddUser.Font = new Font("Segoe UI Emoji", 20F);
            AddUser.ForeColor = Color.White;
            AddUser.Location = new Point(732, 406);
            AddUser.Margin = new Padding(4);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(329, 73);
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
            UsersList.Location = new Point(539, 487);
            UsersList.Margin = new Padding(4);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(522, 73);
            UsersList.TabIndex = 11;
            UsersList.Text = "Users List";
            UsersList.UseVisualStyleBackColor = false;
            UsersList.Click += UsersList_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1378, 692);
            Controls.Add(UsersList);
            Controls.Add(AddUser);
            Controls.Add(AddPhoto);
            Controls.Add(AddNew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ContentPanel);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Margin = new Padding(4);
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