namespace FileworxsNewsUI
{
    partial class FilterForm
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
            comBoxDate = new ComboBox();
            lblDateValue = new Label();
            datePickerValue = new DateTimePicker();
            lblToDate = new Label();
            datePickerToValue = new DateTimePicker();
            checkBoxTitle = new CheckBox();
            checkBoxDescription = new CheckBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            comBoxTitle = new ComboBox();
            comBoxDescription = new ComboBox();
            checkBoxDate = new CheckBox();
            checkBoxCreator = new CheckBox();
            comboxCreator = new ComboBox();
            checkBoxlastMod = new CheckBox();
            comboxLastMod = new ComboBox();
            labelChooseFilterText = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // comBoxDate
            // 
            comBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxDate.Font = new Font("Segoe UI", 15F);
            comBoxDate.FormattingEnabled = true;
            comBoxDate.Items.AddRange(new object[] { "Exact Date ", "Before", "After", "Date Range", "Today" });
            comBoxDate.Location = new Point(303, 116);
            comBoxDate.Name = "comBoxDate";
            comBoxDate.Size = new Size(350, 43);
            comBoxDate.TabIndex = 1;
            comBoxDate.Visible = false;
            comBoxDate.SelectedIndexChanged += ComBoxDateSelect;
            // 
            // lblDateValue
            // 
            lblDateValue.AutoSize = true;
            lblDateValue.Font = new Font("Segoe UI", 15F);
            lblDateValue.ForeColor = Color.Black;
            lblDateValue.Location = new Point(748, 111);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(74, 35);
            lblDateValue.TabIndex = 2;
            lblDateValue.Text = "Date ";
            lblDateValue.Visible = false;
            // 
            // datePickerValue
            // 
            datePickerValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datePickerValue.CalendarFont = new Font("Segoe UI", 15F);
            datePickerValue.Location = new Point(837, 111);
            datePickerValue.Name = "datePickerValue";
            datePickerValue.Size = new Size(415, 29);
            datePickerValue.TabIndex = 2;
            datePickerValue.Visible = false;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 15F);
            lblToDate.ForeColor = Color.Black;
            lblToDate.Location = new Point(748, 157);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(41, 35);
            lblToDate.TabIndex = 3;
            lblToDate.Text = "To";
            lblToDate.Visible = false;
            // 
            // datePickerToValue
            // 
            datePickerToValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datePickerToValue.CalendarFont = new Font("Segoe UI", 15F);
            datePickerToValue.Location = new Point(837, 157);
            datePickerToValue.Name = "datePickerToValue";
            datePickerToValue.Size = new Size(415, 29);
            datePickerToValue.TabIndex = 4;
            datePickerToValue.Visible = false;
            // 
            // checkBoxTitle
            // 
            checkBoxTitle.AutoSize = true;
            checkBoxTitle.Font = new Font("Segoe UI", 15F);
            checkBoxTitle.ForeColor = Color.Black;
            checkBoxTitle.Location = new Point(47, 220);
            checkBoxTitle.Name = "checkBoxTitle";
            checkBoxTitle.Size = new Size(144, 39);
            checkBoxTitle.TabIndex = 5;
            checkBoxTitle.Text = "Title Filter";
            checkBoxTitle.UseVisualStyleBackColor = true;
            checkBoxTitle.Click += OnClickTitleFilterChBox;
            // 
            // checkBoxDescription
            // 
            checkBoxDescription.AutoSize = true;
            checkBoxDescription.Font = new Font("Segoe UI", 15F);
            checkBoxDescription.ForeColor = Color.Black;
            checkBoxDescription.Location = new Point(47, 320);
            checkBoxDescription.Name = "checkBoxDescription";
            checkBoxDescription.Size = new Size(225, 39);
            checkBoxDescription.TabIndex = 6;
            checkBoxDescription.Text = "Description Filter";
            checkBoxDescription.UseVisualStyleBackColor = true;
            checkBoxDescription.Click += OnClickDescFilterChBox;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 15F);
            txtTitle.Location = new Point(748, 220);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(504, 41);
            txtTitle.TabIndex = 7;
            txtTitle.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 15F);
            txtDescription.Location = new Point(748, 318);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(504, 41);
            txtDescription.TabIndex = 8;
            txtDescription.Visible = false;
            // 
            // comBoxTitle
            // 
            comBoxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTitle.Font = new Font("Segoe UI", 15F);
            comBoxTitle.FormattingEnabled = true;
            comBoxTitle.Items.AddRange(new object[] { "Exact Value", "Contains", "Starts With", "Ends With" });
            comBoxTitle.Location = new Point(303, 218);
            comBoxTitle.Name = "comBoxTitle";
            comBoxTitle.Size = new Size(350, 43);
            comBoxTitle.TabIndex = 9;
            comBoxTitle.Visible = false;
            comBoxTitle.SelectedIndexChanged += ComBoxTitleSelect;
            // 
            // comBoxDescription
            // 
            comBoxDescription.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxDescription.Font = new Font("Segoe UI", 15F);
            comBoxDescription.FormattingEnabled = true;
            comBoxDescription.Items.AddRange(new object[] { "Exact Value", "Contains", "Starts With", "Ends With" });
            comBoxDescription.Location = new Point(303, 318);
            comBoxDescription.Name = "comBoxDescription";
            comBoxDescription.Size = new Size(350, 43);
            comBoxDescription.TabIndex = 10;
            comBoxDescription.Visible = false;
            comBoxDescription.SelectedIndexChanged += ComBoxDescSelect;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.Font = new Font("Segoe UI", 15F);
            checkBoxDate.ForeColor = Color.Black;
            checkBoxDate.Location = new Point(47, 111);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(150, 39);
            checkBoxDate.TabIndex = 11;
            checkBoxDate.Text = "Date Filter";
            checkBoxDate.UseVisualStyleBackColor = true;
            checkBoxDate.Click += OnClickDateFilterChBox;
            // 
            // checkBoxCreator
            // 
            checkBoxCreator.AutoSize = true;
            checkBoxCreator.Font = new Font("Segoe UI", 15F);
            checkBoxCreator.ForeColor = Color.Black;
            checkBoxCreator.Location = new Point(47, 420);
            checkBoxCreator.Name = "checkBoxCreator";
            checkBoxCreator.Size = new Size(180, 39);
            checkBoxCreator.TabIndex = 12;
            checkBoxCreator.Text = "Creator Filter";
            checkBoxCreator.UseVisualStyleBackColor = true;
            checkBoxCreator.Click += OnClickCreatorFilterChBox;
            // 
            // comboxCreator
            // 
            comboxCreator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxCreator.Font = new Font("Segoe UI", 15F);
            comboxCreator.FormattingEnabled = true;
            comboxCreator.Location = new Point(303, 420);
            comboxCreator.Name = "comboxCreator";
            comboxCreator.Size = new Size(350, 43);
            comboxCreator.TabIndex = 13;
            comboxCreator.Visible = false;
            // 
            // checkBoxlastMod
            // 
            checkBoxlastMod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxlastMod.AutoSize = true;
            checkBoxlastMod.Font = new Font("Segoe UI", 15F);
            checkBoxlastMod.ForeColor = Color.Black;
            checkBoxlastMod.Location = new Point(47, 514);
            checkBoxlastMod.Name = "checkBoxlastMod";
            checkBoxlastMod.Size = new Size(243, 39);
            checkBoxlastMod.TabIndex = 14;
            checkBoxlastMod.Text = "Last Modifier Filter";
            checkBoxlastMod.UseVisualStyleBackColor = true;
            checkBoxlastMod.Click += OnClickLastModFilterChBox;
            // 
            // comboxLastMod
            // 
            comboxLastMod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxLastMod.Font = new Font("Segoe UI", 15F);
            comboxLastMod.FormattingEnabled = true;
            comboxLastMod.Items.AddRange(new object[] { "Exact Date ", "Before", "After", "Date Range" });
            comboxLastMod.Location = new Point(303, 510);
            comboxLastMod.Name = "comboxLastMod";
            comboxLastMod.Size = new Size(350, 43);
            comboxLastMod.TabIndex = 15;
            comboxLastMod.Visible = false;
            // 
            // labelChooseFilterText
            // 
            labelChooseFilterText.AutoSize = true;
            labelChooseFilterText.Font = new Font("Segoe UI", 20F);
            labelChooseFilterText.ForeColor = Color.Black;
            labelChooseFilterText.Location = new Point(26, 9);
            labelChooseFilterText.Name = "labelChooseFilterText";
            labelChooseFilterText.Size = new Size(292, 46);
            labelChooseFilterText.TabIndex = 16;
            labelChooseFilterText.Text = "Choose Your Filter";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 130, 200);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(979, 636);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 70);
            btnSave.TabIndex = 17;
            btnSave.Text = "Apply";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += OnApplyButtonClick;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(1119, 636);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 70);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += OnCancelButtonClick;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1352, 761);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(labelChooseFilterText);
            Controls.Add(comboxLastMod);
            Controls.Add(checkBoxlastMod);
            Controls.Add(comboxCreator);
            Controls.Add(checkBoxCreator);
            Controls.Add(checkBoxDate);
            Controls.Add(comBoxDescription);
            Controls.Add(comBoxTitle);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(checkBoxDescription);
            Controls.Add(checkBoxTitle);
            Controls.Add(datePickerToValue);
            Controls.Add(lblToDate);
            Controls.Add(datePickerValue);
            Controls.Add(lblDateValue);
            Controls.Add(comBoxDate);
            ForeColor = Color.White;
            Name = "FilterForm";
            Text = "Filter Result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comBoxDate;
        private Label lblDateValue;
        private DateTimePicker datePickerValue;
        private Label lblToDate;
        private DateTimePicker datePickerToValue;
        private CheckBox checkBoxTitle;
        private CheckBox checkBoxDescription;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private ComboBox comBoxTitle;
        private ComboBox comBoxDescription;
        private CheckBox checkBoxDate;
        private CheckBox checkBoxCreator;
        private ComboBox comboxCreator;
        private CheckBox checkBoxlastMod;
        private ComboBox comboxLastMod;
        private Label labelChooseFilterText;
        private Button btnSave;
        private Button btnCancel;
    }
}