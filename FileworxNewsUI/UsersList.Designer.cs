namespace FileworxsNewsUI
{
    partial class UsersListForm
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
            userList = new ListView();
            nameColumnHeader = new ColumnHeader();
            logInColumnHeader = new ColumnHeader();
            creationDateColumnHeader = new ColumnHeader();
            LastModifierColumnHeader = new ColumnHeader();
            passwordColumnHeader4 = new ColumnHeader();
            btnAddUser = new Button();
            pnlTop = new Panel();
            pnlBody = new Panel();
            pnlTop.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // userList
            // 
            userList.BackColor = Color.FromArgb(224, 224, 224);
            userList.BorderStyle = BorderStyle.FixedSingle;
            userList.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, logInColumnHeader, creationDateColumnHeader, LastModifierColumnHeader, passwordColumnHeader4 });
            userList.Cursor = Cursors.Hand;
            userList.Dock = DockStyle.Fill;
            userList.FullRowSelect = true;
            userList.GridLines = true;
            userList.Location = new Point(0, 0);
            userList.MinimumSize = new Size(400, 0);
            userList.Name = "userList";
            userList.Size = new Size(892, 478);
            userList.TabIndex = 0;
            userList.UseCompatibleStateImageBehavior = false;
            userList.View = View.Details;
            userList.DoubleClick += OnUserListDoubleClick;
            userList.MouseClick += OnUserListMouseClick;
            // 
            // nameColumnHeader
            // 
            nameColumnHeader.Text = "Name";
            nameColumnHeader.Width = 150;
            // 
            // logInColumnHeader
            // 
            logInColumnHeader.Text = "Login Name";
            logInColumnHeader.Width = 180;
            // 
            // creationDateColumnHeader
            // 
            creationDateColumnHeader.Text = "Creation Date";
            creationDateColumnHeader.Width = 200;
            // 
            // LastModifierColumnHeader
            // 
            LastModifierColumnHeader.Text = "Password";
            LastModifierColumnHeader.Width = 160;
            // 
            // passwordColumnHeader4
            // 
            passwordColumnHeader4.Text = "Last Modifier";
            passwordColumnHeader4.Width = 200;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Left;
            btnAddUser.Location = new Point(1, 10);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(126, 53);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += OnAddUserButtonClick;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnAddUser);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(15, 15);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(892, 77);
            pnlTop.TabIndex = 2;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(userList);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(15, 92);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(892, 478);
            pnlBody.TabIndex = 3;
            // 
            // UsersListForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 585);
            Controls.Add(pnlBody);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UsersListForm";
            Padding = new Padding(15);
            Text = "Users List";
            pnlTop.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView userList;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader logInColumnHeader;
        private ColumnHeader creationDateColumnHeader;
        private ColumnHeader passwordColumnHeader4;
        private ColumnHeader LastModifierColumnHeader;
        private Button btnAddUser;
        private Panel pnlTop;
        private Panel pnlBody;
    }
}