﻿namespace FileworxsNews
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
            lblName.Location = new Point(93, 172);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 35);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblLoginName
            // 
            lblLoginName.Anchor = AnchorStyles.None;
            lblLoginName.AutoSize = true;
            lblLoginName.Font = new Font("Segoe UI", 15F);
            lblLoginName.ForeColor = SystemColors.ButtonShadow;
            lblLoginName.Location = new Point(93, 245);
            lblLoginName.Name = "lblLoginName";
            lblLoginName.Size = new Size(151, 35);
            lblLoginName.TabIndex = 4;
            lblLoginName.Text = "Login Name";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.ForeColor = SystemColors.ButtonShadow;
            lblPassword.Location = new Point(93, 329);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 35);
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
            btnSave.Location = new Point(351, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 62);
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
            btnCancel.Location = new Point(512, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 62);
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
            lblTitle.Location = new Point(411, 60);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 35);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Add User";
            // 
            // lblNullWarnning
            // 
            lblNullWarnning.Anchor = AnchorStyles.None;
            lblNullWarnning.AutoSize = true;
            lblNullWarnning.Font = new Font("Segoe UI", 9F);
            lblNullWarnning.ForeColor = Color.Red;
            lblNullWarnning.Location = new Point(667, 396);
            lblNullWarnning.Margin = new Padding(4, 0, 4, 0);
            lblNullWarnning.Name = "lblNullWarnning";
            lblNullWarnning.Size = new Size(196, 20);
            lblNullWarnning.TabIndex = 12;
            lblNullWarnning.Text = "All Fields Shoud Not Be Null";
            // 
            // pnlContainer
            // 
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
            pnlContainer.Margin = new Padding(4, 4, 4, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1156, 739);
            pnlContainer.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.Location = new Point(342, 329);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(298, 47);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            txtLoginName.Anchor = AnchorStyles.None;
            txtLoginName.BorderStyle = BorderStyle.FixedSingle;
            txtLoginName.Font = new Font("Segoe UI", 18F);
            txtLoginName.Location = new Point(342, 245);
            txtLoginName.MaxLength = 255;
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(298, 47);
            txtLoginName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(342, 172);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(298, 47);
            txtName.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1156, 739);
            Controls.Add(pnlContainer);
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
    }
}
