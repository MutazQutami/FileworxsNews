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
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // userList
            // 
            userList.BackColor = Color.FromArgb(224, 224, 224);
            userList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            userList.Dock = DockStyle.Fill;
            userList.GridLines = true;
            userList.Location = new Point(0, 0);
            userList.Name = "userList";
            userList.Size = new Size(922, 585);
            userList.TabIndex = 0;
            userList.UseCompatibleStateImageBehavior = false;
            userList.View = View.Details;
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
            // columnHeader4
            // 
            columnHeader4.Text = "Last Modifier";
            // 
            // UsersListForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(922, 585);
            Controls.Add(userList);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UsersListForm";
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
    }
}