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
            passwordColumnHeader4 = new ColumnHeader();
            btnAddUser = new Button();
            pnlTop = new Panel();
            pnlBody = new Panel();
            panelBottom = new Panel();
            btnCancel = new Button();
            pnlTop.SuspendLayout();
            pnlBody.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // userList
            // 
            userList.BackColor = Color.White;
            userList.BorderStyle = BorderStyle.FixedSingle;
            userList.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, logInColumnHeader, creationDateColumnHeader, passwordColumnHeader4 });
            userList.Cursor = Cursors.Hand;
            userList.Dock = DockStyle.Fill;
            userList.FullRowSelect = true;
            userList.GridLines = true;
            userList.Location = new Point(0, 0);
            userList.Name = "userList";
            userList.Size = new Size(777, 418);
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
            pnlTop.Size = new Size(777, 77);
            pnlTop.TabIndex = 2;
            // 
            // pnlBody
            // 
            pnlBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBody.AutoScroll = true;
            pnlBody.Controls.Add(userList);
            pnlBody.Location = new Point(15, 92);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(0, 0, 0, 5);
            pnlBody.Size = new Size(777, 423);
            pnlBody.TabIndex = 3;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnCancel);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(15, 515);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(777, 125);
            panelBottom.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Brown;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(636, 35);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 59);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // UsersListForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(807, 655);
            Controls.Add(panelBottom);
            Controls.Add(pnlBody);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(550, 650);
            Name = "UsersListForm";
            Padding = new Padding(15);
            Text = "Users List";
            pnlTop.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView userList;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader logInColumnHeader;
        private ColumnHeader creationDateColumnHeader;
        private ColumnHeader passwordColumnHeader4;
        private Button btnAddUser;
        private Panel pnlTop;
        private Panel pnlBody;
        private Panel panelBottom;
        private Button btnCancel;
    }
}