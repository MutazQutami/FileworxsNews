namespace FileworxsNews
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnAddUser = new Button();
            SuspendLayout();
            // 
            // userList
            // 
            userList.BackColor = Color.FromArgb(224, 224, 224);
            userList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
            userList.Cursor = Cursors.Hand;
            userList.Dock = DockStyle.Fill;
            userList.FullRowSelect = true;
            userList.GridLines = true;
            userList.Location = new Point(15, 15);
            userList.MinimumSize = new Size(700, 0);
            userList.Name = "userList";
            userList.Size = new Size(892, 555);
            userList.TabIndex = 0;
            userList.UseCompatibleStateImageBehavior = false;
            userList.View = View.Details;
            userList.DoubleClick += userList_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Login Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Creation Date";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Password";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Last Modifier";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(747, 31);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(126, 53);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // UsersListForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 585);
            Controls.Add(btnAddUser);
            Controls.Add(userList);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UsersListForm";
            Padding = new Padding(15);
            Text = "UsersForm";
            Resize += UsersList_Resize;
            ResumeLayout(false);
        }

        #endregion

        private ListView userList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnAddUser;
    }
}