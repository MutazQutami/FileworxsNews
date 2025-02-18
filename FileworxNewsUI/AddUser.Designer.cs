namespace FileworxsNewsUI
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblLoginName = new Label();
            lblPassword = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblNullWarnning = new Label();
            pnlContainer = new Panel();
            lblConfPassword = new Label();
            txtConfirmPass = new TextBox();
            passMatchWarning = new Label();
            txtPassword = new TextBox();
            txtLoginName = new TextBox();
            txtName = new TextBox();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F);
            lblName.ForeColor = SystemColors.ButtonShadow;
            lblName.Location = new Point(72, 123);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblLoginName
            // 
            lblLoginName.Anchor = AnchorStyles.None;
            lblLoginName.AutoSize = true;
            lblLoginName.Font = new Font("Segoe UI", 15F);
            lblLoginName.ForeColor = SystemColors.ButtonShadow;
            lblLoginName.Location = new Point(72, 175);
            lblLoginName.Margin = new Padding(2, 0, 2, 0);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(118, 28);
            lblLoginName.TabIndex = 4;
            lblLoginName.Text = "Login Name";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.ForeColor = SystemColors.ButtonShadow;
            lblPassword.Location = new Point(72, 235);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(395, 387);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnSaveButtonClick;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(513, 387);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 130, 200);
            lblTitle.Location = new Point(320, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 28);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Add User";
            // 
            // lblNullWarnning
            // 
            lblNullWarnning.Anchor = AnchorStyles.None;
            lblNullWarnning.AutoSize = true;
            lblNullWarnning.Font = new Font("Segoe UI", 9F);
            lblNullWarnning.ForeColor = Color.Red;
            lblNullWarnning.Location = new Point(524, 288);
            lblNullWarnning.Name = "lblNullWarnning";
            lblNullWarnning.Size = new Size(155, 15);
            lblNullWarnning.TabIndex = 12;
            lblNullWarnning.Text = "All Fields Shoud Not Be Null";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(lblConfPassword);
            pnlContainer.Controls.Add(txtConfirmPass);
            pnlContainer.Controls.Add(passMatchWarning);
            pnlContainer.Controls.Add(lblNullWarnning);
            pnlContainer.Controls.Add(lblTitle);
            pnlContainer.Controls.Add(btnCancel);
            pnlContainer.Controls.Add(btnSave);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(lblLoginName);
            pnlContainer.Controls.Add(lblName);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(txtLoginName);
            pnlContainer.Controls.Add(txtName);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(899, 528);
            pnlContainer.TabIndex = 14;
            // 
            // lblConfPassword
            // 
            lblConfPassword.Anchor = AnchorStyles.None;
            lblConfPassword.AutoSize = true;
            lblConfPassword.Font = new Font("Segoe UI", 15F);
            lblConfPassword.ForeColor = SystemColors.ButtonShadow;
            lblConfPassword.Location = new Point(72, 288);
            lblConfPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfPassword.Name = "lblConfPassword";
            lblConfPassword.Size = new Size(168, 28);
            lblConfPassword.TabIndex = 15;
            lblConfPassword.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Anchor = AnchorStyles.None;
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Segoe UI", 18F);
            txtConfirmPass.Location = new Point(266, 288);
            txtConfirmPass.Margin = new Padding(2);
            txtConfirmPass.MaxLength = 255;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(232, 39);
            txtConfirmPass.TabIndex = 3;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // passMatchWarning
            // 
            passMatchWarning.Anchor = AnchorStyles.None;
            passMatchWarning.AutoSize = true;
            passMatchWarning.ForeColor = Color.Red;
            passMatchWarning.Location = new Point(524, 303);
            passMatchWarning.Name = "passMatchWarning";
            passMatchWarning.Size = new Size(137, 15);
            passMatchWarning.TabIndex = 13;
            passMatchWarning.Text = "Passwords do not match";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(266, 235);
            txtPassword.Margin = new Padding(2);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(232, 39);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            txtLoginName.Anchor = AnchorStyles.None;
            txtLoginName.BorderStyle = BorderStyle.FixedSingle;
            txtLoginName.Font = new Font("Segoe UI", 18F);
            txtLoginName.Location = new Point(266, 175);
            txtLoginName.Margin = new Padding(2);
            txtLoginName.MaxLength = 255;
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(232, 39);
            txtLoginName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(266, 123);
            txtName.Margin = new Padding(2);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 39);
            txtName.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(899, 528);
            Controls.Add(pnlContainer);
            Margin = new Padding(2);
            Name = "UserForm";
            Text = "New User";
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Label lblLoginName;
        private Label lblPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblNullWarnning;
        private Panel pnlContainer;
        private TextBox txtPassword;
        private TextBox txtLoginName;
        private TextBox txtName;
        private Label passMatchWarning;
        private Label lblConfPassword;
        private TextBox txtConfirmPass;
    }
}
