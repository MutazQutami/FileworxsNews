namespace FileworxsNews
{
    partial class LogInForm
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
            userNameField = new TextBox();
            passwordField = new TextBox();
            logInButton = new Button();
            userNameLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            signUpLable = new LinkLabel();
            nullFieldWarning = new Label();
            wrongCredentials = new Label();
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
            panel1.Size = new Size(226, 600);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 294);
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
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // userNameField
            // 
            userNameField.Anchor = AnchorStyles.None;
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Font = new Font("Segoe UI", 16F);
            userNameField.Location = new Point(530, 248);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(256, 36);
            userNameField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.Font = new Font("Segoe UI", 16F);
            passwordField.Location = new Point(530, 311);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(256, 36);
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
            logInButton.Location = new Point(530, 374);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(256, 52);
            logInButton.TabIndex = 3;
            logInButton.Text = "LogIn";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.None;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 15F);
            userNameLabel.Location = new Point(404, 248);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(99, 28);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(404, 311);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 130, 200);
            label4.Location = new Point(610, 110);
            label4.Name = "label4";
            label4.Size = new Size(80, 30);
            label4.TabIndex = 6;
            label4.Text = "LOGIN";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(474, 156);
            label5.Name = "label5";
            label5.Size = new Size(354, 30);
            label5.TabIndex = 7;
            label5.Text = "ENTER YOUR CREDENTIALS BELOW";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(646, 446);
            label6.Name = "label6";
            label6.Size = new Size(25, 21);
            label6.TabIndex = 8;
            label6.Text = "or";
            // 
            // signUpLable
            // 
            signUpLable.Anchor = AnchorStyles.None;
            signUpLable.AutoSize = true;
            signUpLable.Font = new Font("Segoe UI", 12F);
            signUpLable.LinkColor = Color.FromArgb(0, 130, 200);
            signUpLable.Location = new Point(629, 481);
            signUpLable.Name = "signUpLable";
            signUpLable.Size = new Size(61, 21);
            signUpLable.TabIndex = 9;
            signUpLable.TabStop = true;
            signUpLable.Text = "sign up";
            signUpLable.LinkClicked += signUpLable_LinkClicked;
            // 
            // nullFieldWarning
            // 
            nullFieldWarning.Anchor = AnchorStyles.None;
            nullFieldWarning.AutoSize = true;
            nullFieldWarning.ForeColor = Color.Red;
            nullFieldWarning.Location = new Point(814, 332);
            nullFieldWarning.Name = "nullFieldWarning";
            nullFieldWarning.Size = new Size(234, 15);
            nullFieldWarning.TabIndex = 10;
            nullFieldWarning.Text = "Username or Password  Should Not Be Null";
            // 
            // wrongCredentials
            // 
            wrongCredentials.Anchor = AnchorStyles.None;
            wrongCredentials.AutoSize = true;
            wrongCredentials.ForeColor = Color.Red;
            wrongCredentials.Location = new Point(814, 362);
            wrongCredentials.Name = "wrongCredentials";
            wrongCredentials.Size = new Size(165, 15);
            wrongCredentials.TabIndex = 11;
            wrongCredentials.Text = "Invalid Username or Password";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 600);
            Controls.Add(wrongCredentials);
            Controls.Add(nullFieldWarning);
            Controls.Add(signUpLable);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(userNameLabel);
            Controls.Add(logInButton);
            Controls.Add(passwordField);
            Controls.Add(userNameField);
            Controls.Add(panel1);
            Name = "LogInForm";
            Text = "LogInForm";
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
        private Button logInButton;
        private Label userNameLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private LinkLabel signUpLable;
        private Label nullFieldWarning;
        private Label wrongCredentials;
    }
}