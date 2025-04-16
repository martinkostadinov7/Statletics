namespace WinFormsUI
{
    partial class EditAthleteForm
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
            label1 = new Label();
            errorMessageLabel = new Label();
            notesTextBox = new TextBox();
            notesLabel = new Label();
            clubNameTextBox = new TextBox();
            clubNameLabel = new Label();
            femaleRadioButton = new RadioButton();
            genderLabel = new Label();
            maleRadioButton = new RadioButton();
            birthDateLabel = new Label();
            dateBirthDatePicker = new DateTimePicker();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            saveAthleteButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 186);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 34;
            label1.Text = "* - Required Field";
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.ForeColor = Color.IndianRed;
            errorMessageLabel.Location = new Point(577, 150);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(0, 20);
            errorMessageLabel.TabIndex = 33;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(297, 118);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(250, 54);
            notesTextBox.TabIndex = 32;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(297, 95);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(48, 20);
            notesLabel.TabIndex = 31;
            notesLabel.Text = "Notes";
            // 
            // clubNameTextBox
            // 
            clubNameTextBox.Location = new Point(156, 145);
            clubNameTextBox.Name = "clubNameTextBox";
            clubNameTextBox.Size = new Size(111, 27);
            clubNameTextBox.TabIndex = 30;
            // 
            // clubNameLabel
            // 
            clubNameLabel.AutoSize = true;
            clubNameLabel.Location = new Point(156, 118);
            clubNameLabel.Name = "clubNameLabel";
            clubNameLabel.Size = new Size(83, 20);
            clubNameLabel.TabIndex = 29;
            clubNameLabel.Text = "Club Name";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(12, 148);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 24);
            femaleRadioButton.TabIndex = 28;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(12, 95);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(63, 20);
            genderLabel.TabIndex = 27;
            genderLabel.Text = "Gender*";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(12, 118);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(63, 24);
            maleRadioButton.TabIndex = 26;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(297, 23);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(82, 20);
            birthDateLabel.TabIndex = 25;
            birthDateLabel.Text = "Birth Date*";
            // 
            // dateBirthDatePicker
            // 
            dateBirthDatePicker.Location = new Point(297, 46);
            dateBirthDatePicker.Name = "dateBirthDatePicker";
            dateBirthDatePicker.Size = new Size(250, 27);
            dateBirthDatePicker.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(156, 46);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(111, 27);
            lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 46);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(111, 27);
            firstNameTextBox.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(156, 23);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(85, 20);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name*";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 23);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 20;
            firstNameLabel.Text = "First Name*";
            // 
            // saveAthleteButton
            // 
            saveAthleteButton.Location = new Point(577, 55);
            saveAthleteButton.Name = "saveAthleteButton";
            saveAthleteButton.Size = new Size(148, 100);
            saveAthleteButton.TabIndex = 19;
            saveAthleteButton.Text = "Save";
            saveAthleteButton.UseVisualStyleBackColor = true;
            saveAthleteButton.Click += addathleteButton_Click;
            // 
            // EditAthleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 227);
            Controls.Add(label1);
            Controls.Add(errorMessageLabel);
            Controls.Add(notesTextBox);
            Controls.Add(notesLabel);
            Controls.Add(clubNameTextBox);
            Controls.Add(clubNameLabel);
            Controls.Add(femaleRadioButton);
            Controls.Add(genderLabel);
            Controls.Add(maleRadioButton);
            Controls.Add(birthDateLabel);
            Controls.Add(dateBirthDatePicker);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(saveAthleteButton);
            Name = "EditAthleteForm";
            Text = "EditAthleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label errorMessageLabel;
        private TextBox notesTextBox;
        private Label notesLabel;
        private TextBox clubNameTextBox;
        private Label clubNameLabel;
        private RadioButton femaleRadioButton;
        private Label genderLabel;
        private RadioButton maleRadioButton;
        private Label birthDateLabel;
        private DateTimePicker dateBirthDatePicker;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button saveAthleteButton;
    }
}