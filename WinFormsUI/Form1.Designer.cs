namespace WinFormsUI
{
    partial class Form1
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
            addathleteButton = new Button();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            dateBirthDatePicker = new DateTimePicker();
            birthDateLabel = new Label();
            maleRadioButton = new RadioButton();
            genderLabel = new Label();
            femaleRadioButton = new RadioButton();
            clubNameLabel = new Label();
            clubNameTextBox = new TextBox();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            errorMessageLabel = new Label();
            label1 = new Label();
            athletesComboBox = new ComboBox();
            athletesGridView = new DataGridView();
            editAthleteButton = new Button();
            deleteAthleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)athletesGridView).BeginInit();
            SuspendLayout();
            // 
            // addathleteButton
            // 
            addathleteButton.Location = new Point(602, 35);
            addathleteButton.Name = "addathleteButton";
            addathleteButton.Size = new Size(148, 100);
            addathleteButton.TabIndex = 0;
            addathleteButton.Text = "Add Athlete";
            addathleteButton.UseVisualStyleBackColor = true;
            addathleteButton.Click += addathleteButton_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(37, 35);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name*";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(181, 35);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(85, 20);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name*";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(37, 58);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(111, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(181, 58);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(111, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // dateBirthDatePicker
            // 
            dateBirthDatePicker.Location = new Point(322, 58);
            dateBirthDatePicker.Name = "dateBirthDatePicker";
            dateBirthDatePicker.Size = new Size(250, 27);
            dateBirthDatePicker.TabIndex = 5;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(322, 35);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(82, 20);
            birthDateLabel.TabIndex = 6;
            birthDateLabel.Text = "Birth Date*";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(37, 130);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(63, 24);
            maleRadioButton.TabIndex = 7;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(37, 107);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(63, 20);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "Gender*";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(37, 160);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 24);
            femaleRadioButton.TabIndex = 9;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // clubNameLabel
            // 
            clubNameLabel.AutoSize = true;
            clubNameLabel.Location = new Point(181, 130);
            clubNameLabel.Name = "clubNameLabel";
            clubNameLabel.Size = new Size(83, 20);
            clubNameLabel.TabIndex = 10;
            clubNameLabel.Text = "Club Name";
            // 
            // clubNameTextBox
            // 
            clubNameTextBox.Location = new Point(181, 157);
            clubNameTextBox.Name = "clubNameTextBox";
            clubNameTextBox.Size = new Size(111, 27);
            clubNameTextBox.TabIndex = 11;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(322, 107);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(48, 20);
            notesLabel.TabIndex = 12;
            notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(322, 130);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(250, 54);
            notesTextBox.TabIndex = 13;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.ForeColor = Color.IndianRed;
            errorMessageLabel.Location = new Point(602, 162);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(0, 20);
            errorMessageLabel.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 198);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 17;
            label1.Text = "* - Required Field";
            // 
            // athletesComboBox
            // 
            athletesComboBox.FormattingEnabled = true;
            athletesComboBox.Location = new Point(599, 198);
            athletesComboBox.Name = "athletesComboBox";
            athletesComboBox.Size = new Size(151, 28);
            athletesComboBox.TabIndex = 18;
            // 
            // athletesGridView
            // 
            athletesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            athletesGridView.Location = new Point(12, 257);
            athletesGridView.Name = "athletesGridView";
            athletesGridView.RowHeadersWidth = 51;
            athletesGridView.Size = new Size(667, 181);
            athletesGridView.TabIndex = 19;
            // 
            // editAthleteButton
            // 
            editAthleteButton.Location = new Point(685, 257);
            editAthleteButton.Name = "editAthleteButton";
            editAthleteButton.Size = new Size(103, 89);
            editAthleteButton.TabIndex = 20;
            editAthleteButton.Text = "Edit";
            editAthleteButton.UseVisualStyleBackColor = true;
            editAthleteButton.Click += editAthleteButton_Click;
            // 
            // deleteAthleteButton
            // 
            deleteAthleteButton.Location = new Point(685, 352);
            deleteAthleteButton.Name = "deleteAthleteButton";
            deleteAthleteButton.Size = new Size(103, 86);
            deleteAthleteButton.TabIndex = 21;
            deleteAthleteButton.Text = "Delete";
            deleteAthleteButton.UseVisualStyleBackColor = true;
            deleteAthleteButton.Click += deleteAthleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteAthleteButton);
            Controls.Add(editAthleteButton);
            Controls.Add(athletesGridView);
            Controls.Add(athletesComboBox);
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
            Controls.Add(addathleteButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)athletesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addathleteButton;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private DateTimePicker dateBirthDatePicker;
        private Label birthDateLabel;
        private RadioButton maleRadioButton;
        private Label genderLabel;
        private RadioButton femaleRadioButton;
        private Label clubNameLabel;
        private TextBox clubNameTextBox;
        private Label notesLabel;
        private TextBox notesTextBox;
        private Label errorMessageLabel;
        private Label label1;
        private ComboBox athletesComboBox;
        private DataGridView athletesGridView;
        private Button editAthleteButton;
        private Button deleteAthleteButton;
    }
}
