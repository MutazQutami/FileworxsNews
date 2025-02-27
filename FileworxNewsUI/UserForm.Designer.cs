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
            pnlContainer = new Panel();
            checkBoxIsAdmin = new CheckBox();
            lblNullConfirmPassword = new Label();
            lblPass = new Label();
            lblNullLoginName = new Label();
            lblNullName = new Label();
            lblConfPassword = new Label();
            txtConfirmPass = new TextBox();
            lblpassMatchWarning = new Label();
            txtPassword = new TextBox();
            txtLoginName = new TextBox();
            txtName = new TextBox();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F);
            lblName.ForeColor = SystemColors.ButtonShadow;
            lblName.Location = new Point(75, 44);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Font = new Font("Segoe UI", 15F);
            lblLoginName.ForeColor = SystemColors.ButtonShadow;
            lblLoginName.Location = new Point(75, 107);
            lblLoginName.Margin = new Padding(2, 0, 2, 0);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(118, 28);
            lblLoginName.TabIndex = 4;
            lblLoginName.Text = "Login Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.ForeColor = SystemColors.ButtonShadow;
            lblPassword.Location = new Point(75, 170);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(564, 395);
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
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(683, 395);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(checkBoxIsAdmin);
            pnlContainer.Controls.Add(lblNullConfirmPassword);
            pnlContainer.Controls.Add(lblPass);
            pnlContainer.Controls.Add(lblNullLoginName);
            pnlContainer.Controls.Add(lblNullName);
            pnlContainer.Controls.Add(lblConfPassword);
            pnlContainer.Controls.Add(txtConfirmPass);
            pnlContainer.Controls.Add(lblpassMatchWarning);
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
            pnlContainer.Size = new Size(828, 465);
            pnlContainer.TabIndex = 14;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.AutoSize = true;
            checkBoxIsAdmin.Font = new Font("Segoe UI", 15F);
            checkBoxIsAdmin.ForeColor = SystemColors.ButtonShadow;
            checkBoxIsAdmin.Location = new Point(244, 340);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(132, 32);
            checkBoxIsAdmin.TabIndex = 21;
            checkBoxIsAdmin.Text = "Admin Role";
            checkBoxIsAdmin.UseVisualStyleBackColor = true;
            checkBoxIsAdmin.Visible = false;
            // 
            // lblNullConfirmPassword
            // 
            lblNullConfirmPassword.AutoSize = true;
            lblNullConfirmPassword.Font = new Font("Segoe UI", 15F);
            lblNullConfirmPassword.ForeColor = Color.Red;
            lblNullConfirmPassword.Location = new Point(244, 218);
            lblNullConfirmPassword.Margin = new Padding(2, 0, 2, 0);
            lblNullConfirmPassword.Name = "lblNullConfirmPassword";
            lblNullConfirmPassword.Size = new Size(274, 28);
            lblNullConfirmPassword.TabIndex = 19;
            lblNullConfirmPassword.Text = "Confirm Password  is Required";
            lblNullConfirmPassword.Visible = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 15F);
            lblPass.ForeColor = Color.Red;
            lblPass.Location = new Point(244, 147);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(194, 28);
            lblPass.TabIndex = 18;
            lblPass.Text = "Password is Required";
            lblPass.Visible = false;
            // 
            // lblNullLoginName
            // 
            lblNullLoginName.AutoSize = true;
            lblNullLoginName.Font = new Font("Segoe UI", 15F);
            lblNullLoginName.ForeColor = Color.Red;
            lblNullLoginName.Location = new Point(244, 79);
            lblNullLoginName.Margin = new Padding(2, 0, 2, 0);
            lblNullLoginName.Name = "lblNullLoginName";
            lblNullLoginName.Size = new Size(162, 28);
            lblNullLoginName.TabIndex = 17;
            lblNullLoginName.Text = "Login is Required";
            lblNullLoginName.Visible = false;
            // 
            // lblNullName
            // 
            lblNullName.AutoSize = true;
            lblNullName.Font = new Font("Segoe UI", 15F);
            lblNullName.ForeColor = Color.Red;
            lblNullName.Location = new Point(240, 9);
            lblNullName.Margin = new Padding(2, 0, 2, 0);
            lblNullName.Name = "lblNullName";
            lblNullName.Size = new Size(165, 28);
            lblNullName.TabIndex = 16;
            lblNullName.Text = "Name is Required";
            lblNullName.Visible = false;
            // 
            // lblConfPassword
            // 
            lblConfPassword.AutoSize = true;
            lblConfPassword.Font = new Font("Segoe UI", 15F);
            lblConfPassword.ForeColor = SystemColors.ButtonShadow;
            lblConfPassword.Location = new Point(72, 254);
            lblConfPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfPassword.Name = "lblConfPassword";
            lblConfPassword.Size = new Size(168, 28);
            lblConfPassword.TabIndex = 15;
            lblConfPassword.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Segoe UI", 18F);
            txtConfirmPass.Location = new Point(244, 249);
            txtConfirmPass.Margin = new Padding(2);
            txtConfirmPass.MaxLength = 255;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(327, 39);
            txtConfirmPass.TabIndex = 3;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblpassMatchWarning
            // 
            lblpassMatchWarning.AutoSize = true;
            lblpassMatchWarning.Font = new Font("Segoe UI", 15F);
            lblpassMatchWarning.ForeColor = Color.Red;
            lblpassMatchWarning.Location = new Point(242, 293);
            lblpassMatchWarning.Name = "lblpassMatchWarning";
            lblpassMatchWarning.Size = new Size(224, 28);
            lblpassMatchWarning.TabIndex = 13;
            lblpassMatchWarning.Text = "Passwords do not match";
            lblpassMatchWarning.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(244, 177);
            txtPassword.Margin = new Padding(2);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(327, 39);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            txtLoginName.BorderStyle = BorderStyle.FixedSingle;
            txtLoginName.Font = new Font("Segoe UI", 18F);
            txtLoginName.Location = new Point(244, 107);
            txtLoginName.Margin = new Padding(2);
            txtLoginName.MaxLength = 255;
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(327, 39);
            txtLoginName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(244, 38);
            txtName.Margin = new Padding(2);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(327, 39);
            txtName.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(828, 465);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
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
        private Panel pnlContainer;
        private TextBox txtPassword;
        private TextBox txtLoginName;
        private TextBox txtName;
        private Label lblpassMatchWarning;
        private Label lblConfPassword;
        private TextBox txtConfirmPass;
        private Label lblNullConfirmPassword;
        private Label lblPass;
        private Label lblNullLoginName;
        private Label lblNullName;
        private CheckBox checkBoxIsAdmin;
    }
}
