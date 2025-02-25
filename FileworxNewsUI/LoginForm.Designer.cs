namespace FileworxsNewsUI
{
    partial class LoginForm
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
            pnlLeft = new Panel();
            lblWelcomText = new Label();
            lblWelcome = new Label();
            userNameField = new TextBox();
            passwordField = new TextBox();
            logInButton = new Button();
            userNameLabel = new Label();
            lblPassword = new Label();
            lblLogin = new Label();
            lblLoginText = new Label();
            lblOr = new Label();
            lblSignUp = new LinkLabel();
            lblWrongCredentials = new Label();
            lblNullUsername = new Label();
            lblNullPassword = new Label();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(0, 130, 200);
            pnlLeft.Controls.Add(lblWelcomText);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(291, 840);
            pnlLeft.TabIndex = 0;
            // 
            // lblWelcomText
            // 
            lblWelcomText.Anchor = AnchorStyles.None;
            lblWelcomText.AutoSize = true;
            lblWelcomText.Font = new Font("Segoe UI", 15F);
            lblWelcomText.ForeColor = Color.LightGray;
            lblWelcomText.Location = new Point(15, 412);
            lblWelcomText.Margin = new Padding(4, 0, 4, 0);
            lblWelcomText.Name = "lblWelcomText";
            lblWelcomText.Size = new Size(213, 35);
            lblWelcomText.TabIndex = 2;
            lblWelcomText.Text = "To Fileworx News ";
            lblWelcomText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 25F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(15, 347);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(196, 57);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // userNameField
            // 
            userNameField.Anchor = AnchorStyles.None;
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Font = new Font("Segoe UI", 16F);
            userNameField.Location = new Point(681, 347);
            userNameField.Margin = new Padding(4);
            userNameField.MaxLength = 255;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(329, 43);
            userNameField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.Font = new Font("Segoe UI", 16F);
            passwordField.Location = new Point(681, 435);
            passwordField.Margin = new Padding(4);
            passwordField.MaxLength = 255;
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(329, 43);
            passwordField.TabIndex = 2;
            // 
            // logInButton
            // 
            logInButton.Anchor = AnchorStyles.None;
            logInButton.BackColor = Color.FromArgb(0, 130, 200);
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderSize = 0;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Segoe UI Emoji", 20F);
            logInButton.ForeColor = Color.White;
            logInButton.Location = new Point(681, 524);
            logInButton.Margin = new Padding(4);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(329, 73);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += LogInProcess;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.None;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 15F);
            userNameLabel.Location = new Point(519, 347);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(127, 35);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.Location = new Point(519, 435);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 35);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(0, 130, 200);
            lblLogin.Location = new Point(784, 154);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(99, 37);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "LOGIN";
            // 
            // lblLoginText
            // 
            lblLoginText.Anchor = AnchorStyles.None;
            lblLoginText.AutoSize = true;
            lblLoginText.Font = new Font("Segoe UI", 16F);
            lblLoginText.ForeColor = SystemColors.AppWorkspace;
            lblLoginText.Location = new Point(609, 218);
            lblLoginText.Margin = new Padding(4, 0, 4, 0);
            lblLoginText.Name = "lblLoginText";
            lblLoginText.Size = new Size(435, 37);
            lblLoginText.TabIndex = 7;
            lblLoginText.Text = "ENTER YOUR CREDENTIALS BELOW";
            // 
            // lblOr
            // 
            lblOr.Anchor = AnchorStyles.None;
            lblOr.AutoSize = true;
            lblOr.Font = new Font("Segoe UI", 12F);
            lblOr.ForeColor = Color.Black;
            lblOr.Location = new Point(831, 624);
            lblOr.Margin = new Padding(4, 0, 4, 0);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(31, 28);
            lblOr.TabIndex = 8;
            lblOr.Text = "or";
            // 
            // lblSignUp
            // 
            lblSignUp.Anchor = AnchorStyles.None;
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 12F);
            lblSignUp.LinkColor = Color.FromArgb(0, 130, 200);
            lblSignUp.Location = new Point(815, 667);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(82, 28);
            lblSignUp.TabIndex = 9;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "Sign Up";
            lblSignUp.Click += SignUpProcess;
            // 
            // lblWrongCredentials
            // 
            lblWrongCredentials.Anchor = AnchorStyles.None;
            lblWrongCredentials.AutoSize = true;
            lblWrongCredentials.Font = new Font("Segoe UI", 15F);
            lblWrongCredentials.ForeColor = Color.Red;
            lblWrongCredentials.Location = new Point(681, 482);
            lblWrongCredentials.Margin = new Padding(4, 0, 4, 0);
            lblWrongCredentials.Name = "lblWrongCredentials";
            lblWrongCredentials.Size = new Size(350, 35);
            lblWrongCredentials.TabIndex = 11;
            lblWrongCredentials.Text = "Invalid Username or Password";
            lblWrongCredentials.Visible = false;
            // 
            // lblNullUsername
            // 
            lblNullUsername.Anchor = AnchorStyles.None;
            lblNullUsername.AutoSize = true;
            lblNullUsername.Font = new Font("Segoe UI", 15F);
            lblNullUsername.ForeColor = Color.Red;
            lblNullUsername.Location = new Point(681, 301);
            lblNullUsername.Margin = new Padding(4, 0, 4, 0);
            lblNullUsername.Name = "lblNullUsername";
            lblNullUsername.Size = new Size(252, 35);
            lblNullUsername.TabIndex = 12;
            lblNullUsername.Text = "Username is required";
            lblNullUsername.Visible = false;
            // 
            // lblNullPassword
            // 
            lblNullPassword.Anchor = AnchorStyles.None;
            lblNullPassword.AutoSize = true;
            lblNullPassword.Font = new Font("Segoe UI", 15F);
            lblNullPassword.ForeColor = Color.Red;
            lblNullPassword.Location = new Point(681, 396);
            lblNullPassword.Margin = new Padding(4, 0, 4, 0);
            lblNullPassword.Name = "lblNullPassword";
            lblNullPassword.Size = new Size(245, 35);
            lblNullPassword.TabIndex = 13;
            lblNullPassword.Text = "Password is required";
            lblNullPassword.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1391, 840);
            Controls.Add(lblNullPassword);
            Controls.Add(lblNullUsername);
            Controls.Add(lblWrongCredentials);
            Controls.Add(lblSignUp);
            Controls.Add(lblOr);
            Controls.Add(lblLoginText);
            Controls.Add(lblLogin);
            Controls.Add(lblPassword);
            Controls.Add(userNameLabel);
            Controls.Add(logInButton);
            Controls.Add(passwordField);
            Controls.Add(userNameField);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Log In";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLeft;
        private Label lblWelcomText;
        private Label lblWelcome;
        private TextBox userNameField;
        private TextBox passwordField;
        private Button logInButton;
        private Label userNameLabel;
        private Label lblPassword;
        private Label lblLogin;
        private Label lblLoginText;
        private Label lblOr;
        private LinkLabel lblSignUp;
        private Label lblWrongCredentials;
        private Label lblNullUsername;
        private Label lblNullPassword;
    }
}