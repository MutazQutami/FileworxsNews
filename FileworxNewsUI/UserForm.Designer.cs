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
            lblNullConfirmPassword = new Label();
            lblPassMatchWarning = new Label();
            lblNullLoginName = new Label();
            lblNullName = new Label();
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
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F);
            lblName.ForeColor = SystemColors.ButtonShadow;
            lblName.Location = new Point(96, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 35);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblLoginName
            // 
            lblLoginName.AutoSize = true;
            lblLoginName.Font = new Font("Segoe UI", 15F);
            lblLoginName.ForeColor = SystemColors.ButtonShadow;
            lblLoginName.Location = new Point(96, 150);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(151, 35);
            lblLoginName.TabIndex = 4;
            lblLoginName.Text = "Login Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.ForeColor = SystemColors.ButtonShadow;
            lblPassword.Location = new Point(96, 238);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 35);
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
            btnSave.Location = new Point(672, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 62);
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
            btnCancel.Location = new Point(825, 439);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 62);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(lblNullConfirmPassword);
            pnlContainer.Controls.Add(lblPassMatchWarning);
            pnlContainer.Controls.Add(lblNullLoginName);
            pnlContainer.Controls.Add(lblNullName);
            pnlContainer.Controls.Add(lblConfPassword);
            pnlContainer.Controls.Add(txtConfirmPass);
            pnlContainer.Controls.Add(passMatchWarning);
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
            pnlContainer.Margin = new Padding(4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1012, 538);
            pnlContainer.TabIndex = 14;
            // 
            // lblNullConfirmPassword
            // 
            lblNullConfirmPassword.AutoSize = true;
            lblNullConfirmPassword.Font = new Font("Segoe UI", 15F);
            lblNullConfirmPassword.ForeColor = Color.Red;
            lblNullConfirmPassword.Location = new Point(308, 296);
            lblNullConfirmPassword.Name = "lblNullConfirmPassword";
            lblNullConfirmPassword.Size = new Size(420, 35);
            lblNullConfirmPassword.TabIndex = 19;
            lblNullConfirmPassword.Text = "Confirm Password Name is Required";
            lblNullConfirmPassword.Visible = false;
            // 
            // lblPassMatchWarning
            // 
            lblPassMatchWarning.AutoSize = true;
            lblPassMatchWarning.Font = new Font("Segoe UI", 15F);
            lblPassMatchWarning.ForeColor = Color.Red;
            lblPassMatchWarning.Location = new Point(308, 200);
            lblPassMatchWarning.Name = "lblPassMatchWarning";
            lblPassMatchWarning.Size = new Size(324, 35);
            lblPassMatchWarning.TabIndex = 18;
            lblPassMatchWarning.Text = "Password Name is Required";
            lblPassMatchWarning.Visible = false;
            // 
            // lblNullLoginName
            // 
            lblNullLoginName.AutoSize = true;
            lblNullLoginName.Font = new Font("Segoe UI", 15F);
            lblNullLoginName.ForeColor = Color.Red;
            lblNullLoginName.Location = new Point(308, 111);
            lblNullLoginName.Name = "lblNullLoginName";
            lblNullLoginName.Size = new Size(281, 35);
            lblNullLoginName.TabIndex = 17;
            lblNullLoginName.Text = "Login Name is Required";
            lblNullLoginName.Visible = false;
            // 
            // lblNullName
            // 
            lblNullName.AutoSize = true;
            lblNullName.Font = new Font("Segoe UI", 15F);
            lblNullName.ForeColor = Color.Red;
            lblNullName.Location = new Point(308, 23);
            lblNullName.Name = "lblNullName";
            lblNullName.Size = new Size(212, 35);
            lblNullName.TabIndex = 16;
            lblNullName.Text = "Name is Required";
            lblNullName.Visible = false;
            // 
            // lblConfPassword
            // 
            lblConfPassword.AutoSize = true;
            lblConfPassword.Font = new Font("Segoe UI", 15F);
            lblConfPassword.ForeColor = SystemColors.ButtonShadow;
            lblConfPassword.Location = new Point(92, 334);
            lblConfPassword.Name = "lblConfPassword";
            lblConfPassword.Size = new Size(216, 35);
            lblConfPassword.TabIndex = 15;
            lblConfPassword.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Segoe UI", 18F);
            txtConfirmPass.Location = new Point(314, 334);
            txtConfirmPass.MaxLength = 255;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(420, 47);
            txtConfirmPass.TabIndex = 3;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // passMatchWarning
            // 
            passMatchWarning.AutoSize = true;
            passMatchWarning.Font = new Font("Segoe UI", 15F);
            passMatchWarning.ForeColor = Color.Red;
            passMatchWarning.Location = new Point(311, 390);
            passMatchWarning.Margin = new Padding(4, 0, 4, 0);
            passMatchWarning.Name = "passMatchWarning";
            passMatchWarning.Size = new Size(288, 35);
            passMatchWarning.TabIndex = 13;
            passMatchWarning.Text = "Passwords do not match";
            passMatchWarning.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(314, 238);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(420, 47);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            txtLoginName.BorderStyle = BorderStyle.FixedSingle;
            txtLoginName.Font = new Font("Segoe UI", 18F);
            txtLoginName.Location = new Point(314, 150);
            txtLoginName.MaxLength = 255;
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(420, 47);
            txtLoginName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(314, 61);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(420, 47);
            txtName.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1012, 538);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private Label passMatchWarning;
        private Label lblConfPassword;
        private TextBox txtConfirmPass;
        private Label lblNullConfirmPassword;
        private Label lblPassMatchWarning;
        private Label lblNullLoginName;
        private Label lblNullName;
    }
}
