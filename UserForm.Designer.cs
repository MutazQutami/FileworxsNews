namespace FileworxsNews
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
            nameField = new TextBox();
            loginNameField = new TextBox();
            passwordField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveButton = new Button();
            cancleButton = new Button();
            label4 = new Label();
            confirmPassField = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nullFieldsWarnning = new Label();
            passMatchWarning = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameField
            // 
            nameField.Anchor = AnchorStyles.None;
            nameField.BorderStyle = BorderStyle.FixedSingle;
            nameField.Font = new Font("Segoe UI", 18F);
            nameField.Location = new Point(710, 221);
            nameField.Name = "nameField";
            nameField.Size = new Size(298, 47);
            nameField.TabIndex = 0;
            // 
            // loginNameField
            // 
            loginNameField.Anchor = AnchorStyles.None;
            loginNameField.BorderStyle = BorderStyle.FixedSingle;
            loginNameField.Font = new Font("Segoe UI", 18F);
            loginNameField.Location = new Point(710, 294);
            loginNameField.Name = "loginNameField";
            loginNameField.Size = new Size(298, 47);
            loginNameField.TabIndex = 1;
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.None;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.Font = new Font("Segoe UI", 18F);
            passwordField.Location = new Point(710, 378);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(298, 47);
            passwordField.TabIndex = 2;
            passwordField.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(460, 221);
            label1.Name = "label1";
            label1.Size = new Size(82, 35);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(460, 294);
            label2.Name = "label2";
            label2.Size = new Size(151, 35);
            label2.TabIndex = 4;
            label2.Text = "Login Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(460, 378);
            label3.Name = "label3";
            label3.Size = new Size(120, 35);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = Color.FromArgb(0, 130, 200);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 15F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(710, 582);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(132, 62);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancleButton
            // 
            cancleButton.Anchor = AnchorStyles.None;
            cancleButton.BackColor = Color.Brown;
            cancleButton.Cursor = Cursors.Hand;
            cancleButton.FlatAppearance.BorderSize = 0;
            cancleButton.FlatStyle = FlatStyle.Flat;
            cancleButton.Font = new Font("Segoe UI", 15F);
            cancleButton.ForeColor = Color.White;
            cancleButton.Location = new Point(885, 585);
            cancleButton.Name = "cancleButton";
            cancleButton.Size = new Size(123, 57);
            cancleButton.TabIndex = 7;
            cancleButton.Text = "Cancle";
            cancleButton.UseVisualStyleBackColor = false;
            cancleButton.Click += cancleButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(460, 461);
            label4.Name = "label4";
            label4.Size = new Size(216, 35);
            label4.TabIndex = 8;
            label4.Text = "Confirm Password";
            // 
            // confirmPassField
            // 
            confirmPassField.Anchor = AnchorStyles.None;
            confirmPassField.BorderStyle = BorderStyle.FixedSingle;
            confirmPassField.Font = new Font("Segoe UI", 18F);
            confirmPassField.Location = new Point(710, 461);
            confirmPassField.Name = "confirmPassField";
            confirmPassField.PasswordChar = '*';
            confirmPassField.Size = new Size(298, 47);
            confirmPassField.TabIndex = 3;
            confirmPassField.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 130, 200);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 850);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(33, 433);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 35);
            label5.TabIndex = 2;
            label5.Text = "To Fileworx NEWS ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 368);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(196, 57);
            label6.TabIndex = 1;
            label6.Text = "Welcome";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 130, 200);
            label7.Location = new Point(779, 109);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 35);
            label7.TabIndex = 11;
            label7.Text = "Add User";
            // 
            // nullFieldsWarnning
            // 
            nullFieldsWarnning.Anchor = AnchorStyles.None;
            nullFieldsWarnning.AutoSize = true;
            nullFieldsWarnning.Font = new Font("Segoe UI", 9F);
            nullFieldsWarnning.ForeColor = Color.Red;
            nullFieldsWarnning.Location = new Point(1036, 493);
            nullFieldsWarnning.Margin = new Padding(4, 0, 4, 0);
            nullFieldsWarnning.Name = "nullFieldsWarnning";
            nullFieldsWarnning.Size = new Size(196, 20);
            nullFieldsWarnning.TabIndex = 12;
            nullFieldsWarnning.Text = "All Fields Shoud Not Be Null";
            // 
            // passMatchWarning
            // 
            passMatchWarning.Anchor = AnchorStyles.None;
            passMatchWarning.AutoSize = true;
            passMatchWarning.ForeColor = Color.Red;
            passMatchWarning.Location = new Point(1036, 514);
            passMatchWarning.Margin = new Padding(4, 0, 4, 0);
            passMatchWarning.Name = "passMatchWarning";
            passMatchWarning.Size = new Size(295, 21);
            passMatchWarning.TabIndex = 13;
            passMatchWarning.Text = "Passwords do not match. Please try again";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 850);
            Controls.Add(passMatchWarning);
            Controls.Add(nullFieldsWarnning);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(confirmPassField);
            Controls.Add(label4);
            Controls.Add(cancleButton);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordField);
            Controls.Add(loginNameField);
            Controls.Add(nameField);
            Name = "UserForm";
            Text = "New User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameField;
        private TextBox loginNameField;
        private TextBox passwordField;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
        private Button cancleButton;
        private Label label4;
        private TextBox confirmPassField;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label nullFieldsWarnning;
        private Label passMatchWarning;
    }
}
